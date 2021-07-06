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
using static FuelStationApp.Impl.Enums;

namespace FuelStationApp.WUI {
    public partial class ItemForm : Form {
        public SqlConnection Connection { get; set; }
        public ItemForm() {
            InitializeComponent();
        }

        private void ItemForm_Load(object sender, EventArgs e) {
          //  List<ItemsTypeEnum> enumList = Enum.GetValues(typeof(ItemsTypeEnum)).Cast<Pe>().ToList();
            foreach (ItemsTypeEnum type in Enum.GetValues(typeof(ItemsTypeEnum))) {
                comboBoxEdit1.Properties.Items.Add(type);
            }

        }
        private void ResetFields() {
            ctrlCode.EditValue = String.Empty;
            ctrlDescription.EditValue = String.Empty;
            comboBoxEdit1.Text = String.Empty;
            ctrlPrice.Text = String.Empty;
            ctrlCost.Text = String.Empty;
        }

        



        public void InsertItem() {


            string code = Convert.ToString(ctrlCode.EditValue);
            string description = Convert.ToString(ctrlDescription.EditValue);
            //string itemType = Convert.ToString(ctrlItemType.EditValue);
            //Category = (ItemsTypeEnum)Enum.Parse(typeof(ItemsTypeEnum), comboBoxEdit1.Text);
            string itemType = Convert.ToString(comboBoxEdit1.EditValue);
            decimal price = Convert.ToDecimal(ctrlPrice.Text);
            decimal cost = Convert.ToDecimal(ctrlCost.Text);
            int type = Convert.ToInt32(Enum.Parse(typeof(ItemsTypeEnum), itemType, true));

            Items newItem = new Items(code, description, itemType, price, cost);


            if (!string.IsNullOrWhiteSpace(code) && !string.IsNullOrWhiteSpace(description) && !string.IsNullOrWhiteSpace(itemType)
                &&
                  decimal.TryParse(Convert.ToString(ctrlPrice.EditValue), out price) && price > 0
                  && decimal.TryParse(Convert.ToString(ctrlPrice.EditValue), out cost) && cost > 0) {


                SqlCommand cmd = new SqlCommand("INSERT INTO Items (ID, Code, Description, ItemType, Price ,Cost) VALUES (NEWID(), '" + newItem.Code + "', '" + newItem.Description + "', " + type + ", '" + newItem.Price+ "', '" + newItem.Cost + "')", Connection);
                Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Items Succesfully Added");
                Connection.Close();
                PopulateDataGridView();
            }
            else {

                MessageBox.Show("Please fill all fields with valid values!");
            }
        }
         void PopulateDataGridView() {
            try {
                Connection.Open();
                string MyQuery = "SELECT * FROM Items";
                SqlDataAdapter data = new SqlDataAdapter(MyQuery, Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(data);
                var dataset = new DataSet();
                data.Fill(dataset);
                gridItems.DataSource = dataset.Tables[0];
                Connection.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertValues_Click(object sender, EventArgs e) {
            InsertItem();
        }

        private void btndelete_Click(object sender, EventArgs e) {
            Deletebutton();

            }


            private void Deletebutton() {
            DialogResult result = MessageBox.Show("Delete this record?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {

                SqlCommand cmd = new SqlCommand(string.Format(Resources.DeleteItem, Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"))), Connection);
                Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Record Succesfully Deleted!");
                Connection.Close();
                PopulateDataGridView();
                ResetFields();
            }
        }
        public void UpdateRecord() {

            

            Guid id = Guid.Parse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID")));
            string code = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Code"));
            string description = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Description"));
            string itemType = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ItemType"));
            int type = Convert.ToInt32(Enum.Parse(typeof(ItemsTypeEnum), itemType, true));


            String.Format("{0:0.00}", 123.4);

            decimal price;
            decimal cost;
            if (!string.IsNullOrWhiteSpace(code) && !string.IsNullOrWhiteSpace(description) && !string.IsNullOrWhiteSpace(itemType)
                &&
                  decimal.TryParse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Price")), out price) && price > 0
                  && decimal.TryParse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Cost")), out cost) && cost > 0) {

                SqlCommand cmd = new SqlCommand(string.Format(Resources.UpdateItem, code, description, type, price, cost, id ), Connection);
                Connection.Open();
                cmd.ExecuteNonQuery();
                Connection.Close();
                MessageBox.Show("Record Succesfully Updated!");
            }
            else {

                MessageBox.Show("No valid values!");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e) {
            UpdateRecord();
            PopulateDataGridView();
            ResetFields();
        }

        private void btnView_Click(object sender, EventArgs e) {
            PopulateDataGridView();
            ResetFields();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
          
        }
    }
}
