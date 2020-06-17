using System;

namespace ConsoleApp20
{
    class Program
    {
        static void PrintParam(int a, int b = 1, int c = 2)
        {
            Console.WriteLine($"{a} {b} {c}");
        }
        static void Main(string[] args)
        {
            string s = "123";
            if (int.TryParse(s, out int n))
            {
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine($"{s} can not convert to int");
            }
            PrintParam(3);
        }
    }
}