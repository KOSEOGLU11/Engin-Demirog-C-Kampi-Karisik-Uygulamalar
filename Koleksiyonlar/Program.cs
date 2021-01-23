using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //new yaptığımız zaman bellekte yeni bir adres oluşur

            //string[] isimler = new string[] { "engin", "murat", "furkan", "merve" };
            //console.writeline(isimler[0]);
            //console.writeline(isimler[1]);
            //console.writeline(isimler[2]);

            //isimler = new string[5];
            //isimler[4] = "ilker";
            //console.writeline(isimler[4]);


            List<string> isimler2 = new List<string>() { "engin", "murat", "furkan", "merve" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
