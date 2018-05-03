using System;

namespace capp_23_11_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                Console.Write("Bir sayı giriniz (1-50 arası): ");
                int girdi = int.Parse(Console.ReadLine());
                if (girdi > 50 || girdi < 1)
                    Console.WriteLine("1 ile 50 arası girebilirsiniz.");
                else
                {
                    Console.Write("Kaç defa bulunmasını istiyorsunuz?: ");
                    int bulmaIstegi = int.Parse(Console.ReadLine());
                    if (bulmaIstegi < 0)
                        Console.WriteLine("Pozitif bir sayı girebilirsiniz.");
                    else
                    {
                        int[] sayilar = new int[bulmaIstegi];
                        int say = 0, i;
                        for (i = 1; say < bulmaIstegi; i++)
                        {
                            int rastgele = rnd.Next(1, 51);
                            Console.WriteLine(i + " - " + rastgele);
                            if (rastgele == girdi)
                                sayilar[say++] = i;
                        }
                        Console.Write("\n{0} defada ", sayilar[sayilar.Length - 1]);
                        foreach (var item in sayilar)
                            Console.Write(item + ". ");
                        Console.Write("denemelerde {0} defa bulundu.", bulmaIstegi);
                    }
                }
                Console.WriteLine("\n\nTekrar denemek için ENTER tuşuna basın.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
