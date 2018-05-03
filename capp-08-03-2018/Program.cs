using System;

namespace capp_08_03_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri("Mahmut");
            musteri1.DogumTarihi = new int[] { 5, 8, 1999, 12, 6 };
            musteri1.DogumTarihi = new int[] { 12, 4 };
            Console.WriteLine("{0} -> {1}/{2}/{3}", musteri1.Isim, musteri1.DogumTarihi[0], musteri1.DogumTarihi[1], musteri1.DogumTarihi[2]);
        }
    }
}
