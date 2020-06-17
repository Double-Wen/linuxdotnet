using System;

namespace ConsoleApp14
{
    class MyDate
    {
        public int year = 2018;
        public int month = 1;
        public int day = 1;
    }

    class MyClass
    {
        public static int ss = 123;
        public const int hello = 456;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDate date = new MyDate();
            date.day = 7;
            Console.WriteLine("{0} {1} {2}", date.year, date.month, date.day);
            Console.WriteLine("Hello World!");
            Console.WriteLine(MyClass.ss);
            Console.WriteLine(MyClass.hello);
        }
    }
}