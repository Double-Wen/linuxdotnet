using System;

namespace ConsoleApp8
{
    internal class Person
    {
        public string name;
        protected int age;

        public Person()
        {
            this.name = "Unknown";
            this.age = -1;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void print()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Age: " + this.age);
        }
    }

    class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("wenwen", 12);
            p1.name = "liu";
            Cat cat = new Cat {Name = "Herllo", Age = 13};
        }
    }
}