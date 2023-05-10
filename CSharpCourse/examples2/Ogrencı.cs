using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace examples2
{
    internal class Ogrencı
    {
        private string isim;

        private string soyisim;

        private int yas;

        private string okulismi;

        private int sınavnotu;

        public double sınav1;
        public double sınav2;
        public double sınav3;



        public Ogrencı(string _isim, string _soyisim, int _yas, string _okulismi, int _sınavnotu)
        {
            isim = _isim;
            soyisim = _soyisim;
            yas = _yas;
            okulismi = _okulismi;
            sınavnotu = _sınavnotu;
        }
        public void ogrencıBılgılerınıGoster()
        {
            Console.WriteLine("Öğrencinin İsmi : " + isim);
            Console.WriteLine("Öğrencinin Soyismi : " + soyisim);
            Console.WriteLine("Öğrencinin Yası : " + yas);
            Console.WriteLine("Öğrencinin okudugu okulun ismi : " + okulismi);
            Console.WriteLine("Öğrencinin Sınav notu : " + sınavnotu);
        }

        public double sınavOrtalaması()
        {
            double ortalama = (sınav1 + sınav2 + sınav3) / 3;
            return ortalama;
        }
    }
}
