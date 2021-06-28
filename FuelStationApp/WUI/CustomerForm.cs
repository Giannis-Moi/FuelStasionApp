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
    }
}
