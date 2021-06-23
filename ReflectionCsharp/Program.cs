using System;
using System.Runtime.InteropServices;

namespace ReflectionCsharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person();
            var type = person.GetType();
            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Namespace);
            foreach (var property in type.GetProperties())
            {
                Console.WriteLine(property);
            }

            foreach (var method in type.GetMethods())
            {
                Console.WriteLine(method.Name);
                foreach (var parameter in method.GetParameters())
                {
                    Console.WriteLine(parameter.Name);
                    Console.WriteLine(parameter.ParameterType);
                }
            }

            foreach (var constructor in type.GetConstructors())
            {
                Console.WriteLine(constructor);
               
            }
            

        }
    }
}