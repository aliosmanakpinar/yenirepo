using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVeriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("helo world");

            double number5 = 10.4;
            decimal number6 = 10.482394240830932093480238m;
            char character = 'a';
            bool condition = false;
            byte number4 = 255;
            short number3 = -32768;
            int number1 = 1000;
            long number2 = 2137483647;
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("number3 is {0}", number3);
            Console.WriteLine("number4 is {0}", number4);
            Console.WriteLine("character is : {0}", (int)character);
            Console.WriteLine("number is {0}", number5);
            Console.WriteLine("number6 is {0}", number6);
            Console.WriteLine("Number8 is {0}",(int)Days.Friday);
            Console.WriteLine("Number7 is {0}", number7);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday=1,Tuesday, Wednesday,Thursday,Friday,Saturday,Sunday
    }
        
}
