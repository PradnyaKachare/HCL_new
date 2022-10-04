using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.CollectionDemo
{
    class Book : IComparable<Book>
    {
        string bookname;
        int price;
        string authorname;
        public int CompareTo(Book b2)
        {
            if (this.price == b2.price)
            {
                return this.authorname.CompareTo(b2.authorname);
            }
            return this.price.CompareTo(b2.price);

            // return b2.price.CompareTo(this.price);


            /* if (this.price < b2.price)
             return -1;
        else if (this.price > b2.price)
             return 1;
         else
             return 0;*/
        }

        public Book()
        {
        }
        public string Bookname { get => bookname; set => bookname = value; }
        public int Price { get => price; set => price = value; }
        public string Authorname { get => authorname; set => authorname = value; }

        public Book(string bookname, int price, string authorname)
        {
            this.Bookname = bookname;
            this.Price = price;
            this.Authorname = authorname;
        }
        public override string ToString()
        {
            return $"Bookname: {Bookname} Price: {Price} Authorname: {Authorname} ";
        }

    }
    class Book1
    {
        static void Main(string[] args)
        {
            List<Book> lst = new List<Book>();
            lst.Add(new Book("Java", 900, "kathay"));
            lst.Add(new Book("c++", 500, "kanetkar"));
            lst.Add(new Book("c#", 800, "balguru"));
            lst.Add(new Book("Python", 1000, "Raj"));

            lst.Sort();
            foreach (Book b in lst)
            {
                Console.WriteLine(b);
            }
        }

    }
    /* class Array
     {
         static void Main(string[] args)
         {
             string[] arr = { "Adf", "ffdf", "Pdg", "Bdf" };

             foreach (string str in arr)
             {
                 Console.WriteLine(arr);
             }

           //  Array.Sort(arr);

             foreach (string str in arr)
             {
                 Console.WriteLine(arr);
             }
         }

     }*/


}
