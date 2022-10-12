using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager("man1", 23000, 40000);
            m1.CalculateSalary();
            Console.WriteLine(m1); ;

            president p1 = new president("president1", 23000, 34444,5466);
            p1.CalculateSalary();
            Console.WriteLine(p1);

            SalesManager sm1 = new SalesManager("vikas", 34000, 349, 879);
            sm1.CalculateSalary();
            Console.WriteLine(sm1);
        }
    }
}
