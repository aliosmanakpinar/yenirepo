using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string city = "ankara";
            //Console.WriteLine(city[0]);
            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);
            //}
            //string city2 = "istanbul";
            //string result = city + city2;
            //Console.WriteLine(result);
            //    Console.ReadLine();

            string sentence = "My name is Engin Demiroğ";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "my name is aliosman";

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("my name");

            var result5 = sentence.IndexOf("name");//index of bize cümlenin kaçıncı karakterden başladığını gösterir.
            var result6 = sentence.IndexOf("");
            var result7 = sentence.LastIndexOf("name");
            var result8 = sentence.Insert(0, "Hello, ");//cümleye bir şey eklemek için kullanılır
            var result9 = sentence.Substring(3);//cümleyi parçalamak için kullanılır.
            var result10 = sentence.ToLower();//cümledeki tüm harfleri küçük harflere dönüştürür
            var result11 = sentence.ToUpper();//cümledeki tüm karakterleri büyük harfe çevirir.
            var result12 = sentence.Replace(" ", "-") ;//cümle içindeki kelimeleri başka bir kelimeyle değiştirmek için kullanılır.
            var result13 = sentence.Remove(2);//cümledeki karakterleri kaldırmak için kullanılır.


            Console.WriteLine(result13);
            Console.ReadLine();
        }
    }
}
