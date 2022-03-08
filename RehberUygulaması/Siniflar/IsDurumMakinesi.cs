using System;

namespace RehberUygulaması
{
    class IsDurumMakinesi
    {
        public static void Kontrol(char numara)
        {
            System.Console.WriteLine(numara);
            switch (numara)
            {
                case (char)Menu.Kayit:
                    Islem.IslemKayit();
                    Console.Clear();
                    MenuYazdir.Yazdir();

                    break;

                case (char)Menu.Sil:
                    Islem.IslemSil();
                    Console.Clear();
                    MenuYazdir.Yazdir();

                    break;

                case (char)Menu.Guncelle:
                    Islem.IslemGuncelle();
                    Console.Clear();
                    MenuYazdir.Yazdir();

                    break;

                case (char)Menu.Listele:
                    Islem.IslemListele();
                    System.Console.WriteLine("Menuye geçmek için herhangi bir tuşa basın");
                    Console.ReadKey();
                    Console.Clear();
                    MenuYazdir.Yazdir();

                    break;

                case (char)Menu.Arama:
                    Islem.IslemArama();
                    System.Console.WriteLine("Menuye geçmek için herhangi bir tuşa basın");
                    Console.ReadKey();
                    Console.Clear();
                    MenuYazdir.Yazdir();

                    break;

                default:
                    System.Console.WriteLine("Yanlış tuşa bastınız Program kapatılıyor");
                    Console.Clear();
                    break;

            }
        }
    }
}