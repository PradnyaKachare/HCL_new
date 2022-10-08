using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.HASHSETDEMO
{
    class UnionHashset
    {

        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("Pranav");
            hs.Add("Pradnya");
            hs.Add("Pranesh");
            hs.Add("Pratik");
            hs.Add("Priyashree");


            HashSet<string> h = new HashSet<string>();
            h.Add("Priyashree");
            h.Add("Pradnya");
            h.Add("Veda");
            h.Add("Prachi");

            foreach (string data in hs)
                Console.WriteLine(data);


            Console.WriteLine("*****After Intersection**********");

            hs.UnionWith(h);


            foreach (string data in hs)
                Console.WriteLine(data);
        }
    }
}
