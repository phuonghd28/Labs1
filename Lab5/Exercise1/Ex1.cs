using System;
using Order;

namespace Lab5.Exercise1
{
    public class Ex1
    {
        public static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Grocery");
                Console.WriteLine("2. Bakery");
                Console.WriteLine("0. exist");
                var choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter customer name :");
                    var name = Console.ReadLine();
                    Customer.Customer customer = new Customer.Customer();
                    var nameResult = customer.AcceptsCustomerName(name);
                    Grocery grocery = new Grocery();
                    Console.WriteLine(nameResult + " " + grocery.ChoiceGrocery());
                }else if (choice == 2)
                {
                    Console.WriteLine("Enter customer name :");
                    var name = Console.ReadLine();
                    Customer.Customer customer = new Customer.Customer();
                    var nameResult = customer.AcceptsCustomerName(name);
                    Bakery bakery = new Bakery();
                    Console.WriteLine(nameResult + " " + bakery.ChoiceBakery());
                }
                else if (choice == 0)
                {
                    break;
                }
                else
                {
                        Console.WriteLine("Enter choice (0-2)");
                }
            }
        }
    }
}
namespace Customer
{
    public class Customer
    {
        public string AcceptsCustomerName(string customerName)
        {
            return $"Customer : {customerName}";
        }
    }
}
namespace Order
{
    
    public class Grocery
    {
        public string ChoiceGrocery()
        {
            return "accept Grocery";
        }
    }

    public class Bakery
    {
        public string ChoiceBakery()
        {
            return "accept Bakery";
        }
    }
    
}