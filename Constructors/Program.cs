using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };
            //yukardaki gibi kullanabilmem için alttaki public i yazmamam lazım, alttaki public tam alt satırda yazdığım için gerekli
            //ikisini de yani iki üstümdeki ve bir altımdaki satırların hepsini calistırmak istiyorsam üstteki satır için ctor lu şeyden bir tane daha oluşturmalıyım ama boş olmalı. FirstName= firstname olan kısmı yazmalıyım ki customer2.FirstName diye sorduğumda sonucu görebileyim

            Customer customer2 = new Customer(2,"Derin","Demiroğ","Ankara"); //sonunda parantez olanlar metot oluyor. constructerlar da bir metot gibi çalışır
            Console.WriteLine(customer2.FirstName);
        
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        //public Customer()  bunu yazsak da yazmasak da arka planda bu varmış ve çalışırmış. buna default constructor denir.
        //{

        //}
        //constructor yapıcı blok demek.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
