using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            /* Console.Write("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if(i%2==1)
                    Console.WriteLine(i);
            }

            //1 ve 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazdır
            int tekToplam = 0;
            int ciftToplam = 0;
            
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i; //tektoplam = tektoplam + i;
                else
                    ciftToplam += i; //cifttoplam = cifttoplam +i;
            }
            Console.WriteLine("Tek Toplam :" + tekToplam);
            Console.WriteLine("Çift Toplam :" + ciftToplam); */

            //break 
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break; // 4 ü gördüğü zaman döngüden çık
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue; // sadece 4 ü atla döngüye devam et
                Console.WriteLine(i);
            }
        }
    }
}