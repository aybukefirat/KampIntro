using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Aybuke";
            int yas = 21;
            Kurs kurs1 = new Kurs(); //class ı kullanarak bir değişken tanımlayabiliriz. Class değişkenin tipini belirler bu değişken birden fazla değer içerir.

            
            //kurs1 için sınıf içerisinde tanımlanan kursadı özelliğine bir veri eklemişi olduk. kursadı str olduğu için veriyi str girdik.
            kurs1.KursAdi = "aybuke firat";
            kurs1.IzlenmeOrani = 70;
            kurs1.KursAdi = "C#";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "cansu tutar";
            kurs2.IzlenmeOrani = 80;
            kurs2.KursAdi = "Java";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "engin demirog";
            kurs3.IzlenmeOrani = 65;
            kurs3.KursAdi = "Phyton";




            Console.WriteLine("Hello World!");
        }
    }

    class Kurs //Özellikleri içeren bir kurs objesi oluşturduk.
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; } //Kurs class içerisinde üç tane özellik tanımlamış olduk.
    }
}
