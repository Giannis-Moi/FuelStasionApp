using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStationApp.WUI {
    public partial class LedgerForm : Form {
        public SqlConnection Connection { get; set; }
        
        private const decimal rent = 5000m;
        public LedgerForm() {
            InitializeComponent();
        }


        private void Dates()
        {

            DateTime dateStart = Convert.ToDateTime(ctrlDateFrom.EditValue);

            DateTime dateEnd = Convert.ToDateTime(ctrlDateΤο.EditValue);

            const decimal rent = 5000m;

            decimal totalRentCount = (dateEnd - dateStart).Days * rent / 30;

            try
            {
                Connection.Open();
                string sqlCommandIncome = "SELECT SUM(TotalValue) AS 'Income' FROM [Transactions] WHERE [Date] BETWEEN '" + dateStart.ToString("yyyy-MM-dd") + "' AND '" + dateEnd.ToString("yyyy-MM-dd") + "'";
                SqlCommand Income = new SqlCommand(sqlCommandIncome, Connection);
                int income = 0;
                var n = Income.ExecuteScalar();
                if (n != DBNull.Value && n != null) {
                    income = Convert.ToInt32(n); ;
                }
                //Executes the query, and returns the first column of the first row in the result set returned by the query. Additional columns or rows are ignored.
                //int income = Convert.ToInt32(Income.ExecuteScalar());


                string sqlCommandExpenses = "SELECT SUM(TotalCost) AS 'ExpensesCost' FROM [Transactions] WHERE [Date] BETWEEN '" + dateStart.ToString("yyyy-MM-dd") + "' AND '" + dateEnd.ToString("yyyy-MM-dd") + "'";
                SqlCommand ExpensesCost = new SqlCommand(sqlCommandExpenses, Connection);

                // Executes the query, and returns the first column of the first row in the result set returned by the query.Additional columns or rows are ignored.
                int itemsCost = 0;
                var x = ExpensesCost.ExecuteScalar();
                if (x != DBNull.Value && x != null) {
                itemsCost = Convert.ToInt32(x);
            }




                string sqlCommandEmployees = "SELECT SUM(Salary) AS 'Cost' FROM [Employees] WHERE [DateStart] <='" + dateStart.ToString("yyyy-MM-dd") + "'";

                SqlCommand cmdEmployees = new SqlCommand(sqlCommandEmployees, Connection);

                int employeesCost = 0;
                var y = cmdEmployees.ExecuteScalar();
                if (y != DBNull.Value && y != null) {
                    employeesCost = Convert.ToInt32(y);
                }

                

                Connection.Close();
                decimal totalExpenses = (employeesCost + itemsCost + totalRentCount) ;
                ctrlIncome.EditValue = income;
                ctrlExpenses.EditValue = totalExpenses.ToString("0.00");
                decimal profit = income - totalExpenses;
                if (profit > 0)
                    labelProfit.Text = "Your profit is " + profit;

                else labelProfit.Text = "Your loss is "+ Math.Abs(profit).ToString("0.00");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();
            }
        }


        private void labelControl6_Click(object sender, EventArgs e) {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dates();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e) {




        }
    }
}
