using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace examples2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrencı ogrencı = new Ogrencı("Ali", "Akpınar", 20, "AOF" , 85);
            ogrencı.sınav1 = 75;
            ogrencı.sınav2 = 80;
            ogrencı.sınav3 = 95;
            ogrencı.ogrencıBılgılerınıGoster();
            Console.WriteLine("Ögrencının Sınav ortalaması = " + ogrencı.sınavOrtalaması());

            Console.ReadLine();
        }
    }
}
