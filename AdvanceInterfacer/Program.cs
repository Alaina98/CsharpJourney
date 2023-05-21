namespace AdvanceInterfacer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cashier chas1 = new Cashier(new Cash(400));
            chas1.checkout();
            Cashier chas2 = new Cashier(new Visa(200));
            chas1.checkout();
            Cashier chas3 = new Cashier(new MasterCard(30.5m));
            chas1.checkout();
        }
    }


}
interface Ipayment
{
    void pay();
    
}

class Cashier
{
    public  Ipayment payment;
    public Cashier(Ipayment payment)
    {
        this.payment = payment;
    }
    public void checkout()
    {
        payment.pay();
    }
}

class Cash: Ipayment
{
    public decimal amount { get; set; }
    public Cash(decimal amount)
    {
        this.amount = amount;
    }

    public void pay()
    {
        Console.WriteLine($"The amount you pay is:{amount} om By Cash");
    }
}
class MasterCard: Ipayment
{
    public decimal amount { get; set; }
    public MasterCard(decimal amount)
    {
        this.amount = amount;
    }

    public void pay()
    {
        Console.WriteLine($"The amount you pay is:{amount} om By Master Card");
    }
}
class Visa:Ipayment
{
    public decimal amount { get; set; }
    public Visa(decimal amount)
    {
        this.amount = amount;
    }

    public void pay()
    {
        Console.WriteLine($"The amount you pay is:{amount} om By VISA");
    }
}

