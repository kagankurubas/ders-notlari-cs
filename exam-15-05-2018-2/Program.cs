using System;

/*
  - Bu soruda bizden yazmamız beklenen `Musabaka` adında enum, bir `Hesapla` metodu, `Takim` struct'ı ve `Main` metodu istenmişti
  - Musaba enumu galibiyet, beraberlik ve mağlubiyetin int karşılıklarını tanımlıyordu.
  - Hesapla metodu takımın skorunu hesaplayıp takımın adıyla beraber konsola çıktı veren bir metottu.
  - Takim yapısı(struct) takımın adı ve musabakaları tutan bir diziye(Musabaka[]) sahipti
*/

namespace exam_15_05_2018_2
{
    class Futbol
    {
        enum Musabaka
        {
            galibiyet = 3, beraberlik = 1, maglubiyet = 0
        }
        static void Hesapla(Takim takim)
        {
            int toplam = 0;
            // Bu satırda buraya `var` yerine `int` girmek önemli,
            // Musabaka[] içindeki değerlerin int karşılıklarını alabilmemiz için.
            foreach (int skor in takim.musabakalar)
                toplam += skor;
            
            Console.WriteLine("{0} takımının skoru: {1}", takim.takimadi, toplam);
        }
        struct Takim
        {
            public string takimadi;
            public Musabaka[] musabakalar;
        }
        static void Main(string[] args)
        {
            Takim t1;
            t1.takimadi = "Takımın Adı Aklıma Gelmedi Spor";

            t1.musabakalar = new Musabaka[]{
                Musabaka.galibiyet,
                Musabaka.beraberlik,
                Musabaka.maglubiyet,
                Musabaka.maglubiyet
            };

            Futbol.Hesapla(t1);
            Console.ReadKey();
        }
    }
}
