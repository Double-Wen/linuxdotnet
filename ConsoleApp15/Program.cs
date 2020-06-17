using System;
using System.Threading;

namespace ConsoleApp15
{
    class MyClass
    {
        public readonly int a = 1;
        public readonly int b = 2;
        
        public readonly int c;

        public MyClass()
        {
            b = 6;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass w = new MyClass();
            
            Console.WriteLine(w.b);
            Console.WriteLine(w.a);
        }
    }
}