using System;

namespace ReflectionCsharp
{
    public class Person
    {
        public int Id { get; set; }

        public void DoSomething(string id)
        {
           Console.WriteLine("Hello world");
        }
    }
}