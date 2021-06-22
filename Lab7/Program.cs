using System;

namespace Lab7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var employeeManager = new EmployeeManager();
            while (true)
            {
                Console.WriteLine("Employee Manager");
                Console.WriteLine("------------------");
                Console.WriteLine("1. Creat employee");
                Console.WriteLine("2. Show employee");
                Console.WriteLine("3. Update employee");
                Console.WriteLine("4. Delete employee");
                Console.WriteLine("5. Exit");
                Console.WriteLine("-------------------");
                Console.WriteLine("Enter your choice (1 - 5) : ");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        employeeManager.Create();
                        break;
                    case 2:
                        employeeManager.Display();
                        break;
                    case 3:
                        employeeManager.Update();
                        break;
                    case 4:
                        employeeManager.Delete();
                        break;
                }

                if (choice == 5)
                {
                    break;
                }
            }
        }
    }
}