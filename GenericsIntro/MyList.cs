using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
        //burdaki T type yani string, int vs. olabiliyor
        //diğer sayfada string dedeiğm içi n atık bu t string oldu.
    {
        T[] items; //bu bir dizi
        //ctor yazıp iki kez tab yapınca alttaki kalıp çıkıyor
        //buna constructor deniyor. new lediğin anda çalışan bloğa denir.
        public MyList()
        {
            items = new T[0]; //burda arrayi newliyorum, 0 elelmanlı olarak newliyorum
        }
        public void Add(T item) //burda diziye ekleme yapıyorum
            //eleman ekleyebilmem için bir array in newlenme zorunluluğğu var.
            //items.Length dizinin eleman sayısını verir.
            //temparray geçici dizi demektir.
        {
            T[] tempArray = items; //bunu yazmazsam elemanlarım uçar,numaram değişir 101ken 102 gibi
            //ama bunu yazarsam elemanlarım uçacak diye korkmama gerek yok çünkü bunu yazarak elemanlarımı birine emanet etmiş olurum
            items = new T[items.Length+1]; //dizinin eleman sayısını 1 arttırdım.
            //for yaz taba 2 kez bas, length i temparray.length olarak değiştir.
            for (int i = 0; i < tempArray.Length; i++) //bunun anlamı da şu: arkadaşım bana emanetleri geri versene
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //önceki elemanları almıştım bu işlemle de son elemanımı alıyorum.

        }
    }
}
