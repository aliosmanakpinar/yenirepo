using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacess
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    interface IPerson
    {
        int Id { get; set; }
        int FirstName { get; set; }
        int LastName { get; set; }

    }
    class Customer:IPerson
    {
        int Id { get; set; }
        int FirstName { get; set; }
        int LastName { get; set; }
        public string Address { get; set; }
    }
    class Student:IPerson
    {
        int Id { get; set; }
        int FirstName { get; set; }
        int LastName { get; set; }
        public string Departmand { get; set; }

    }
    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName);
        }
    }
}
