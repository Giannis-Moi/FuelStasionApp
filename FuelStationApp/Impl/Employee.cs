using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public class Employee: Person {
     
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal Salary { get; set; }
      

        public Employee():base() {

        }
        public Employee(decimal salary, DateTime dateStart, DateTime dateEnd):base() {

  
            DateStart = dateStart;
            DateEnd = dateEnd;
            Salary = salary;
        }
    }
}

