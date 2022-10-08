using System;
using System.Collections.Generic;
using System.Text;


namespace HCL_new.StackDemo
{
    class DemoSortedList
    {
        static void Main(string[] args)
        {
            SortedList<string, int> s = new SortedList<string,int>();
            s.Add("pune",5);
            s.Add("solapur",9);
            s.Add("satara",4);        
            s.Add("Akluj",6);

            
            foreach (KeyValuePair <string,int> kv in s)
            {
                Console.WriteLine(kv.Key+ "==>"+kv.Value);
            }

            /*foreach (string k in s.Keys)
            {
                Console.WriteLine(k+"==>"+s[k]);
            }*/
            

        }

    }
}
