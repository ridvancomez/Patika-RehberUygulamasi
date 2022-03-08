using System;

namespace RehberUygulaması
{
    class Goster : Rehber
    {
        public static void Listele()
        {
            foreach (var kisi in Rehber.RehberKayit)
            {
                System.Console.WriteLine($"İsim: {kisi.Isim}");
                System.Console.WriteLine($"Soyisim: {kisi.Soyisim}");
                System.Console.WriteLine($"Telefon Numarası: {kisi.TelefonNumarasi}");
                System.Console.WriteLine("-");
            }
        }

        public static void Arama(string isim, string soyisim)
        {
            foreach (var kisi in Rehber.RehberKayit)
            {
                if (kisi.Isim == isim || kisi.Soyisim == soyisim)
                {
                    System.Console.WriteLine($"İsim: {kisi.Isim}");
                    System.Console.WriteLine($"Soyisim: {kisi.Soyisim}");
                    System.Console.WriteLine($"Telefon Numarası: {kisi.TelefonNumarasi}");
                    System.Console.WriteLine("-");
                }
            }
        }

        public static void Arama(string telefonNumarasi)
        {
            foreach (var kisi in Rehber.RehberKayit)
            {
                if (kisi.TelefonNumarasi == telefonNumarasi)
                {
                    System.Console.WriteLine($"İsim: {kisi.Isim}");
                    System.Console.WriteLine($"Soyisim: {kisi.Soyisim}");
                    System.Console.WriteLine($"Telefon Numarası: {kisi.TelefonNumarasi}");
                    System.Console.WriteLine("-");
                }
            }
        }
    }
}