using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2MethParametersDay6
{
    internal class OurClass
    {
        public void display(int workingHours = 8, int workingdays = 8, int projecthandel = 0, int extra = 0)
        {
            int result = workingHours * workingdays * 100 + projecthandel * 3000 + extra * 2000;
            Console.WriteLine("Monthly Salary of employee: \t" + result);
        }
    }
}
