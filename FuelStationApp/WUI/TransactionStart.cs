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
    public partial class TransactionStart : Form {

        public SqlConnection Connection { get; set; }
        public Guid CustomerId { get; set; }

        public TransactionStart() {
            InitializeComponent();
        }

        private void CustomerCardField() {

            string query = "SELECT CardNumber FROM Customers";
            SqlCommand cmd = new SqlCommand(query, Connection);
            //Provides a way of reading a forward - only stream of rows from a SQL Server database
            SqlDataReader reader;
            try {
                Connection.Open();
                DataTable datatable = new DataTable();
                datatable.Columns.Add("CardNumber", typeof(string));
                reader = cmd.ExecuteReader();
                datatable.Load(reader);
                ctrlCardNumber.ValueMember = "CardNumber";
                ctrlCardNumber.DataSource = datatable;
                //Populate a textbox with selected item of a dropdownlist when selectedindex is chosen
                // items before the top item in the ListBox
                ctrlCardNumber.SelectedIndex = -1;
                Connection.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Connection.Close();
            }
        }

        private void TransactionStart_Load(object sender, EventArgs e) {
            CustomerCardField();
        }

        private void CustomerSearch() {
            try {
                Connection.Open();
                string Myquery = "SELECT * FROM  Customers WHERE CardNumber = '" + Convert.ToString(ctrlCardNumber.SelectedValue) + "'";
                SqlDataAdapter data = new SqlDataAdapter(Myquery, Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(data);
                var dataset = new DataSet();
                data.Fill(dataset);
                gridCustomers.DataSource = dataset.Tables[0];
                Connection.Close();

                CustomerId = Guid.Parse(Convert.ToString(gridViewCustomer.GetFocusedRowCellValue("ID")));
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Connection.Close();
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e) {
            CustomerSearch();
        }
        private void NewTransaction() {
            if (ctrlCardNumber.SelectedIndex == -1) {
                MessageBox.Show("Please Select a Card Number");
            }
            else {
                TransactionForm transactionForm = new TransactionForm();
                transactionForm.Connection = Connection;
                transactionForm.CustomerId = CustomerId;
                transactionForm.ShowDialog();
            }
        }

        private void btnNewTransaction_Click(object sender, EventArgs e) {
            NewTransaction();
        }
    }
}
