using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Lab7
{
    public class EmployeeManager
    {
        private Dictionary<string,Employee> _list = new Dictionary<string, Employee>();
        public void Create()
        {
            Console.WriteLine("Enter id :");
            var id = Console.ReadLine();
            Console.WriteLine("Enter your name :");
            var name = Console.ReadLine();
            Console.WriteLine("Enter age :");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter salary :");
            var salary = double.Parse(Console.ReadLine());
            _list.Add(id,new Employee()
            {
                Name = name,
                Age = age,
                Salary = salary
            });
        }

        public void FindAll()
        {
            Console.WriteLine("--------------List Employee--------------");
            foreach (var list in _list)
            {
                Console.WriteLine($"Id: {list.Key} , {list.Value}");
            }

            Console.WriteLine("------------------------------------------");
        }

        public void Update()
        {
            Console.WriteLine("Enter id");
            var id = Console.ReadLine();
            if (_list.ContainsKey(id))
            {
                Console.WriteLine("Enter new name");
                var name = Console.ReadLine();
                Console.WriteLine("Enter new age");
                var age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new salary");
                var salary = double.Parse(Console.ReadLine());
                _list[id].Name = name;
                _list[id].Age = age;
                _list[id].Salary = salary;
            }
            else
            {
                Console.WriteLine("Employee does not exist");
            }

        }

        public void Delete()
        {
            Console.WriteLine("Enter id");
            var id = Console.ReadLine();
            if (_list.ContainsKey(id))
            {
                _list.Remove(id);
            }
            else
            {
                Console.WriteLine("Employee does not exist");
            }
        }
    }
}