using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    class Employee {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal Salary { get; set; }
      

        public Employee() {

        }
        public Employee(string name, string surname, decimal salary, DateTime datestart, DateTime dateend) {

            ID = Guid.NewGuid();
            Name = name;
            Surname = surname;
            DateStart = datestart;
            DateEnd = dateend;
            Salary = salary;
        }
    }
}

