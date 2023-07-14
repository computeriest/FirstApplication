// See https://aka.ms/new-console-template for more information

using System;

public class HelloEvogens
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Evogens");
        Console.WriteLine(5);
        Console.WriteLine("--------------------");

        string isim;
        int sira;

        Console.Write("İsminizi giriniz: ");
        isim = Console.ReadLine();
        Console.Write("Sıranızı giriniz: ");
        //sira = Convert.ToInt32(Console.ReadLine);

        while (!int.TryParse(Console.ReadLine(), out sira))
        {
            Console.Write("Lütfen sadece rakam giriniz: ");
        }
        Console.WriteLine("İsminiz: " + isim + ", Sıra Numaranız: " + sira);
        Console.ReadLine();
    }
}
    
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı girin: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }

        Console.WriteLine("1'den " + number + " kadar olan sayıların toplamı: " + sum);

        using System;

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int product = 1;

            for (int i = 1; i <= number; i++)
            {
                sum += i;
                product *= i;
            }

            Console.WriteLine("1'den " + number + " kadar olan sayıların toplamı: " + sum);
            Console.WriteLine("1'den " + number + " kadar olan sayıların çarpımı: " + product);

            // Diğer kodları buraya ekleyebilirsiniz
        }
    }

}
}





