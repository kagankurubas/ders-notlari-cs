using System;

namespace capp_26_02_2018
{
    class Dortgen
    {
        int En = 0;
        int Boy = 0;
        public int Alan()
        {
            return En * Boy;
        }
        public void EnBoyBelirle(int En, int Boy)
        {
            if (En > 0 && Boy > 0)
            {
                this.En = En;
                this.Boy = Boy;
            }
            else
            {
                Exception gecersizBuyukluk = new Exception("Geçersiz büyüklük girildi. En ve boy sıfırdan büyük olmalı.");
                throw gecersizBuyukluk;
            }
        }
        public void Yaz()
        {
            Console.WriteLine("***************");
            Console.WriteLine("En = {0,5}", En);
            Console.WriteLine("Boy = {0,5}", Boy);
            Console.WriteLine("Alan = {0,5}", Alan());
            Console.WriteLine("***************");
        }
    }
    class AnaSinif
    {
        static void Main()
        {
            Dortgen d1 = new Dortgen();
            d1.EnBoyBelirle(5, 10);
            d1.Yaz();

            d1.EnBoyBelirle(-20, 50);
            d1.Yaz();
        }
    }
}
