using Electives;
using System.Diagnostics;
using WinFormsControlLibraryJournal;

namespace Interface;

/// <summary> Основная форма </summary>
public partial class FormMain : Form
{
	private readonly FormPlan _formPlan = new();
	private readonly FormClass _formClass = new();
	private readonly FormStudent _formStudent = new();

	/// <summary> Ссылка на журнал </summary>
	private readonly Electives.Journal s_journal = Journal.Get;

	public FormMain()
	{
		this.InitializeComponent();

		s_journal.PlanAdded += this.PlanAdded;
		s_journal.PlanRemoved += this.PlanRemoved;

		s_journal.StudentAdded += this.ItemAdded;
		s_journal.StudentRemoved += this.ItemRemoved;

		s_journal.ClassAdded += this.ItemAdded;
		s_journal.ClassRemoved += this.ItemRemoved;

		UserControlPlan.PlanNeedsToUpdate += this.UpdateSelectedPlan;
	}

	/// <summary> Метод, вызываемый ивентом при необходимости изменения плана </summary>
	/// <param name="sender">Изменяемый план</param>
	private void UpdateSelectedPlan(object? sender, EventArgs e)
	{
		if (sender is Electives.Plan plan) {
			this.AddOrEditPlan(plan);
		}
	}

	/// <summary> Метод для закрытия приложения через пункт меню </summary>
	private void CloseButton_Click(object sender, EventArgs e) => this.Close();

	/// <summary> Запрос подтверждения от пользователя удаления </summary>
	/// <param name="text">Текст в окне</param>
	/// <returns>Ответ пользователя</returns>
	private static DialogResult VerifyDeletion(string item)
		=> MessageBox.Show($"Удалить {item}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

	/// <summary> Добавление нового элемента в нужные списки формы </summary>
	/// <param name="sender">Новый элемент</param>
	/// <param name="e"></param>
	/// <exception cref="ArgumentNullException">При sender null</exception>
	/// <exception cref="InvalidDataException">При sender неправильного типа</exception>
	private void ItemAdded(object? sender, EventArgs e)
	{
		_ = sender switch
		{
			Electives.Student => this.listViewStudents.Items.Add(CreateStudentListViewItem((Electives.Student)sender)),
			Electives.Class => this.listViewClasses.Items.Add(CreateClassListViewItem((Electives.Class)sender)),

			null => throw new ArgumentNullException("FormMain.ItemAdded: sender is null"),
			_ => throw new InvalidDataException("FormMain.ItemAdded: sender is unknown")
		};
	}

	/// <summary> Удаление элемента из соответствующего списка формы </summary>
	/// <param name="sender">Удаляемый элемент</param>
	/// <param name="e"></param>
	/// <exception cref="ArgumentNullException">При sender null</exception>
	/// <exception cref="InvalidDataException">При sender неправильного типа</exception>
	private void ItemRemoved(object? sender, EventArgs e)
	{
		var lv = sender switch
		{
			Electives.Student => this.listViewStudents,
			Electives.Class => this.listViewClasses,

			null => throw new ArgumentNullException("FormMain.ItemAdded: sender is null"),
			_ => throw new InvalidDataException("FormMain.ItemAdded: sender is unknown")
		};

		for (int i = 0; i < lv.Items.Count; i++) {
			if (lv.Items[i].Tag == sender) {
				lv.Items.RemoveAt(i);
			}
		}
	}

	/// <summary> Удаление плана из соответствующего списка формы </summary>
	/// <param name="sender">Удаляемый план </param>
	/// <param name="e"></param>
	/// <exception cref="ArgumentNullException">При sender null</exception>
	/// <exception cref="InvalidDataException">При sender неправильного типа</exception>
	private void PlanRemoved(object? sender, EventArgs e)
	{
		var oldPlan = sender as Electives.Plan
			?? throw new InvalidDataException("FormMain.PlanAdded: sender is invalid");

		foreach (var item in tabPagePlans.Controls) {
			var ucPlan = item as UserControlPlan;
			Debug.Assert(ucPlan is not null);

			if (oldPlan == ucPlan.Plan) {
				tabPagePlans.Controls.Remove(ucPlan);
			}
		}
	}

	/// <summary> Добавление нового плана в список формы </summary>
	/// <param name="sender"> Новый план </param>
	/// <param name="e"></param>
	/// <exception cref="ArgumentNullException">При sender null</exception>
	/// <exception cref="InvalidDataException">При sender неправильного типа</exception>
	private void PlanAdded(object? sender, EventArgs e)
	{
		var newPlan = sender as Electives.Plan
			?? throw new InvalidDataException("FormMain.PlanAdded: sender is invalid");

		tabPagePlans.Controls.Add(new UserControlPlan(newPlan) { Dock = DockStyle.Top });
	}

	/// <summary> Обработка нажатия по пустому полю для снятия выделения </summary>
	private void tabPagePlans_Click(object sender, EventArgs e)
	{
		foreach (var item in tabPagePlans.Controls) {
			((UserControlPlan)item).Selected = false;
		}
	}

	/// <summary> 
	/// Метод, вызываемый по нажатию клавиши. 
	/// Предназначен для вызова удаления плана по Delete. 
	/// </summary>
	private void tabControlMain_KeyUp(object sender, KeyEventArgs e)
	{
		if (e.KeyCode != Keys.Delete) {
			return;
		}

		if (this.tabControlMain.SelectedTab != this.tabPagePlans) {
			return;
		}

		foreach (UserControlPlan? ucPlan in tabPagePlans.Controls) {
			if (ucPlan?.Selected ?? false) {
				if (VerifyDeletion(ucPlan.Plan.ToString()) != DialogResult.Yes) {
					return;
				}

				s_journal.RemovePlan(ucPlan.Plan);
			}
		}
	}

	/// <summary> Метод, вызываемый при нажатии на пункта на сохранение в JSON </summary>
	private void jsonSaveToolStripMenuItem_Click(object sender, EventArgs e)
	{ 
		this.saveFileDialog.Filter = "JSON-файлы|*.json|Все файлы|*.*";
		if (DialogResult.OK == this.saveFileDialog.ShowDialog()) {
			s_journal.SaveToFile(
				Journal.SerializeType.JSON, 
				this.saveFileDialog.FileName
			);
		}
	}	

	/// <summary> Метод, вызываемый при нажатии на пункта на сохранение в XML </summary>
	private void xmlSaveToolStripMenuItem_Click(object sender, EventArgs e)
	{ 
		this.saveFileDialog.Filter = "XML-файлы|*.xml|Все файлы|*.*";
		if (DialogResult.OK == this.saveFileDialog.ShowDialog()) {
			s_journal.SaveToFile(
				Journal.SerializeType.XML, 
				this.saveFileDialog.FileName
			);
		}
	}	

	/// <summary> Метод, вызываемый при нажатии на пункта на сохранение в бинарный файл </summary>
	private void binSaveToolStripMenuItem_Click(object sender, EventArgs e)
	{ 
		this.openFileDialog.Filter = "Бинарные файлы|*.bin|Все файлы|*.*";
		if (DialogResult.OK == this.saveFileDialog.ShowDialog()) {
			s_journal.SaveToFile(
				Journal.SerializeType.BIN, 
				this.saveFileDialog.FileName
			);
		}
	}	

	/// <summary> Метод, вызываемый при нажатии на пункта на чтение из JSON-файла </summary>
	private void jsonLoadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.openFileDialog.Filter = "JSON-файлы|*.json|Все файлы|*.*";
		if (this.openFileDialog.ShowDialog() == DialogResult.OK) {
			s_journal.ReadFromFile(
				Journal.SerializeType.JSON,
				this.openFileDialog.FileName
			);
		}
	}

	/// <summary> Метод, вызываемый при нажатии на пункта на чтение из XML-файла </summary>
	private void xmlLoadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.openFileDialog.Filter = "XML-файлы|*.xml|Все файлы|*.*";
		if (this.openFileDialog.ShowDialog() == DialogResult.OK) {
			s_journal.ReadFromFile(
				Journal.SerializeType.JSON,
				this.openFileDialog.FileName
			);
		}
	}

	/// <summary> Метод, вызываемый при нажатии на пункта на чтение из бинарного файла </summary>
	private void binLoadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.openFileDialog.Filter = "Бинарные файлы|*.bin|Все файлы|*.*";
		if (this.openFileDialog.ShowDialog() == DialogResult.OK) {
			s_journal.ReadFromFile(
				Journal.SerializeType.JSON,
				this.openFileDialog.FileName
			);
		}
	}
}
