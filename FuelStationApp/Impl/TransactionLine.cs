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

        public TransactionLine() {

        }

        public TransactionLine(Guid transactionID, Guid itemID, int quantity, decimal itemPrice, decimal value) : base() {

            TransactionID = transactionID;
            ItemID = itemID;
            Quantity = quantity;
            ItemPrice = itemPrice;
            Value = value;

        }
    }
}
