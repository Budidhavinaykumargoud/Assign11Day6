using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2MethParametersDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OurClass Hr = new OurClass();
            Hr.display(workingHours: 8, workingdays: 30);
            OurClass Admin = new OurClass();
            Admin.display(workingHours: 8, workingdays: 30, projecthandel: 3);
            OurClass softwareDeveloper = new OurClass();
            softwareDeveloper.display(workingHours: 8, workingdays: 30, projecthandel: 4, extra: 5);
            Console.ReadKey();
        }
    }
}
