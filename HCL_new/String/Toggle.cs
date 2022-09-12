using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.String
{
    class Toggle
    {
        static string Togle(string s)
        {
            string t = "";
            foreach (char c in s)
            {
                if(char.IsUpper(c))
                {
                    t = t + char.ToLower(c);
                }
                else if(char.IsLower(c))
                {
                    t = t + char.ToLower(c);
                }
               
            }
            return t;
        }
        static void Main(string[] args)
        {
            string s = "Pradnya Veda";
            string s1 = Togle(s);
            Console.WriteLine(s1);

            int[] a = { 1, 2, 3, 4, 5, 6, 7 };        //op-pradnya 7 letter
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
