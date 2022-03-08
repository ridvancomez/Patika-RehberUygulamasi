using System;

namespace RehberUygulaması
{
    class Dondur : Rehber
    {
        public static int Kontrol(string isim, string soyisim)
        {
            for(int i = 0; i< Rehber.RehberKayit.Count; i++)
            {
                if (Rehber.RehberKayit[i].Isim == isim && Rehber.RehberKayit[i].Soyisim == soyisim)
                {
                    return i;
                }
            }
            return -1;


        }
    }
}