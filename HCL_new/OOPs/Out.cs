using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.OOPs
{
    class Out
    {
        static void Swapping(ref int x)
        {
            x = 700;
        }
        static void Calculate( out int sum)
        {
            sum = 1000;           
        }
        static void Main(string[] args)
        {
            int a = 0, b ;
            Swapping(ref a);             //ref addr + data
            Console.WriteLine(a);
           // int s = 10, p;
            Calculate(out b);      //out addr or ref only
            Console.WriteLine(b);

            string k = "Pradnya";
            k = k + "Shri";
            Console.WriteLine(k);
        }
    }
}
