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






