using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;



namespace HCL_new.Exception_handlingDemo
{
    class InvalidUserExp : ApplicationExceptionException
    {
        public InvalidUserExp(string msg) //:base(msg)
        {

        }

        public override string ToString()
        {
            return "Alphabets only allowed";
        }
    }
    class Utest
    {
        static void Main(string[] args)
        {
            User u = new User();
            /* try
             {
                 u.name = "Pradnya123";
             }
             //catch (InvalidUserNameException e)
             {
                 Console.WriteLine(e);
             }
             u.password = "xyz";
             Console.WriteLine(u);*/
        }
    }
    class User
    {
        // public string name;
        // public string password;

        /* public string Name 
         {*/
        /* set 
         {
             bool isvalid = true;
             for(int i=0;i<value.Length;i++)
             {
                 if(!char.IsLetter(value[i]))
                 {
                     isvalid = false;
                     break;
                 }
             }*/
        /*  if(isvalid)
          {
              this.name = value;

          }
          else
          {
              throw new InvalidUserNameException("User name contain only alphabet");
          }*/
        /*      
          }
          get { return name; }
      }
*/
        //  public string Password  

    }

}








