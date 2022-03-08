using System;

namespace RehberUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Rehber.RehberEkle("Ali", "Kaya", "012");
            Rehber.RehberEkle("Ayşe", "Yıldız", "345");
            Rehber.RehberEkle("Fatma", "Sönmez", "012");
            Rehber.RehberEkle("Ahmet", "Yıldırım", "901");
            Rehber.RehberEkle("Mehmet", "Durmaz", "234");

            MenuYazdir.Yazdir();
        }
    }
}
