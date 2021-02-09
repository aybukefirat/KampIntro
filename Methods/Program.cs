using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Product product1 = new Product(); // bir class aracılığı ile değişken tanımlarken new kullanmak gerekir. Bir ürün oluşturduk.

            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";
            product1.StokAdedi = 10;
            //class içerisinde tanımladığımız ad,fiyat,açıklama özelliklerini class kullanarak tanımladığımız değişkenin verilerini girdik.

            Product product2 = new Product();

            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu"; //ikinci bir değişken tanımladık
            product2.StokAdedi = 5;

            Product[] products = new Product[] {product1,product2 };

            //öğrenmek amacıyla manuel yazılan bu veriler gerçek hayat uygulamalarında bir veri kaynağı aracılığıyla gelir.

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.StokAdedi);
            }

            Console.WriteLine("---Metodlar---");

            SepetManager sepetManager = new SepetManager(); //class instance oluşturduk.

            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2); 
            //sepetmanager.ekle diyerek class içinde tanımlanan metodu çağırmış olduk. Ekle metoduna class da parametre verdiğimizde buradada parametre tanımlamalıyız.
        }
    }
}
