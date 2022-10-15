using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new
{
    public delegate bool Deleven(int a);
    class EvenOddDel
    {
        static bool IsEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Deleven d = IsEven;
            bool ans = d(6);
              
            Console.WriteLine(ans);
        }
    }
}
