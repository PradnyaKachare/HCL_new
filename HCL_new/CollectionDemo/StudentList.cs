using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.CollectionDemo
{
    class StudentList
    {
        int rollno;
        string name;
        int percentage;
        public object this[int index] //annother prg
        {
            get
            {
                if (index == 0)
                    return rollno;
                if (index == 1)
                    return name;
                if (index == 2)
                    return percentage;
                else
                    return null;
            }
            set
            {
                rollno = (int)value;
                //name = (string)value;                
                percentage = (int)value;
            }
        }
        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public int Percentage { get => percentage; set => percentage = value; }
        public StudentList(string name, int rollno, int percentage)
        {

            this.rollno = rollno;
            this.name = name;
            this.percentage = percentage;
        }

        public StudentList()
        {

        }
        public override string ToString()       //tostring method
        {
            //return base.ToString();
            return $"Rollno: { Rollno} Name: {Name} Percentage:{ percentage}";
        }
        static void Main(string[] args)
        {
            StudentList s1 = new StudentList("priya", 101, 90);
            Console.WriteLine("student List:");
            Console.Write(s1[0]);
            Console.Write(s1[1]);
            Console.WriteLine(s1[2]);
            s1[0] = 201;                    //set propertyy
        }
    }
}
