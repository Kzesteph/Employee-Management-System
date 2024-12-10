namespace EmployeeManagement1
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EmpNameTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            DailySalTb = new TextBox();
            GenCb = new ComboBox();
            DepCb = new ComboBox();
            DOBTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            JDateTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            AddBtn = new Button();
            Layoutbtn = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            EmployeeList = new Guna.UI2.WinForms.Guna2DataGridView();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 78);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(389, 29);
            label1.Name = "label1";
            label1.Size = new Size(394, 25);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System Version 1.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(515, 155);
            label2.Name = "label2";
            label2.Size = new Size(186, 25);
            label2.TabIndex = 1;
            label2.Text = "Manage Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(10, 113);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 6;
            label3.Text = "Employee Name";
            // 
            // EmpNameTb
            // 
            EmpNameTb.Location = new Point(12, 152);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(237, 30);
            EmpNameTb.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(12, 204);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 8;
            label4.Text = "Employee Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(12, 304);
            label5.Name = "label5";
            label5.Size = new Size(205, 25);
            label5.TabIndex = 10;
            label5.Text = "Employee Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(12, 397);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 12;
            label6.Text = "Date Of Birth";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(12, 489);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 14;
            label7.Text = "Join Date";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 772);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 116);
            panel2.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(12, 583);
            label8.Name = "label8";
            label8.Size = new Size(208, 25);
            label8.TabIndex = 17;
            label8.Text = "Employee Daily Salary";
            // 
            // DailySalTb
            // 
            DailySalTb.Location = new Point(12, 622);
            DailySalTb.Name = "DailySalTb";
            DailySalTb.Size = new Size(237, 30);
            DailySalTb.TabIndex = 16;
            // 
            // GenCb
            // 
            GenCb.FormattingEnabled = true;
            GenCb.Items.AddRange(new object[] { "Male ", "Female" });
            GenCb.Location = new Point(12, 243);
            GenCb.Name = "GenCb";
            GenCb.Size = new Size(237, 33);
            GenCb.TabIndex = 18;
            // 
            // DepCb
            // 
            DepCb.FormattingEnabled = true;
            DepCb.Location = new Point(12, 350);
            DepCb.Name = "DepCb";
            DepCb.Size = new Size(237, 33);
            DepCb.TabIndex = 19;
            // 
            // DOBTb
            // 
            DOBTb.Checked = true;
            DOBTb.CustomizableEdges = customizableEdges5;
            DOBTb.FillColor = Color.Teal;
            DOBTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DOBTb.Format = DateTimePickerFormat.Short;
            DOBTb.Location = new Point(12, 441);
            DOBTb.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DOBTb.MinDate = new DateTime(1960, 11, 27, 11, 51, 0, 0);
            DOBTb.Name = "DOBTb";
            DOBTb.ShadowDecoration.CustomizableEdges = customizableEdges6;
            DOBTb.Size = new Size(250, 45);
            DOBTb.TabIndex = 21;
            DOBTb.Value = new DateTime(2024, 11, 27, 11, 51, 43, 0);
            // 
            // JDateTb
            // 
            JDateTb.Checked = true;
            JDateTb.CustomizableEdges = customizableEdges7;
            JDateTb.FillColor = Color.Teal;
            JDateTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            JDateTb.Format = DateTimePickerFormat.Short;
            JDateTb.Location = new Point(12, 535);
            JDateTb.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            JDateTb.MinDate = new DateTime(1960, 11, 27, 0, 0, 0, 0);
            JDateTb.Name = "JDateTb";
            JDateTb.ShadowDecoration.CustomizableEdges = customizableEdges8;
            JDateTb.Size = new Size(250, 45);
            JDateTb.TabIndex = 22;
            JDateTb.Value = new DateTime(2024, 11, 27, 0, 0, 0, 0);
            // 
            // AddBtn
            // 
            AddBtn.ForeColor = Color.Teal;
            AddBtn.Location = new Point(12, 665);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 43);
            AddBtn.TabIndex = 23;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // Layoutbtn
            // 
            Layoutbtn.AutoSize = true;
            Layoutbtn.ForeColor = Color.Teal;
            Layoutbtn.Location = new Point(992, 91);
            Layoutbtn.Name = "Layoutbtn";
            Layoutbtn.Size = new Size(72, 25);
            Layoutbtn.TabIndex = 51;
            Layoutbtn.Text = "Logout";
            Layoutbtn.Click += Layoutbtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(781, 91);
            label10.Name = "label10";
            label10.Size = new Size(68, 25);
            label10.TabIndex = 50;
            label10.Text = "Salary";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(526, 91);
            label11.Name = "label11";
            label11.Size = new Size(113, 25);
            label11.TabIndex = 49;
            label11.Text = "Department";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(267, 91);
            label12.Name = "label12";
            label12.Size = new Size(99, 25);
            label12.TabIndex = 48;
            label12.Text = "Employee";
            // 
            // EmployeeList
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            EmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            EmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            EmployeeList.ColumnHeadersHeight = 25;
            EmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            EmployeeList.DefaultCellStyle = dataGridViewCellStyle6;
            EmployeeList.GridColor = Color.FromArgb(231, 229, 255);
            EmployeeList.Location = new Point(281, 204);
            EmployeeList.Name = "EmployeeList";
            EmployeeList.RowHeadersVisible = false;
            EmployeeList.RowHeadersWidth = 51;
            EmployeeList.RowTemplate.Height = 29;
            EmployeeList.Size = new Size(898, 466);
            EmployeeList.TabIndex = 52;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.Font = null;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            EmployeeList.ThemeStyle.BackColor = Color.White;
            EmployeeList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            EmployeeList.ThemeStyle.HeaderStyle.BackColor = Color.Teal;
            EmployeeList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            EmployeeList.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            EmployeeList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            EmployeeList.ThemeStyle.HeaderStyle.Height = 25;
            EmployeeList.ThemeStyle.ReadOnly = false;
            EmployeeList.ThemeStyle.RowsStyle.BackColor = Color.White;
            EmployeeList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EmployeeList.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            EmployeeList.ThemeStyle.RowsStyle.Height = 29;
            EmployeeList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            EmployeeList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            EmployeeList.CellContentClick += EmployeeList_CellContentClick;
            // 
            // UpdateBtn
            // 
            UpdateBtn.ForeColor = Color.Teal;
            UpdateBtn.Location = new Point(133, 665);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(94, 43);
            UpdateBtn.TabIndex = 53;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.ForeColor = Color.Teal;
            DeleteBtn.Location = new Point(133, 714);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 43);
            DeleteBtn.TabIndex = 55;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 888);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(EmployeeList);
            Controls.Add(Layoutbtn);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(AddBtn);
            Controls.Add(JDateTb);
            Controls.Add(DOBTb);
            Controls.Add(DepCb);
            Controls.Add(GenCb);
            Controls.Add(label8);
            Controls.Add(DailySalTb);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EmpNameTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "Employees";
            Text = "Employees";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EmpNameTb;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private Label label8;
        private TextBox DailySalTb;
        private ComboBox GenCb;
        private ComboBox DepCb;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOBTb;
        private Guna.UI2.WinForms.Guna2DateTimePicker JDateTb;
        private Button AddBtn;
        private Label Layoutbtn;
        private Label label10;
        private Label label11;
        private Label label12;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeList;
        private Button UpdateBtn;
        private Button DeleteBtn;
    }
}