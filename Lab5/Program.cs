using System;
using Lab5.Exercise1;
using Lab5.Exercise2;

namespace Lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Ex1.ShowMenu();*/ // Ex1
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter salary");
            var salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter bonus");
            var bonus = double.Parse(Console.ReadLine());
            var seniorLecture = new SeniorLecture
            {
                Name = name,
                Salary = salary,
                Bonus = bonus
            };
            try
            {
                CheckAmount(seniorLecture);
            }
            catch (AmountException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public static void CheckAmount(SeniorLecture seniorLecture)
        {
            if (seniorLecture.Salary < 60000)
            {
                throw new AmountException($"Minimum salary of lecturer {seniorLecture.Name} must be from 60000");
            }
            else if(seniorLecture.Bonus > 10000)
            {
                throw new AmountException($"Maximum lecturer {seniorLecture.Name} bonus 10000");
            }
            else
            {
                Console.WriteLine("Done");
            }
            
        }
    }
}