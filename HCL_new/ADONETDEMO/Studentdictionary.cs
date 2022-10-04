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
            List<Studentdictionary> lst = new List<Studentdictionary>();
            lst.Add(new Studentdictionary(1, "Veda", 95));
            lst.Add(new Studentdictionary(2, "Pradnya", 85));
            lst.Add(new Studentdictionary(3, "Siya", 79));
            lst.Add(new Studentdictionary(3, "Riya", 90));
            lst.Add(new Studentdictionary(3, "Shree", 80));
            lst.Sort();
            foreach (Studentdictionary st in lst)
            {
                Console.WriteLine(st);
            }
        }
    }
}
