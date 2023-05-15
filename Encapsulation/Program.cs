namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1= new Person();
            p1.SetFname("Alaina");
            p1.Setlname("Aladwi");
            p1.Setage(1998);
            p1.Setsalary(400);
            Console.WriteLine(p1.PrintInfo());


            Bank_Accounr B1= new Bank_Accounr();
            B1.SetAccount_Number(1234555);
            B1.Set_Balance(1000);
            Console.WriteLine($"Your Balance is {B1.deposite(100)}");
            B1.withDraw(50);


        }
    }
}