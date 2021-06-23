using System;
using System.Collections.Generic;

namespace GenericType
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GenericAnimal<Dog> animal = new GenericAnimal<Dog>();
            animal.Add(new Dog(){Id = 1, Name = "Corgi", Dob = "2020"});
            animal.Add(new Dog(){Id = 2, Name = "Corgi", Dob = "2021"});
            animal.Add(new Dog(){Id = 3, Name = "Corgi", Dob = "2022"});
            animal.Remove(2);
            animal.ShowInformation();
        }
    }

    public class GenericAnimal<T> where T : Animal
    {
        private List<T> _animals = new List<T>();

        public void Add(T obj)
        {
            _animals.Add(obj);
        }

        public void Remove(int index)
        {
            _animals.RemoveAt(index);
        }

        public void ShowInformation()
        {
            foreach (var animal in _animals)
            {
                Console.WriteLine(animal.ToString());
                animal.Speak();
            }
        }
    }
}