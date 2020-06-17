using System;

namespace ConsoleApp21
{
    class Program
    {
        static void F(params int[] args)
        {
            Console.WriteLine(args.Length);
            foreach (var item in args)
            {
                Console.Write($"{item}");
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4};
            F(arr);
            F(3, 6, 9);
            F();
        }
    }
}