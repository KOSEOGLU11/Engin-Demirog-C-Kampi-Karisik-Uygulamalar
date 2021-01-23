using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Coorparate
    //Miras-inheritance
    class TüzelMüsteri:Musteri
    {
        public string SirketAdi { get; set; } //matematiksel işlem yapmıyorsan metinsel olarak planla

        public string VergiNo { get; set; } //Eğer bir nesnede bir değeri kullanmak zorunda değilsen orda soyutlama hatası var
        public int Id { get; set; }
        public string MusteriNo { get; set; }

    }
}
