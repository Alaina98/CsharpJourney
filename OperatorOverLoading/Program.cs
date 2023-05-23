using System.Data.SqlTypes;

namespace OperatorOverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(25);
            Money m2 = new Money(5);
            Money m3=m1 + m2;
            Money m4 = m1 *m2;
            Money m5 = m1 / m2;
            Console.WriteLine($"Sum : {m3.amount}");
            Console.WriteLine($"Multiplucation :{m4.amount}");
            Console.WriteLine($"Divinition {m5.amount}");
        }
    }

    
    public class Money
    {
        public double amount;
        public Money(double amount)
        {
            this.amount = amount;
        }
       


        public static Money operator +(Money m1, Money m2)
        {
            double value=m1.amount+m2.amount;
            return new Money(value);
           

        }
        public static Money operator *(Money m1, Money m2)
        {
            double value = m1.amount * m2.amount;
            return new Money(value);


        }
        public static Money operator /(Money m1, Money m2)
        {
            double value = m1.amount / m2.amount;
            return new Money(value);


        }


    }
}




