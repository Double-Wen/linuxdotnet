using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] objs = new object[3];
            objs[0] = 123;
            objs[1] = "abc";
            objs[2] = new DateTime(2018, 7, 8);
            for (int i = 0; i < objs.Length; i++)
            {
                Console.WriteLine();
            }

            foreach (var obj in objs)
            {
                Console.WriteLine("{0} {1} {2} {3}", obj, obj.GetType(), obj.GetHashCode(), obj.ToString());
            }
        }
    }
}