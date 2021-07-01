using FuelStationApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
   public class TransactionLine: Entity {

        public Guid TransactionID { get; set; }
        public Guid ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal Value { get; set; }
        public decimal Cost { get; set; }
        public string ItemType { get; set; }
        public decimal ItemCost { get; set; }

        public TransactionLine() {

        }

        public TransactionLine( Guid itemID, int quantity, decimal itemPrice, decimal value, decimal itemCost, decimal cost, string itemType) : base() {

            
            ItemID = itemID;
            Quantity = quantity;
            ItemPrice = itemPrice;
            Value = value;
            Cost = cost;
            ItemType = itemType;
            ItemCost = itemCost;

        }
    }
}
