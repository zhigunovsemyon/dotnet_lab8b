namespace Interface
{
	partial class FormMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			toolStripMenuItemFile = new ToolStripMenuItem();
			saveToolStripMenuItem = new ToolStripMenuItem();
			jsonSaveToolStripMenuItem = new ToolStripMenuItem();
			xmlSaveToolStripMenuItem = new ToolStripMenuItem();
			binSaveToolStripMenuItem = new ToolStripMenuItem();
			loadToolStripMenuItem = new ToolStripMenuItem();
			jsonLoadToolStripMenuItem = new ToolStripMenuItem();
			xmlLoadToolStripMenuItem = new ToolStripMenuItem();
			binLoadToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItemClose = new ToolStripMenuItem();
			toolStripMenuItemStudents = new ToolStripMenuItem();
			toolStripMenuItemAddStudent = new ToolStripMenuItem();
			toolStripMenuItemEditStudent = new ToolStripMenuItem();
			ClassesToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItemAddClass = new ToolStripMenuItem();
			toolStripMenuItemEditClass = new ToolStripMenuItem();
			планToolStripMenuItem = new ToolStripMenuItem();
			ToolStripMenuItemAddPlan = new ToolStripMenuItem();
			ToolStripMenuItemEditPlan = new ToolStripMenuItem();
			tabControlMain = new TabControl();
			tabPageStudents = new TabPage();
			listViewStudents = new ListView();
			surnameHeader = new ColumnHeader();
			nameHeader = new ColumnHeader();
			patronimHeader = new ColumnHeader();
			phoneHeader = new ColumnHeader();
			addressHeader = new ColumnHeader();
			tabPageClasses = new TabPage();
			listViewClasses = new ListView();
			classNameHeader = new ColumnHeader();
			lectionsHeader = new ColumnHeader();
			labsHeader = new ColumnHeader();
			practicesHeader = new ColumnHeader();
			tabPagePlans = new TabPage();
			openFileDialog = new OpenFileDialog();
			saveFileDialog = new SaveFileDialog();
			menuStrip1.SuspendLayout();
			tabControlMain.SuspendLayout();
			tabPageStudents.SuspendLayout();
			tabPageClasses.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile, toolStripMenuItemStudents, ClassesToolStripMenuItem, планToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItemFile
			// 
			toolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, toolStripMenuItemClose });
			toolStripMenuItemFile.Name = "toolStripMenuItemFile";
			toolStripMenuItemFile.Size = new Size(48, 20);
			toolStripMenuItemFile.Text = "&Файл";
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jsonSaveToolStripMenuItem, xmlSaveToolStripMenuItem, binSaveToolStripMenuItem });
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.Size = new Size(180, 22);
			saveToolStripMenuItem.Text = "&Сохранить";
			// 
			// jsonSaveToolStripMenuItem
			// 
			jsonSaveToolStripMenuItem.Name = "jsonSaveToolStripMenuItem";
			jsonSaveToolStripMenuItem.Size = new Size(163, 22);
			jsonSaveToolStripMenuItem.Text = "&JSON";
			jsonSaveToolStripMenuItem.Click += jsonSaveToolStripMenuItem_Click;
			// 
			// xmlSaveToolStripMenuItem
			// 
			xmlSaveToolStripMenuItem.Name = "xmlSaveToolStripMenuItem";
			xmlSaveToolStripMenuItem.Size = new Size(163, 22);
			xmlSaveToolStripMenuItem.Text = "&XML";
			xmlSaveToolStripMenuItem.Click += xmlSaveToolStripMenuItem_Click;
			// 
			// binSaveToolStripMenuItem
			// 
			binSaveToolStripMenuItem.Name = "binSaveToolStripMenuItem";
			binSaveToolStripMenuItem.Size = new Size(163, 22);
			binSaveToolStripMenuItem.Text = "&Бинарный файл";
			binSaveToolStripMenuItem.Click += binSaveToolStripMenuItem_Click;
			// 
			// loadToolStripMenuItem
			// 
			loadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jsonLoadToolStripMenuItem, xmlLoadToolStripMenuItem, binLoadToolStripMenuItem });
			loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			loadToolStripMenuItem.Size = new Size(180, 22);
			loadToolStripMenuItem.Text = "&Загрузить";
			// 
			// jsonLoadToolStripMenuItem
			// 
			jsonLoadToolStripMenuItem.Name = "jsonLoadToolStripMenuItem";
			jsonLoadToolStripMenuItem.Size = new Size(180, 22);
			jsonLoadToolStripMenuItem.Text = "&JSON";
			jsonLoadToolStripMenuItem.Click += jsonLoadToolStripMenuItem_Click;
			// 
			// xmlLoadToolStripMenuItem
			// 
			xmlLoadToolStripMenuItem.Name = "xmlLoadToolStripMenuItem";
			xmlLoadToolStripMenuItem.Size = new Size(180, 22);
			xmlLoadToolStripMenuItem.Text = "&XML";
			xmlLoadToolStripMenuItem.Click += xmlLoadToolStripMenuItem_Click;
			// 
			// binLoadToolStripMenuItem
			// 
			binLoadToolStripMenuItem.Name = "binLoadToolStripMenuItem";
			binLoadToolStripMenuItem.Size = new Size(180, 22);
			binLoadToolStripMenuItem.Text = "&Бинарный файл";
			binLoadToolStripMenuItem.Click += binLoadToolStripMenuItem_Click;
			// 
			// toolStripMenuItemClose
			// 
			toolStripMenuItemClose.Name = "toolStripMenuItemClose";
			toolStripMenuItemClose.Size = new Size(180, 22);
			toolStripMenuItemClose.Text = "&Выйти";
			toolStripMenuItemClose.Click += CloseButton_Click;
			// 
			// toolStripMenuItemStudents
			// 
			toolStripMenuItemStudents.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAddStudent, toolStripMenuItemEditStudent });
			toolStripMenuItemStudents.Name = "toolStripMenuItemStudents";
			toolStripMenuItemStudents.Size = new Size(71, 20);
			toolStripMenuItemStudents.Text = "&Студенты";
			// 
			// toolStripMenuItemAddStudent
			// 
			toolStripMenuItemAddStudent.Name = "toolStripMenuItemAddStudent";
			toolStripMenuItemAddStudent.Size = new Size(180, 22);
			toolStripMenuItemAddStudent.Text = "&Добавить";
			toolStripMenuItemAddStudent.Click += StudentAddtoolStripMenuItem_Click;
			// 
			// toolStripMenuItemEditStudent
			// 
			toolStripMenuItemEditStudent.Name = "toolStripMenuItemEditStudent";
			toolStripMenuItemEditStudent.Size = new Size(180, 22);
			toolStripMenuItemEditStudent.Text = "&Редактировать";
			toolStripMenuItemEditStudent.Click += StudentEditToolStripMenuItem_Click;
			// 
			// ClassesToolStripMenuItem
			// 
			ClassesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAddClass, toolStripMenuItemEditClass });
			ClassesToolStripMenuItem.Name = "ClassesToolStripMenuItem";
			ClassesToolStripMenuItem.Size = new Size(63, 20);
			ClassesToolStripMenuItem.Text = "&Занятия";
			// 
			// toolStripMenuItemAddClass
			// 
			toolStripMenuItemAddClass.Name = "toolStripMenuItemAddClass";
			toolStripMenuItemAddClass.Size = new Size(180, 22);
			toolStripMenuItemAddClass.Text = "&Добавить";
			toolStripMenuItemAddClass.Click += ClassAddStripMenuItem_Click;
			// 
			// toolStripMenuItemEditClass
			// 
			toolStripMenuItemEditClass.Name = "toolStripMenuItemEditClass";
			toolStripMenuItemEditClass.Size = new Size(180, 22);
			toolStripMenuItemEditClass.Text = "&Редактировать";
			toolStripMenuItemEditClass.Click += ClassEditStripMenuItem_Click;
			// 
			// планToolStripMenuItem
			// 
			планToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemAddPlan, ToolStripMenuItemEditPlan });
			планToolStripMenuItem.Name = "планToolStripMenuItem";
			планToolStripMenuItem.Size = new Size(48, 20);
			планToolStripMenuItem.Text = "&План";
			// 
			// ToolStripMenuItemAddPlan
			// 
			ToolStripMenuItemAddPlan.Name = "ToolStripMenuItemAddPlan";
			ToolStripMenuItemAddPlan.Size = new Size(154, 22);
			ToolStripMenuItemAddPlan.Text = "&Добавить";
			ToolStripMenuItemAddPlan.Click += PlanAddStripMenuItem_Click;
			// 
			// ToolStripMenuItemEditPlan
			// 
			ToolStripMenuItemEditPlan.Name = "ToolStripMenuItemEditPlan";
			ToolStripMenuItemEditPlan.Size = new Size(154, 22);
			ToolStripMenuItemEditPlan.Text = "&Редактировать";
			ToolStripMenuItemEditPlan.Click += PlanEditStripMenuItem_Click;
			// 
			// tabControlMain
			// 
			tabControlMain.Controls.Add(tabPageStudents);
			tabControlMain.Controls.Add(tabPageClasses);
			tabControlMain.Controls.Add(tabPagePlans);
			tabControlMain.Dock = DockStyle.Fill;
			tabControlMain.Location = new Point(0, 24);
			tabControlMain.Name = "tabControlMain";
			tabControlMain.SelectedIndex = 0;
			tabControlMain.Size = new Size(800, 426);
			tabControlMain.TabIndex = 1;
			tabControlMain.KeyUp += tabControlMain_KeyUp;
			// 
			// tabPageStudents
			// 
			tabPageStudents.Controls.Add(listViewStudents);
			tabPageStudents.Location = new Point(4, 24);
			tabPageStudents.Name = "tabPageStudents";
			tabPageStudents.Padding = new Padding(3);
			tabPageStudents.Size = new Size(792, 398);
			tabPageStudents.TabIndex = 0;
			tabPageStudents.Text = "Студенты";
			tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// listViewStudents
			// 
			listViewStudents.Columns.AddRange(new ColumnHeader[] { surnameHeader, nameHeader, patronimHeader, phoneHeader, addressHeader });
			listViewStudents.Dock = DockStyle.Fill;
			listViewStudents.FullRowSelect = true;
			listViewStudents.Location = new Point(3, 3);
			listViewStudents.MultiSelect = false;
			listViewStudents.Name = "listViewStudents";
			listViewStudents.Size = new Size(786, 392);
			listViewStudents.TabIndex = 0;
			listViewStudents.UseCompatibleStateImageBehavior = false;
			listViewStudents.View = View.Details;
			listViewStudents.KeyUp += listViewStudents_KeyUp;
			listViewStudents.MouseDoubleClick += listViewStudents_MouseDoubleClick;
			// 
			// surnameHeader
			// 
			surnameHeader.Text = "Фамилия";
			surnameHeader.Width = 80;
			// 
			// nameHeader
			// 
			nameHeader.Text = "Имя";
			// 
			// patronimHeader
			// 
			patronimHeader.Text = "Отчество";
			patronimHeader.Width = 80;
			// 
			// phoneHeader
			// 
			phoneHeader.Text = "Телефон";
			phoneHeader.Width = 80;
			// 
			// addressHeader
			// 
			addressHeader.Text = "Адрес";
			addressHeader.Width = 120;
			// 
			// tabPageClasses
			// 
			tabPageClasses.Controls.Add(listViewClasses);
			tabPageClasses.Location = new Point(4, 24);
			tabPageClasses.Name = "tabPageClasses";
			tabPageClasses.Padding = new Padding(3);
			tabPageClasses.Size = new Size(792, 398);
			tabPageClasses.TabIndex = 1;
			tabPageClasses.Text = "Занятия";
			tabPageClasses.UseVisualStyleBackColor = true;
			// 
			// listViewClasses
			// 
			listViewClasses.Columns.AddRange(new ColumnHeader[] { classNameHeader, lectionsHeader, labsHeader, practicesHeader });
			listViewClasses.Dock = DockStyle.Fill;
			listViewClasses.FullRowSelect = true;
			listViewClasses.Location = new Point(3, 3);
			listViewClasses.MultiSelect = false;
			listViewClasses.Name = "listViewClasses";
			listViewClasses.Size = new Size(786, 392);
			listViewClasses.TabIndex = 0;
			listViewClasses.UseCompatibleStateImageBehavior = false;
			listViewClasses.View = View.Details;
			listViewClasses.KeyUp += listViewClasses_KeyUp;
			listViewClasses.MouseDoubleClick += listViewClasses_MouseDoubleClick;
			// 
			// classNameHeader
			// 
			classNameHeader.Text = "Название";
			classNameHeader.Width = 80;
			// 
			// lectionsHeader
			// 
			lectionsHeader.Text = "Лекции";
			// 
			// labsHeader
			// 
			labsHeader.Text = "Лабораторные занятия";
			labsHeader.Width = 140;
			// 
			// practicesHeader
			// 
			practicesHeader.Text = "Практические занятия";
			practicesHeader.Width = 140;
			// 
			// tabPagePlans
			// 
			tabPagePlans.AutoScroll = true;
			tabPagePlans.Location = new Point(4, 24);
			tabPagePlans.Name = "tabPagePlans";
			tabPagePlans.Padding = new Padding(3);
			tabPagePlans.Size = new Size(792, 398);
			tabPagePlans.TabIndex = 2;
			tabPagePlans.Text = "Планы";
			tabPagePlans.UseVisualStyleBackColor = true;
			tabPagePlans.Click += tabPagePlans_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog.FileName = "openFileDialog1";
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControlMain);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			MinimumSize = new Size(360, 180);
			Name = "FormMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Факультативы";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			tabControlMain.ResumeLayout(false);
			tabPageStudents.ResumeLayout(false);
			tabPageClasses.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem toolStripMenuItemFile;
		private ToolStripMenuItem toolStripMenuItemClose;
		private ToolStripMenuItem toolStripMenuItemStudents;
		private ToolStripMenuItem ClassesToolStripMenuItem;
		private ToolStripMenuItem toolStripMenuItemAddStudent;
		private ToolStripMenuItem toolStripMenuItemEditStudent;
		private ToolStripMenuItem toolStripMenuItemAddClass;
		private ToolStripMenuItem toolStripMenuItemEditClass;
		private TabControl tabControlMain;
		private TabPage tabPageStudents;
		private TabPage tabPageClasses;
		private TabPage tabPagePlans;
		private ToolStripMenuItem планToolStripMenuItem;
		private ToolStripMenuItem ToolStripMenuItemAddPlan;
		private ToolStripMenuItem ToolStripMenuItemEditPlan;
		private ListView listViewClasses;
		private ColumnHeader surnameHeader;
		private ColumnHeader nameHeader;
		private ColumnHeader patronimHeader;
		private ColumnHeader phoneHeader;
		private ColumnHeader addressHeader;
		protected ListView listViewStudents;
		private ColumnHeader classNameHeader;
		private ColumnHeader lectionsHeader;
		private ColumnHeader labsHeader;
		private ColumnHeader practicesHeader;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem jsonSaveToolStripMenuItem;
		private ToolStripMenuItem xmlSaveToolStripMenuItem;
		private ToolStripMenuItem binSaveToolStripMenuItem;
		private ToolStripMenuItem loadToolStripMenuItem;
		private ToolStripMenuItem jsonLoadToolStripMenuItem;
		private ToolStripMenuItem xmlLoadToolStripMenuItem;
		private ToolStripMenuItem binLoadToolStripMenuItem;
		private OpenFileDialog openFileDialog;
		private SaveFileDialog saveFileDialog;
	}
}
