using HCL_new.CollectionDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.CollectionDemo
{
    class HashCodeDemo
    {
        int trainerid;
        string trainername;

        public HashCodeDemo(int trainerid, string trainername)
        {
            this.trainerid = trainerid;
            this.trainername = trainername;
        }

        public override int GetHashCode()
        {

            return HashCode.Combine(Trainername, Trainerid);
        }

        public override bool Equals(object obj)
        {
            HashCodeDemo t2 = (HashCodeDemo)obj;
            return this.Trainerid == t2.Trainerid && this.Trainername == t2.Trainername;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public object this[int i]
        {
            get
            {
                if (i == 0)
                    return trainerid;
                if (i == 1)
                    return trainerid;
                if (i == 2)
                    return trainerid;
                else
                    return trainerid;
            }
            set
            {

            }
        }

        public string Trainername { get => Trainername; set => Trainername = value; }
        public int Trainerid { get => trainerid; set => trainerid = value; }

    }
    class TrainerTest
    {
        static void Main(string[] args)
        {
            HashCodeDemo t1 = new HashCodeDemo(1, "deepa");

            HashCodeDemo t2 = new HashCodeDemo(1, "deepa");

            Console.WriteLine(t1.GetHashCode()); Console.WriteLine(t2.GetHashCode());

            Dictionary<HashCodeDemo, int> d = new Dictionary<HashCodeDemo, int>();
            d.Add(new HashCodeDemo(1, "deepa"), 9000);
            d.Add(new HashCodeDemo(1, "deepa"), 9000);
            d.Add(new HashCodeDemo(1, "Deepa"), 9000);

            Console.WriteLine(d.Count);

            foreach (KeyValuePair<HashCodeDemo, int> ob in d)
            {
                Console.WriteLine(ob.Key + "---->" + ob.Value);
            }
        }
    }
}


    




