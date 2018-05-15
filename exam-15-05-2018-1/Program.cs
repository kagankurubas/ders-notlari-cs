using System;

/*
  Kartezyen koordinat sistemi ile alakalı soru hatırladığım kadarıyla şuydu:
  - Nokta sınıfı oluşturup nesneler arasında toplama ve çıkarma işlemlerini aşırı yükleyecektik
  - Toplama işlemi iki noktayı toplayıp yeni bir Nokta nesnesi döndürecekti.
  - Çıkarma işlemi de iki nokta arasındaki uzaklığı `double` olarak verecekti.
*/

namespace exam_15_05_2018_1
{
    class Nokta
    {
        public int x, y;

        // Oluştucu metod:
        public Nokta(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // İki Nokta nesnesi arasındaki + operatörü:
        public static Nokta operator +(Nokta a, Nokta b)
        {
            return new Nokta(a.x + b.x, a.y + b.y);
        }

        // İki Nokta nesnesi arasındaki - opretatörü:
        public static double operator -(Nokta a, Nokta b)
        {
            double yatayUzaklik = a.x - b.x;
            double dikeyUzaklik = a.x - b.y;
            return Math.Sqrt(Math.Pow(dikeyUzaklik, 2) + Math.Pow(yatayUzaklik, 2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İlk noktayı girin: ");
            string[] s1 = Console.ReadLine().Split(" ");
            Console.Write("İkinci noktayı girin: ");
            string[] s2 = Console.ReadLine().Split(" ");

            int x1 = Convert.ToInt32(s1[0]),
                y1 = Convert.ToInt32(s1[1]),
                x2 = Convert.ToInt32(s2[0]),
                y2 = Convert.ToInt32(s2[1]);

            Nokta n1 = new Nokta(x1, y1);
            Nokta n2 = new Nokta(x2, y2);

            Nokta toplam = n1 + n2;
            Console.WriteLine("İki noktanın toplamı: ({0}/{1})", toplam.x, toplam.y);

            double fark = n1 - n2;
            Console.WriteLine("İki nokta arasındaki uzaklık: {0}", fark);

            Console.ReadKey();
        }
    }
}
