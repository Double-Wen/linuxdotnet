using System;

namespace ConsoleApp16
{
    class MyMath
    {
        public int Add(int x, int y)
        {
            return x+y;
        }

        public int Squre(int num)
        {
            return num * num;
        }

        public static void Show(int num)
        {
            Console.WriteLine(num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyMath foo = new MyMath();
            Console.WriteLine(foo.Add(2, 3));
            Console.WriteLine(foo.Squre(5));
            MyMath.Show(666);
        }
    }
}