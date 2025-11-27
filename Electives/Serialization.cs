using System.Diagnostics;
using System.Text.Json;
using System.Xml.Serialization;

namespace Electives;

partial class Journal
{
	/// <summary> Дочерний класс для сериализации журнала </summary>
	[Serializable]
	public class JournalSerializable
	{
		public JournalSerializable () { }

		public JournalSerializable (Electives.Journal source)
		{
			foreach (var item in source._students) {
				this.Students.Add(item.Value);
			}
			foreach (var item in source._classes) {
				this.Classes.Add(item.Value);
			}
			foreach (var item in source._plans) {
				this.Plans.Add(item);
			}
		}

		/// <summary> Список студентов </summary>
		public List<Electives.Student> Students { get; set; } = [];

		/// <summary> Список занятий </summary>
		public List<Electives.Class> Classes { get; set; } = [];

		/// <summary> Список планов </summary>
		public List<Electives.Plan> Plans { get; set; } = [];
	}

	private void ReadFromSerializable (JournalSerializable source)
	{
		this.WipeJournal();

		foreach (var item in source.Students) {
			this.AddStudent(item);
			Debug.Assert(item.IsValid);
		}
		foreach (var item in source.Classes) {
			this.AddClass(item);
			Debug.Assert(item.IsValid);
		}
		foreach (var item in source.Plans) {
			this.AddPlan(item);

			Debug.Assert(item.ClassId >= 0);
			Debug.Assert(item.StudentId >= 0);
		}
	}

	/// <summary> Параметры используемой сериализации JSON </summary>
	static readonly JsonSerializerOptions? _jsonSerializerOpts = new() { WriteIndented = true };

	/// <summary> Используемый формат сериализации </summary>
	public enum SerializeType
	{
		JSON,
		XML
	}

	/// <summary> Сохранение журнала в файл </summary>
	/// <param name="type">Тип сериализации</param>
	public static void SaveToFile (SerializeType type, string filename)
	{
		var journalToSerialize = new JournalSerializable(Journal.Get);
		switch (type) {
		case SerializeType.XML:
			var xmlSerializer = new XmlSerializer(typeof(JournalSerializable));
			using (var sw = new StreamWriter(filename)) {
				xmlSerializer.Serialize(sw, journalToSerialize);
			}
			break;
		case SerializeType.JSON:
			File.WriteAllText(filename, JsonSerializer.Serialize(journalToSerialize, _jsonSerializerOpts));
			break;
		default:
			throw new NotImplementedException("Неизвестный тип сериализации");
		}
	}

	/// <summary> Чтение журнала из файл </summary>
	/// <param name="type">Тип сериализации</param>
	public static void ReadFromFile (SerializeType type, string filename)
	{
		JournalSerializable? newJournal = null;
		switch (type) {
		case SerializeType.XML:
			var xmlSerializer = new XmlSerializer(typeof(JournalSerializable));
			using (var sr = new StreamReader(filename)) {
				newJournal = xmlSerializer.Deserialize(sr) as JournalSerializable;
			}
			break;
		case SerializeType.JSON:
			using (var sr = new StreamReader(filename)) {
				newJournal =
					JsonSerializer.Deserialize<JournalSerializable>(sr.ReadToEnd(), _jsonSerializerOpts);
			}
			break;
		default:
			throw new NotImplementedException("Неизвестный тип сериализации");
		}

		if (newJournal is null) {
			throw new ArgumentNullException("Journal.ReadFromFile: newJournal null!");
		}
		Journal.Get.ReadFromSerializable(newJournal);
	}

}
