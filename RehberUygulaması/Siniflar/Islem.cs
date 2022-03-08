using System;

namespace RehberUygulaması
{
    class Islem
    {
        public static void IslemKayit()
        {
            string isim;
            string soyisim;
            string telefonNumarasi;

            System.Console.WriteLine("Lütfen isim giriniz");
            isim = Console.ReadLine();

            System.Console.WriteLine("Lütfen soyisim giriniz");
            soyisim = Console.ReadLine();

            System.Console.WriteLine("Lütfen telefon numarası giriniz");
            telefonNumarasi = Console.ReadLine();

            Rehber.RehberEkle(isim, soyisim, telefonNumarasi);

        }

        public static void IslemSil()
        {
            string isim;
            string soyisim;

            System.Console.WriteLine("Lütfen silmek istediğiniz ismi giriniz");
            isim = Console.ReadLine();

            System.Console.WriteLine("Lütfen silmek istediğiniz soyisimi giriniz");
            soyisim = Console.ReadLine();

            Sil.KullaniciSil(isim, soyisim);
        }

        public static void IslemGuncelle()
        {
            string isim;
            string soyisim;
            string guncelIsım;
            string guncelSoyisim;
            string guncelTelefonNumarasi;

            System.Console.WriteLine("Değiştirmek istediğiniz ismi girin");
            isim = Console.ReadLine();

            System.Console.WriteLine("Değiştirmek istediğiniz soyismi girin");
            soyisim = Console.ReadLine();

            System.Console.WriteLine("Güncel ismi girin");
            guncelIsım = Console.ReadLine();

            System.Console.WriteLine("Güncel soyismi girin");
            guncelSoyisim = Console.ReadLine();

            System.Console.WriteLine("Güncel telefon numarasını girin");
            guncelTelefonNumarasi = Console.ReadLine();

            Guncelle.KullaniciGuncelle(isim, soyisim, guncelIsım, guncelSoyisim, guncelTelefonNumarasi);

        }

        public static void IslemListele()
        {
            Goster.Listele();
        }

        public static void IslemArama()
        {
            char isimTelefon;
            System.Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            System.Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            ConsoleKeyInfo isimTelefonConsoleKeyInfo = Console.ReadKey();
            isimTelefon = isimTelefonConsoleKeyInfo.KeyChar;

            if (isimTelefon == '1')
            {
                string isim;
                string soyisim;

                System.Console.WriteLine("Arama yapılacak ismi girin");
                isim = Console.ReadLine();

                System.Console.WriteLine("Arama yapılacak soyismi girin");
                soyisim = Console.ReadLine();

                Goster.Arama(isim, soyisim);
            }
            else if (isimTelefon == '2')
            {
                string telefonNumarasi;

                System.Console.WriteLine("Arama yapılacak telefon numarasını girin");
                telefonNumarasi = Console.ReadLine();

                Goster.Arama(telefonNumarasi);

            }
            else
            {
                System.Console.WriteLine("Yanlış giriş yaptınız tüm telefon kayıtları listelenecektir");
                Goster.Listele();
            }



        }
    }
}