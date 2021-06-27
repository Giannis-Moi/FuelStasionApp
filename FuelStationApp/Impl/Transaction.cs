using FuelStationApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public class Transaction: Entity{
        public string Date { get; set; }
        public Guid CustomerID { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }
        public List<TransactionLine> TransactionLine { get; set; }
    }
}
