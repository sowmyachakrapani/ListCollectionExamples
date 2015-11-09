using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListCollectionexp
{
    class Program
    {
        static void Main(string[] args)
        {
            string struserchoice = string.Empty;

            Country country1 = new Country() { Code = "IND", Name = "India", Capital = "Delhi" };
            Country country2 = new Country() { Code = "USA", Name = "United States", Capital = "Washington" };
            Country country3 = new Country() { Code = "UK", Name = "United Kingdom", Capital = "Londom" };
            Country country4 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };
            List<Country> listcountries = new List<Country>();
            listcountries.Add(country1);
            listcountries.Add(country2);
            listcountries.Add(country3);
            listcountries.Add(country4);
            do
            {
                Console.WriteLine("Please enter the country code");
                string strcountrycode = Console.ReadLine().ToUpper();
                Country selectedcountry = listcountries.Find(country => country.Code == strcountrycode);//lambaexpression
                Country selectcountry = listcountries.Find(delegate(Country C) { return C.Code == strcountrycode; });//anonymous method
                Console.WriteLine("selectcountry" + selectcountry.Code);
                Func<int, int, string> funcdel = (fn, sn) => "sum =" + (fn + sn).ToString();
                string result = funcdel(10, 20);
                Console.WriteLine(result); //Using func delegate.
                
                if (selectedcountry == null)
                {
                    Console.WriteLine("Please enter proper code");
                }
                else
                {
                    Console.WriteLine("Code={0}, Name={1},Capital={2}", selectedcountry.Code, selectedcountry.Name, selectedcountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you wanna continue YES or NO");
                    struserchoice = Console.ReadLine().ToUpper();
                } while (struserchoice != "YES" && struserchoice != "NO");

            } while (struserchoice == "YES");

        }
    }

    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        
    }
}
