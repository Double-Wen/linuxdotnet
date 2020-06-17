using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Swap(int x, int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        static void RealSwap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            Console.WriteLine("{0} {1}", x, y);
            Swap(x, y);
            Console.WriteLine("{0} {1}", x, y);
            Console.WriteLine("{0} {1}", x, y);
            RealSwap(ref x, ref y);
            Console.WriteLine("{0} {1}", x, y);
        }
    }
}