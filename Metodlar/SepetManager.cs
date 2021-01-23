using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //normal parantez () varsa orda metot vardır.
        //syntax-yazım şekilleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : "+urun.Adi);
        }

       public void Ekle2(string urunAdi, string acıklama, double fiyat,int stokAdedi)
        { } 
    }
}
