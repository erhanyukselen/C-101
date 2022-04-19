using System;

namespace String_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hosgeldiniz!";
            string degisken2 = "dersimiz CSharp, Hosgeldiniz!";
            //Length; 
            Console.WriteLine(degisken.Length); //Kaç karakterden oluştuğunu görmek için

            //ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper()); // Tüm karakterlerin hepsini büyültür
            Console.WriteLine(degisken.ToLower()); // Tüm karakterlerin hepsini küçültür

            //Concat
            Console.WriteLine(string.Concat(degisken, "Merhaba!")); // Değişkeni alır ve sonra verdiğimiz yazıyla birleştirir

            //Compare, CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2)); //İki değişkeni karşılaştırır. 1. değişken 2. değişkene eşit olursa sıfır döndürür. Daha büyükse 1 . Daha küçükse -1 
            Console.WriteLine(string.Compare(degisken, degisken2, true)); // büyük küçük harf duyarsız hale gelir true denirse
            Console.WriteLine(string.Compare(degisken, degisken2, false)); // büyük küçük harf duyarlı hale gelir false denirse

            //Contains

            Console.WriteLine(degisken.Contains(degisken2)); // değişken birin içerisinde değişken iki var mı diye kontrol eder bulursa true döner.
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!")); // bitimini kontrol eder.
            Console.WriteLine(degisken.StartsWith("Merhaba!"));  // başlangıcını kontrol eder.


            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS")); //değişkenin içerisinde arar bulduğu yerin indexini söyler.
            Console.WriteLine(degisken.IndexOf("Erhan")); //bulamazsa -1 döner.
            Console.WriteLine(degisken.LastIndexOf("i"));  // i içeren son index'i getirir.

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba")); // sıfırıncı indexten başlayarak yazdığımız yazıyı ekler.


            //PadLeft, PadRight;
            Console.WriteLine(degisken + degisken2.PadLeft(30)); //degiskene verdiğimiz kadar boşluk ekler değişken 15 indexten oluşuyorsa 15 tane ekler.
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));// 10. indexten öncesini getirir
            Console.WriteLine(degisken.Remove(5, 3)); //5. indexten başlayıp 3 index siler
            Console.WriteLine(degisken.Remove(0, 1)); // 0. indexten başlayıp 1 index siler

            //Replace
            Console.WriteLine(degisken.Replace("C Sharp", "C#")); // C sharp yazını C# ile değiştirir
            Console.WriteLine(degisken.Replace(" ", "*")); // Boşluklar yerine yıldız yazar

            //Split
            Console.WriteLine(degisken.Split(" ")[1]); //boşluklara göre parçala ve diziye ata. 3 elemanlı bir dizi tanımladı ve 1.yi getirir.

            //SubString
            Console.WriteLine(degisken.Substring(4)); // 4. indexten başlayarak sonuna kadar getirir.
            Console.WriteLine(degisken.Substring(4, 6)); // 4. indexten başlayarak 6 karakter getirir.
        }
    }
}