using System;

namespace TongHopLab
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var ex1 = new Exercise1();
            var ex2 = new Exercise2();
            var ex3 = new Exersice3();
            var ex4 = new Exersice4();
            var ex5 = new Exersice5();
            while (true)
            {
                Console.WriteLine("------Lab1--------------");
                Console.WriteLine("1. Exersice 1");
                Console.WriteLine("2. Exersice 2");
                Console.WriteLine("3. Exersice 3");
                Console.WriteLine("4. Exersice 4");
                Console.WriteLine("5. Exersice 5");
                Console.WriteLine("6. Exit");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ex1.ShowExercise1();
                        break;
                    case 2:
                        ex2.ShowExercise2();
                        break;
                    case 3:
                        ex3.ShowExersice3();
                        break;
                    case 4:
                        ex4.ShowExersice4();
                        break;
                    case 5:
                        ex5.showExersice5();
                        break;
                }

                if (choice == 6)
                {
                    break;
                }
            }
        }
    }
}