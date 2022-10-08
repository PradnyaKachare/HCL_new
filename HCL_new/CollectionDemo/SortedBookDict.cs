using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HCL_new.CollectionDemo
{
    class Book
    {
        string bnm;
        string author;
        int price;

        public Book(string bnm, string author, int price)
        {
            this.Bnm = bnm;
            this.Author = author;
            this.Price = price;
        }

        public string Bnm { get => bnm; set => bnm = value; }
        public string Author { get => author; set => author = value; }
        public int Price { get => price; set => price = value; }

        public override string ToString()
        {
            return "Bookname=" + bnm + "Price" + price + "Author name=" + Author;
        }
    }
    class SortPrice : IComparer<Book >
    {
       public  int Compare(Book x, Book y)
        {
            return x.Price.CompareTo(y.Price);
        }        
    }
    class SortedBookDict
    {
        static void Main(string[] args)
        {
            SortedDictionary<Book,int> b = new SortedDictionary<Book,int>();
            b.Add(new Book("Asp", "Andrew", 600), 4);
            b.Add(new Book("Java", "Jhon", 500), 6);
            b.Add(new Book("C#", "JAmes", 700), 3);
            b.Add(new Book("C++", "Rickey", 900), 9);
            b.Add(new Book("C", "David", 800), 1);

            foreach (KeyValuePair<Book, int> kv in b)

                Console.WriteLine(kv.Key + " " + kv.Value);
        }
    }
}
