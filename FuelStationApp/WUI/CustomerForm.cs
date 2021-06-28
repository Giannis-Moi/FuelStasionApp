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
using FuelStationApp.Impl;

namespace FuelStationApp.WUI {
    public partial class CustomerForm : Form {
        public SqlConnection Connection { get; set; }
        public CustomerForm() {
            InitializeComponent();
        }

        void PopulateDataGridView() {
            try {
                Connection.Open();
                string MyQuery = "SELECT * FROM Customers";
                SqlDataAdapter data = new SqlDataAdapter(MyQuery, Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(data);
                var dataset = new DataSet();
                data.Fill(dataset);
                gridCustomers.DataSource = dataset.Tables[0];
                Connection.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        public void addCustomer() {

            string customerName = Convert.ToString(ctrlName.Text);
            string customerSurname = Convert.ToString(ctrlSurname.Text);
            string customerCardNumber = Convert.ToString(ctrlCardNumber.Text);


            Customer newCustomer = new Customer(customerName, customerSurname, customerCardNumber);

            try {
                Connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Customers (ID, Name, Surname, CardNumber) VALUES (NEWID(), '" + newCustomer.Name + "', '" + newCustomer.Surname + "', '" + newCustomer.CardNumber + "')", Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Succesfully Added");
                Connection.Close();
                PopulateDataGridView();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
         
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            addCustomer();
            PopulateDataGridView();

        }

        private void gridCustomers_Click(object sender, EventArgs e) {

        }

        private void CustomerForm_Load(object sender, EventArgs e) {
            PopulateDataGridView();
            ResetFields();
        }

        private void ResetFields() {
            ctrlName.Text = String.Empty;
            ctrlSurname.Text = String.Empty;
            ctrlCardNumber.Text = String.Empty;
        }

        private void btndelete_Click(object sender, EventArgs e) {
            DeleteCustomer();
        }
        private void DeleteCustomer() {
            if (ctrlName.Text == String.Empty && ctrlSurname.Text == String.Empty && ctrlCardNumber.Text == String.Empty) {
                MessageBox.Show("Enter the Customer's data to delete the Record");
            }
            else {
                Connection.Open();
                string myquery = "DELETE FROM Customers WHERE CardNumber='" + ctrlCardNumber.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                Connection.Close();
                PopulateDataGridView();
                ResetFields();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e) {
            EditCustomer();
        }

        private void EditCustomer() {
            try {
                Connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Customers SET Name='" + ctrlName.Text + "',Surname='" + ctrlSurname.Text + "' WHERE CardNumber='" + ctrlCardNumber.Text + "'", Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Connection.Close();
                PopulateDataGridView();
                ResetFields();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
  
}
