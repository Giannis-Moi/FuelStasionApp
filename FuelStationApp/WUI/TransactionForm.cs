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
    public partial class TransactionForm : Form {

        public SqlConnection Connection { get; set; }
        public Guid CustomerId { get; set; }

        BindingList<TransactionLine> TransactionLines = new BindingList<TransactionLine>();
        private int FuelQuantityCount = 0;
        private bool DiscountDone = false;
        private const decimal DiscountRate = 0.10m;

        public TransactionForm() {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e) {
            PopulateItemsDataGridView();
            PopulateCustomerIdView();
        }

        void PopulateItemsDataGridView() {
            try {
                Connection.Open();
                string MyQuery = "SELECT * FROM Items";
                SqlDataAdapter data = new SqlDataAdapter(MyQuery, Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(data);
                var dataset = new DataSet();
                data.Fill(dataset);
                gridViewItems.DataSource = dataset.Tables[0];
                Connection.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

        }
        private void PopulateCustomerIdView() {
            ctrlCustomerID.Text = Convert.ToString(CustomerId);
        }

        private void AddListItems() {
            Guid itemID = Guid.Parse(Convert.ToString(gridViewListItems.GetFocusedRowCellValue("ID")));

            int itemQuantity = Convert.ToInt32(ctrlQuantity2.Text);

            string itemType = Convert.ToString(gridViewListItems.GetFocusedRowCellValue("ItemType"));
            if (itemType == "Fuel") {
                FuelQuantityCount += 1;
                itemQuantity = 1;
            }

            decimal itemPrice = decimal.Parse(Convert.ToString(gridViewListItems.GetFocusedRowCellValue("Price")));
            decimal itemCost = decimal.Parse(Convert.ToString(gridViewListItems.GetFocusedRowCellValue("Cost")));
            decimal value = itemQuantity * itemPrice;
            decimal cost = itemQuantity * itemCost;

            if (FuelQuantityCount > 1 && itemPrice > 50) {
                DiscountDone = true;
            }

            if (FuelQuantityCount > 1) {
                MessageBox.Show("Please choose other product!");
            }
            else {
                TransactionLine newTransactionLine = new TransactionLine ( itemID,  itemQuantity,  itemPrice,  value, itemCost, cost, itemType);
                TransactionLines.Add(newTransactionLine);

                gridTransactionLines.DataSource = TransactionLines;

                CalculateTotalValues();
            }
        }


        private void gridViewItems_Click(object sender, EventArgs e) {

        }

        private void CalculateTotalValues() {
            decimal totalValue = TransactionLines.Sum(x => x.Value);
            ctrlTotalValue.Text = Convert.ToString(totalValue);

            decimal totalCost = TransactionLines.Sum(x => x.Cost);
            ctrlTotalCost.Text = Convert.ToString(totalCost);

            decimal discount = 0;
            decimal discountValue = 0;
            if (DiscountDone) {
                discount = totalValue * DiscountRate;
                discountValue = totalValue - discount;
            }
            else {
                discountValue = totalValue;
            }

            ctrlDiscountValue.Text = Convert.ToString(discountValue);
        }

        private void btnAddItem_Click(object sender, EventArgs e) {
            AddListItems();

        }

        private void btnRefresh_Click(object sender, EventArgs e) {

        }

        private void ctrlItemType_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
