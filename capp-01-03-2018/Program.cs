using System;

namespace capp_01_03_2018
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            string[] kahveIsimler = { "Türk Kahvesi", "Nescafe", "Olmamış Kahve" };
            Kahve[] kahveDizi = new Kahve[3];
            for (int i = 0; i < kahveDizi.Length; i++)
            {
                kahveDizi[i] = new Kahve();
                if (rnd.Next(2) == 0)
                    kahveDizi[i].suz();
                if (rnd.Next(2) == 0)
                    kahveDizi[i].sutEkle();
                kahveDizi[i].kaynakSec(kahveIsimler[rnd.Next(0, kahveIsimler.Length)]);
                kahveDizi[i].sekerEkle(rnd.Next(0, 4));
            }
            foreach (Kahve kahve in kahveDizi)
            {
                kahve.kahveYazdir();
            }
            kahveDizi[0].hazirla();
            kahveDizi[0].sekerEkle(2);
            kahveDizi[0].sutEkle();
            kahveDizi[0].kahveYazdir();
        }
    }
}
