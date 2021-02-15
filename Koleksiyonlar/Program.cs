using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };
            ////stack burası     //heap       //burası değerleri kapsayacak.
           
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //bunları yazarsam olmaz, çünkü array ler yalnızca belirlediğimiz sınırlarda çalışır.
            //İsimler = new string[5]; yazarsam İlker çıkar ekranda ama tekrar
            //Console.WriteLine(İsimler[0]); yazarsam hiçbir şeygelmez. Çünkü ben new diyerek yeni dizi yaptım ve 5. eleman dışındakileri yazmadım yani artık sadece İlker gözükür.

            //dizilere bir şey ekleyemiyoruz o yüzden burda çalışmıyoruz.
            //o yüzden koleksiyonları kullanırız.

            //değer tipler stack i kullanıyor, referans tipler ikisini de

            //list yazdıktan sonra sağdaki ampule basıp en üstteki yani usingsystemcollectionsgeneric i işaretle.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
