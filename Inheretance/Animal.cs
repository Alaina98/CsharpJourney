using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretance
{
    abstract public class Animal
    {
        public string name;
        int age;
        public virtual void move()
        {
            Console.WriteLine("moving");
        }
        //Abstract+body of them will be in the child
        public abstract void makeSound();
    }

    public class Cat:Animal {
        public string gender;

        public override void makeSound()
        {
            Console.WriteLine("Mewoooo");
        }

        public override void move() 
        { 
            //give the move from animal
            base.move();
            Console.WriteLine("Four legs");

        }

        public void sound()
        {
            Console.WriteLine("Sound");
        }

        public override string ToString()
        {
            return $"my name is {this.name}";
        }

    }

    public class Dog:Animal
    {
        string cateqory;

        public override void makeSound()
        {
            Console.WriteLine("HOW HOW");
        }

        public void sound() { Console.WriteLine("Sound"); }
    }
     sealed public class Eagle : Animal
    {
        string gender;
        public void fly()
        {
            Console.WriteLine("flying");
        }

        public override void makeSound()
        {
            Console.WriteLine("WEEEEEE");
        }
    }


}
