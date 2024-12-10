using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement1
{
    public partial class Salaries : Form
    {
        Functions Con;
        public Salaries()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalaries();
            GetEmployees();
        }
        private void GetEmployees()
        {
            string Query = "select * from EmployeeTbl";
            EmpCb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            EmpCb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            EmpCb.DataSource = Con.GetData(Query);

        }
        int Dsal = 0;
        string Period = "";
        private void GetSalary()
        {
            string Query = "select EmpSal from EmployeeTbl where EmpId={0}";
            Query = string.Format(Query, EmpCb.SelectedValue.ToString());
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                Dsal = Convert.ToInt32(dr["EmpSal"].ToString());
            }
            //MessageBox.Show("" + Dsal);
            //EmpCb.DataSource = Con.GetData(Query);
            if (DaysTb.Text == "")
            {
                AmountTb.Text = "EUR" + (d * Dsal);
            }
            else if (Convert.ToInt32(DaysTb.Text) > 31)
            {
                MessageBox.Show("Days can not be Greater than 31");
            }
            else
            {
                d = Convert.ToInt32(DaysTb.Text);
                AmountTb.Text = "EUR" + (d * Dsal);
            }


        }
        private void ShowSalaries()
        {
            try
            {
                string Query = "Select * from SalaryTbl";
                SalaryList.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            if (SalaryList.SelectedRows.Count > 0)
            {
                EmpCb.Text = SalaryList.SelectedRows[0].Cells[1].Value.ToString();
                DaysTb.Text = SalaryList.SelectedRows[0].Cells[2].Value.ToString();
                PeriodTb.Text = SalaryList.SelectedRows[0].Cells[3].Value.ToString();
                AmountTb.Text = SalaryList.SelectedRows[0].Cells[4].Value.ToString();
                Key = 0;

            }
            else
            {
                Key = Convert.ToInt32(SalaryList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        int d = 1;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpCb.SelectedIndex == -1 || DaysTb.Text == "" || PeriodTb.Text == "")
                {
                    MessageBox.Show("Missing Data !!!");
                }
                else
                {
                    Period = PeriodTb.Value.Date.Month.ToString() + "-" + PeriodTb.Value.Date.Year.ToString();
                    int Amount = Dsal * Convert.ToInt32(DaysTb.Text);
                    int Days = Convert.ToInt32(DaysTb.Text);

                    string Query = "INSERT into  SalaryTbl values ({0},{1}, '{2}',{3},{4})";
                    Query = string.Format(Query, EmpCb.SelectedValue.ToString, Days, Period, Amount, DateTime.Today.Date, Key);
                    ShowSalaries();
                    MessageBox.Show("Salary Paid !!!");
                    DaysTb.Text = "";
                    PeriodTb.Text = "";
                    EmpCb.SelectedIndex = -1;


                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }

        }

        private void EmpCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void LayoutBtn_Click(object sender, EventArgs e)
        {
            Login Obj=new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
