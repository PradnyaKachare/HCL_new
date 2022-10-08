using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.ListDemo
{
    class ListOfStringInteger
    {
        public static void Main()
        {
            // Creating an ArrayList
            ArrayList myList = new ArrayList(10);

            // Adding elements to ArrayList
            myList.Add(20);
            myList.Add("A");
            myList.Add(2);
            myList.Add("C");

            // Displaying the elements in ArrayList
            Console.WriteLine("The initial ArrayList is : ");

            foreach (var str in myList)
            {
                Console.WriteLine(str);
            }           
        }
    }
}
