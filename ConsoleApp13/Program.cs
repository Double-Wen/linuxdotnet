using System;

namespace ConsoleApp13
{
    class MyClass
    {
        public void g()
        {
            Console.WriteLine("MyClass.g()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyClass obj = new MyClass();
                obj.g();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            //obj.g();
        }
    }
}