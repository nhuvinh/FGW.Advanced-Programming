using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrange Employees, Organization and add employees
            var developer = new Developer("John", 5000);
            var designer = new Designer("Arya", 5000);

            var organization = new Organization();
            organization.AddEmployee(developer);
            organization.AddEmployee(designer);

            Console.WriteLine($"Net Salary of Employees in Organization is {organization.GetNetSalaries():c}");
            //Ouptut: Net Salary of Employees in Organization is $10000.00
            Console.ReadKey();
        }
    }
}
