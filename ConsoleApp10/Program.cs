using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] foo = new int[100];
            for (int i = 0; i < 100; i++)
            {
                foo[i] = i + 1;
            }

            foreach (var item in foo)
            {
                Console.WriteLine(item);
            }
        }
    }
}