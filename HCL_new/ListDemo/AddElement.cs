using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.CollectionDemo
{
    class AddElement
    {
        // C# code to insert an element // into the ArrayList at the// specified index
        //1.	WAP add elements to List<String>,insert at specified position,
        //	update and delete a element.
        
        public static void Main()
        {
            // Creating an ArrayList
            ArrayList myList = new ArrayList(10);

            // Adding elements to ArrayList
            myList.Add("A");
            myList.Add("B");
            myList.Add("C");

            // Displaying the elements in ArrayList
            Console.WriteLine("The initial ArrayList is : ");
            foreach (string str in myList)
            {
                Console.WriteLine(str);
            }

            // Inserting 3 elements at random index in the ArrayList
            myList.Insert(1, "D");
            myList.Insert(4, "E");
            myList.Insert(5, "F");

            // setting the value at index 2
            myList[2] = "Z";


            // Removing the element present at index 4
            myList.RemoveAt(4);

            // Displaying the modified ArrayList
            Console.WriteLine("The ArrayList after Inserting elements is : ");

            // Displaying the elements in ArrayList
            foreach (string str in myList)
            {
                Console.WriteLine(str);
            }
        }
    }

}

