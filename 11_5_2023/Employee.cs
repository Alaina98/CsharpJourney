using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_2023
{
    public class Employee
    {
        public const double TAX = 0.03;
        public string Fname;
        public string lname;
        public double wage;
        public double logdHours;


        public void Greeting()
        {
            Console.WriteLine($"Hello {Fname} {lname}");
        }
        public  int addone(int x)
        {
            return x + 1;

        }
    }
}
