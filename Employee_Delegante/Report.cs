using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Delegante
{
    internal class Report
    {
        public delegate bool isValid(Employee emp);
        public void ProcessEmployee(Employee[] emp, string title, isValid con)
        {
            Console.WriteLine(title);
            //Console.WriteLine(title2);
            foreach (Employee e in emp)
            {
                if (con(e))
                {
                    Console.WriteLine($"{e.name} | {e.age} | {e.salay} | {e.total_salary}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
