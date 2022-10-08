using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCL_new.StackDemo
{
   /* 16.	WAP to create a Stack to store some objects and iterate over it.
        Also show use  push,pop,peek.*/
    class demostack
    {
        static void Main(string[] args)
        {
            Stack<string> stk = new Stack<string>();
            stk.Push("prerna");
            stk.Push("riya");
            stk.Push("Pranoti");
/*
            IEnumerable<string> e = stk.DefaultIfEmpty("none");
            Console.WriteLine(e);
*/
            foreach (string data in stk)
            {
                Console.WriteLine(data);
            }

            string v = stk.Peek();
            Console.WriteLine("Data at stack top =    "   +v);


            string s = stk.Pop();
           // Console.WriteLine("remove element"+s);

            foreach (string data in stk)
            {
                Console.WriteLine(data);
            }
            
        }
    }
}
