using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement1
{
    public partial class Employees : Form
    {
        Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmp();
            GetDepartment();

            DepCb.SelectedValue = 0;
        }
        private void ShowEmp()
        {
            string Query = "Select * from EmployeeTbl";
            EmployeeList.DataSource = Con.GetData(Query);
        }
        private void GetDepartment()
        {
            string Query = "select * from DepartmentTbl";
            DepCb.DisplayMember = Con.GetData(Query).Columns["DepName"].ToString();
            DepCb.ValueMember = Con.GetData(Query).Columns["Depid"].ToString();
            DepCb.DataSource = Con.GetData(Query);

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data !!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Dep = DepCb.SelectedValue.ToString();
                    string DOB = DOBTb.Value.ToString();

                    string JDate = JDateTb.Value.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "INSERT into  EmployeeTbl values ('{0}','{1}', '{2}','{3}','{4}',{5})";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Added !!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data !!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Dep = DepCb.SelectedValue.ToString();
                    string DOB = DOBTb.Value.ToString();

                    string JDate = JDateTb.Value.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "Update EmployeeTbl set EmpName= '{0}', EmpGen='{1}', EmpDep='{2}',EmpDOB='{3}',EmpJDate='{4}',EmpSal={5} where Empid={6}";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary, Key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Updated !!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Missing Data !!!");
                }
                else
                {

                    string Query = "delete from EmployeeTbl where Empid={0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Deleted !!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //EmployeeList.ColumnCount = 7;

            //// Set the properties of the DataGridView columns.
            //EmployeeList.Columns[0].Name = "EmpId";
            //EmployeeList.Columns[1].Name = "EmpName";
            //EmployeeList.Columns[2].Name = "EmpGen";
            //EmployeeList.Columns[3].Name = "EmpDep";
            //EmployeeList.Columns[4].Name = "EmpDOB";
            //EmployeeList.Columns[5].Name = "EmpJDate";
            //EmployeeList.Columns[6].Name = "EmpSal";
            //EmployeeList.Columns["EmpId"].HeaderText = "EmpId";
            //EmployeeList.Columns["EmpName"].HeaderText = "EmpName";
            //EmployeeList.Columns["EmpGen"].HeaderText = "EmpGen";
            //EmployeeList.Columns["EmpDep"].HeaderText = "EmpDep";
            //EmployeeList.Columns["EmpDOB"].HeaderText = "EmpDOB";
            //EmployeeList.Columns["EmpJDate"].HeaderText = "EmpJDate";
            //EmployeeList.Columns["EmpSal"].HeaderText = "EmpSal";

            //// Add rows of data to the DataGridView.
            //try
            //{
            //    if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
            //    {
            //        MessageBox.Show("Missig Data !!!");
            //    }
            //    else
            //    {

            //    }


            //}
            //catch (Exception Ex)
            //{

            //    MessageBox.Show(Ex.Message);
            //}
            //EmployeeList.Rows.Add(new string[] { "1", "Parker", "Seattle" });
            //EmployeeList.Rows.Add(new string[] { "2", "Parker", "New York" });
            //EmployeeList.Rows.Add(new string[] { "3", "Watson", "Seattle" });
            //EmployeeList.Rows.Add(new string[] { "4", "Jameson", "New Jersey" });
            //EmployeeList.Rows.Add(new string[] { "5", "Brock", "New York" });
            //EmployeeList    .Rows.Add(new string[] { "6", "Conner", "Portland" });
            EmpNameTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            DepCb.SelectedValue = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            DOBTb.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            JDateTb.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
            DailySalTb.Text = EmployeeList.SelectedRows[0].Cells[6].Value.ToString();
            if (EmpNameTb.Text == "")
            {
                Key = 0;

            }
            else
            {
                Key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Layoutbtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
