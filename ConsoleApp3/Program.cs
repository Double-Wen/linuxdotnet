using System;

namespace ConsoleApp3
{
    class Program
    {
        public int number;
        public static int count;

        public Program()
        {
            count += 1;
            number = count;
        }

        public void showInstance()
        {
            Console.WriteLine(number);
            Console.WriteLine(count);
        }

        public static void showStatic()
        {
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Program p2 = new Program();
            Program.showStatic();
            p2.showInstance();
        }
    }
}