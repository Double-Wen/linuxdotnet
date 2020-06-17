using System;

namespace ConsoleApp4
{
    class Program
    {
        public int i1 = 123;
        public string s1 = "abc";

        public Program() {}

        public Program(int i1, string s1)
        {
            this.i1 = i1;
            this.s1 = s1;
        }

        public void PrintInfo()
        {
            int i1 = 123123123;
            string s1 = "qweqwe";
            Console.WriteLine(i1 + " " + s1);
            Console.WriteLine(this.i1 + " " + this.s1);
        }
        static void Main(string[] args)
        {
            Program boj1 = new Program(999, "zxczxc");
            boj1.PrintInfo();
            Program boj2 = new Program();
            boj2.PrintInfo();
        }
    }
}