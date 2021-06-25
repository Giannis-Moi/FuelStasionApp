using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    class Customer {

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CardNumber { get; set; }

        public Customer() { }
        public Customer(string name, string surname, int cardnumber) {

            ID = Guid.NewGuid();
            Name = name;
            Surname = surname;
            CardNumber = cardnumber;
        }
    }
}
