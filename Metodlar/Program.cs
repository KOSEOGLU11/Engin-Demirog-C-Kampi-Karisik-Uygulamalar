using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyat = 15;
            string acıklama = "Amasya Elması";


            string[] meyveler = new string[] { };

            Urun urun1= new Urun();
            urun1.Adi = "elma";
            urun1.Acıklama = "amasya elması";
            urun1.Fiyatı = 15;

            Urun urun2 = new Urun();

            urun2.Adi = "karpuz";
            urun2.Acıklama = "diyarbakır kapruzu";
            urun2.Fiyatı = 80;

            Urun[] urunler = new Urun[] { urun1,urun2}; // ürün arrayi oluşturduk.

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine("*******************");
            }
            Console.WriteLine("**************Metotlar***********");

            // instance- örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 15,10);
            sepetManager.Ekle2("erik", "yeşil erik", 10,9);
            sepetManager.Ekle2("karpuz", "tatlı", 19,8);






        }
    }
}
