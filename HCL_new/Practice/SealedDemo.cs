using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Practice
{
    sealed class Demo
    {
        public void show()
        {
            Console.WriteLine("Sealed class");
        }
        /* public virtual sealed void Display()
         {
             Console.WriteLine("Sealed Method");
         }*/
    }
    class demo1 //:Demo
    {
        /* public override void Display()
         {
             Console.WriteLine("Child Display method");
         }*/
    }
    class SealedDemo
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.show();
            // d.Display();

        }

    }
}
