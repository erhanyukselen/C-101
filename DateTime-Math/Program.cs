using System;

namespace DateTime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //Günün tarihini getirir.
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);// Bu haftanın hangi günü olduğunu string şekilde getirir.
            Console.WriteLine(DateTime.Now.DayOfYear);// Bugün yılın kaçıncı günü olduğunu getirir.

            Console.WriteLine(DateTime.Now.ToLongDateString());//Gün, Ay ve gün, Yıl 

            Console.WriteLine(DateTime.Now.ToShortDateString());//19.03.2022

            Console.WriteLine(DateTime.Now.ToLongTimeString()); // saat dakika saniye 
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // saat dakika 

            Console.WriteLine(DateTime.Now.AddDays(2)); //Bu güne 2 gün ekle.
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(5));
            Console.WriteLine(DateTime.Now.AddMilliseconds(100));

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //11
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Cum
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Cuma


            Console.WriteLine(DateTime.Now.ToString("MM")); //02
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Şub
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //Şubat

            Console.WriteLine(DateTime.Now.ToString("yy")); //22
            Console.WriteLine(DateTime.Now.ToString("yyy")); //2022

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));//25

            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));


            Console.WriteLine(Math.Ceiling(22.3));//23
            Console.WriteLine(Math.Round(22.3));//22
            Console.WriteLine(Math.Round(22.7));//23
            Console.WriteLine(Math.Floor(22.7));//22

            Console.WriteLine(Math.Max(2, 6));
            Console.WriteLine(Math.Min(2, 6));

            Console.WriteLine(Math.Pow(3, 4));//üs alma 3^4 81 getirir.
            Console.WriteLine(Math.Sqrt(9));//Kök hesaplar. sonuç 3.

            Console.WriteLine(Math.Log(9));//9'un e tabanında logaritmasını verir.
            Console.WriteLine(Math.Log10(10)); // 10 saysının log10 tabanındaki karşılığı
            Console.WriteLine(Math.Exp(3)); // e üzeri 3 ü verir
        }
    }
}