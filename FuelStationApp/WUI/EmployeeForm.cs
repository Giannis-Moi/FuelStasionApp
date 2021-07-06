using FuelStationApp.Impl;
using FuelStationApp.Properties;
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

        private DataSet _MasterData = new DataSet();
        private DataSet _MasterDataOld = new DataSet();

        public EmployeeForm() {


            InitializeComponent();

            dateTimePicker2.Value = DateTime.Now;


        }

        void PopulateDataGridView() {
            try {
                Connection.Open();
                string MyQuery = "SELECT * FROM Employees";
                SqlDataAdapter data = new SqlDataAdapter(MyQuery, Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(data);

                _MasterData.Clear();
                _MasterDataOld.Clear();
                data.Fill(_MasterData, "EMPLOYEES");
                data.Fill(_MasterDataOld, "EMPLOYEES");
                gridEmployee.DataSource = _MasterData.Tables[0];

                Connection.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

      


        public void AddEmployee() {
            string employeeName = Convert.ToString(ctrlName.EditValue);
            string employeeSurname = Convert.ToString(ctrlSurname.EditValue);
            string employeeDateStart = dateTimePicker3.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
          
            string employeeDateEnd = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
            decimal employeeSalary = Convert.ToDecimal(ctrlSalary.EditValue);


            Employee newEmployee = new Employee(employeeName, employeeSurname, employeeSalary, employeeDateStart, employeeDateEnd);




            SqlCommand cmd = new SqlCommand("INSERT INTO Employees (ID, Name, Surname,Salary,DateStart,DateEnd  ) VALUES (NEWID(), '" + newEmployee.Name + "', '" + newEmployee.Surname + "'" +
                ",'" + newEmployee.Salary + "','" + newEmployee.DateStart + "','" + newEmployee.DateEnd + "')", Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employees Succesfully Added");
            Connection.Close();
            PopulateDataGridView();


        }

        private void btnView_Click(object sender, EventArgs e) {
           
            
            PopulateDataGridView();
            
        }

        private void btnInsert_Click(object sender, EventArgs e) {
            AddEmployee();

            PopulateDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e) {


            DialogResult result = MessageBox.Show("Are you sure you want to delete this Employee?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {

                SqlCommand cmd = new SqlCommand(string.Format(Resources.DeleteEmployee, Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"))), Connection);
                Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Record Succesfully Deleted!");
                Connection.Close();
                PopulateDataGridView();
               
            }
        }







        private void UpdateEntry(string primaryKey) {

            


            foreach (DataRow row in _MasterData.Tables[0].Rows) {

                string sql = string.Empty;
                string sqlSet = string.Empty;

                List<string> sqlSetLines = new List<string>();
                List<string> sqlWhereLines = new List<string>();
                var temp = row[primaryKey];
                DataRow rowOld = _MasterDataOld.Tables[0].Select("ID ='" + row[primaryKey]+"'")[0];



                foreach (DataColumn column in _MasterData.Tables[0].Columns) {

                    if (column.ColumnName == "ID") {
                        ComposeQueryField(sqlWhereLines, column.ColumnName, row[column]);
                    }
                    else {

                        if (row[column.ColumnName].ToString() != rowOld[column.ColumnName].ToString()) {

                            ComposeQueryField(sqlSetLines, column.ColumnName, row[column]);
                        }
                    }
                }

                sqlSet = string.Join(",", sqlSetLines);

                if (sqlSetLines.Count > 0) {
                    sql = "UPDATE [EMPLOYEES] " + " SET " + sqlSet + " WHERE " + string.Join(",", sqlWhereLines);
                    Connection.Open();
                   
                    SqlCommand command = new SqlCommand(sql, Connection);
                    int rowsAffected = command.ExecuteNonQuery();
                   
                    Connection.Close();
                }
            }
        }


        private void ComposeQueryField(List<string> sqlLine, string columnName, object value) {

            switch (value.GetType().Name) {

                case "Guid":
                case "String":
                    sqlLine.Add(string.Format("{0}='{1}'", columnName, value));
                    break;

                case "Int32":
                case "Int64":
                    sqlLine.Add(string.Format("{0}={1}", columnName, value));
                    break;

                case "DateTime":
                    string datePart = Convert.ToDateTime(value).ToString("yyyyMMdd");
                    sqlLine.Add(string.Format("{0}='{1}'", columnName, datePart));
                    break;

                case "Decimal":



                    string decimalPart = Convert.ToDecimal(value).ToString().Replace(',', '.');

                    sqlLine.Add(string.Format("{0}={1}", columnName, decimalPart));
                    break;
            }



        }

        private void btnEdit_Click(object sender, EventArgs e) {
            UpdateEntry("ID");
        }
    }
    }

