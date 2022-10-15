using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.DELIGATEDEMO
{
    public delegate int Mydel(int a);
   
    class FIRSTdELIGATE
    {
        static int Square(int a)
        {
            Console.WriteLine("In Square method");
            return a * a;
        }

      

        static void Main(string[] args)
        {           
            Mydel d = Square;
            int ans = d(12);
            Console.WriteLine(ans);          

        }
    }
}
