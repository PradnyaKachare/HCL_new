using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.HASHSETDEMO
{
   // 19.	WAP to iterate through all elements in a HashSet and print the elements.
   // Observe the order of elements.

    class HashObjDemo
    {
        static void Main(string[] args)
        {
            HashSet<string> hs= new HashSet<string> ();
            hs.Add("Pranav");
            hs.Add("Pradyna");
            hs.Add("Pranesh");
            hs.Add("Pratik");
            hs.Add("Priyashree");          
            hs.Add("Priyashree");
            hs.Add("Pradyna");
            hs.Add("Pradyna");        

            foreach (string data in hs) 
                Console.WriteLine(data);
        }
    }
}
