using System;

namespace Degiskenler
{
    class Program
    {
        static void Main (string[] args)
        {
            //Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); //sonuç 2020

            int int21=int20+Convert.ToInt32 (str20);
            Console.WriteLine(int21); //sonuç 40

            string datetime = DateTime.Now.ToString("dd.mm.yyyy");
            Console.WriteLine(datetime);
        }
    }
}