using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayı1, sayı2, toplam;
            //Console.Write("1.Sayı ="); 
            //sayı1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.Sayı =");
            //sayı2 = Convert.ToInt32(Console.ReadLine());
            //toplam = sayı1 + sayı2;
            //Console.Write("{0} ve {1} sayılarının toplamı = {2}", sayı1,sayı2,toplam);

            //double sayı3, sayı4, ekleme, çıkartma, çarpma, bölme;
            //Console.Write("1. Sayı =");
            //sayı3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2. Sayı =");
            //sayı4= Convert.ToDouble(Console.ReadLine());
            //ekleme = sayı3 + sayı4;
            //çıkartma = sayı3 - sayı4;
            //çarpma = sayı3 * sayı4;
            //bölme = sayı3 / sayı4;
            //Console.WriteLine("{0} ve {1} Sayılarının toplamı = {2}",sayı3 , sayı4 , ekleme);
            //Console.WriteLine("{0} ve {1} Sayılarının Farkı = {2}", sayı3 , sayı4 , çıkartma);
            //Console.WriteLine("{0} ve {1} Sayılarının çarpımı = {2}", sayı3 , sayı4 , çarpma);
            //Console.WriteLine("{0} ve {1} Sayılarının bölümü = {2}", sayı3 , sayı4 , bölme);

            //double sayı1, sonuç;
            //Console.Write("Bir sayı giriniz =");
            //sayı1 = Convert.ToDouble(Console.ReadLine());
            //sonuç = sayı1 * 18 / 100;
            //Console.WriteLine("Girilen sayının %18 i = {0}", sonuç);

            //double sayı1, yüzde, sonuç;
            //Console.Write("Bir sayı giriniz =");
            //sayı1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Girdiğiniz sayının yüzdesini giriniz =");
            //yüzde = Convert.ToDouble(Console.ReadLine());
            //sonuç = sayı1 * yüzde / 100;
            //Console.WriteLine("{0} sayısının %{1} = {2} ", sayı1 , yüzde , sonuç);

            //double sayı1, karoranı, satış;
            //Console.Write("Bir Sayı Girin =");
            //sayı1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Bir kar oranı girin=");
            //karoranı= Convert.ToDouble(Console.ReadLine());
            //satış = sayı1 * karoranı / 100 + sayı1;
            //Console.Write("Girilen sayının %{0} karla satış fiyatı = {1}", karoranı,satış);

            //int uzun, kısa, alan, çevre;
            //Console.Write("Kısa Kenar = ");
            //kısa = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Uzun Kenar = ");
            //uzun= Convert.ToInt32(Console.ReadLine());
            //alan = uzun * kısa;
            //çevre = 2 * (uzun + kısa);
            //Console.WriteLine("Dikdörtgenin Alanı = {0}", alan);
            //Console.WriteLine("Dikdörtgenin Çevresi = {0}", çevre);

            //double radıus, area, perımeter;
            //Console.Write("Dairenin yarıçapını giriniz = ");
            //radıus = Convert.ToDouble(Console.ReadLine());
            //area = 3.14 * radıus * radıus;
            //perımeter = 2 * 3.14 * radıus;
            //Console.WriteLine("Dairenin alanı = {0}", area);
            //Console.WriteLine("Dairenin Çevresi = {0}", perımeter);


            //double sayı1, sayı2;
            //Console.Write("1. Sayıyı Giriniz = ");
            //sayı1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz = ");
            //sayı2 = Convert.ToDouble(Console.ReadLine());

            //if (sayı1 < sayı2)
            //{
            //    Console.WriteLine("2. Sayı büyük");
            //}
            //else if (sayı1 == sayı2)
            //{
            //    Console.WriteLine("İki sayı eşit");
            //}
            //else
            //{
            //    Console.WriteLine("1. sayı buyuk");
            //}


            //int sayı;
            //Console.Write("Bir Sayı giriniz : ");
            //sayı = Convert.ToInt32(Console.ReadLine());

            //if (sayı < 0)
            //{
            //    Console.WriteLine("Bu Sayı negatif bir sayıdır.");
            //}
            //else
            //{
            //    Console.WriteLine("Bu sayı pozitif bir sayıdır.");
            //}



            //double sayı;
            //Console.Write("Bir sayı giriniz = ");
            //sayı = Convert.ToDouble(Console.ReadLine());
            //if (sayı > 0 && <= 100)
            //{
            //    Console.WriteLine("Bu sayı 0-100 aralığındadır.");
            //}
            //else
            //{
            //    Console.WriteLine("Bu sayı 0-100 aralığında değildir.");
            ////}

            //double r1, r2, r3, rt;
            //int secim;
            //Console.Write("R1 = ");
            //r1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("R2 = ");
            //r2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("R3 = ");
            //r3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("******************");
            //Console.WriteLine("1- Seri");
            //Console.WriteLine("2- Paralel");
            //Console.Write("Bir seçim Yapınız = ");

            //secim = Convert.ToInt32(Console.ReadLine());

            //if (secim==1)
            //{
            //    rt = r1 + r2 + r3;
            //    Console.WriteLine("Seri bağlanan dirençlerin toplamı = {0} Ohm", rt);
            //}
            //else if (secim==2)
            //{
            //    rt = (r1 / 3) + (r2 / 3) + (r3 / 3);
            //    Console.WriteLine("Paralel bağlanan dirençlerin toplamı = {0} Ohm", rt);
            //}
            //else 
            //{
            //    rt = -1;
            //    Console.WriteLine("Yanlış seçim yaptınız!");
            //}

            //Console.WriteLine("Eşdeğer Direnç = {0} Ohm", rt);
            //Console.ReadKey();

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i+ "-Merhaba Dünya!");
            //}

            //Console.ReadKey();

            //int sayı , adet = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(i+ ". Sayıyı Giriniz = ");
            //    sayı= Convert.ToInt32(Console.ReadLine());

            //    if (sayı<50)
            //    {
            //        adet++;
            //    }
            //}
            //Console.WriteLine("50 den küçük sayıların adedi : {0}", adet);



            //Console.ReadKey();

            //int sayı , toplam=0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write(i+ ". Sayıyı Giriniz = ");
            //    sayı=Convert.ToInt32(Console.ReadLine());
            //    if (sayı>50)
            //    {
            //        toplam+= sayı;
            //    }
            //}
            //Console.WriteLine("50 den büyük sayıların toplamı = {0}", toplam);
            //Console.ReadKey();


            //Kullanıcının girdiği 5 sayıdan 50′ den büyük olanların toplamını gösteren Console programı

            //int sayı , tekAdet =0 , çiftAdet =0 ;
            //Random rnd = new Random();

            //for (int i = 1; i <= 10; i++)
            //{
            //    sayı = rnd.Next(1, 100);
            //    Console.WriteLine(sayı);
            //    if (sayı%2 ==0)
            //    {
            //        çiftAdet = çiftAdet + 1;

            //    }
            //    else
            //    {
            //        tekAdet = tekAdet + 1;
            //    }
            //}

            //Console.WriteLine("Tek Sayı adedi = {0}", tekAdet);
            //Console.WriteLine("Çift Sayı Adedi = {0}", çiftAdet);
            //Console.ReadKey();

            //Bilgisayar tarafından rastgele tutulan 10 sayıdan 50′ den yukarı olanların ortalamasını bulan Console programı



            //int toplam=0 , sayaç=0 ,sayı;

            //Random rnd=new Random();

            //for (int i = 1; i <= 10; i++)
            //{

            //   sayı= rnd.Next(1 ,100);
            //    Console.WriteLine(sayı);
            //    if (sayı > 50)
            //    {
            //        toplam += sayı;
            //        sayaç++;
            //    }
            //}

            //Console.WriteLine("50 den büyük sayıların ortalaması = {0}", (toplam/sayaç));
            //Console.ReadKey();

            //int sayı, toplam = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("Bir sayı giriniz =");
            //    sayı = Convert.ToInt32(Console.ReadLine());

            //    toplam += sayı;
            //}
            //Console.WriteLine("Sayıların Toplamı = {0}",toplam);
            //Console.ReadLine();

            //Kullanıcıdan başlangıç,bitiş ve artım değeri istenerek, verilen artış miktarına göre başlangıç ve bitiş sayıları arasındaki sayıları ekranda gösteren program



            //int start, end, increasing;
            //Console.Write("Başlangıç sayısı = ");
            //start = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ulaşılacak sayı = ");
            //end = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Artış Miktarı = ");
            //increasing = Convert.ToInt32(Console.ReadLine());

            //for (int i = start; i <= end; i += increasing)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadLine();

            //int[] a = new int[10];
            //a[0] = 0;
            //a[1] = 100;
            //a[2] = 200;
            //a[3] = 300;
            //a[4] = 400;
            //a[5] = 500;
            //a[6] = 600;
            //a[7] = 700;
            //a[8] = 800;
            //a[9] = 900;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("A'nın [{0}]. değeri = {1}" , i , a[i]);
            //}

            //Console.ReadKey();



            //2 den 100'e kadar dolaş
            //dolaştığın sayının asal olup olmadığını bul
            //sayı asalsa ekrana yazdır.



            //// Örnek. Girilen sayının asal olup olmadığını bulan program yazınız.

            //// 1- Kullanıcıdan bir sayı al
            //// 2- Sayının asal olup olmadığını kontrol et
            //// 3- Asalsa ekrana "Sayı asaldır" yazdır, değilse "Sayı asal değildir" yazdır.

            //// 1:
            //var girilenMetin = Console.ReadLine();
            //int girilenSayi = Convert.ToInt32(girilenMetin);
            //// 2:
            //bool sayiAsaldir = true;
            //for (int i = 2; i < girilenSayi; i++)
            //{
            //    if(girilenSayi % i == 0)
            //    {
            //        sayiAsaldir = false;
            //    }
            //}

            //// 3:
            //if (sayiAsaldir)
            //{
            //    Console.WriteLine("Sayı asaldır.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı asal değildir.");
            //}

            // 30.Örnek: Yaş Hesaplama
            // 1 - Kullanıcıdan doğum tarihi al
            // 2 - Bulunduğumuz yıldan kullanıcının doğum tarihini çıkarıp yazdır.

            //    Console.WriteLine(DateTime.Now);
            //    Console.Write("Doğduğunuz ayı giriniz: ");
            //    int girilenDogumAyi = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Doğum yılınızı giriniz: ");
            //    int girilenDogumYili = Convert.ToInt32(Console.ReadLine());
            //    int bulundugumuzAy = DateTime.Now.Month;
            //    int bulundugumuzYil = DateTime.Now.Year;
            //    int yas = bulundugumuzYil - girilenDogumYili;
            //    if(bulundugumuzAy < girilenDogumAyi)
            //    {
            //        yas--;
            //    }
            //    Console.WriteLine($"Yaşınız : {yas}");



            //    Console.ReadKey();
            //}

            //private static int SumOfPrimeNumbers(int number)
            //{
            //    int sum = 0;
            //    for (int i = 2; i < number; i++)
            //    {
            //        if (IsPrimeNumber(i))
            //        {
            //            sum += i;
            //        }
            //    }
            //    return sum;
            //}

            //private static void PrintPrimeNumbers(int number)
            //{
            //    for (int i = 2; i < number; i++)
            //    {
            //        if (IsPrimeNumber(i))
            //        {
            //            // sayı asaldır.
            //            Console.Write(i+",");
            //        }
            //    }
            //    Console.Write("\n");
            //}

            //private static bool IsPrimeNumber(int number)
            //{
            //    var isPrimeNumber = true;

            //    // burada sayının asal olup olmadığını bulan ve asal değilse isPrimeNumber değişkenini false yapan kod
            //    for (int j = 2; j < number; j++)
            //    {
            //        if (number % j == 0)
            //        {
            //            isPrimeNumber = false;
            //        }
            //    }

            //    return isPrimeNumber;
            //

            //kullanıcıdan bir sayı iste
            //kullanıcının girdiği sayının asal olup olmadığını kontrol et 
            //girilen sayı asal ise ekrana "sayı asaldır" yazdır.
            //girilen sayı asal değilse ekrana "sayı asal değildir" yazdır.

            //int kontrol = 0;
            //for (int i = 2; i <= 1000000; i++)
            //{
            //    kontrol = 0;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j ==0)
            //        {
            //            kontrol++;
            //            break;
            //        }
            //    }
            //    if (kontrol == 0)
            //    {
            //        Console.Write(i+"-");
            //    }
            //}

            //Console.ReadKey();

            //kullanıcının girdiği sayının tek mi çift mi olduğunu bulan program 

            //int sayı;
            //Console.Write("Bir sayı girin = ");
            //sayı = Convert.ToInt32(Console.ReadLine());
            //if (sayı % 2 == 0)
            //{
            //    Console.WriteLine("Bu sayı çift sayıdır");
            //}
            //else
            //{
            //    Console.WriteLine("Bu sayı tek sayıdır.");
            //}
            //Console.ReadKey();

            //string metin = "Merhaba Dünya!!! +123";
            //Console.WriteLine(metin+"\n");

            //Console.WriteLine("Bu metinde {0} tane karakter vardır." , metin.Length);
            //Console.ReadKey();

            //string metin = "Merhaba Dünya! +123";
            //Console.WriteLine(metin + "\n");
            //string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
            //               + "abcçdefgğhiıjklmnoöprsştuüvyz";
            //int sayac = 0;  

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (liste.Contains(metin[i]))
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine("Bu metinde {0} tane harf var ." ,sayac);
            //Console.ReadKey();
            //Console.Write("Metin : ");
            //string metin = Convert.ToString(Console.ReadLine());
            //string sesli = "aeıioöuü";
            //int sayac = 0;

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (sesli.Contains(metin[i]))
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine("\n Girilen metinde {0} tane sesli harf vardır ", sayac);
            //Console.ReadKey();


            //Kullanıcının girdiği boy ve ağırlık değerlerine göre vücut kitle indeksini (VKİ=ağırlık/(boy*boy), boy metre cinsinden verilmeli) hesaplayınız.
            //VKİ 18 ile < 25 aralığındaysa normal,
            //VKİ 25 ile < 30 aralığındaysa kilolu,
            //VKİ 30 ve daha yüksekse obez,
            //VKİ 35 ve daha fazlaysa ciddi obez olarak kabul edilir.
            //VKİ’ni hesaplayarak kişinin durumunu yazdırınız.

            //double boy, kilo;
            //Console.Write("Boy : ");
            //boy = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Kilo : ");
            //kilo = Convert.ToDouble(Console.ReadLine());

            //var vki = kilo / (boy * boy);

            //if (vki < 25 && vki >18)
            //{
            //    Console.WriteLine("İdeal");
            //}
            //else if (vki > 25 && vki < 30)
            //{
            //    Console.WriteLine("Kilolu");
            //}
            //else
            //{
            //    Console.WriteLine("Ciddi Obez");
            //}
            //Console.ReadKey();

            //int toplam = 0;
            //Console.Write("n :");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    toplam = 0;
            //        for (int j = 1; j <= i; j++)
            //    {
            //        toplam += j * j;
            //        Console.Write(j + "^2");
            //        if (j != i)
            //        {
            //            Console.Write(" + ");
            //        }
            //        else
            //        {
            //            Console.Write(" = ");
            //        }

            //    }
            //    Console.Write(toplam);
            //    Console.WriteLine();
            //}

            //türkçe , matematik , fizik , edebiyat , geometri , beden , din , resim , tarih



            //    string[,] dersler =
            //    {
            //        {"Pazartesi" , "Matematik" , "Matematik" , "Beden" , "Beden" , "Fizik" , "Fizik" , "Tarih" , "Tarih"  },
            //        {"Salı" , "Turkce" , "Turkce" , "Beden" , "Beden" , "Fizik" , "Fizik" , "Tarih" , "Tarih"  },
            //        {"Carsamba" , "Resim" , "Resim" , "Beden" , "Beden" , "Fizik" , "Fizik" , "Tarih" , "Tarih"  },
            //        {"Persembe" , "Edebiyat" , "Edebiyat" , "Beden" , "Beden" , "Fizik" , "Fizik" , "Tarih" , "Tarih"  },
            //        {"Cuma" , "Matematik" , "Matematik" , "Beden" , "Beden" , "Fizik" , "Fizik" , "Tarih" , "Tarih"  }
            //    };

            //    string k = "*";
            //    int x = 0, y = 3, a = 15;

            //    Console.SetCursorPosition(x, 0);
            //    Console.WriteLine(yıldızla(75, k));
            //    Console.WriteLine("{0} DERS PROGRAMI {0}", yıldızla(30, k));
            //    Console.WriteLine(yıldızla(75, k));


            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 9; j++)
            //        {
            //            Console.SetCursorPosition(x,y);
            //            Console.Write(k + " ");
            //            Console.Write(dersler[i,j]);
            //            y = y + 1;

            //            if (j==0)
            //            {
            //                Console.SetCursorPosition(x,y);
            //                Console.Write(k);
            //                Console.Write(yıldızla(a,k));
            //                y = y + 1;
            //            }
            //        }
            //        y = 3;
            //        x = x + a;
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine(yıldızla(75,k));
            //    Console.WriteLine(yıldızla(75, k));
            //    for (int i = 0; i < 14; i++)
            //    {
            //        Console.SetCursorPosition(x - 1, i);
            //        Console.Write("*");
            //    }

            //    Console.ReadKey();

            //}
            //static string yıldızla(int sayı, string karakter)
            //{
            //    string yazı = "";
            //    for (int i = 0; i < sayı; i++)
            //    {
            //        yazı += karakter;
            //    }
            //    return yazı;
            //}



            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(i+". Sayı = ");
            //    sayı = Convert.ToInt32(Console.ReadLine());


            //    if (sayı % 2 == 0)
            //    {
            //        Console.WriteLine("Sayı çift sayıdır.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayı tek sayıdır.");
            //    }
            //}
            //Console.ReadKey();
            //double sayı1, sayı2 , ıslem ;
            //int secım=0 ;




            //while (secım != 5)
            //{
            //    Console.Write("1. sayıyı girin = ");
            //    sayı1 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("2. sayıyı girin = ");
            //    sayı2 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("--------------------------------");

            //    Console.WriteLine("1. Bolme(/) ");
            //    Console.WriteLine("2. Carpma(*)");
            //    Console.WriteLine("3. Toplama(+)");
            //    Console.WriteLine("4. Cıkarma(-)");
            //    Console.WriteLine("5. Cıkıs");

            //    Console.WriteLine("--------------------------------");

            //    Console.Write("Yapmak istediğiniz işlemi seçin :");
            //    secım = Convert.ToInt32(Console.ReadLine());

            //    if (secım == 1)
            //    {
            //        ıslem = sayı1 / sayı2;
            //        Console.WriteLine("Girdiğniz işlemin sonucunda bulunan deger = {0}", ıslem);
            //    }
            //    else if (secım == 2)
            //    {
            //        ıslem = sayı1 * sayı2;
            //        Console.WriteLine("Girdiğniz işlemin sonucunda bulunan deger = {0}", ıslem);
            //    }
            //    else if (secım == 3)
            //    {
            //        ıslem = sayı1 + sayı2;
            //        Console.WriteLine("Girdiğniz işlemin sonucunda bulunan deger = {0}", ıslem);
            //    }
            //    else if (secım == 4)
            //    {
            //        ıslem = sayı1 - sayı2;
            //        Console.WriteLine("Girdiğniz işlemin sonucunda bulunan deger = {0}", ıslem);
            //    }
            //    else
            //    if (secım == 5)
            //    {
            //        Console.WriteLine("Cıkıs yapılıyor iyi günler dileriz :)");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tanımlı olmayan bir sayı değeri girdiniz.\n");
            //    }

            //}

            //Bilgisayarın tuttuğu random bir sayıyı bulmaya çalıaşım.
            //girdiğimiz sayı bilgisayarın tuttuğu random sayıdan büyükse "Daha küçük" uyarısı ver.
            //girdiğimiz sayı bilgisayarın tuttuğu random sayıdan küçükse "Daha büyük" uyarısı ver.

            int tahmin = 0, pc, pc2, alt = 1, ust = 100, x = 22, y = 0;
            Random rnd = new Random();
            pc = rnd.Next(1, 100);

            pc2 = rnd.Next(alt, ust);

            while (tahmin != pc || pc2 != pc)
            {
                Console.Write("Bir sayı giriniz :");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin < pc)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("|| Girdiğiniz sayı , hedef sayıdan küçük ");
                }
                else if (tahmin > pc)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("|| Girdiğiniz sayı , hedef sayıdan büyük ");
                }
                else if (tahmin == pc)
                {                   
                    Console.WriteLine("Hedef sayıya ulastınız , Tebrikler :)");
                    break;
                }


                pc2 = rnd.Next(alt, ust);
                Console.SetCursorPosition(0,y+1);
                Console.WriteLine("Bilgisayar : {0}", pc2);

                if (pc2 > pc)
                {
                    ust = pc2;
                    pc2 = rnd.Next(alt, ust);
                }
                else if (pc2 < pc)
                {
                    alt = pc2;
                    pc2 = rnd.Next(alt, ust);
                }

                else if (pc2 == pc)
                {
                    Console.WriteLine("Üzgünüm , kaybettiniz :( Bilgisayar kazandı .");
                    break;
                }

                y = y + 2;
                Console.SetCursorPosition(0, y);

            }

            Console.ReadKey();
        }

    }

}
