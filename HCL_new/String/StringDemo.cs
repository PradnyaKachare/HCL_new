using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.String
{
    class StringDemo
    {
        int id;
        string name;
        public StringDemo(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public static StringDemo operator+(StringDemo s1, StringDemo s2)
        {
            return null;
        }
        static void Main(string[] args)
        {
            //Operator are designed to work with Primitives
            int a = 10, b = 20;
            Console.WriteLine(a+b);

            string s1 = new string("Pradnya");
            string s2 = new string("Veda");
            Console.WriteLine(s1==s2);
            Console.WriteLine(Object.ReferenceEquals(s1,s2));

            StringDemo s3 = new StringDemo(1, "Pradnya");
            StringDemo s4 = new StringDemo(1, "Pradnya");
            Console.WriteLine(s3==s4);
           
        }
    }
}
