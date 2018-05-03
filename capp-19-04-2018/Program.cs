using System;

namespace capp_19_04_2018
{
    class Program
    {
        static void SepetOrnegi()
        {
            byte eleman = 3;
            Sepet sepet = new Sepet(eleman);
            sepet[0] = "Elma";
            sepet[1] = "Armut";
            for (int i = 0; i < eleman; i++)
            {
                Console.WriteLine(sepet[i]);
            }
        }
        struct Kitap
        {
            public string ad;
            public string yazar;
            public int basimYili;
        }
        static void KitaplariYazdir(Kitap[] kitaplar)
        {
            foreach (Kitap kitap in kitaplar)
            {
                Console.WriteLine("{0}, Yazar: {1}, Basım Yılı: {2}", kitap.ad, kitap.yazar, kitap.basimYili);
            }
        }
        static void StructOrnegi()
        {
            Kitap[] kitaplar = new Kitap[3];

            Kitap kitap1;
            kitap1.ad = "Uçurtma Avcısı";
            kitap1.yazar = "Khaled Hosseini";
            kitap1.basimYili = 2003;

            Kitap kitap2 = new Kitap();
            kitap2.ad = "Java Programlama";
            kitap2.yazar = "Faruk SAYGIN";

            Kitap kitap3 = kitap1;
            kitap3.ad = "C++ ile Programlama";

            kitaplar[0] = kitap1;
            kitaplar[1] = kitap2;
            kitaplar[2] = kitap3;

            KitaplariYazdir(kitaplar);
        }
        static void Main(string[] args)
        {
            //SepetOrnegi();
            StructOrnegi();
        }
    }
}
