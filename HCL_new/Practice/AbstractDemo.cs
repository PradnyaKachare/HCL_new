using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Practice
{
    abstract class Animal
    {
        public abstract void Tiger();
        public static void Lion()
        {
            Console.WriteLine("Lion");
        }
        public void Rabbit()
        {
            Console.WriteLine("Rabbit");
        }
    }
    class AbstractDemo
    {
        /* public override void Tiger()
         {
             Console.WriteLine("Tiger");
         }*/
        static void Main(string[] args)
        {
            AbstractDemo a = new AbstractDemo();
            // a.Animal();
            // a.Tiger();
            // a.Lion();
            // a.rabbit();
        }
    }
}
