using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.CollectionDemo
{
    class Movie : IComparable<Movie>
    {
        string movie_nm;
        int rating;

        public int CompareTo(Movie mv)
        {
            // return this.rating.CompareTo(mv.rating);   //asending

            return mv.rating.CompareTo(this.rating);        //descending
        }

        public string Movie_nm { get => movie_nm; set => movie_nm = value; }
        public int Rating { get => rating; set => rating = value; }

        public Movie(string movie_nm, int rating)
        {
            this.movie_nm = movie_nm;
            this.rating = rating;
        }

        public Movie()
        {
        }
        public override string ToString()
        {
            return $"movie name:{movie_nm} Rating {rating}";
        }

        static void Main(string[] args)
        {
            List<Movie> lst = new List<Movie>();
            lst.Add(new Movie("Taal", 6));
            lst.Add(new Movie("Hum", 5));
            lst.Add(new Movie("Avengers", 7));
            lst.Add(new Movie("Harry potter", 8));

            lst.Sort();

            foreach (Movie m in lst)
            {
                Console.WriteLine(m);
            }
        }
    }
}
