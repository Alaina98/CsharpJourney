namespace _11_5_2023
{

  
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee emp=new Employee();
            Console.WriteLine("Enter employee numbers");
            int employeeNo = Convert.ToInt32(Console.ReadLine());
            int[] empNp = new int[employeeNo];

            foreach (int i in empNp)
            {


                //emp_num [] emps= new emps(ReadLine());
                //for (int i = 0; i < emps.Length; i++)

                Console.WriteLine("Enter your first name: ");
                emp.Fname = Console.ReadLine();
                Console.WriteLine("Enter your last name: ");
                emp.lname = Console.ReadLine();
                Console.WriteLine("Enter your last wage:");
                emp.wage = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter your last logged hours:");
                emp.logdHours =double.Parse( Console.ReadLine());
                double total_salary = emp.wage * emp.logdHours;
                double salary = total_salary - Employee.TAX;
                Console.WriteLine($"Hello {emp.Fname} {emp.lname} , " +
                    $"your Salary is {salary}");
                emp.Greeting();
                //string gt = emp.Greeting();
                //cw(gt);
                // when the type of class is string
            }
            int y = 18;
            emp.addone(y);
            Console.WriteLine(y);




        }
    }
}