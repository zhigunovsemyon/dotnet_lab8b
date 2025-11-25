using Electives;

namespace Interface;

/// <summary> Форма редактирования плана </summary>
public partial class FormPlan : Form
{
	/// <summary> Статический указатель на журнал </summary>
	private static readonly Electives.Journal s_journal = Electives.Journal.Get;

	public Electives.Plan _plan = new();

	/// <summary> Поле с редактируемым планом </summary>
	public Electives.Plan Plan
	{
		get => _plan;
		set 
		{
			this._plan = value;
			this.comboBoxClasses.SelectedItem = s_journal.FindClass(this.Plan.ClassId);
			this.comboBoxStudents.SelectedItem = s_journal.FindStudent(this.Plan.StudentId);
			this.comboBoxMarks.SelectedIndex = (int)(this.Plan.Mark.Value);
		}
	}

	/// <summary> Конструктор </summary>
	public FormPlan ()
	{
		this.InitializeComponent();

		Journal.Get.StudentAdded += this.AddPossibleItem;
		Journal.Get.ClassAdded += this.AddPossibleItem;
		Journal.Get.StudentRemoved += this.RemoveInvalidItem;
		Journal.Get.ClassRemoved += this.RemoveInvalidItem;

		foreach (var pv in Electives.Mark.Types) { 
			this.comboBoxMarks.Items.Add(pv);
		}
	}

	/// <summary> Удаление некорректных записей о студентах и предметах </summary>
	/// <param name="sender"> Студент или предмет </param>
	/// <param name="e"></param>
	/// <exception cref="ArgumentNullException">Если sender null</exception>
	/// <exception cref="InvalidDataException">Если sender не является корректным типом</exception>
	private void RemoveInvalidItem (object? sender, EventArgs e)
	{
		var cbox = sender switch
		{
			Electives.Student => this.comboBoxStudents,
			Electives.Class => this.comboBoxClasses,

			null => throw new ArgumentNullException("AddPossibleItem: sender is null"),
			_ => throw new InvalidDataException("AddPossibleItem: sender is unknown type")
		};

		cbox.Items.Remove(sender);
	}

	/// <summary> Добавление новых записей о студентах и предметах </summary>
	/// <param name="sender"> Студент или предмет </param>
	/// <param name="e"></param>
	/// <exception cref="ArgumentNullException">Если sender null</exception>
	/// <exception cref="InvalidDataException">Если sender не является корректным типом</exception>
	private void AddPossibleItem(object? sender, EventArgs e)
	{
		var cbox = sender switch
		{
			Electives.Student => this.comboBoxStudents,
			Electives.Class => this.comboBoxClasses,
			null => throw new ArgumentNullException("AddPossibleItem: sender is null"),
			_ => throw new InvalidDataException("AddPossibleItem: sender is unknown type")
		};

		cbox.Items.Add(sender);
	}

	/// <summary> Обработчик нажатия кнопки "Закрыть" </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void buttonClose_Click (object sender, EventArgs e) => this.Close();

	/// <summary> Обработчик нажатия кнопки "ОК" </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void buttonOK_Click (object sender, EventArgs e)
	{
		var selectedStudent = this.comboBoxStudents.SelectedItem as Electives.Student;
		var selectedClass = this.comboBoxClasses.SelectedItem as Electives.Class;
		var selectedMark = this.comboBoxMarks.SelectedItem as Electives.Mark;
		if (null == selectedClass || selectedStudent == null || selectedMark == null) {

			this.DialogResult = DialogResult.Retry;
			return;
		}

		this.Plan.ClassId = selectedClass.Id;
		this.Plan.StudentId = selectedStudent.Id;
		this.Plan.Mark = selectedMark;

		this.DialogResult = DialogResult.OK;
		this.Close();
	}
}
