using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
   public class Customer: Person {

     
        public string CardNumber { get; set; }

        public Customer() { }

        public Customer(string name, string surname, string cardnumber) :base() {
            Name = name;
            Surname = surname;
            CardNumber = cardnumber;
        }
    }
}
