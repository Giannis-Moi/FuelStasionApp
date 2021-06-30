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
    public partial class TransactionForm : Form {

        public SqlConnection Connection { get; set; }
        public Guid CustomerId { get; set; }
        public TransactionForm() {
            InitializeComponent();
        }
    }
}
