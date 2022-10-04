using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new
{
    //Method Overriding Meanse where dicision takes at run time 
    class Parent
    {
        public int x;
        public Parent(int x)            //constructor call using base keyword
        {
            this.x = x;

        }
        public virtual void show()
        {

        }
        public static void Display()     //static Can't be overring
        {

        }
        public void Play()               //Metod Hiding
        {
            Console.WriteLine("Parent Class Play ");
        }

    }
    class Child : Parent
    {
        public Child() : base(10)
        {
            Console.WriteLine(x);
        }
        public override void show()
        {

        }
        /*public static  void Display()
        {

        }*/
        /* public void Play()
         {
             Console.WriteLine("Child class Play ");
         }*/
        public void m1()                // //Only method call which is present in parent class
        {

        }

    }
    class OverridingDemo
    {
        static void Main(string[] args)

        {
            Parent p = new Child();
            p.show();
            // p.Display();
            // p.Play();
            // p.m1();         //Only method call which is present in parent class
        }
    }
}
