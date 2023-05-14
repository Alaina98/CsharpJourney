namespace OOP_Method
{
    public class Program
    {
        public static void PritnLine(int cnt=4,string patren="%%")
        {
            for (int i = 0; i <=cnt; i++)
            {
                Console.Write(patren);

            }
            Console.WriteLine();

        }

        public static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void sum(int x, int y, out int s, out int m)
        {
            s = x + y;
            m = x * y;


        }



        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter the first Number");
            x= int.Parse(Console.ReadLine());
            PritnLine();

            Console.WriteLine("Enter the Second Number");
            y = int.Parse(Console.ReadLine());
            PritnLine(cnt:4);

            Console.WriteLine("Enter the Third Number");
            z = int.Parse(Console.ReadLine());
            PritnLine(patren:"&&");

            int a = 5, b = 7;
            swap(ref a, ref b);
            Console.WriteLine($"A is {a}");
            Console.WriteLine($"B is {b}");



            int w = 3, l = 5, c, g;
            sum(w, l, out c, out g);
            Console.WriteLine($" sum is {c}");
            Console.WriteLine($"multiplication is {g}");


            Calculator calc =new Calculator();
            int a1 = 10,b1 = 10;
            double c1= 2.2, d = 3.6;
            string e = "hi", f = " alaina";
            Console.WriteLine(calc.add(a1,b1));
            Console.WriteLine(calc.add(c1, d));
            Console.WriteLine(calc.add(e, f));



            Person p1 = new Person("Alaina","Aladwi","Nizwa",false,24,"FullStack");

            


        }
    }
}