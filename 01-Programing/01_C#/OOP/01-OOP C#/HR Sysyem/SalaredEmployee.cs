using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Sysyem
{
    internal class SalaredEmployee : Employee
    {
        public decimal BasicSalary { get; set; }
        public decimal Transportation { get; set; }
        public decimal Housing { get; set; }

        public override decimal GetSalary()
        {
            return BasicSalary + Transportation + Housing ;
        }

    }
}
