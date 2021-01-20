using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazilim geliştirme kursu";
            string kurs2 = "programlamaya başlangıç kursu";
           

            //array dizi

            string[] kurslar = new string[] { "yazilim geliştirme kursu" , "programlamaya başlangıç kursu" };



     
            //in kurslar demek kursları dolaş demek
             //foreach dizillere uygulanır.

            foreach (string kurs in kurslar)
            {

                Console.WriteLine(kurs);
            }
        }
    }
}
