using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public class Employee: Person {
     
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public decimal Salary { get; set; }
      

        public Employee():base() {

        }
        public Employee(string name, string surname, decimal salary, string dateStart, string dateEnd):base() {

            Name = name;
            Surname = surname;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Salary = salary;
        }
    }
}

