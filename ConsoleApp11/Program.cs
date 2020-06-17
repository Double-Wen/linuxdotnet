using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj1 = new object();
            object obj2 = new Object();
            Object obj3 = new Object();
            Console.WriteLine(obj1.GetType());
            Console.WriteLine(obj2.GetType());
            Console.WriteLine(obj3.GetType());
            object x = 3;
            object y = 3;
            Console.WriteLine(x == y);
            int xx = 1;
            int yy = 2;
            Console.WriteLine(xx == yy);
            Console.WriteLine(object.Equals(x, y));
            Console.WriteLine(object.ReferenceEquals(x, y));
            
        }
    }
}