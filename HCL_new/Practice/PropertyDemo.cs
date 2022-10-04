using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Practice
{
    class Vehicle
    {
        string nm;
        int cost;
        public string Nm
        {
            get { return nm; }
            set { nm = value; }
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
    class PropertyDemo
    {
        string name;
        string email;
        Vehicle v;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Vehicle V
        {
            get { return v; }
            set { v = value; }
        }
        static void Main(string[] args)
        {
            PropertyDemo p = new PropertyDemo();
            p.Name = "Pradnya";
            p.Email = "Pradnyakore99@gmail.com";

            Vehicle vl = new Vehicle();
            p.v = vl;

            p.v.Nm = "BMW";
            p.v.Cost = 80000;

            Console.WriteLine(p.Name + " \t " + p.Email + " \t " + p.v.Nm + " \t " + p.v.Cost);


        }
    }

}
