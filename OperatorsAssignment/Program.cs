using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the two employee objects for comparison.

            Employee employee1 = new Employee() { Id = 10783, FirstName="Kunta", LastName="Kinte"};
            Employee employee2 = new Employee() { Id = 12783, FirstName="Binta", LastName="Juwara"};

            //Comparing the Employee Id's.
            bool comparison = employee1 == employee2;
            Console.WriteLine(comparison);
            Console.ReadLine();          
        }
    }
}
