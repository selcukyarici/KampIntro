using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği 
            //Do not repat your self - Kendini tekrarlama
            //değer tutucu, alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.25;
            double dolarBugün = 7.45;

            if (dolarDun>dolarBugün)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugün)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
