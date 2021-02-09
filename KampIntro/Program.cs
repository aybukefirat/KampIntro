using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            //Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false; //Gerçek hayat projelerinde buradaki true fallse değeri sistemden bir veri kaynağından-fonksiyondan gelir. 
            //Yapılan işleme bağlı olarak bir değer alır. Statik olarak belirtilmez.
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artıs Goster");
            }
            else
            {
                Console.WriteLine("Degismemistir");
            }






            if (sistemeGirisYapmisMi== true)
            {
                Console.WriteLine("Kullanici Ayarlari Butonu");

            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

        }
    }
}
