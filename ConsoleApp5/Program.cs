using System;

namespace ConsoleApp5
{
    class Program
    {
        public void SayHello()
        {
            Console.WriteLine("Hello World");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.SayHello();
        }
    }
}