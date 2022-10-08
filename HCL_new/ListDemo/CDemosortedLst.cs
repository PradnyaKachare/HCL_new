
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace HCL_new.StackDemo
{
    sealed class Trainer : IComparable<Trainer> ,IEquatable<Trainer>
    {
        int tid;
        string tname;

      
        public int CompareTo(Trainer t)
        {
            return t.tid.CompareTo(this.tid);
        }


        public Trainer(int tid, string tname)
        {
            this.Tid = tid;
            this.Tname = tname;
        }

        public Trainer()
        {
        }

        public int Tid { get => tid; set => tid = value; }
        public string Tname { get => tname; set => tname = value; }

      
        public override int GetHashCode()
        {
            return HashCode.Combine(Tid, Tname);
        }

        public override string ToString()
        {
            return  $"Tid: {tid} Tname: {tname} ";
        }

        public bool Equals(Trainer tr)
        {
            return true;
        }
    }
    class CDemosortedLst
    {
        static void Main(string[] args)
        {
            SortedList<Trainer, string> s = new SortedList<Trainer, string>();

            s.Add(new Trainer(101, "Medha"), "Java");
            s.Add(new Trainer(102, "Kirti"), "Java");
            s.Add(new Trainer(103, "Deepa"), "C#");

            foreach (KeyValuePair<Trainer, string> kv in s)
            {
                Console.WriteLine(kv.Key + "==>" + kv.Value);
            }
        }
    }
}
