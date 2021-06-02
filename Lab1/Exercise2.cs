using System;

namespace TongHopLab
{
    public class Exercise2
    {
        public void ShowExercise2()
        {
            Console.WriteLine("Enter number 1");
            var number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            var number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            var number3 = int.Parse(Console.ReadLine());
            var maxValue = number1;
            if (maxValue < number2)
            {
                maxValue = number2;
            }
            if (maxValue < number3)
            {
                maxValue = number3;
            }
            Console.WriteLine($"Largest number in 3 digits : {maxValue}");
        }
    }
}