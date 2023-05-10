using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopAdam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] sozcukler = { "DOLAP", "KALEM", "SANDALYE", "MASA", "KULAKLIK", "DEMIR", "BILEKLIK", };
            Random rnd = new Random();
            int kelime = rnd.Next(sozcukler.Length);
            
            int hak = 3;
            int kontrol = 0;
            Console.WriteLine("Hakkınız = {0}", hak);

            char[] yazdirilanKelime = new char[sozcukler[kelime].Length];


            for (int i = 0; i < sozcukler[kelime].Length; i++)
            {
                yazdirilanKelime[i] = '-';

            }
            Console.Write(yazdirilanKelime);
            Console.WriteLine();

            while (yazdirilanKelime.Contains('-'))
            {

                Console.Write("Bir harf giriniz : ");
                char girilenHarf = Convert.ToChar(Console.ReadLine().ToUpper());



                for (int i = 0; i < sozcukler[kelime].Length; i++)
                {

                    if (!sozcukler[kelime].Contains(girilenHarf))
                    {
                        Console.WriteLine("Girdiginiz harf kelimede bulunmamaktadır.");
                        hak--;
                        Console.WriteLine("Kalan hak = {0}", hak);
                        break;
                    }


                    else if (sozcukler[kelime][i] == girilenHarf)
                    {
                        yazdirilanKelime[i] = sozcukler[kelime][i];
                        kontrol++;
                    }


                }
                if (hak == 0)
                {
                    Console.WriteLine("Tüm haklarınız bitti , kaybettiniz :(:(:(:(:(:(");
                    break;
                }

                else if (sozcukler[kelime].Length == kontrol)

                {
                    Console.WriteLine(yazdirilanKelime);
                    Console.WriteLine("Tebrikler oyunu kazandınız. :):):):):):)");
                    break;
                }

                Console.WriteLine(yazdirilanKelime);

            }
            

            Console.ReadKey();
        }

    }

}

