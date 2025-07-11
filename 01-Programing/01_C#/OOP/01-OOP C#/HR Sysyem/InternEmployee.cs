using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Sysyem
{
    internal class InternEmployee : Employee
    {
        public override decimal GetSalary()
        {
            return 2000;
        }
    }
}
