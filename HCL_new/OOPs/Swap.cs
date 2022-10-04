using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.OOPs
{
    class Swap
    {
        static void Swapping(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
        static void Calculate(int a, int b, out int sum, out int prod)
        {
            sum = a + b;
            prod = a * b;

        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Swapping(ref a, ref b);       //ref addr+ data
            Console.WriteLine("a=" + a + "b" + b);
            int s = 10, p;
            Calculate(3, 4, out s, out p);      //out addr or ref only
            Console.WriteLine(s);
            Console.WriteLine(p);
        }

    }
}
