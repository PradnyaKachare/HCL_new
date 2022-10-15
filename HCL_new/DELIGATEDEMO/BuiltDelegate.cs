using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.DELIGATEDEMO
{
    public delegate void Add(int a, int b);
    public delegate int Multiply(int a, int b);
    public delegate bool Leap(int a);
    class BuiltDelegate
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition:" + (a + b));
        }
        public int Multiply(int a, int b)
        {            
            return a * b;
        }
        public static bool isLeap(int a)
        {
            if (a % 4 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            BuiltDelegate b = new BuiltDelegate();

            Action<int, int> a = (a, b) => Console.WriteLine(a+b);

           /* Func<int,int> f = BuiltDelegate.Multiply;
            int num = f(5, 2);
            Console.WriteLine();

            Predicate<int> p = BuiltDelegate.isLeap;
            bool b = f(2004);
            Console.WriteLine(b);*/


        }
    }
}
