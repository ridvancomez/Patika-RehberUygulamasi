using System;

namespace RehberUygulaması
{
    class MenuYazdir
    {
        public static void Yazdir()
        {
            System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin (Programı kapatmak için 1 ve 5 dışında başka bir tuşa basın) :)");
            System.Console.WriteLine("*******************************************");
            System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
            System.Console.WriteLine("(2) Varolan Numarayı Silmek");
            System.Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            System.Console.WriteLine("(4) Rehberi Listelemek");
            System.Console.WriteLine("(5) Rehberde Arama Yapmak");

            ConsoleKeyInfo numara = Console.ReadKey();
            Console.Clear();
            IsDurumMakinesi.Kontrol(numara.KeyChar);
        }
    }
}