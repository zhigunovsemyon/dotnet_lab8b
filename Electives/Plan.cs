using System.Diagnostics;

namespace Electives;

/// <summary>
/// Учебный план для студента по предмету
/// </summary>
[Serializable]
public class Plan : IValidatable
{
	private static readonly Electives.Journal s_journal = Electives.Journal.Get;

	/// <summary> Студент </summary>
	public int StudentId { get; set; } = -1;

	/// <summary> Предмет </summary>
	public int ClassId { get; set; } = -1;

	/// <summary> Оценка </summary>
	public Mark Mark { get; set; } = new Mark();

	public override string ToString () 
		=> $"{s_journal.FindStudent(this.StudentId)}" 
		 + $" предмет: {s_journal.FindStudent(this.ClassId)?.Name}, оценка {Mark}";

	/// <summary>
	/// Конструктор пустого плана. Содержит пустого студента и занятие.
	/// </summary>
	public Plan () {}

	/// <summary>Конструктор плана с уже заданной оценкой</summary>
	/// <param name="student">Студент</param>
	/// <param name="class">Предмет</param>
	/// <param name="mark">Оценка</param>
	public Plan (int studentId, int classId, Mark mark)
	{
		this.StudentId = studentId;
		this.ClassId = classId;
		this.Mark = mark;

		Journal.Get.ClassRemoved += this.ClassChangedOrRemoved;
		Journal.Get.StudentRemoved += this.StudentChangedOrRemoved;
	}

	public bool IsValid 
		=> (s_journal.FindStudent(this.StudentId)?.IsValid ?? false) 
		&& (s_journal.FindClass(this.ClassId)?.IsValid ?? false);

	/// <summary> Создание копии текущего плана </summary>
	/// <returns>Копия плана</returns>
	public Plan Clone () => new(this.StudentId, this.ClassId, new Mark(this.Mark.Value));

	/// <summary> Проверка на наличие обновлённого студента в списке </summary>
	/// <param name="sender"> Старый студент (Electives.Student) </param>
	/// <param name="e"></param>
	/// <exception cref="ArgumentException"></exception>
	public void StudentChangedOrRemoved (object? sender, EventArgs e)
	{
		var oldStudent = sender as Electives.Student ?? 
			throw new ArgumentException("Plan.StudentChangedOrRemoved: sender null or not Student");

		if (this.StudentId != oldStudent.Id) {
			return;
		}

		if (s_journal.FindStudent(oldStudent.Id) is not null) { 
			s_journal.AddPlan(this.Clone());
		}
			s_journal.RemovePlan(this);
		
		//var newStudent = findStudent(journal.ListStudents, oldStudent.Id);
		//if (newStudent is not null) {
		//	var newPlan = this.Clone();
		//	newPlan.Student = newStudent;
		//	journal.AddPlan(newPlan);
		//}
		//journal.RemovePlan(this);
	}

	/// <summary> Проверка на наличие обновлённого предмета в списке </summary>
	/// <param name="sender"> Старый предмет (Electives.Class) </param>
	/// <param name="e"></param>
	/// <exception cref="ArgumentException"></exception>
	public void ClassChangedOrRemoved (object? sender, EventArgs e)
	{
		var oldClass = sender as Electives.Class ?? 
			throw new ArgumentException("Plan.ClassChangedOrRemoved: sender null or not Class");

		if (this.ClassId != oldClass.Id) {
			return;
		}

		if (s_journal.FindClass(oldClass.Id) is not null) {
			s_journal.AddPlan(this.Clone());
		}
			s_journal.RemovePlan(this);

		//var newClass = findClass(s_journal.ListClasses, oldClass.Id);
		//if (newClass is not null) {
		//	var newPlan = this.Clone();
		//	newPlan.Class = newClass;
		//	s_journal.AddPlan(newPlan);
		//}
		//s_journal.RemovePlan(this);
	}
}
