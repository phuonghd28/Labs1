using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var temperatures = new List<int>();
            temperatures.Add(40);
            temperatures.Add(45);
            temperatures.Add(25);
            temperatures.Add(20);
            var count = 0;
            foreach (var temperature in temperatures)
            {
                if (temperature >= 25)
                {
                    count++;
                }
            }

            Console.WriteLine("Number of temperatures that equal or exceed 25 degrees are: " + count);
            Console.WriteLine("Number of temperatures that equal or exceed 30 degrees are: " +
                              Ex1.GreaterCount(temperatures, 30));
            
            double[] temperatures1 = new double[100];
            temperatures1[0] = 20;
            temperatures1[1] = 23;
            temperatures1[2] = 30;
            Console.WriteLine(Ex2.GreaterCount(temperatures1, 25));
        }

        
        
        
    }
}