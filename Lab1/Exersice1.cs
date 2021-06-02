using System;

namespace TongHopLab
{
    public class Exercise1
    {
        public void ShowExercise1()
        {
            Console.WriteLine("Please enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter address");
            string address = Console.ReadLine();
            Console.WriteLine("Please enter phone");
            string phone = Console.ReadLine();
            Console.WriteLine($"Name : {name}\nAddress : {address}\nPhone : {phone}");
        }
    }
}