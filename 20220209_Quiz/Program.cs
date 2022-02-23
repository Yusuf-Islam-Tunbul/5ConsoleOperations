using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220209_Quiz
{
    class Program
    {
        char[] vowels = new char[] { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

        static void Main(string[] args)
        {
            Program program = new Program();

            program.Choose();
        }

        void Choose()
        {
            Console.WriteLine("Tersten metin yazdırmak için 2 tuşuna basınız.\n2-5-8-...50 serisindeki sayıların toplamını görmek için 3 tuşuna basınız.\nGirdiğiniz 5 sayıdan kaçının negatif olduğunu görmek için 4 tuşuna basınız.\nGirdiğiniz metindeki ünlü harf sayısını görmek için 5 tuşuna basınız.");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D2:
                    Console.WriteLine("\nTersten yazılmasını istediğiniz metni giriniz.");
                    string text1 = Console.ReadLine();
                    string reversed_text = "";

                    foreach (char letter in text1.Reverse())
                    {
                        reversed_text += letter;
                    }

                    Console.WriteLine("Girdiğiniz metnin tersi:");
                    Console.WriteLine(reversed_text);
                    Console.WriteLine("Çıkış yapmak için herhangi bir tuşa basınız.");
                    Console.ReadKey();

                    break;

                case ConsoleKey.D3:
                    Console.WriteLine("");

                    int sum = 0;

                    for (int i = 2; i <= 50; i += 3)
                    {
                        sum += i;
                    }

                    Console.WriteLine("Serideki sayıların toplamı:");
                    Console.WriteLine(sum);
                    Console.WriteLine("Çıkış yapmak için herhangi bir tuşa basınız.");
                    Console.ReadKey();

                    break;

                case ConsoleKey.D4:
                    Console.WriteLine("");
                    Console.WriteLine("Beş adet sayı girişi yapınız.");

                    int negative_numbers = 0;
                    int total_numbers = 0;

                    while (total_numbers < 5)
                    {
                        try
                        {
                            double temp_number = Convert.ToDouble(Console.ReadLine());
                            if (temp_number < 0)
                            {
                                negative_numbers++;
                            }

                            total_numbers++;
                        }
                        catch
                        {
                            Console.WriteLine("Girdiğiniz ifade bir sayı değildi. Lütfen tekrar deneyiniz.");
                        }
                    }

                    if (negative_numbers == 0)
                    {
                        Console.WriteLine("Girdiğiniz sayılardan hiçbiri negatif değil.");
                    }
                    else
                    {
                        Console.WriteLine($"Girdiğiniz sayılardan {negative_numbers} tanesi negatif.");
                    }

                    Console.WriteLine("Çıkış yapmak için herhangi bir tuşa basınız.");
                    Console.ReadKey();

                    break;

                case ConsoleKey.D5:
                    Console.WriteLine("");
                    Console.WriteLine("İçerisindeki ünlü harf sayısını görmek istediğiniz metni giriniz.");

                    string text2 = Console.ReadLine();
                    int number_of_vowels = 0;

                    foreach (char letter in text2)
                    {
                        if (vowels.Contains(letter))
                        {
                            number_of_vowels++;
                        }
                    }

                    if (number_of_vowels == 0)
                    {
                        Console.WriteLine("Girdiğiniz metinde hiç ünlü harf yok.");
                    }
                    else
                    {
                        Console.WriteLine($"Girdiğiniz metinde {number_of_vowels} adet ünlü harf bulunmaktadır.");
                    }

                    Console.WriteLine("Çıkış yapmak için herhangi bir tuşa basınız.");
                    Console.ReadKey();

                    break;
                default:
                    Console.Clear();
                    Choose();
                    break;
            }
        }
    }
}
