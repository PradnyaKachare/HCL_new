using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace HCL_new.CollectionDemo
{
    class TrainerSort : IComparable<TrainerSort>
    {
        int tid;
        string tname;
        int texp;

        public int CompareTo(TrainerSort tr)
        {
            if (this.texp == tr.texp)
            {
                return this.texp.CompareTo(tr.texp);
            }
            return this.texp.CompareTo(tr.texp);
        }
        public override string ToString()
        {
            return $"Tid: {tid} Tname: {tname} Texp: {texp} ";
        }
        public TrainerSort(int tid, string tname, int texp)
        {
            this.tid = tid;
            this.tname = tname;
            this.texp = texp;
        }

        public TrainerSort()
        {
        }

        public int Tid { get => tid; set => tid = value; }
        public string Tname { get => tname; set => tname = value; }
        public int Texp { get => texp; set => texp = value; }


    }
    class Trainer
    {
        static void Main(string[] args)
        {
            List<TrainerSort> lst = new List<TrainerSort>();
            lst.Add(new TrainerSort(1, "Deepa", 19));
            lst.Add(new TrainerSort(2, "Kallyani", 15));
            lst.Add(new TrainerSort(3, "Nisha", 18));

            lst.Sort();
            foreach (TrainerSort t in lst)
            {
                Console.WriteLine(t);
            }
        }
    }
}
