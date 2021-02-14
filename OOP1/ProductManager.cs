using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation = aşağıya 50 tane kategori geçmek yerine ( int kategori ıd felan diye) classlar yapıp onları göndermek 
        public void Add(Product product) //burdaki product şu demek: sen bana product türünde bir şey göndereceksin, ben onu tutacağım. Diğer dosyalarda açtığımın içinde product adı altında tanımladıklarımı istiyor yani.
                                         //yukardaki satıra gelir yani 101 olur
                                         //Dolayısıyla 101 yerinde bulunan ürünün ismini kamera yaptın.
        {
            //product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + "eklendi.");

        }
        //public void BiseyYap(int sayi)
        //{
            //sayi = 99;
        //}
        // void şu demek: git ekle, git güncelle felan ve o işlemini yapıyor bitiryor.
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");

        }

        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
        // voidle de yazsam intle de yazsam sonuç çıkar. Ama ben çıkan o sonucu voidde kullanamam
        //Çünkü void yap-bitirdir ama intle yani returnle yaptığımı tekrar çağırıp kullanırım. Bankacılıkta felan da gerekli olan budur, bu kullanılır.


    }
}
