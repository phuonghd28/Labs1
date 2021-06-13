using System;

namespace Lab4
{
    public class Staff : Employee
    
    {
        public string Title { get; set; }
        public override string ToString()
        {
            return $"Name :{Name}, Phone :{Phone}, Email :{Email}, Department :{Department}, Salary :{Salary}, Date_hired : {DateHired}, Title: {Title}";
        }

        public override double CalculBonus()
        {
            var sum = Salary * 0.05 + 1000;
            return sum;
        }

        public override void CalculationVacation()
        {
            Console.WriteLine("Enter year of dedication");
            var year = int.Parse(Console.ReadLine());
            if (year >= 5)
            {
                Console.WriteLine("4 weeks vacation");
            }
            else
            {
                Console.WriteLine("3 weeks vacation");
            }
        }
    }
}