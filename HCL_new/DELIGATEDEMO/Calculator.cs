using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.DELIGATEDEMO
{
    public delegate void myde(int a, int b);
    class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition:"+(a+b));
        }
        public void Substract(int a, int b)
        {
            Console.WriteLine("Substract:" + (a - b));
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiply:" + (a * b));
        }  
            static void Main(string[] args)
            {
            Calculator c = new Calculator();
            myde d = c.Add;
            d = d + c.Substract;
            d = d + c.Multiply;
            d(11, 5);
            }

    }
}
