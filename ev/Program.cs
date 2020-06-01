using System;

namespace ev
{
    class Program
    {
        static void Main(string[] args)
        {
            int evGenislik = 0;

            do
            {
                Console.WriteLine("LÜTFEN EVİN GENİŞLİĞİNİ GİRİNİZ");
                evGenislik = Convert.ToInt32(Console.ReadLine());
                if (evGenislik <= 0 || evGenislik % 2 == 0)
                    Console.WriteLine("HATALI GİRİŞ YAPTINIZ");
            } while (evGenislik <= 0 || evGenislik % 2 == 0);

            int evYükseklik = evGenislik / 2;
            int kapıGenislik = evYükseklik / 4 + 1;
            int sayac = 0;

            for (int i = 0; i < (evGenislik / 4) + 1; i++)
            {
                for (int j = 0; j < (evGenislik / 2) - sayac; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < sayac; j++)
                {
                    Console.Write("/");
                }
                Console.Write("+");
                for (int m = 0; m < sayac; m++)
                {
                    Console.Write("\\");
                }
                sayac = sayac + 2;
                Console.WriteLine();
            }
            for (int j = 0; j <= (evGenislik / 4) + 1; j++)
            {
                for (int k = 0; k < (evGenislik); k++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
            for (int k = 0; k < (kapıGenislik / 2) + 1; k++)
            {
                for (int j = 0; j < (evGenislik - kapıGenislik) / 2; j++)
                {
                    Console.Write("0");
                }
                for (int j = 0; j < (kapıGenislik / 2); j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j = 0; j < (kapıGenislik / 2); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (evGenislik - kapıGenislik) / 2; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}