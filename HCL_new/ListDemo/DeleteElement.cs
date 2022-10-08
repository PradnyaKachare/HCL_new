using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.CollectionDemo
{
    class DeleteElement
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();

            lst.Add("Amey");
            lst.Add("Om");
            lst.Add("Priya");
            lst.Add("Riya");
            lst.Add("Pratik");
            Console.WriteLine("List of Given");

            foreach (string s in lst)
            {
                Console.Write(s + " , ");
            }
            Console.WriteLine();

            Console.WriteLine("\n List of Deleted element");

            //lst.Clear();                  //clear

            // lst.RemoveRange(1, 3);        //removerange

            // lst.RemoveAt(1);

            lst.Remove("Riya");

            /*Console.WriteLine("Original array list: " + lst);
            string new_color = "White";
            object p = lst.set(1, new_color);

            int num = lst.Count();
            Console.WriteLine("Replace second element with 'White'.");
            for (int i = 0; i < num; i++)
                Console.WriteLine(lst.get(i));*/

            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i] + "  , ");
            }


        }
    }
        class Color
        {
            static void Main(string[] args)
            {
           /* ArrayList <string> color = new ArrayList <string>();

                color.add("Red");
                color.add("Green");
              Console.WriteLine("Original array list: " + color);
                string new_color = "White";
                color.set(1, new_color);

                int num = color.size();
              Console.WriteLine("Replace second element with 'White'.");
                for (int i = 0; i < num; i++)
                Console.WriteLine(color.get(i));*/
            }

                
           
        }
        
    
}
