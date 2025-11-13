using Electives;
using System.Diagnostics;
using WinFormsControlLibraryJournal;

namespace Interface;

public partial class FormMain : Form
{
	/// <summary> Обработчик создания нового плана </summary>
	private void PlanAddStripMenuItem_Click (object sender, EventArgs e)
		=> this.AddOrEditPlan(new Electives.Plan());

	/// <summary> Обработчик редактирования плана </summary>
	private void PlanEditStripMenuItem_Click (object sender, EventArgs e)
	{
		foreach (var item in tabPagePlans.Controls) {
			var ucPlan = item as UserControlPlan;
			Debug.Assert(ucPlan != null);

			if (ucPlan.Selected){
				this.AddOrEditPlan(ucPlan.Plan);
				return;
			}
		}
		MessageBox.Show("Не выбран редактируемый элемент!");
	}

	/// <summary>
	/// Метод для вызова и обработки результата работы формы изменения плана
	/// </summary>
	/// <param name="plan">Обрабатываемый план</param>
	/// <returns> Изменённый план при успехе, null при неудаче </returns>
	private void AddOrEditPlan (Electives.Plan? oldPlan)
	{
		if (oldPlan == null) {
			MessageBox.Show(
				"AddOrEditPlan: plan is null",
				"Внутренняя ошибка"
			);
			throw new Electives.Exception.InvalidPlanException("AddOrEditPlan: plan is null");
		}

		this._formPlan.Plan = oldPlan.Clone();
		DialogResult res = this._formPlan.ShowDialog();

		if (DialogResult.Retry == res) {
			MessageBox.Show("Неправильно указаны данные!");
			return;
		}

		if (DialogResult.OK != res) {
			return;
		}

		try {
			Journal.Get.AddPlan(this._formPlan.Plan);
			Journal.Get.RemovePlan(oldPlan);
		}
		catch (Electives.Exception.InvalidPlanException ex) {
			MessageBox.Show(
				"Не удалось добавить элемент!\n" + ex.Message,
				"Ошибка"
			);
		}
	}
}