namespace Employee_Delegante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[]
             {
                new Employee {name="Alaina", age=24, salay=2300m,total_salary=12000m},
                new Employee {name="Shrooq", age=25, salay=3500m,total_salary=897000m},
                new Employee {name="Arwa", age=26, salay=4500m,total_salary=9000098m}
             };
            Report report = new Report();
            report.ProcessEmployee(employee, "Total sales more than 60k: ", (emp) => emp.total_salary >= 60000m);
            report.ProcessEmployee(employee, "Total sales between 30k and 60k:", (emp) => emp.total_salary >= 30000m && emp.total_salary <= 60000m);
            report.ProcessEmployee(employee, "Total sales less than 30k:", (emp) => emp.total_salary < 30000m);
            report.ProcessEmployee(employee, "Employee Age less than 25 ", (emp) => emp.age < 25);
            report.ProcessEmployee(employee, "Employee Age More than 25 ", (emp) => emp.age >=25);
            report.ProcessEmployee(employee, "Employee Age More than 40 ", (emp) => emp.age >=40);



        }
    }
}