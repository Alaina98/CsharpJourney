using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Method
{
    internal class Person
    {
        public string fName;
        public string lName;
        public string address;
        public bool isMarried;
        public int age;
        public string job;
        public Person(string Name1,string Name2,string addr,bool maried,int age,string job)
        {
            this.fName = Name1;
            this.lName = Name2;
            this.address = addr;
            this.isMarried = maried;
            this.age = age;
            this.job = job;


        }
        
    }
    
}
