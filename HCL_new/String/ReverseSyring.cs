using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.String
{
    class ReverseSyring
    {
        static string Reverse(string s)
        {
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            return rev;
        }
        static void Main(string[] args)
        {
            string s = "shanaya goes to bishops school";
            
            string[] arr = s.Split(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                string s1 = Reverse(arr[i]);
                Console.Write( s1 +"  ");
            }

        }
    }
}
