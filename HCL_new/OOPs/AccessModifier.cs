using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.OOPs
{
    class AccessModifier
    {
        //By default private Variable
         int a = 10;         // this assembly or current class only
        internal int b = 20; // Current Assembly/project Anywhere
        protected int c=30; //only in subclass in current assembly or another Assembly
        public int d = 40; //EveryWhere in same project or Different project
        private protected int e = 50;//This or current Assembly only in subclass in current assembly
        internal protected int f = 60;//Current Assembly everywhere and other in subclass in current assembly 
       
        public void show()
        {
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Aceess modifier");
        }
    }
}
