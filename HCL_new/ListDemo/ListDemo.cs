using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace HCL_new.CollectionDemo
{
    //6.	WAP to create List of Students and iterate over it.
    class ListDemo
    {
        static void Main(string[] args)
        {
            List<StudentList> lst = new List<StudentList>();
             lst.Add(new StudentList(1, "Pradnya", 90));
            lst.Add(new StudentList(2, "veda", 94));
            lst.Add(new StudentList(3, "prachi", 97));
            lst.Add(new StudentList(4, "jayanti", 89));
            lst.Add(new StudentList(5, "raj", 80));


            do
            {
                Console.WriteLine("Enter id,name,percentage");
                int id = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                int per = int.Parse(Console.ReadLine());
                StudentList s = new StudentList(name, id, per);
                lst.Add(s);
                Console.WriteLine("Do u want to add more(Y/N)");
                char ch = char.Parse(Console.ReadLine());

                if (ch != 'Y')
                {
                    break;
                }
            }
            while (true);

            foreach (StudentList s in lst)
            {
                Console.WriteLine(s);
            }

        }
    }
    
}
