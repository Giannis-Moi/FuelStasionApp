using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
   public class Customer: Person {

     
        public int CardNumber { get; set; }

        public Customer() { }

        public Customer(int cardnumber) :base() {

            CardNumber = cardnumber;
        }
    }
}
