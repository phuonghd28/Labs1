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

        private List<Atom> _list = new List<Atom>();

        public bool Accept()
        {
            while (true)
            {
                var atom = new Atom();
                Console.WriteLine("Enter atomic number: ");
                atom.Number = int.Parse(Console.ReadLine());
                if (atom.Number == 0)
                {
                    Console.WriteLine("No Sym Name Weight");
                    return false;
                }
                Console.WriteLine("Enter symbol: ");
                atom.Symbol = Console.ReadLine();
                Console.WriteLine("Enter full name: "); 
                atom.Fullname = Console.ReadLine();
                Console.WriteLine("Enter atomic weight: ");
                atom.Weight = float.Parse(Console.ReadLine());
                _list.Add(atom);
                Console.WriteLine("1. Continue");
                Console.WriteLine("2. Stop");
                var choice = int.Parse(Console.ReadLine());
                if (choice != 1)
                {
                    break;
                }
            }
            return true;
        }

        public void Display()
        {
            for (int i = 0; i < _list.Count; i++)
            {
                var atoms = _list[i];
                if (_list.Count > 10)
                {
                    Console.WriteLine("Sorry ! program only accepts information for up to 10 atomic elements");
                    return;
                }
                Console.WriteLine($"{atoms.Number} {atoms.Symbol} {atoms.Fullname} {atoms.Weight}");
                

            }
        }
    }
}