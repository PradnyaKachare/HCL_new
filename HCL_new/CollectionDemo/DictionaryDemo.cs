using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.String
{
    //14.	WAP to create a  Dictionary  using Custom class as any other object as value

    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("Pratik", 91);
            d.Add("pranesh", 91);       //Duplicate value allow
            d.Add("Pradnya", 92);
        //  d.Add("Pradnya", 91);       //key duplicate not allow

            Console.WriteLine(d["Pratik"]);

            //update

            d["Pratik"] = 93;

            d.Remove("Pratik");

            Console.WriteLine(d.ContainsKey("Deepa"));//key present or not

            Console.WriteLine(d.ContainsValue(91));     //value present or not find

            foreach (KeyValuePair<string, int> kv in d)

                Console.WriteLine(kv.Key + " " + kv.Value);

        }
    }
}
