using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Phyton", "Java", "C" };



            for (int i = 0; i < kurslar.Length ; i++) //tabx2 bize döngü iskeleti oluşturdu. Bu kod java ile aynıdır. i nin başlangıcı 0, lenght den küçük olana kadar i yi 1er artırır.
            {
                // i<3 yerine i< kurslar.length yazmak daha dinamik bir yapı oluşturur. diziye eleman ekleyince şartı güncellemek gerekmez.
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("For bitti");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



        }
    }
}
