using System.Globalization;
using Worker_.Entities.Enums;
using Worker_.Entities;

namespace Worker_
{
    class Program
    {
        static void Main (string[] args)
        {
            System.Console.WriteLine("Enter the department name: ");
            string departmentName = Console.ReadLine();
            System.Console.WriteLine("Enter worker data: ");
            Console.Write("name: ");
            string name = Console.ReadLine();
            System.Console.Write("Level (Junior/Pleno/Senior) ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            System.Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Department dept = new Department(departmentName);   
            Worker worker = new Worker(name, level, salary, dept); 
            System.Console.WriteLine();
            System.Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine("enter #" + i + " contract  data: ");
                Console.Write("Date (MM/DD/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration(hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, value, hours);
                worker.AddContract(contract);
            }
            System.Console.WriteLine();
            Console.Write("Enter the Month and year to calculate income (MM/YYYY)");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));
            System.Console.WriteLine();
            Console.WriteLine("name: " + worker.Name);
            Console.WriteLine("department: " + worker.Department.Name);
            Console.WriteLine("Income " + monthAndYear + ": " + worker.Income(year, month).ToString("F2"), CultureInfo.InvariantCulture );
        }
    }
}