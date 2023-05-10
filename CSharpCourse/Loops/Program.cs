using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int number = 100;
            //while (number>=0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //int number = 10;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //} while (number >= 8);

            //for (int i = 100; i >= 0 ; i=i-2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Finished!!");



            //i=i+2 yazarak sadece tek sayıları yazdırabiliriz.

            string[] student2 = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in student2)
            {

                Console.WriteLine(student);
            }
            Console.ReadLine();
        }

    }
}
