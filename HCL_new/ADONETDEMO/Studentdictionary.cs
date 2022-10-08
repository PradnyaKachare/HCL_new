using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.ADONETDEMO
{
    class Studentdictionary : IComparable<Studentdictionary>
    {
        int sid;
        string sname;
        int mark;

        public Studentdictionary(int sid, string sname, int mark)
        {
            this.Sid = sid;
            this.Sname = sname;
            this.Mark = mark;
        }

        public int Sid { get => sid; set => sid = value; }
        public string Sname { get => sname; set => sname = value; }
        public int Mark { get => mark; set => mark = value; }

       
        public override string ToString()
        {
            return $"Sid: {sid} Sname: {sname} Mark: {mark} ";
        }

        public int CompareTo(Studentdictionary s)
        {
            if (this.mark == s.mark)
            {
                return this.mark.CompareTo(s.mark);
            }
            return this.mark.CompareTo(s.mark);
        }
    }
    class Student
    {
        static void Main(string[] args)
        {
            Studentdictionary s1 = new Studentdictionary(1, "Veda", 91);
            Studentdictionary s2 = new Studentdictionary(2, "reva", 95); 
            Studentdictionary s3 = new Studentdictionary(3, "Pradnya", 92);
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());

            Dictionary<Studentdictionary, int> d = new Dictionary<Studentdictionary, int>();
           /* d.Add (new Studentdictionary(1, "Veda", 91));
            d.Add(new Studentdictionary(2, "reva", 95 ));
            d.Add(new Studentdictionary(3, "Pradnya", 92));

*/


            foreach (KeyValuePair<Studentdictionary, int> kv in d)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
