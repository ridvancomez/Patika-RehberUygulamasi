using System;

namespace RehberUygulaması
{
    class Guncelle : Rehber
    {
        public static void KullaniciGuncelle(string isim, string soyisim, string guncelIsım, string guncelSoyisim, string guncelTelefonNumarasi)
        {
            int kisi = Dondur.Kontrol(isim, soyisim);

            for (int i = 0; i < Rehber.RehberKayit.Count; i++)
            {
                if (kisi != -1)
                {
                    System.Console.WriteLine($"{isim} {soyisim} isimli kişi güncelleniyor onaylıyor musunuz (y/n)");
                    ConsoleKeyInfo x = Console.ReadKey();
                    if (x.KeyChar == 'y')
                    {
                        Kisi yeniKisi = new Kisi(guncelIsım, guncelSoyisim, guncelTelefonNumarasi);

                        System.Console.WriteLine("Güncellendi");
                        Rehber.RehberKayit[kisi] = yeniKisi;
                        return;
                    }
                    else
                    {
                        System.Console.WriteLine("Güncelleme durduruldu");
                        return;
                    }
                }
                else
                {
                    System.Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");

                    System.Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                    System.Console.WriteLine("Yeniden denemek için      : (2)");

                    ConsoleKeyInfo kontrol = Console.ReadKey();

                    if (kontrol.KeyChar == '2')
                    {
                        Islem.IslemGuncelle();
                    }
                    else{
                        return;
                    }
                }
            }
        }
    }
}