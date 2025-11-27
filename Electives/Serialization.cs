using System.Text.Json;
using System.Xml.Serialization;

namespace Electives;

partial class Journal
{
	/// <summary> Дочерний класс для сериализации журнала </summary>
	[Serializable]
	public class JournalSerializable 
	{
		public JournalSerializable() { }

		public JournalSerializable(Electives.Journal source) 
		{
			foreach (var item in source._students) {
				this._students.Add(item.Value);
			}
			foreach (var item in source._classes) {
				this._classes.Add(item.Value);
			}
			foreach (var item in source._plans) {
				this._plans.Add(item);
			}
		}

		/// <summary> Список студентов </summary>
		public List<Electives.Student> _students = [];

		/// <summary> Список занятий </summary>
		public List<Electives.Class> _classes = [];

		/// <summary> Список планов </summary>
		public List<Electives.Plan> _plans = [];		
	}

	private void ReadFromSerializable (JournalSerializable source)
	{
		this.WipeJournal();

		foreach (var item in source._students) {
			this.AddStudent(item);
		}
		foreach (var item in source._classes) {
			this.AddClass(item);
		}
		foreach (var item in source._plans) {
			this.AddPlan(item);
		}
	}

	/// <summary> Параметры используемой сериализации JSON </summary>
	static readonly JsonSerializerOptions _jsonSerializerOpts = new() { WriteIndented = true };

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
		switch (type) {
		case SerializeType.XML:
			var xmlSerializer = new XmlSerializer(typeof(Journal));
			using (var sr = new StreamReader(filename)) {
				_instance = xmlSerializer.Deserialize(sr) as Journal;
			}
			break;
		case SerializeType.JSON:
			using (var sr = new StreamReader(filename)) {
				_instance =
					JsonSerializer.Deserialize<Journal>(sr.ReadToEnd(), _jsonSerializerOpts);
			}
			break;
		default:
			throw new NotImplementedException("Неизвестный тип сериализации");
		}
	}

}
