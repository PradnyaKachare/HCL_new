using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCL_new.HASHSETDEMO
{
    class HashSetInterSection
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("Pranav");
            hs.Add("Pradnya");
            hs.Add("Pranesh");
            hs.Add("Pratik");
            hs.Add("Priyashree");          


            HashSet<string> h= new HashSet<string>();
            h.Add("Priyashree");
            h.Add("Pradnya");
            h.Add("Veda");
            h.Add("Prachi");
          
            foreach (string data in hs)
                Console.WriteLine(data);


            Console.WriteLine("*****After Intersection**********");

           //  hs.IntersectWith(h);


            IEnumerable<string> i = hs.Intersect(h);
             _ = hs.Intersect(h).ToHashSet();
           // HashSet<string> h3 = i.ToHashSet();




            foreach (string data in hs)
                Console.WriteLine(data);

        }
    }
}
