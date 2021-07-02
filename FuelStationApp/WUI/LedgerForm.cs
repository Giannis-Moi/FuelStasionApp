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
        
        private const decimal rent = 1500m;
        public LedgerForm() {
            InitializeComponent();
        }


        private void Dates()
        {

            DateTime dateStart = Convert.ToDateTime(ctrlDateFrom.EditValue);

            DateTime dateEnd = Convert.ToDateTime(ctrlDateΤο.EditValue);

            const decimal rent = 1500m;

            decimal totalRentCount = (dateEnd - dateStart).Days * rent / 25;

            try
            {
                Connection.Open();
                string sqlCommandIncome = "SELECT SUM(DiscountValue) AS 'Income' FROM [Transactions] WHERE [Date] BETWEEN '" + dateStart.ToString("yyyy-MM-dd") + "' AND '" + dateEnd.ToString("yyyy-MM-dd") + "'";
                SqlCommand Income = new SqlCommand(sqlCommandIncome, Connection);

                //Executes the query, and returns the first column of the first row in the result set returned by the query. Additional columns or rows are ignored.
                string income = Convert.ToString(Income.ExecuteScalar());


                string sqlCommandExpenses = "SELECT SUM(TotalValue) AS 'ExpensesCost' FROM [Transactions] WHERE [Date] BETWEEN '" + dateStart.ToString("yyyy-MM-dd") + "' AND '" + dateEnd.ToString("yyyy-MM-dd") + "'";
                SqlCommand ExpensesCost = new SqlCommand(sqlCommandExpenses, Connection);

               // Executes the query, and returns the first column of the first row in the result set returned by the query.Additional columns or rows are ignored.
                string itemsCost = Convert.ToString(ExpensesCost.ExecuteScalar());


              

                string sqlCommandEmployees = "SELECT SUM(Salary) AS 'Cost' FROM [Employees] WHERE [Date] BETWEEN '" + dateStart.ToString("yyyy-MM-dd") + "' AND '" + dateEnd.ToString("yyyy-MM-dd") + "'";

                SqlCommand cmdEmployees = new SqlCommand(sqlCommandEmployees, Connection);

                string employeesCost = Convert.ToString(ExpensesCost.ExecuteScalar());

                Connection.Close();

                ctrlIncome.EditValue = income;
                ctrlExpenses.EditValue = employeesCost + itemsCost + totalRentCount;

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
    }
}
