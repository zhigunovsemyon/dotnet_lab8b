using System.Text.Json;
using System.Xml.Serialization;

namespace Electives;

partial class Journal
{
	[Serializable]
	private class JournalSerializable 
	{
		public JournalSerializable() { }

		/// <summary> Список студентов </summary>
		public Dictionary<int, Electives.Student> _students = [];

		/// <summary> Список занятий </summary>
		public Dictionary<int, Electives.Class> _classes = [];

		/// <summary> Список планов </summary>
		public List<Electives.Plan> _plans = [];

		/// <summary> Обмен контейнерами между материнским классом, и классом для сериализации </summary>
		/// <param name="journal">Материнский класс</param>
		public void SwapContainers (Journal journal) 
		{
			(this._students, journal._students) = (journal._students, this._students); 
			(this._classes, journal._classes) = (journal._classes, this._classes); 
			(this._plans, journal._plans) = (journal._plans, this._plans); 
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
		switch (type) {
		case SerializeType.XML:
			var xmlSerializer = new XmlSerializer(typeof(Journal));
			using (var sw = new StreamWriter(filename)) {
				xmlSerializer.Serialize(sw, _instance);
			}
			break;
		case SerializeType.JSON:
			File.WriteAllText(filename, JsonSerializer.Serialize(_instance, _jsonSerializerOpts));
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
