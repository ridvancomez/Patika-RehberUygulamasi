using System;
using System.Collections.Generic;

namespace RehberUygulaması
{
    class Rehber
    {

        protected static List<Kisi> RehberKayit = new List<Kisi>();

        internal static void RehberEkle(string isim, string soyisim, string telefonNumarasi)
        {
            Kisi kisi = new Kisi(isim, soyisim, telefonNumarasi);
            RehberKayit.Add(kisi);
        }


    }
}