using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.DELIGATEDEMO
{
    public delegate int Del1(int a, int b);
        
    class anonyomousmethodDel
    {
        static void Main(string[] args)
        {
            Del1 d = delegate (int a, int b)
                           {
                               Console.WriteLine("Hi in anonyomus method");
                               return a * b;
                           };
            int ans = d(11, 12);
            Console.WriteLine(ans);

        }
    }
}
