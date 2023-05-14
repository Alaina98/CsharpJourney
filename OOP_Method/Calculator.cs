using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Method
{
    internal class Calculator
    {
        public int add(int x, int y)=> x + y;
        
        public double add (double y, double x)=> x + y;
        
        public string add (string y, string x)=> x + y;
        public string isEven(int a) => (a % 2 == 0) ? "Even" : "Odd";

    }
}
