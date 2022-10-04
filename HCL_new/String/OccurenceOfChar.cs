using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.String
{
    class OccurenceOfChar
    {
        static int Character(string s, char c)
        {
            int n = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (c == s[i])
                {
                    n++;
                }
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");
            string s = Console.ReadLine();

            Console.WriteLine("Enter any Character");
            char c = char.Parse(Console.ReadLine());
            int a = Character(s, c);
            Console.WriteLine(a);

            /* string nm = Console.ReadLine();
                                                 //remove duplicate.0
             string s2 = " ";
             foreach (char ch in nm)

             {
                 if(!s2.Contains(ch))
                 {
                     s2 = s2 + ch;
                 }
             }
             Console.WriteLine(s2);*/
        }
    }
}
