using System;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte ELEMAN_SAYISI = 11;
            Random rnd = new Random();
            byte[] dizi = new byte[ELEMAN_SAYISI];
            Console.WriteLine("1- Dizi oluştur.");
            Console.WriteLine("2- Diziyi yazdır.");
            Console.WriteLine("3- Dizinini modunu ve bu değere ait frekansı hesapla.");
            Console.WriteLine("4- Dizinin medyanını hesapla.");
            while (true)
            {
                Console.Write("Girdi: ");
                string girdi = Console.ReadLine();
                switch (girdi)
                {
                    case "1":
                        for (int i = 0; i < dizi.Length; i++)
                            dizi[i] = Convert.ToByte(rnd.Next(1, 51));
                        break;
                    case "2":
                        for (int i = 0; i < dizi.Length; i++)
                            Console.WriteLine("dizi[{0}] = {1}", i, dizi[i]);
                        break;
                    case "3":
                        byte[] tekrar = new byte[51];
                        for (byte i = 0; i < dizi.Length; i++)
                            tekrar[dizi[i]]++;
                        byte enCok = 0;
                        for (byte i = 1; i < tekrar.Length; i++)
                        {
                            if (tekrar[enCok] < tekrar[i])
                                enCok = i;
                        }
                        for (byte i = 1; i < tekrar.Length; i++)
                        {
                            if (tekrar[i] == tekrar[enCok])
                                Console.Write("({0},{1})", i, tekrar[i]);
                        }

                        Console.WriteLine();
                        //Console.WriteLine("Dizinin modu: " + enCok + ", " + tekrar[enCok] + " kere tekrar etmiş.");
                        break;
                    case "4":
                        byte[] siraliDizi = dizi;
                        for (int j = 0; j < siraliDizi.Length; j++)
                        {
                            for (byte i = 1; i < siraliDizi.Length; i++)
                            {
                                if (siraliDizi[i] < siraliDizi[i - 1])
                                {
                                    byte temp = siraliDizi[i];
                                    siraliDizi[i] = siraliDizi[i - 1];
                                    siraliDizi[i - 1] = temp;
                                }
                            }
                        }
                        for (byte i = 0; i < siraliDizi.Length; i++)
                        {
                            Console.WriteLine("dizi[" + i + "] = " + dizi[i]);
                        }
                        Console.WriteLine("Dizinin medyanı = " + siraliDizi[siraliDizi.Length / 2] + " (" + siraliDizi.Length / 2 + ")");
                        break;
                }
            }
        }
    }
}
