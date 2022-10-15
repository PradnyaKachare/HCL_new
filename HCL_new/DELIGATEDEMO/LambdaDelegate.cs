using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.DELIGATEDEMO
{
    public delegate int Del2(int a, int b);
    class LambdaDelegate
    {
        static void Main(string[] args)
        {
            Del2 d = (a, b) => 
            {
                Console.WriteLine("in lambda");
                return a * b;

            };
            int res = d(4, 5);
            Console.WriteLine(res);
        }
    }
}
