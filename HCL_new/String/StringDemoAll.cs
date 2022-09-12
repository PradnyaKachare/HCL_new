using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.String
{
    class StringDemoAll
    {
        static void Main(string[] args)
        {

            // string m = "shanaya goes to bishops school";
            //m="ayanahs seog ot spohsib loohcs";

            //lower
            string s1 = "Race";
            string s2 = "Care";
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            //upper
             s1 = s1.ToUpper();
            s2 = s2.ToUpper();

             Console.WriteLine(s1.Length); //13
             Console.WriteLine(s1[2]);


            //Substring`
             string sg = "thinkquotient";
            string s4 = sg.Substring(2);
            Console.WriteLine(s4);
            string s5 = sg.Substring(2, 3);
            Console.WriteLine(s5);

            //Equals
            string str1 = "Shree";
            string str2 = "Ram";
            Console.WriteLine(str1.Equals(str1));
            Console.WriteLine(str1==str2);


            //Index of()
            int j = s2.IndexOf('@');  //-1
            int k = s2.IndexOf('_');
            Console.WriteLine("Enter any string:");
            string s = Console.ReadLine();
            s = "Pradnya";
            int l= s.IndexOf('a');
            int n= s.IndexOf('a',l+1);
            int p = s.IndexOf('a', n + 1);

            string z = "Pradnya";
            int o = s.IndexOf('r');//2
            int q = s.LastIndexOf('s' + z);

            //Replace
            string st = s.Replace('p', 's');
            Console.WriteLine("string=" + s);
            Console.WriteLine("Replace=" + st);

            //2 way
            s = "Pradnya learns Asp";
           // string a = s.Replace('p', ' '); //char replace
            string a = s.Replace("p", " ");  //string replace
            Console.WriteLine(s); 
            Console.WriteLine(a);

            //3 way
            string c = "red apple red ball red rose";
            string d = c.Replace("red", "purple ");
            Console.WriteLine(c);
            Console.WriteLine(d);
           
            //Trim
            str1 = "veda shri";
            str1 = str1.Trim();

            Console.WriteLine(str1.StartsWith("the"));
            Console.WriteLine(str1.EndsWith("@gmail.com"));

            //compare
            string r = "rahul";
            string r1 = "Amey";
            Console.WriteLine(r.CompareTo(r1));
            Console.WriteLine(r1.CompareTo(r));
            Console.WriteLine(r1.CompareTo("rahul"));

            //arry   sort
            char[] arr = s1.ToCharArray();//  {'q','o',''p','r'}
            char[] arr1 = s2.ToCharArray();//  {'r','p',''q','o'}
            //spilt
            string[] sarr = s.Split(" ");

            Array.Sort(arr);    // o p q r
            Array.Sort(arr1);     // o p q r
            
            
            //ToCharArray()

            //string[] sa = { "Adi","abhi","siya","diya"};

            int[] sa1 = { 123, 67, 1, 88, 32 };

            for (int i = 0; i <sa1.Length; i++)
            {
               /* for (int j = 0; j < sa1.Length-1-i; j++)
                {
                    if (sa1[j] > sa1[j+1])
                    {
                        //swap

                    }
                }*/
            }




        }

    }
    
}
