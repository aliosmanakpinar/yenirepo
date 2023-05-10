using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a Prime Number");
            }
            else
            {
                Console.WriteLine("This is a not Prime Number");
            }



            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    
                    
                }
            }
            return result;
        }


    }
}

