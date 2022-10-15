using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new
{
    internal class Class
    {
        static int[] test(int[] n)
        {
            int f = n[1];
            n[0] = n[n.Length - 2];
            n[n.Length - 2] = f;

            int s = n[0];
            n[0] = n[n.Length - 1];
            n[n.Length - 1] = s;

            return n;
            
        }
        static void Main(string[] args)
        {
            int[] a =test(new[] { 10, 20, 30, 40, 50 });
            //40,50,30,10,20
            foreach (var i in a)
            {
                Console.WriteLine(i.ToString()+" ");
            }
            
        }
    }
}
