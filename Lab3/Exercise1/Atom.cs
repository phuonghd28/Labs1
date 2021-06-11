using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Lab3.Exercise1
{
    public class Atom
    {
        public int Number { get; set; }
        public string Symbol { get; set; }
        public string Fullname { get; set; }
        public float Weight { get; set; }
        

        public bool Accept()
        {
            try
            {
                Console.WriteLine("Enter atomic number: ");
                this.Number = int.Parse(Console.ReadLine());
                if (this.Number == 0)
                {
                    return false;
                }
                Console.WriteLine("Enter symbol: ");
                this.Symbol = Console.ReadLine();
                Console.WriteLine("Enter full name: "); 
                this.Fullname = Console.ReadLine();
                Console.WriteLine("Enter atomic weight: ");
                this.Weight = float.Parse(Console.ReadLine());
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return false;
        }

        public void Display()
        {
            Console.WriteLine($"{this.Number} {this.Symbol} {this.Fullname} {this.Weight}");
        }
        
    }
}
