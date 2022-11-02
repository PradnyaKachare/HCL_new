using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Practice
{
    internal class InterfaceDem
    {
        static void Main(string[] args)
        {
            IOrder order = new Transaction();
            Console.WriteLine(order.DisplayDetails());

            ICustomer customer = new Transaction();
            Console.WriteLine(customer.DisplayDetails());
        }

    }
    public interface IOrder
        {
            string DisplayDetails();
        }
        public interface ICustomer
        {
            string DisplayDetails();
        }

        public class Transaction : IOrder, ICustomer
        {
            string IOrder.DisplayDetails()
            {
                return "Order details";
            }

            string ICustomer.DisplayDetails()
            {
                return "Customer details";
            }
        }     
}
