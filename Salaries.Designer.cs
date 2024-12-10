namespace EmployeeManagement1
{
    partial class Salaries
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            UpdateBtn = new Button();
            AddBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            EmpCb = new ComboBox();
            DaysTb = new TextBox();
            PeriodTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            LayoutBtn = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            SalaryList = new Guna.UI2.WinForms.Guna2DataGridView();
            AmountTb = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalaryList).BeginInit();
            SuspendLayout();
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.PaleTurquoise;
            UpdateBtn.ForeColor = Color.Black;
            UpdateBtn.Location = new Point(138, 678);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(111, 43);
            UpdateBtn.TabIndex = 42;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            AddBtn.ForeColor = Color.Teal;
            AddBtn.Location = new Point(12, 678);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 43);
            AddBtn.TabIndex = 41;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(12, 397);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 31;
            label6.Text = "Salary Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(12, 304);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 30;
            label5.Text = "Period";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(12, 204);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 29;
            label4.Text = "Days Attended";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 28;
            label3.Text = "Employee ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(594, 160);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 26;
            label2.Text = "Manage Salary";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 78);
            panel1.TabIndex = 25;
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
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 772);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 116);
            panel2.TabIndex = 33;
            // 
            // EmpCb
            // 
            EmpCb.FormattingEnabled = true;
            EmpCb.Items.AddRange(new object[] { "Male ", "Female" });
            EmpCb.Location = new Point(12, 152);
            EmpCb.Name = "EmpCb";
            EmpCb.Size = new Size(237, 33);
            EmpCb.TabIndex = 43;
            EmpCb.SelectionChangeCommitted += EmpCb_SelectionChangeCommitted;
            // 
            // DaysTb
            // 
            DaysTb.Location = new Point(12, 243);
            DaysTb.Name = "DaysTb";
            DaysTb.Size = new Size(237, 30);
            DaysTb.TabIndex = 44;
            // 
            // PeriodTb
            // 
            PeriodTb.Checked = true;
            PeriodTb.CustomizableEdges = customizableEdges3;
            PeriodTb.FillColor = Color.Teal;
            PeriodTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PeriodTb.Format = DateTimePickerFormat.Long;
            PeriodTb.Location = new Point(12, 343);
            PeriodTb.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            PeriodTb.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            PeriodTb.Name = "PeriodTb";
            PeriodTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PeriodTb.Size = new Size(250, 45);
            PeriodTb.TabIndex = 45;
            PeriodTb.Value = new DateTime(2024, 11, 26, 9, 39, 57, 906);
            // 
            // LayoutBtn
            // 
            LayoutBtn.AutoSize = true;
            LayoutBtn.ForeColor = Color.Teal;
            LayoutBtn.Location = new Point(1005, 95);
            LayoutBtn.Name = "LayoutBtn";
            LayoutBtn.Size = new Size(72, 25);
            LayoutBtn.TabIndex = 51;
            LayoutBtn.Text = "Logout";
            LayoutBtn.Click += LayoutBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(794, 95);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 50;
            label7.Text = "Salary";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(528, 95);
            label9.Name = "label9";
            label9.Size = new Size(113, 25);
            label9.TabIndex = 49;
            label9.Text = "Department";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(280, 95);
            label10.Name = "label10";
            label10.Size = new Size(99, 25);
            label10.TabIndex = 48;
            label10.Text = "Employee";
            // 
            // SalaryList
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            SalaryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            SalaryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            SalaryList.ColumnHeadersHeight = 25;
            SalaryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            SalaryList.DefaultCellStyle = dataGridViewCellStyle6;
            SalaryList.GridColor = Color.FromArgb(231, 229, 255);
            SalaryList.Location = new Point(347, 224);
            SalaryList.Name = "SalaryList";
            SalaryList.RowHeadersVisible = false;
            SalaryList.RowHeadersWidth = 51;
            SalaryList.RowTemplate.Height = 29;
            SalaryList.Size = new Size(898, 466);
            SalaryList.TabIndex = 52;
            SalaryList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            SalaryList.ThemeStyle.AlternatingRowsStyle.Font = null;
            SalaryList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            SalaryList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            SalaryList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            SalaryList.ThemeStyle.BackColor = Color.White;
            SalaryList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            SalaryList.ThemeStyle.HeaderStyle.BackColor = Color.Teal;
            SalaryList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            SalaryList.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SalaryList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            SalaryList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SalaryList.ThemeStyle.HeaderStyle.Height = 25;
            SalaryList.ThemeStyle.ReadOnly = false;
            SalaryList.ThemeStyle.RowsStyle.BackColor = Color.White;
            SalaryList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SalaryList.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SalaryList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            SalaryList.ThemeStyle.RowsStyle.Height = 29;
            SalaryList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            SalaryList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            SalaryList.CellContentClick += SalaryList_CellContentClick;
            // 
            // AmountTb
            // 
            AmountTb.BackColor = Color.White;
            AmountTb.BorderStyle = BorderStyle.None;
            AmountTb.ForeColor = Color.Teal;
            AmountTb.Location = new Point(12, 425);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(237, 23);
            AmountTb.TabIndex = 53;
            AmountTb.TextAlign = HorizontalAlignment.Right;
            // 
            // Salaries
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 888);
            Controls.Add(AmountTb);
            Controls.Add(SalaryList);
            Controls.Add(LayoutBtn);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(PeriodTb);
            Controls.Add(DaysTb);
            Controls.Add(EmpCb);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "Salaries";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salaries";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SalaryList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateBtn;
        private Button AddBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox EmpCb;
        private TextBox DaysTb;
        private Guna.UI2.WinForms.Guna2DateTimePicker PeriodTb;
        private Label LayoutBtn;
        private Label label7;
        private Label label9;
        private Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView SalaryList;
        private TextBox AmountTb;
    }
}