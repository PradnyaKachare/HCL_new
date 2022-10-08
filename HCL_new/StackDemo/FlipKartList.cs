using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.StackDemo
{
    /*18.	Flipkart maintains a list<order> from different places.Order has
    (orderid, city, itemname, status). From this create a Dictionary which
    stores key has cityname and count as no of order’s pending in that city.
    Data should be sorted according to city*/

    class Order
    {
        int orderid;
        string city, itemname, status;

        public Order(int orderid, string city, string itemname, string status)
        {
            this.Orderid = orderid;
            this.City = city;
            this.Itemname = itemname;
            this.Status = status;
        }

        public int Orderid { get => orderid; set => orderid = value; }
        public string City { get => city; set => city = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        public string Status { get => status; set => status = value; }

        public override int GetHashCode()
        {
            return HashCode.Combine(orderid, city, itemname, status);
        }

       
    }
    class FlipKartList
    {

        static void Main(string[] args)
        {
            List<Order> s = new List<Order>();
            s.Add(new Order(1,"Pune","watch","Pending"));
            s.Add(new Order(2,"Pune","tv","Delivered"));
            s.Add(new Order(3,"Solapur","Mobile", "Delivered"));
            s.Add(new Order(4,"Shirur","fan", "Pending"));

            foreach (Order or in s)
            {
               /* KeyValuePair<Order, int> kv = KeyValuePair<Order, int>;
                 Console.WriteLine(kv.Key + "==>" + kv.Value);*/
            }

        }
    }
}
