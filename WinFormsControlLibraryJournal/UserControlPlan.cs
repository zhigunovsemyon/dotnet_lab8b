using System.Diagnostics;

namespace WinFormsControlLibraryJournal;

//todo: обработка нажатия
//todo: разъезд элементов
public partial class UserControlPlan : UserControl
{
	/// <summary> Статический указатель на журнал </summary>
	private static readonly Electives.Journal s_journal = Electives.Journal.Get;

	/// <summary> Ивент, вызываемый при необходимости изменения выделенного элемента </summary>
	static public event EventHandler? PlanNeedsToUpdate;

	/// <summary> План данного элемента </summary>
	public Electives.Plan Plan { get; init; }

	/// <summary> Конструктор элемента </summary>
	/// <param name="plan">Учебный план</param>
	public UserControlPlan (Electives.Plan plan)
	{
		this.InitializeComponent();
		this.Plan = plan;
	}

	private bool _selected = false;

	/// <summary> Обработка нажатия по элементу </summary>
	private void UserControlPlan_Click (object sender, EventArgs e) => this.Selected = true;

	/// <summary> Обработка кнопки удаления </summary>
	private void buttonDelete_Click (object sender, EventArgs e) => s_journal.RemovePlan(this.Plan);

	/// <summary> Ивент, выполняемый по появлению пункта </summary>
	private void UserControlPlan_Load (object sender, EventArgs e)
	{
		this.textBoxClass.Text = s_journal.FindClass(this.Plan.ClassId)?.ToString();

		this.textBoxStudent.Text = s_journal.FindStudent(this.Plan.StudentId)?.ToString();

		this.textBoxMark.Text = this.Plan.Mark.ToString();
		this.textBoxMark.BackColor = MarkToColour(this.Plan.Mark.Value);
	}

	private static Color MarkToColour (Electives.Mark.Type mark) => mark switch
	{
		Electives.Mark.Type.None => Color.White,
		Electives.Mark.Type.Skip => Color.Gray,
		Electives.Mark.Type.Two => Color.Red,
		Electives.Mark.Type.Three => Color.Yellow,
		Electives.Mark.Type.Four => Color.GreenYellow,
		Electives.Mark.Type.Five => Color.Green,
		Electives.Mark.Type.Extra => Color.LightGreen,
		_ => throw new NotImplementedException("Unknown mark")
	};

	/// <summary>
	/// Геттер/сеттер выделения пункта
	/// </summary>
	public bool Selected
	{
		get => _selected;
		set
		{
			this.CleanSelections();
			if ((this._selected = value) == true) {
				this.BackColor = Color.CornflowerBlue;
			}
		}
	}

	/// <summary> Снятие выделения со всех элементов </summary>
	private void CleanSelections ()
	{
		var controls = this.Parent?.Controls;
		Debug.Assert(controls != null);

		foreach (var control in controls) {
			var ucPlan = control as UserControlPlan;
			Debug.Assert(ucPlan != null);

			ucPlan._selected = false;
			ucPlan.BackColor = DefaultBackColor;
		}
	}

	/// <summary> Вызов необходимости обновления элемента по двойному нажатию </summary>
	private void UserControlPlan_DoubleClick (object sender, EventArgs e) 
		=> PlanNeedsToUpdate?.Invoke(this.Plan, EventArgs.Empty);
}
