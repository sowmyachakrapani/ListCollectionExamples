using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listcollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer() { ID = 1, Name = "Sowmya", Gender = "Female" };
            Customer cust2 = new Customer() { ID = 2, Name = "Mukund", Gender = "Male" };
            Customer cust3 = new Customer(){ID= 3,Name ="Vishnu", Gender = "Male"};
            List<Customer> customers = new List<Customer>();
            customers.Add(cust1);
            customers.Add(cust2);
            customers.Add(cust3);
            
            foreach (Customer c in customers)
            {
                Console.WriteLine("id={0} , Name ={1},Gender={2}", c.ID, c.Name, c.Gender);

            }
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("id={0} , Name ={1},Gender={2}", customers[i].ID, customers[i].Name, customers[i].Gender);
            }
            customers.Insert(3, cust1);
            Console.WriteLine("Index of cust2= {0}",customers.IndexOf(cust2));
            Console.WriteLine("Index of cust1= {0}", customers.IndexOf(cust1,1,3));
            foreach (Customer c in customers)
            {
                Console.WriteLine("id={0} , Name ={1},Gender={2}", c.ID, c.Name, c.Gender);

            }
            if (customers.Contains(cust3))
            {
                Console.WriteLine("cust3 exists");
            }
            if(customers.Exists(cust=>cust.Name.StartsWith("S")) )       
            {
                Console.WriteLine("Name starting with S exits");
            }
            Customer ct = customers.Find(cust => cust.Name == "Sowmya");
           List<Customer> cts =  customers.FindAll(cust => cust.Name == "Sowmya");
           foreach (Customer cy in cts)
           {
               Console.WriteLine("id={0} , Name ={1},Gender={2}", cy.ID, cy.Name, cy.Gender);
           }

           Customer[] cuts = new Customer[3];
           cuts[0] = cust1;
           cuts[1]=cust2;

           List<Customer>  listcust = cuts.ToList();//converting array to list
           Customer[] custarray = customers.ToArray();//this is converting a list to an array.
           Dictionary<int, Customer> dictcustomer = customers.ToDictionary(x => x.ID); //converting a list to a dictionary.To Dictionary has 4 overloads.

            }
    }
    public class Customer
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Gender { set; get; }


    }
}
