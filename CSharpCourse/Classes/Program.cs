using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.city = "Ankara";
            customer.Id = 1;
            customer.FirstName = "engin";
            customer.LastName = "demiroğ";

            Customer customer2 = new Customer
            {
                Id = 2,
                city = "istanbul",
                FirstName = "ali",
                LastName = "akpınar"
            };
            Console.WriteLine(customer2.FirstName);




            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("customer added!");
        }
        public void Update()
        {
            Console.WriteLine("customer updated!");
        }
    }
    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("product added!");
        }
        public void Update()
        {
            Console.WriteLine("product updated!");
        }
    }
}
