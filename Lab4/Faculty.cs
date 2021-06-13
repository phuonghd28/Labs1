using System;

namespace Lab4
{
    public class Faculty : Employee
    {
        public string OfficeHours { get; set; }
        public int Rank { get; set; } // 1. Senior Lecturer 0. Junior Lecturer

        public override string ToString()
        {
            return
                $"Name :{Name}, Phone :{Phone}, Email :{Email}, Department :{Department}, Salary :{Salary}, Date_hired :{DateHired}, Office_hour :{OfficeHours}, Rank: {Rank}";
        }

        public override double CalculBonus()
        {
            var sum = Salary * 0.06;
            return sum;
        }

        public override void CalculationVacation()
        {
            Console.WriteLine("Enter year of dedication");
            var year = int.Parse(Console.ReadLine());
            if (year >= 3 && Rank == 1)
            {
                Console.WriteLine("6 weeks vacation");

            }else if (year >= 3)
            {
                Console.WriteLine("5 weeks vacation");
            }
            else
            {
                Console.WriteLine("4 weeks vacation");
            }
        }
    }
}