using System.Collections.Generic;
using System.Collections;
using System.Linq;
/*
-Enter 20 number. The numbers you entered can not be negative and non-numeric and you have to add them to two seperate ArrayList which you created.
-Print the elements of each array in order such as from max to min.
-Print the number of elements and average of both arrays on the screen.
*/
Console.WriteLine("Enter 20 number");
ArrayList nums = new ArrayList();
ArrayList Prime = new ArrayList();
ArrayList NotPrime = new ArrayList();

int counterNums = 1;
while (counterNums < 21)
{
    Console.Write($"<{counterNums}>" + ". number =");
    try
    {
        nums.Add(Convert.ToUInt32(Console.ReadLine()));
    }
    catch (FormatException e)
    {
        Console.WriteLine("Invalid format. Please just enter positive number !", e.Message);
        continue;
    }
    catch (Exception e)
    {
        Console.WriteLine("You can not enter negative number !", e.Message);
        continue;
    }
    counterNums++;
}

int flg;

foreach (uint n in nums)
{
    if (n == 1 || n == 0)
    {
        NotPrime.Add(Convert.ToUInt32(n));
        continue;
    }
    flg = 1;
    for (int x = 2; x < n; x++)
    {
        if (n % x == 0)
        {
            flg = 0;
            break;
        }
    }
    if (flg == 1)
        Prime.Add(Convert.ToUInt32(n));
    else
        NotPrime.Add(Convert.ToUInt32(n));
}

uint sumPrime = 0, sumNotPrime = 0;
Prime.Sort();
Prime.Reverse();
NotPrime.Sort();
NotPrime.Reverse();
Console.WriteLine("****PRIME NUMBERS****");

foreach (uint p in Prime)
{
    Console.Write(p + " ");
    sumPrime += p;
}

Console.WriteLine("\n" + $"Element number of primes': {Prime.Count}" + "");
Console.WriteLine($"Avg: {sumPrime / Prime.Count}");

Console.WriteLine("****NonPRIME NUMBERS****");

foreach (uint np in NotPrime)
{
    Console.Write(np + " ");

    sumPrime += np;
}
Console.WriteLine("\n" + $"Element number of primes': {NotPrime.Count}" + "");
Console.WriteLine($"Avg: {sumNotPrime / NotPrime.Count}");



/* Question 2 
 * 
 */

namespace CollectionsQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen 20 adet sayının en küçük 3 değeri ve en büyük 3 değerini al
            //her iki grubunda ortalamasını ver ortalama toplamlarını yazdır!
            int[] numbers = new int[20];
            int[] arrMax = new int[3];
            int[] arrMin = new int[3];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Please Enter {0}. Number: ", i + 1);
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
            }

            Array.Sort(numbers);
            for (int i = 0; i < 3; i++)
            {
                arrMin[i] = numbers[i];
            }
            Console.WriteLine("Dizideki En küçük 3 Eleman");
            foreach (var item in arrMin)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(numbers);
            for (int i = 0; i < 3; i++)
            {
                arrMax[i] = numbers[i];
            }
            double sumMax = 0;
            foreach (var item in arrMax)
            {
                sumMax += item;
            }
            double sumMin = 0;
            foreach (var item in arrMin)
            {
                sumMin += item;
            }
            double avgMax = sumMax / 3;
            double avgMin = sumMin / 3;
            Console.WriteLine("arrMax's Average : " + avgMax.ToString("F"));
            Console.WriteLine("arrMin's Average : " + avgMin.ToString("F"));
            Console.WriteLine("Sums of Averages : " + (avgMax + avgMin));

        }
    }
}



/* Question 3 */


namespace CollectionsQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden Girilen Cümle İçerisindeki Sesli harfleri al
            //bir diziye aktar ve diziyi sıralı yazdır.
            char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            List<char> vowels1 = new();

            Console.WriteLine("Please enter a sentence!");
            string sentence = Console.ReadLine();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    vowels1.Add(sentence[i]);
                }
            }

            vowels1.Sort();
            vowels1.ToArray();

            if (vowels1.Count == 0)
                Console.WriteLine("There are no vowels in the entered sentence!");
            else
            {
                Console.WriteLine("**** Vowels in sentence of entered ****");
                foreach (var item in vowels1)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}