using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Exception_handlingDemo
{
    class TrainerException
    {
        string name;
        int experience;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Experience
        {
            get { return experience; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    experience = value;
                }

            }

        }
        static void Main(string[] args)
        {

            TrainerException t = new TrainerException();

        }

    }
}
