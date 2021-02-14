using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //böyle yazabilirim ayrıyetten şu şekilde de yazabilirim.

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };


            //case sensitive = c# küçük-büyük harfe duyarlı
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager(); //101 olursa
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); //diye yazarsam ismi değişir. Diğer sayfada farklı isim verdiğim için

            //int sayi = 100;
            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi); //100 bir üst satırda sayıyı diğer sayfaya gönderiyorum burayla ilgisi yok yani burda sayi ne dersem burda sayı ne dersem buraya yazdırdığm çıkar.

            //int,double,bool...değer tip
            //diziler,class,abstract class, interface... referans tip

            //productManager.Topla2(3, 6);

            //int toplamaSonucu = productManager.Topla(3, 6);

            //Console.WriteLine(toplamaSonucu*2); // mesela şimdi geri çağırdım, toplam sonucunu 2 ile çarptım.
            //Console.WriteLine(productManager.Topla(3, 6) * 2); böyle yazsam da çalışır.

             

        }
    }
}
