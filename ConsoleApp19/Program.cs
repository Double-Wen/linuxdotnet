using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp19
{
    class Program
    {
        static void Add(int x, int y, out int z)
        {
            z = x + y;
        }

        static void Add2(int x, int y, ref int z)
        {
            x = x + y;
        }
        static void Main(string[] args)
        {
            //int z;
            int x = 1;
            int y = 2;
            Add(x, y, out int z);
            Console.WriteLine(z);
            int w=0;
            Add2(x, y, ref w);
            Console.WriteLine(w);
        }
    }
}