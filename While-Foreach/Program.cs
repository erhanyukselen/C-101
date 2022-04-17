﻿using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            // 1 den başlayarak konsoldan girilen sayıya kadar sayı dahil ortalama hesaplayıp console'a yazdıran program
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam+= sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            // A dan Z ye kadar tüm harfleri console'a yazdıralım

            char character = 'a';

            while (character<='z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("****Foreach****");

            string[] arabalar = { "BMW", "Ford", "Toyata", "Nissan" };
            
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }


        }
    }
}