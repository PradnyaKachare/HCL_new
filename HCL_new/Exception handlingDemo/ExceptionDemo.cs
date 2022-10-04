using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Exception_handlingDemo
{
    class ExceptionDemo
    {
        static void show()
        {
            Console.WriteLine("Enter any value");
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            Console.WriteLine(10 / b);
        }
        static void Display()
        {
            Console.WriteLine("Display Method");
            try
            {
                show();
            }
            catch (FormatException e)
            {
                Console.WriteLine("in Disply catch");
                Console.WriteLine(e.Message);
                //throw;
            }
            Console.WriteLine("Display End");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main Start");
            Display();
            Console.WriteLine("main end");
        }
    }
}
