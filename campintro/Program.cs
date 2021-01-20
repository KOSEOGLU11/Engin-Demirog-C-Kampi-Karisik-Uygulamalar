using System;

namespace campintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azaliş botonu göster");

            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");

            }
            else
            {
                Console.WriteLine("degismedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
        }
    }
}
