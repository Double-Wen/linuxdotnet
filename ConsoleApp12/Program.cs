using System;

namespace ConsoleApp12
{
    class Person
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

        public void Print()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Age: " + this.age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("zhangsan", 25);
            Person p2 = new Person("lisi", 18);
            if (p1 == p2)
            {
                Console.WriteLine("p1 is equal to p2");
            }
            else
            {
                Console.WriteLine("p1 is not equal to p2");
            }

            p1 = p2;
            
            if (p1 == p2)
            {
                Console.WriteLine("p1 is equal to p2");
            }
            else
            {
                Console.WriteLine("p1 is not equal to p2");
            }

            p2.name = "Hello";
            if (p1 == p2)
            {
                Console.WriteLine("p1 is equal to p2");
            }
            else
            {
                Console.WriteLine("p1 is not equal to p2");
            }

            Console.WriteLine(p1.name);
        }
    }
}