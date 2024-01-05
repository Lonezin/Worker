using Worker_.Entities;

namespace Worker_
{
    class Employee
    {
        static void Main (string[] args)
        {
            System.Console.WriteLine("enter the department name: ");
            string departmentName = Console.ReadLine();
            System.Console.WriteLine("enter worker data: ");
            string name = Console.ReadLine();
            System.Console.Write("Level (Junior/Mid Level/Senior)");
            string level = Console.ReadLine();
            System.Console.Write("base salary: ");
            double salary = double.Parse(Console.ReadLine());
            Department dept = new Department(departmentName);    
            Worker worker = new Worker (name, level, salary, departmentName);  
        }
    }
}