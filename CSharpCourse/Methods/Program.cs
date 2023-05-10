using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2(20,30,40);
            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);
            //int ali = 20;
            //int apo = 10;
            //int batu = 60;
            //var toplamlar = Add4(ali , batu , apo);

            //Console.WriteLine("Ali+Batu+Apo {0}" , toplamlar);
            //int sayı1 = 10;
            //int sayı2 = 20;
            //int sayı3 = 30;
            //var result5 = add5(sayı1, sayı2, sayı3);
            //Console.WriteLine(result5);
            //Console.WriteLine(sayı1);
            //Console.WriteLine(sayı2);


            //var sonuç = çarpma(2, 5);
            //Console.WriteLine(sonuç * 8);
            //Console.WriteLine(sonuç);
            //Console.WriteLine(çarpma(2, 5, 8));
            var sayi0 = 15;
            Console.WriteLine(sayi0);
            add6(15);
            Console.WriteLine(sayi0);
            add7(ref sayi0);
            Console.WriteLine(sayi0);

            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("added!!!");
        }
        static int Add2(int number1, int number2, int number3)
        {
            var result = number1 + number2 + number3;
            return result;

        }
        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
            //Ref ile outun arasındaki tek fark ref kullanacağımız sayının değeri olmak zorundadır , 
            //Out kullanacağımız sayının değeri olmasa da bir problem olmaz.

        }
        static int Add4(int ali, int batu, int apo)
        {

            return ali + batu + apo;

        }
        static int çarpma(int sayı1, int sayı2)
        {
            return sayı1 * sayı2;
        }
        static int çarpma(int sayı1, int sayı2, int sayı3)
        {
            return sayı1 * sayı2 * sayı3;
        }
        static int add5(int sayı1, int sayı2, int sayı3)
        {
            sayı1 = 30;
            sayı2 = 30;
            return sayı1 + sayı2 + sayı3;
        }
        static void add6(int sayi1)
        {
            sayi1= 20;
        }
        static void add7(ref int sayi2)
        {
            sayi2= 10;
        }


    }
}
