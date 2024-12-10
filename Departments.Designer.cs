namespace EmployeeManagement1
{
    partial class Departments
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            EditBtn = new Button();
            AddBtn = new Button();
            DepList = new Guna.UI2.WinForms.Guna2DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            DepNameTb = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            EmpLbl = new Label();
            label6 = new Label();
            SalaryLbl = new Label();
            label8 = new Label();
            DeleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DepList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.PaleTurquoise;
            EditBtn.ForeColor = Color.Black;
            EditBtn.Location = new Point(138, 332);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(137, 43);
            EditBtn.TabIndex = 42;
            EditBtn.Text = "Update";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.ForeColor = Color.Teal;
            AddBtn.Location = new Point(12, 332);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(120, 43);
            AddBtn.TabIndex = 41;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DepList
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            DepList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DepList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DepList.ColumnHeadersHeight = 25;
            DepList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DepList.DefaultCellStyle = dataGridViewCellStyle6;
            DepList.GridColor = Color.FromArgb(231, 229, 255);
            DepList.Location = new Point(343, 223);
            DepList.Name = "DepList";
            DepList.RowHeadersVisible = false;
            DepList.RowHeadersWidth = 51;
            DepList.RowTemplate.Height = 29;
            DepList.Size = new Size(898, 466);
            DepList.TabIndex = 38;
            DepList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DepList.ThemeStyle.AlternatingRowsStyle.Font = null;
            DepList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DepList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DepList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DepList.ThemeStyle.BackColor = Color.White;
            DepList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DepList.ThemeStyle.HeaderStyle.BackColor = Color.Teal;
            DepList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DepList.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DepList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DepList.ThemeStyle.HeaderStyle.Height = 25;
            DepList.ThemeStyle.ReadOnly = false;
            DepList.ThemeStyle.RowsStyle.BackColor = Color.White;
            DepList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DepList.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DepList.ThemeStyle.RowsStyle.Height = 29;
            DepList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DepList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DepList.CellContentClick += DepList_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(22, 195);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 28;
            label3.Text = "Department Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(501, 63);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 26;
            label2.Text = "Manage Departmens";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(385, 9);
            label1.Name = "label1";
            label1.Size = new Size(318, 20);
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
            // DepNameTb
            // 
            DepNameTb.Location = new Point(22, 234);
            DepNameTb.Name = "DepNameTb";
            DepNameTb.Size = new Size(237, 26);
            DepNameTb.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 60);
            panel1.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(534, 166);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 43;
            label4.Text = "Department List";
            // 
            // EmpLbl
            // 
            EmpLbl.AutoSize = true;
            EmpLbl.ForeColor = Color.Teal;
            EmpLbl.Location = new Point(226, 108);
            EmpLbl.Name = "EmpLbl";
            EmpLbl.Size = new Size(79, 20);
            EmpLbl.TabIndex = 44;
            EmpLbl.Text = "Employee";
            EmpLbl.Click += EmpLbl_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(474, 108);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 45;
            label6.Text = "Department";
            // 
            // SalaryLbl
            // 
            SalaryLbl.AutoSize = true;
            SalaryLbl.ForeColor = Color.Teal;
            SalaryLbl.Location = new Point(740, 108);
            SalaryLbl.Name = "SalaryLbl";
            SalaryLbl.Size = new Size(53, 20);
            SalaryLbl.TabIndex = 46;
            SalaryLbl.Text = "Salary";
            SalaryLbl.Click += SalaryLbl_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(951, 108);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 47;
            label8.Text = "Logout";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.ForeColor = Color.Black;
            DeleteBtn.Location = new Point(138, 412);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(137, 43);
            DeleteBtn.TabIndex = 48;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 888);
            Controls.Add(DeleteBtn);
            Controls.Add(label8);
            Controls.Add(SalaryLbl);
            Controls.Add(label6);
            Controls.Add(EmpLbl);
            Controls.Add(label4);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(DepList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(DepNameTb);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "Departments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departments";
            ((System.ComponentModel.ISupportInitialize)DepList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditBtn;
        private Button AddBtn;
        private Guna.UI2.WinForms.Guna2DataGridView DepList;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox DepNameTb;
        private Panel panel1;
        private Label label4;
        private Label EmpLbl;
        private Label label6;
        private Label SalaryLbl;
        private Label label8;
        private Button DeleteBtn;
    }
}