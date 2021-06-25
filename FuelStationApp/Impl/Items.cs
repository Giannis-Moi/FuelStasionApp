using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStationApp.Impl.Enums;

namespace FuelStationApp.Impl {
    class Items {

        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemsTypeEnum ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        public Items() {

        }
        public Items(string code, string description, ItemsTypeEnum itemtype, decimal price, decimal cost) {


            ID = Guid.NewGuid();
            Code = code;
            Description = description;
            ItemType = itemtype;
            Price = price;
            Cost = cost;

        }
    }
}
