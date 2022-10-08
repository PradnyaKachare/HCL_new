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
                name = (string)value;                
                percentage = (int)value;
            }
        }

        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public int Percentage { get => percentage; set => percentage = value; }
        public int V1 { get; }
        public string V2 { get; }
        public int V3 { get; }

        public StudentList(string name, int rollno, int percentage)
        {

            this.rollno = rollno;
            this.name = name;
            this.percentage = percentage;
        }

        public StudentList()
        {

        }

        public StudentList(int v1, string v2, int v3)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
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
           /* s1[0] = 201;
            s1[1] = "Jiya";
            s1[2] = 89;*/
            //set propertyy

           /* foreach (StudentList student in s1)
            {
                Console.WriteLine(student);
            }*/
        }
    }
}
