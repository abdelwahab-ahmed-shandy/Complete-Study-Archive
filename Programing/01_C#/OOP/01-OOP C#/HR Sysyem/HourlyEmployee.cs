using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Sysyem
{
    internal class HourlyEmployee :Employee
    {
        public decimal HourRate { get; set; }
        public decimal TotalWorkHours { get; set; }

        public override decimal GetSalary()
        {
            return HourRate * TotalWorkHours;
        }
    }
}
