﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 211;
            if (number == 10)
            {
                Console.WriteLine("number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 110");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;

                default:
                    Console.WriteLine("number is not 10 or 20");
                    break;


                    if (number >= 0 && number <= 100)
                    {
                        Console.WriteLine("Number is between 0-100");
                    }
                    else if (number > 100 && number <= 200)
                    {
                        Console.WriteLine("number is between 101-200");
                    }
                    else if (number > 200 || number < 0)
                    {
                        Console.WriteLine("number is less then 0 or greater than 200");
                    }
                    else
                    {
                        Console.WriteLine("Number is not between 0-100");
                    }

                    Console.ReadLine();
            }
        }
    }
}
