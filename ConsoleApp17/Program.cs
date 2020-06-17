using System;
using System.Threading.Channels;

namespace ConsoleApp17
{
    class MyClass
    {
        public int Add(int x, int y) => x + y;
        public int Squre(int x) => x * x;
        public static void Show(int x) => Console.WriteLine(x);
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass foo = new MyClass();
            Console.WriteLine(foo.Add(2, 3));
            Console.WriteLine(foo.Squre(6));
            MyClass.Show(666);
        }
    }
}