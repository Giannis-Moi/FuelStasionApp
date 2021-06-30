using FuelStationApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStationApp.Impl.Enums;

namespace FuelStationApp.Impl {
   public class Items: Entity {
        private string itemType;

        public string Code { get; set; }
        public string Description { get; set; }
        public ItemsTypeEnum ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        public Items(string code, string description) {

        }
        public Items(string code, string description, ItemsTypeEnum itemtype, decimal price, decimal cost) : base() {

            Code = code;
            Description = description;
            ItemType = itemtype;
            Price = price;
            Cost = cost;

        }

        public Items(string code, string description, string itemType, decimal price, decimal cost) {
            Code = code;
            Description = description;
            this.itemType = itemType;
            Price = price;
            Cost = cost;
        }
    }
}
