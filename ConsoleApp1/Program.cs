using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMüsteri müster1 = new GercekMüsteri();
            müster1.MusteriNo = "12345";
            müster1.Adi = "Engin";
            müster1.Soyadi = "Demiroğ";
            müster1.TcNo = "12345678911";
            müster1.Id = 1;

            //Kodlama.io girişi
            TüzelMüsteri müsteri2 = new TüzelMüsteri();
            müsteri2.Id = 2;
            müsteri2.MusteriNo = "4567";
            müsteri2.SirketAdi = "kodlama.io";
            müsteri2.VergiNo = "98746";


            Musteri müsteri3 = new GercekMüsteri(); //new bellekteki referans nosu
            Musteri müsteri4 = new TüzelMüsteri(); //Musteri classı hem gercek hem tüzel müsterinin referansını tuabiliyor.

            CustomerManager müsteriManager = new CustomerManager();
            müsteriManager.Add(müster1);
            müsteriManager.Add(müsteri2);


           
           
      }
    }
}
