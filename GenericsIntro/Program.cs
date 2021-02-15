using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            // kullanacağım tipi <> içinde yazmam lazım yoksa kızar.
            isimler.Add("Engin");

            Console.WriteLine("Hello World!");
        }
    }
}
