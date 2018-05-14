using System;
using System.Linq;
using System.Collections.Generic;

namespace direnc_kodlari_oyunu
{
    class Oyun
    {
        List<string> yanitlar = new List<string>();
        List<int[]> sorular = new List<int[]>();
        List<bool> yorumlar = new List<bool>();
        const string HERHANGI_BIR_TUS = "  -> Herhangi bir tuşa basabilirsin.";
        int skor = 0;
        int toplam = 0;
        public void baslat()
        {
            this.hosgeldinMesaji();
            this.oyunAlani();
            this.sonucSayfasi();
            this.cikisMesaji();
        }
        void oyunAlani()
        {
            Random rnd = new Random();
            string yanit = "";
            while (true)
            {
                int[] direnc = new int[] { rnd.Next(Statik.renkTablosu.Length), rnd.Next(Statik.renkTablosu.Length), rnd.Next(Statik.renkTablosu.Length) };
                double dogruCevap = this.dogruCevap(direnc);

                string soru = " ";
                foreach (int i in direnc)
                    soru += Statik.renkTablosu[i] + " ";

                OyunKonsol.konsolaYaz(
                    OyunKonsol.cerceveOlustur(
                        String.Format("Skorun: {0} / {1}   {2}   Çıkmak için \"çıkış\" veya \"ç\" yazabilirsin.",
                            skor, toplam, Statik.dikey
                        )
                    )
                    .Concat(OyunKonsol.cerceveOlustur(new string[] { "Elimizdeki direncin renkleri:", soru + "  (Tolerans)" }))
                    .Concat(new string[] { "Cevabınız (ohm): " })
                    .ToArray()
                );

                yanit = Console.ReadLine();
                if (yanit == "çıkış" || yanit == "ç")
                    break;
                else
                {
                    sorular.Add(direnc);
                    yanitlar.Add(yanit);

                    toplam += 1;

                    if (this.kullaniciYanit(yanit) == dogruCevap)
                    {
                        skor += 1;
                        yorumlar.Add(true);
                    }
                    else
                        yorumlar.Add(false);
                }
            }
        }
        double dogruCevap(int[] direnc)
        {
            return (direnc[1] + (direnc[0] * 10)) * Math.Pow(10, direnc[2]);
        }
        double kullaniciYanit(string girdi)
        {
            double kullaniciYanit = -1;
            try
            {
                kullaniciYanit = Convert.ToDouble(girdi);
            }
            catch (System.FormatException) { }
            return kullaniciYanit;
        }
        void sonucSayfasi()
        {
            List<string> sonuclar = new List<string>();
            for (int i = 0; i < yanitlar.Count; i++)
            {
                double dogruCevap = this.dogruCevap(sorular[i]);
                string yanitYorumu = yorumlar[i] ? "Doğru" : "Yanlış";
                string satir = String.Format("{3,6}: {0,8} {1,8} {2,8} -> {4}",
                    Statik.renkTablosu[sorular[i][0]],
                    Statik.renkTablosu[sorular[i][1]],
                    Statik.renkTablosu[sorular[i][2]],
                    yanitYorumu,
                    dogruCevap
                );

                if (!yorumlar[i])
                    satir += String.Format(" (Siz: {0})", yanitlar[i]);

                sonuclar.Add(satir);
            }

            Console.Clear();
            OyunKonsol.cerceveYaz(
                OyunKonsol.cerceveOlustur(String.Format(" -> Skorun: {0} / {1}", skor, toplam))
                .Concat(sonuclar.ToArray())
                .Concat(new string[] { HERHANGI_BIR_TUS })
                .ToArray(), 3
            );
            Console.ReadKey();
        }
        void cikisMesaji()
        {
            Console.Clear();
            OyunKonsol.cerceveYaz(new string[] {
                "Görüşmek üzere!",
                "Evdekilere selam söyle!",
                "Kendine dikkat et, terliyken soğuk su içme!",
                "Hadi grşrz btnm. Sni svyrm <3",
                "gι∂єηє уσℓ уαкışıя, ƒαzℓα ∂υямα αѕƒαℓт уαρışıяяя",
                "そのばかげたことを終わらせてください",
                "Шутка закончилась. Пришло время для разлуки.",
                HERHANGI_BIR_TUS
            }, 3);
            Console.ReadKey();
        }
        void hosgeldinMesaji()
        {
            Console.Clear();
            OyunKonsol.cerceveYaz(new string[] {
                "3 renkli dirençler ile alakalı isimsiz ve gereksiz oyuna hoşgeldin!",
                "Bu oyunda amaç renkleri verilen direnç kodunun değerini girmen.",
                "Evet sadece bu. Birkaç renk göreceksin ve onlara atanmış değerlerle",
                "birkaç matematik işlemi yapacaksın.",
                "Aslında bu kadar basit bir olay için neden bu kadar çaba gösterdim ki?",
                "Bazen bazı şeyleri sorguluyorum, ama yeterince dinledim dersen oyuna başlamak için:",
                HERHANGI_BIR_TUS
            });
            Console.ReadKey();
        }
    }
}