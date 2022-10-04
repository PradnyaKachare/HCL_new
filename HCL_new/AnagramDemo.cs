using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new
{
    class AnagramDemo
    {
        //An anagram is a word or phrase made by using the letters
        //of another word or phrase in a different order.
        //For example, "silent" is an anagram of "listen".

        public static void anagram(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                char[] a1 = s1.ToLower().ToCharArray();
                char[] a2 = s2.ToLower().ToCharArray();
                Array.Sort(a1);
                Array.Sort(a2);
                string res1 = new string(a1);
                string res2 = new string(a2);
                if (res1 == res2)
                {
                    Console.WriteLine("Anagram");
                }
                else
                {
                    Console.WriteLine("Not Anagram");
                }
            }
        }
        static void Main(string[] args)
        {
            //anagram("listen", "silent");

            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            anagram(s1, s2);
        }
    }
}

