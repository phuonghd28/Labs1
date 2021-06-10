using System;

namespace TongHopLab
{
    public class Exersice5
    {
        public void showExersice5()
        {
            var result = 1;
            for (int i = 1; i < 20; i++)
            {
                result *= i;
                Console.WriteLine($"factorials {i} = {result}");
            }
            

            
        }
    }
}