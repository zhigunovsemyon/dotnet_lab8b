namespace WinFormsControlLibraryJournal
{
	partial class UserControlPlan
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.textBoxStudent = new TextBox();
			this.labelClass = new Label();
			this.textBoxClass = new TextBox();
			this.textBoxMark = new TextBox();
			this.labelMark = new Label();
			this.buttonDelete = new Button();
			this.labelStudent = new Label();
			this.tableLayoutPanelGlob = new TableLayoutPanel();
			this.tableLayoutPanelTop = new TableLayoutPanel();
			this.tableLayoutPanelBottom = new TableLayoutPanel();
			this.tableLayoutPanelGlob.SuspendLayout();
			this.tableLayoutPanelTop.SuspendLayout();
			this.tableLayoutPanelBottom.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxStudent
			// 
			this.textBoxStudent.Dock = DockStyle.Fill;
			this.textBoxStudent.Location = new Point(67, 3);
			this.textBoxStudent.Name = "textBoxStudent";
			this.textBoxStudent.ReadOnly = true;
			this.textBoxStudent.Size = new Size(523, 23);
			this.textBoxStudent.TabIndex = 1;
			this.textBoxStudent.Click += this.UserControlPlan_Click;
			// 
			// labelClass
			// 
			this.labelClass.AutoSize = true;
			this.labelClass.Location = new Point(3, 0);
			this.labelClass.Name = "labelClass";
			this.labelClass.Size = new Size(55, 15);
			this.labelClass.TabIndex = 2;
			this.labelClass.Text = "Предмет";
			this.labelClass.Click += this.UserControlPlan_Click;
			// 
			// textBoxClass
			// 
			this.textBoxClass.Dock = DockStyle.Fill;
			this.textBoxClass.Location = new Point(67, 3);
			this.textBoxClass.Name = "textBoxClass";
			this.textBoxClass.ReadOnly = true;
			this.textBoxClass.Size = new Size(333, 23);
			this.textBoxClass.TabIndex = 0;
			this.textBoxClass.Click += this.UserControlPlan_Click;
			// 
			// textBoxMark
			// 
			this.textBoxMark.Dock = DockStyle.Fill;
			this.textBoxMark.Location = new Point(461, 3);
			this.textBoxMark.Name = "textBoxMark";
			this.textBoxMark.ReadOnly = true;
			this.textBoxMark.Size = new Size(60, 23);
			this.textBoxMark.TabIndex = 2;
			this.textBoxMark.Click += this.UserControlPlan_Click;
			// 
			// labelMark
			// 
			this.labelMark.AutoSize = true;
			this.labelMark.Location = new Point(406, 0);
			this.labelMark.Name = "labelMark";
			this.labelMark.Size = new Size(48, 15);
			this.labelMark.TabIndex = 1;
			this.labelMark.Text = "Оценка";
			this.labelMark.Click += this.UserControlPlan_Click;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new Point(527, 3);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new Size(63, 21);
			this.buttonDelete.TabIndex = 0;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += this.buttonDelete_Click;
			// 
			// labelStudent
			// 
			this.labelStudent.AutoSize = true;
			this.labelStudent.Dock = DockStyle.Fill;
			this.labelStudent.Location = new Point(3, 0);
			this.labelStudent.Name = "labelStudent";
			this.labelStudent.Size = new Size(58, 28);
			this.labelStudent.TabIndex = 0;
			this.labelStudent.Text = "Студент";
			this.labelStudent.Click += this.UserControlPlan_Click;
			// 
			// tableLayoutPanelGlob
			// 
			this.tableLayoutPanelGlob.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
			this.tableLayoutPanelGlob.ColumnCount = 1;
			this.tableLayoutPanelGlob.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			this.tableLayoutPanelGlob.Controls.Add(this.tableLayoutPanelTop, 0, 0);
			this.tableLayoutPanelGlob.Controls.Add(this.tableLayoutPanelBottom, 0, 1);
			this.tableLayoutPanelGlob.Dock = DockStyle.Fill;
			this.tableLayoutPanelGlob.Location = new Point(0, 0);
			this.tableLayoutPanelGlob.Name = "tableLayoutPanelGlob";
			this.tableLayoutPanelGlob.RowCount = 2;
			this.tableLayoutPanelGlob.RowStyles.Add(new RowStyle(SizeType.Percent, 50.9803925F));
			this.tableLayoutPanelGlob.RowStyles.Add(new RowStyle(SizeType.Percent, 49.0196075F));
			this.tableLayoutPanelGlob.Size = new Size(603, 73);
			this.tableLayoutPanelGlob.TabIndex = 3;
			this.tableLayoutPanelGlob.Click += this.UserControlPlan_Click;
			// 
			// tableLayoutPanelTop
			// 
			this.tableLayoutPanelTop.ColumnCount = 2;
			this.tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
			this.tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this.tableLayoutPanelTop.Controls.Add(this.labelStudent, 0, 0);
			this.tableLayoutPanelTop.Controls.Add(this.textBoxStudent, 1, 0);
			this.tableLayoutPanelTop.Dock = DockStyle.Fill;
			this.tableLayoutPanelTop.Location = new Point(5, 5);
			this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
			this.tableLayoutPanelTop.RowCount = 1;
			this.tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this.tableLayoutPanelTop.Size = new Size(593, 28);
			this.tableLayoutPanelTop.TabIndex = 0;
			this.tableLayoutPanelTop.Click += this.UserControlPlan_Click;
			// 
			// tableLayoutPanelBottom
			// 
			this.tableLayoutPanelBottom.ColumnCount = 5;
			this.tableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
			this.tableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this.tableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
			this.tableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
			this.tableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 69F));
			this.tableLayoutPanelBottom.Controls.Add(this.buttonDelete, 4, 0);
			this.tableLayoutPanelBottom.Controls.Add(this.textBoxMark, 3, 0);
			this.tableLayoutPanelBottom.Controls.Add(this.textBoxClass, 1, 0);
			this.tableLayoutPanelBottom.Controls.Add(this.labelMark, 2, 0);
			this.tableLayoutPanelBottom.Controls.Add(this.labelClass, 0, 0);
			this.tableLayoutPanelBottom.Dock = DockStyle.Fill;
			this.tableLayoutPanelBottom.Location = new Point(5, 41);
			this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
			this.tableLayoutPanelBottom.RowCount = 1;
			this.tableLayoutPanelBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this.tableLayoutPanelBottom.Size = new Size(593, 27);
			this.tableLayoutPanelBottom.TabIndex = 1;
			this.tableLayoutPanelBottom.Click += this.UserControlPlan_Click;
			// 
			// UserControlPlan
			// 
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelGlob);
			this.Name = "UserControlPlan";
			this.Size = new Size(603, 73);
			this.Load += this.UserControlPlan_Load;
			this.Click += this.UserControlPlan_Click;
			this.tableLayoutPanelGlob.ResumeLayout(false);
			this.tableLayoutPanelTop.ResumeLayout(false);
			this.tableLayoutPanelTop.PerformLayout();
			this.tableLayoutPanelBottom.ResumeLayout(false);
			this.tableLayoutPanelBottom.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion
		private TextBox textBoxStudent;
		private TextBox textBoxMark;
		private Label labelMark;
		private Button buttonDelete;
		private Label labelClass;
		private TextBox textBoxClass;
		private Label labelStudent;
		private TableLayoutPanel tableLayoutPanelGlob;
		private TableLayoutPanel tableLayoutPanelTop;
		private TableLayoutPanel tableLayoutPanelBottom;
	}
}
