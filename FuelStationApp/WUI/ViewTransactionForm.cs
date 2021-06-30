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
    public partial class ViewTransactionForm : Form {

        public SqlConnection Connection { get; set; }
        public Guid Id { get; set; }
        public ViewTransactionForm() {
            InitializeComponent();
        }

        void PopulateDataGridView() {
            try {
                Connection.Open();
                string MyQuery = "SELECT * FROM Transactions";
                SqlDataAdapter data = new SqlDataAdapter(MyQuery, Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(data);
                var dataset = new DataSet();
                data.Fill(dataset);
                gridTransaction.DataSource = dataset.Tables[0];
                Connection.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }




        private void btnViewTransactionLine_Click(object sender, EventArgs e) {
            Id = Guid.Parse(Convert.ToString(gridViewTransaction.GetFocusedRowCellValue("ID")));

            ViewTransactionFormLine viewTransactionLine = new ViewTransactionFormLine();
            viewTransactionLine.Connection = Connection;
            viewTransactionLine.ID = Id;
            viewTransactionLine.ShowDialog();
        }

        private void ViewTransactionForm_Load(object sender, EventArgs e) {
            PopulateDataGridView();
        }
    }
}
