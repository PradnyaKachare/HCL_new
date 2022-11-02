using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Practice
{
    internal class Calculation
    {
          public int Addition(int a, int b)
            {
                return a + b;
            }
            public int Addition(int a, int b, int c)
            {
                return a + b + c;
            }
            public double Addition(int a, double b)
            {
                return a + b;
            }
        

        static void Main(string[] args)
        {
            Calculation c1 = new Calculation();
            Console.WriteLine(c1.Addition(10, 20.56));
            Console.WriteLine(c1.Addition(1, 2));
        }




    }
}
