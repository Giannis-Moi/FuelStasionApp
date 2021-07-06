using FuelStationApp.Impl;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static FuelStationApp.Impl.Enums;

namespace FuelStationApp.WUI {
    public partial class TransactionForm : Form {

        public SqlConnection Connection { get; set; }
        public Guid CustomerId { get; set; }

        private BindingList<TransactionLine> TransactionLines = new BindingList<TransactionLine>();
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

        private void PopulateItemsDataGridView() {
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
            if (itemQuantity == 0) {
                return;
            }


            decimal itemPrice = decimal.Parse(Convert.ToString(gridViewListItems.GetFocusedRowCellValue("Price")));
            decimal itemCost = decimal.Parse(Convert.ToString(gridViewListItems.GetFocusedRowCellValue("Cost")));
            decimal value = itemQuantity * itemPrice;
            decimal cost = itemQuantity * itemCost;


            string itemType = Convert.ToString(gridViewListItems.GetFocusedRowCellValue("ItemType"));
            int type = Convert.ToInt32(Enum.Parse(typeof(ItemsTypeEnum), itemType, true));

            if (type == Convert.ToInt32(ItemsTypeEnum.Fuel)) {
                FuelQuantityCount += 1;
                if (value > 50) {
                    DiscountDone = true;
                }


            }

            if (FuelQuantityCount > 1) {
                MessageBox.Show("Please choose other product!");
                FuelQuantityCount--;
            }
            else {
                TransactionLine newTransactionLine = new TransactionLine(itemID, itemQuantity, itemPrice, value, itemCost, cost, itemType);
                TransactionLines.Add(newTransactionLine);

                gridTransactionLine.DataSource = TransactionLines;

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



        private void btnDelete_Click(object sender, EventArgs e) {

            Deletebutton();

        }

        private void Deletebutton() {


            DialogResult result = MessageBox.Show("Delete this record?", "Warning", MessageBoxButtons.OKCancel);



            if (result == DialogResult.OK) {

                //Find selected TransactionLine in order to remove it
                //var rowIndex = gridViewTransactionLine.GetFocusedDataSourceRowIndex();
                Guid itemId = new Guid(Convert.ToString(gridViewTransactionLine.GetFocusedRowCellValue("ItemID")));
                var selectedTransactionLine = TransactionLines.First(x => x.ItemID == (itemId));
                TransactionLines.Remove(selectedTransactionLine);

                //If fuel type decrease the fuel quantity counter
                //string itemType = Convert.ToString(gridViewTransactionLine.GetFocusedRowCellValue("ItemType"));
                int type = Convert.ToInt32(Enum.Parse(typeof(ItemsTypeEnum), selectedTransactionLine.ItemType, true));

                if (type == Convert.ToInt32(ItemsTypeEnum.Fuel)) {
                    FuelQuantityCount -= 1;
                    DiscountDone = false;

                }

                CalculateTotalValues();

            }

        }

        private void btnSave_Click(object sender, EventArgs e) {
            var transactionId = SaveTransaction();
            SaveTransactionLines(transactionId);
            TransactionLines.Clear();
        }



        public Guid SaveTransaction() {


            decimal totalValue = Convert.ToDecimal(ctrlTotalValue.EditValue);
            decimal totalCost = Convert.ToDecimal(ctrlTotalCost.EditValue);
            decimal discountValue = Convert.ToDecimal(ctrlDiscountValue.EditValue);


            SqlCommand cmd = new SqlCommand($@"
INSERT INTO TRANSACTIONS(ID, DATE, CUSTOMERID, DISCOUNTVALUE, TOTALVALUE, TOTALCOST)
OUTPUT Inserted.ID 
VALUES(NEWID(), GETDATE(),'{CustomerId}',{discountValue},{totalValue},{totalCost})", Connection);
            Connection.Open();
            //cmd.ExecuteNonQuery();

            Guid transactionId = (Guid)(cmd.ExecuteScalar());

            MessageBox.Show("Transaction Succesfully Added");
            Connection.Close();

            return transactionId;

        }


        public void SaveTransactionLines(Guid transactionId) {

            Connection.Open();
            foreach (TransactionLine line in TransactionLines) {

                SqlCommand cmd = new SqlCommand($@"
INSERT INTO TRANSACTIONLINE(ID, TRANSACTIONID, ITEMID, QUANTITY, ITEMPRICE, VALUE) 
VALUES(NEWID(), '{transactionId}','{line.ItemID}',{line.Quantity},{line.ItemPrice},{line.Value})", Connection);

                cmd.ExecuteNonQuery();

            }

            Connection.Close();



















        }
    }
}
