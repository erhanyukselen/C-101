using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler = new string[5];


            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            // Klavyeden girilen n tane sayının ortalamasını hesaplama

            Console.Write("Lütfen dizinin eleman sayısını giriniz :");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayidisizi = new int[diziUzunlugu];


            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz ", i+1);
                sayidisizi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayidisizi)
            
                toplam += sayi;
            Console.Write("Ortalama :" + toplam/diziUzunlugu);
            
        }
    }
}