using System;

namespace Lab6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 6x^2 + 11x - 35 = 0
                SolveQuadratic(6, 11, -35);
            
                // 5x^2 + 6x + 1 = 0
                SolveQuadratic(5, 6, 1);
            
                // 2x^2 + 4x + 2 = 0
                SolveQuadratic(2, 4, 2);
            
                // 5x^2 + 2x + 1 = 0
                SolveQuadratic(5, 2, 1);
            }

            public static void SolveQuadratic(double a, double b, double c)

            {
                double delta = b * b - 4 * a * c;
                double x1, x2;
                if (delta > 0)
                {
                    x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - System.Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Two real solutions: {x1} or  {x2}");
                }
                else if (delta < 0)
                {
                    Console.WriteLine("No real solution.");
                }
                else
                {
                    x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"One real solution: {x1}");
                }
            }
        }
}
