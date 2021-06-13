using System;

namespace Lab4
{
    public abstract class Employee : Person
    {
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime DateHired { get; set; }
        public override string ToString()
        {
            return $"Name :{Name}, Phone :{Phone}, Email :{Email}, Department :{Department}, Salary :{Salary}, Date_hired : {DateHired}";
        }

        public abstract double CalculBonus();
        public abstract void CalculationVacation();
    }
}