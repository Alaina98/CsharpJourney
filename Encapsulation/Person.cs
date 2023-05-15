using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Person
    {
        private string fname;
        private int age;
        private string lname;
        private decimal salary;

        ////Get , Set
        public void SetFname(string fname)
        {
            this.fname = fname;
            
        }
        public string GetFname()
        { 
            return fname;
        }
        public void Setlname(string lname)
        {
            this.lname = lname;

        }
        public string Getlname()
        {
            return lname;
        }

        public void Setage(int age)
        {
            this.age =2023-age;


        }
        public int Getage()
        {
            return age;
        }

        public void Setsalary(decimal salary)
        {
            this.salary = salary;

        }
        public decimal Getsalary()
        {
            return salary;
        }

        public string PrintInfo()
        {
            return $"Your Name is {fname} {lname} and your age is : {age} your Salary is : {salary}";

        }
        public int MyProperty { get; set; }

    }
}
