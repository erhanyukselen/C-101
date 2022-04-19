//Q1-)Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
//Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Console.WriteLine("lütfen bir sayı giriniz");
int s1 = int.Parse(Console.ReadLine());
int[] dizi1 = new int[s1];
for (int i = 0; i < s1; i++)
{
    Console.WriteLine("lütfen {0}. sayıyı giriniz", i + 1);
    dizi1[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Girilen Çift Sayılar: ");

foreach (var i in dizi1)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}