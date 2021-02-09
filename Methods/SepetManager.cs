using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle( Product product) //Ekle metodu oluşturarak kod bloğu içerisine yapacağı işi yazdık.
        {  //Ekle metoduna eklenecek şeyin bilgisini vermek amacıyla ürün parametresi gireriz. Bu parametrenin tipi tanımlandığı sınıfın adıdır.
            Console.WriteLine("sepete eklendi :  " + product.Adi);
            //Eklenen parametre sayesinde bu kod bloğu içinde ürün hakkında bilgi verebiliriz. örneğin ürünün adı product.Adi
        }

        public void Ekle2(string productAdi, double Fiyat, string Aciklama ) //Bir class içinde birden fazla metod olabilir.
            //Metodun içerisinde ürüne ait bütün özellikleri tek tek parametre haline getirirsek yeni bir özellik ekleneceği zaman metodun kullanıldığı tüm sayfalarda yeni özellik parametresinin verilerini girmek gerekir ve bu zaman alır.
           // Metod parametresi yerine Class içerisinde yeni bir özellik olarak tanımlarsak class ın adıyla oluşturulan parametre metoda eklenince tüm değişiklikler tek seferde dahil edilmiş olur.
          //Bu yapılan işleme Encapsulation denir.
        {

        }


    }
}
