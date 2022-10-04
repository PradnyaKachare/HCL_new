using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCL_new.CollectionDemo
{
    class frequency
    {
        static void Main(string[] args)
        {
            List<string> l1 = new List<string>() { "red", "red", "blue", "pink", "blue", "red" };

            //key color ---value-count

            Dictionary<string, int> dd = new Dictionary<string, int>();
            //{"red"=2}

            foreach (string color in l1)
            {

                if (dd.ContainsKey(color))
                {
                    int val = dd[color];
                    dd[color] = val + 1;

                }
                else
                {
                    dd.Add(color, 1);
                }
            }

            foreach (KeyValuePair<string, int> kv in dd)
            {
                Console.WriteLine(kv.Key + "===>" + kv.Value);
            }

            KeyValuePair<string,int>[] arr= dd.ToArray();
            List<KeyValuePair<string, int>> Ist = dd.ToList();

           

            foreach (string key in dd.Keys)
            {
                Console.WriteLine(key + " " + dd[key]);
            }


        }
    }
}

