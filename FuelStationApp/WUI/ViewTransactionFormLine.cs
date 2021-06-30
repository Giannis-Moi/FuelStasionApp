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
    public partial class ViewTransactionFormLine : Form {
        public SqlConnection Connection { get; set; }
        public Guid ID { get; set; }
        public ViewTransactionFormLine() {
            InitializeComponent();
        }

        private void PopulateTransactionLine() {
            try {

                string transactionId = Convert.ToString(ID);

                Connection.Open();
                string Myquery = "SELECT * FROM TransactionLine WHERE TransactionId = '" + transactionId + "'";
                SqlDataAdapter data = new SqlDataAdapter(Myquery, Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(data);
                var ds = new DataSet();
                data.Fill(ds);
                gridTransactionLine.DataSource = ds.Tables[0];
                Connection.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Connection.Close();
            }
        }

        private void ViewTransactionFormLine_Load(object sender, EventArgs e) {
            PopulateTransactionLine();
        }
    }
}
