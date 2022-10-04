using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Practice
{
    class StaticMethod
    {

        static int x = 23;
        static int y = 15;


        static void Calculate()
        {
            int add = x + y;
            Console.WriteLine("Addition=" + add);
        }

        static void Calculate(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("substraction+" + sub);

        }

        static void Main(string[] args)
        {
            StaticMethod.Calculate();
            StaticMethod.Calculate(52, 23);
        }

    }
}
