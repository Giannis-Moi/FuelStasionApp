using FuelStationApp.Impl;
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
    public partial class EmployeeForm : Form {
        public SqlConnection Connection { get; set; }
        public EmployeeForm() {
            InitializeComponent();
        }

        void PopulateDataGridView() {
            try {
                Connection.Open();
                string MyQuery = "SELECT * FROM Employees";
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

        public void AddEmployee() {
            string employeeName = Convert.ToString(ctrlName.EditValue);
            string employeeSurname = Convert.ToString(ctrlSurname.EditValue);
          // string employeeDateStart = Convert(ctrlDateStart.EditValue);
           // string employeeDateEnd = Convert.ToString(ctrlDateEnd.EditValue);
            decimal employeeSalary = Convert.ToDecimal(ctrlSalary.EditValue);


            Employee newEmployee = new Employee(employeeName, employeeSurname, employeeSalary);




            SqlCommand cmd = new SqlCommand("INSERT INTO Employees (ID, Name, Surname, Salary) VALUES (NEWID(), '" + newEmployee.Name + "', '" + newEmployee.Surname + "', '" + newEmployee.Salary + "')", Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employees Succesfully Added");
            Connection.Close();
            PopulateDataGridView();


        }

        private void btnView_Click(object sender, EventArgs e) {
            PopulateDataGridView();
            //ResetFields();
        }
    }
}
