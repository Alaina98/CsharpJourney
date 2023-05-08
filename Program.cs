namespace Topic1_8_5_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {   //1. Consoling our DATA
            /*use console to run code , the console as will as the cmd
            Console give directely with all functions from Microsoft*/
            Console.WriteLine("Hello my name is Alaina");

            //2.What is Comments: It is a line or many lines that write in program
            /*to help the programmer to know the code that writen by other programmer
            or it is as a help for the programmer to get information about what the code mean */

            //3. CTS supports two different kinds of types:1.Value Types:have a specific size
            int age = 24;

            //2.Reference Types:not have a secific size
            string fname = "Alaina Dawood";

            //3.Declaration (int declaration and assignment
            int year_of_birth= 1998;
            Console.WriteLine(year_of_birth);

            //4.Cts Under the Hood 
            Object obj=new object();

            Console.WriteLine(fname.GetType());
            Console.WriteLine(fname.GetHashCode());
            Console.WriteLine(age.GetHashCode());

            //5.Range illustrated in code : to knoe the min and the maximum size of data type
            Console.WriteLine($"int:[{int.MinValue} {int.MaxValue}]");

            //6.String Concatenation
            String f_name = "Alaina Dawood";
            String lnmae = "Aladwi";
            String hoby = "Programming";
            Console.WriteLine($"My Name is {f_name}{lnmae} and I born in {year_of_birth} and I like {hoby}");

            //7. Var vs Dynamic 
            /* when the user use var in declaration can not change it but when use dynamic can not be
             * change , we use var and dynamic when we try to declare varible without set 
             * data type
             */
            var country = "OMAN";
           // country = 2;
            dynamic x = 12;
            x = 24;
            Console.WriteLine(x);
            Console.WriteLine(country);

            //8.Var Keyword
            var salary = 100d;


        }
    }
}