using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayiDizisi = { 23, 12, 86, 72, 3, 11, 17, 4 };
            Console.WriteLine("********Sırasız Dizi ****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("********Sıralı Dizi ****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("********Array Clear****");
            // Sayı dizisi elemanlarını kullanarak 2. indexten itibaren 2 tane elemanı 0'lar.
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            // Diziyi tersten yazdırır
            Console.WriteLine("********Array Reverse****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            // Verdiğiniz sayının kaçıncı index yani sırada olduğunu söyler 
            Console.WriteLine("********Array Indexof****");

            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            // Dizinin boyutunu arttırıp, indexe bir değer atama
            Console.WriteLine("********Array Resize****");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}