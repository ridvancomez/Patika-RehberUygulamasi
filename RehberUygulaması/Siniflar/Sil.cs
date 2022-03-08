using System;

namespace RehberUygulaması
{
    class Sil : Rehber
    {
        public static void KullaniciSil(string isim, string soyisim)
        {
            var kisi = Dondur.Kontrol(isim, soyisim);

            if (kisi != -1)
            {
                System.Console.WriteLine($"{Rehber.RehberKayit[kisi].Isim} {Rehber.RehberKayit[kisi].Soyisim} isimli kişi silenecek onaylıyor musunuz (y/n)");
                ConsoleKeyInfo x = Console.ReadKey();

                if (x.KeyChar == 'y')
                {
                    System.Console.WriteLine("Silindi");
                    Rehber.RehberKayit.RemoveAt(kisi);
                }
                else
                {
                    System.Console.WriteLine("Silinme işlemi durduldu"); // vazgeçme
                }
            }
            else
            {
                System.Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");

                System.Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                System.Console.WriteLine("Yeniden denemek için      : (2)");

                ConsoleKeyInfo kontrol = Console.ReadKey();

                if (kontrol.KeyChar == '2')
                {
                    Islem.IslemSil();
                }
            }
        }
    }
}