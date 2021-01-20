using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {




            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c++";
            kurs1.KursunEgitmeni = "engin demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.KursunEgitmeni = "kerem";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.KursunEgitmeni = "berkay";
            kurs3.IzlenmeOrani = 8;


            

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.KursunEgitmeni);

            }





        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
