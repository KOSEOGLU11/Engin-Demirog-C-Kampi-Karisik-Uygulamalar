using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        //item=eleman

        T[] items;
        //constructor oluştu
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // geçiçi array oluşturduk. Çünkü eleman sayısını arttırınca önceki yazdığımız elemanlae kayboluyor.
            items = new T[items.Length+1];  //eleman sayısı arttı

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
       
    }
}
