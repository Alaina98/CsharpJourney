namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           phoneBook b1=new phoneBook(2);
            b1[1,"a"]="123";
            b1[2, "b"] = "2344";
            Console.WriteLine(b1.getValue("b"));

        }
    }
}