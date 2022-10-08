using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Linq;
using System.Collections;

namespace HCL_new.CollectionDemo
{

    //WAP to create a  SortedList  using Custom class as any other object as value

    class Books 
    {
        string bname;
        int price;
        string author;

        public Books()
        {
        }

        public Books(string bname, int price, string author)
        {
            this.Bname = bname;
            this.Price = price;
            this.Author = author;
        }

        public string Bname { get => bname; set => bname = value; }
        public int Price { get => price; set => price = value; }
        public string Author { get => author; set => author = value; }

       /* public int Compare(Books x, Books y)
        {
            return x.Bname.CompareTo(y.Bname);
        }
*/
        public override string ToString()
        {
            return "Bookname=" + bname + "Price" + price + "Author name=" + Author;
        }
    }
    class SortPriceBook : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
    class BookSortList 
    {

        /*static void Main(string[] args)
        {
            SortedList<Books, int> s = new SortedList<Books,int>(new SortPriceBook());
            s.Add(new Books("Java", 800, "Xyz"), 10);
            s.Add(new Books("c#", 500, "abc"), 20);
            s.Add(new Books("Java", 700, "fgh"), 30);
            s.Add(new Books("ASP", 800, "pqr"), 40);
            s.Add(new Books("React", 800, "sdf"), 50);


           *//* SortedList<Books, int> sd = new SortedList<Books, int>(new SortPriceBook())
            {
                { new Books("Java", 800, "Xyz"), 10 },
                { new Books("c#", 500, "abc"), 20 },
                { new Books("Java", 700, "fgh"), 30 },
                { new Books("ASP", 800, "pqr"), 40 },
                { new Books("React", 800, "sdf"), 50 }
            };
*//*

            foreach (KeyValuePair<Book,int> kv in s)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }*/

       
    }
}
