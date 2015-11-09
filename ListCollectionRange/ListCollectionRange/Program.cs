using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListCollectionRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer() { ID = 1, Name = "Sowmya", Type = "Ncustomer" };
            Customer cust2 = new Customer() { ID = 5, Name = "Mukund", Type = "Ncustomer" };
            Customer cust3 = new Customer() { ID = 3, Name = "Vishnu", Type = "Ccustomer" };
            Customer cust4 = new Customer() { ID = 4, Name = "Jaya", Type = "Ccustomer" };
            List<Customer> Ncustomers = new List<Customer>();
            Ncustomers.Add(cust1);
            Ncustomers.Add(cust2);
            List<Customer> Ccustomers = new List<Customer>();
            Ccustomers.Add(cust3);
            Ccustomers.Add(cust4);
            Ncustomers.AddRange(Ccustomers);
            foreach (Customer c in Ncustomers)
	        {
                Console.WriteLine("ID ={0} Name = {1} TYpe ={2}", c.ID, c.Name, c.Type);

	        }
            List<Customer> customers= Ccustomers.GetRange(0,2);
            foreach (Customer c in customers)
            {
                Console.WriteLine("ID ={0} Name = {1} TYpe ={2}", c.ID, c.Name, c.Type);

            }
            //Ccustomers.InsertRange(2, Ccustomers);
            //Ncustomers.RemoveAll(x => x.Type == "CCustomers"); removes items which match the condition.

            List<int> numbers = new List<int>() { 2, 4, 1, 8, 3 };//when we goto definition if int we see that it has implemented interface Icomparable hence sort works on int without we providing a definition for sort.
            numbers.Sort();//this will sort numbrs in as
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
             }
            numbers.Reverse();//will arrange numbers in descending order.

            List<string> alphas = new List<string>() { "d", "g", "x", "k", "q", "v" };
            alphas.Sort();//will sort the alphabets in ascending order.

            Ccustomers.Sort();//this calls the CompareTo method which belongs to interface IComparable.
            Console.WriteLine("After IComparable sorting");
            foreach (Customer c in Ccustomers)
            {
                Console.WriteLine("ID ={0} Name = {1} TYpe ={2}", c.ID, c.Name, c.Type);

            }

            SortbyType sorty = new SortbyType();//this is needed for the IComparer interface for which the class SortByType is created.
            Ncustomers.Sort(sorty);
           // Ncustomers.Sort((x, y) => x.ID.CompareTo(y.ID));
            Console.WriteLine("After IComparer sorting");
            foreach (Customer c in Ncustomers)
            {
                Console.WriteLine("ID ={0} Name = {1} TYpe ={2}", c.ID, c.Name, c.Type);

            }
            Comparison<Customer> compcusts = new Comparison<Customer>(Comparisoncust);//1.
            Ncustomers.Sort(compcusts);//2.
            // Ncustomers.Sort((x, y) => x.Type.CompareTo(y.Type)); this statement alone is enough as against statements 1.,2.,3.,4.,5.
        }

        private static int Comparisoncust(Customer x, Customer y)//3.
        {
            return x.Type.CompareTo(y.Type);//4.
        }
    }

    public class SortbyType : IComparer<Customer>//IComparer is used when the cannot mention IComparable say because we dont own the class Customer.
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Type.CompareTo(y.Type);

        }
    }
    public class Customer:IComparable<Customer>
    {
        public int ID { set; get; }
        public string Name {set;get;}
        public string Type{set;get;}

        public int CompareTo(Customer obj)
        {
            return this.Name.CompareTo(obj.Name);

        }
    }

}
