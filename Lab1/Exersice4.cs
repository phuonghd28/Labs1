using System;

namespace TongHopLab
{
    public class Exersice4
    {
        public void ShowExersice4()
        {
            Console.WriteLine("Enter number");
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                int result = n * i;
                Console.WriteLine($"{n} x {i} = {result}");
            }
        }
    }
}