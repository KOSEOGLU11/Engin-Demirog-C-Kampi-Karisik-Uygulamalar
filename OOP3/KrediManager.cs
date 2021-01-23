using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager //genelde operasyonel sınflarda interface kullanılır
    {
        //bankada olması gereken metodlar bunlar. Her kredi türü bunu içerir.
         void Hesapla();
        void BiseyYap();

        //interface leri birbirinin alternatifleri olan ama kod içerikleri farklı olna durumlar için kullanılır.
        
    }
}
