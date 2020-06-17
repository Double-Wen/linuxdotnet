using System;

namespace ConsoleApp6
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
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("asd", 12);
            p1.print();
            p2.print();
        }
    }
}