using System;

namespace dizi_ogrencivenot_atama_yazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adSoyad = new string[3];
            int[] sinav1 = new int[3];
            int[] sinav2 = new int[3];
            int[] ort = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.Write($"{i + 1}. Öğrencinin Adını Girin: ");
                adSoyad[i] = Console.ReadLine();

                Console.Write($"{i + 1}. Öğrencinin İlk Sınavını Girin: ");
                sinav1[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"{i + 1}. Öğrencinin İkinci Sınavını Girin: ");
                sinav2[i] = Convert.ToInt32(Console.ReadLine());

                ort[i] = ((sinav1[i] + sinav2[i]) / 2);
                Console.Clear();

            }
            Console.WriteLine("***************************************");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(adSoyad[i] + " isimli öğrencinin;");
                Console.WriteLine("1. sınav sonucu: " + sinav1[i]);
                Console.WriteLine("2. sınav sonucu: " + sinav2[i]);
                Console.WriteLine("Ortalaması: " + ort[i]);
            }
            Console.WriteLine("***************************************");
        }
    }
}
