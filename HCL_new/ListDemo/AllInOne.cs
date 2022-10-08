using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace HCL_new.CollectionDemo
{
    class AllInOne
    {
        static void Main(string[] args)
        {
            /*AllInOne a = new AllInOne();
            a.ob = "Pradnya";
            string s1 = (string)a.ob;*/
        }
    }
    class AA<T>
    {
        // T ob;
        public T ob { get => ob; set => ob = value; }
    }
    class MM
    {
        static void Main(string[] args)
        {
            AA<string> a = new AA<string>();
            a.ob = "Veda";
            string s = (string)a.ob;

            AA<int> ab = new AA<int>();
            ab.ob = 900;

        }
    }
    class Demolist
    {
        static void Main(string[] args)
        {
            //underlying tis arry growable
            List<string> lst = new List<string>();

            // Console.WriteLine(lst.Count);       //0
            // Console.WriteLine(lst.Capacity);    //4
            lst.Add("Amey");
            lst.Add("Om");
            lst.Add("Priya");
            // Console.WriteLine(lst.Count);       //3
            //Console.WriteLine(lst.Capacity);        //4
            lst.Add("Riya");
            lst.Add("Pratik");
            lst.Add("Amey");                   //Allow duplicat value

            lst.Insert(1, "Pranav");

            //sorting
            lst.Sort();
            foreach (string s in lst)
            {
                Console.WriteLine( s + "  ");
            }
            Console.WriteLine("index+");
            //Indexes of
            int idx = lst.IndexOf("Pratik");
            int Lastidx = lst.LastIndexOf("Pratik");        //lastindexof

            Console.WriteLine(lst.Contains("Rutuja"));


            //add
            List<string> l2 = new List<string>() { "a", "b", "c" };
            l2.AddRange(lst);
            l2.Add("D");

            Console.WriteLine("AddRenge="+lst[0]);      //list print

            //Arry print
            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine(arr[0]);

            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }

            foreach (string s in lst)
            {
                Console.WriteLine(s);
            }

        }
    }
}
