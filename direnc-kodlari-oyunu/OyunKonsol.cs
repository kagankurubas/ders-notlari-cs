using System;
using System.Collections.Generic;

namespace direnc_kodlari_oyunu
{
    class OyunKonsol
    {
        const int PADDING = 2;
        const int BOSLUK = 4;
        public static void konsolaYaz(string[] satirlar, int bosluk = OyunKonsol.BOSLUK)
        {
            Console.Clear();
            const int icGenislik = 15;

            Console.Write(Statik.solUst);
            OyunKonsol.karakterYaz(Statik.yatay, icGenislik);
            Console.WriteLine(Statik.sagUst);

            bool satirlarDahaBuyuk = (satirlar.Length > Statik.renkTablosu.Length) ? true : false;
            int i, tekrar = (satirlarDahaBuyuk) ? Statik.renkTablosu.Length : satirlar.Length;

            for (i = 0; i < tekrar; i++)
            {
                Console.Write("{1}{0}{2}{0}{1}{0}{3,2}{0}{1}", Statik.bosluk, Statik.dikey, Statik.renkTablosu[i], i);
                OyunKonsol.karakterYaz(Statik.bosluk, bosluk);

                Console.Write(satirlar[i]);
                Console.WriteLine();
            }

            if (satirlar.Length == Statik.renkTablosu.Length + 1)
            {
                Console.Write(Statik.solAlt);
                OyunKonsol.karakterYaz(Statik.yatay, icGenislik);
                Console.Write(Statik.sagAlt);
                OyunKonsol.karakterYaz(Statik.bosluk, bosluk);
                Console.Write(satirlar[i]);
            }
            else if (!satirlarDahaBuyuk)
            {
                for (int j = i; j < Statik.renkTablosu.Length; j++)
                    Console.WriteLine("{1}{0}{2}{0}{1}{0}{3,2}{0}{1}", Statik.bosluk, Statik.dikey, Statik.renkTablosu[j], j);

                Console.Write(Statik.solAlt);
                OyunKonsol.karakterYaz(Statik.yatay, icGenislik);
                Console.Write(Statik.sagAlt);
                OyunKonsol.karakterYaz(Statik.bosluk, bosluk);
            }
            else
            {
                Console.Write(Statik.solAlt);
                OyunKonsol.karakterYaz(Statik.yatay, icGenislik);
                Console.Write(Statik.sagAlt);
                OyunKonsol.karakterYaz(Statik.bosluk, bosluk);
                Console.WriteLine(satirlar[i]);
                int j;
                for (j = i + 1; j < satirlar.Length - 1; j++)
                {
                    OyunKonsol.karakterYaz(Statik.bosluk, icGenislik + 2 + bosluk);
                    Console.WriteLine(satirlar[j]);
                }
                OyunKonsol.karakterYaz(Statik.bosluk, icGenislik + 2 + bosluk);
                Console.Write(satirlar[j]);
            }
        }
        public static void konsolaYaz(string satir, int bosluk = OyunKonsol.BOSLUK)
        {
            OyunKonsol.konsolaYaz(new string[] { satir }, bosluk);
        }
        public static string[] cerceveOlustur(string[] satirlar, int padding = OyunKonsol.PADDING)
        {
            List<string> cerceve = new List<string>();

            int enGenis = 0;
            foreach (string satir in satirlar)
            {
                if (satir.Length > enGenis)
                    enGenis = satir.Length;
            }
            int icGenislik = enGenis + (padding * 2);

            cerceve.Add(Statik.solUst + OyunKonsol.karakterCiz(Statik.yatay, icGenislik) + Statik.sagUst);

            for (int i = 0; i < padding / 2; i++)
                cerceve.Add(String.Format("{1}{0}{1}", OyunKonsol.karakterCiz(Statik.bosluk, icGenislik), Statik.dikey));

            foreach (string satir in satirlar)
            {
                int sagPadding = icGenislik - (padding + satir.Length);
                cerceve.Add(String.Format("{1}{0}{3}{2}{1}",
                    OyunKonsol.karakterCiz(Statik.bosluk, padding),
                    Statik.dikey,
                    OyunKonsol.karakterCiz(Statik.bosluk, sagPadding),
                    satir
                ));
            }

            for (int i = 0; i < padding / 2; i++)
                cerceve.Add(String.Format("{1}{0}{1}", OyunKonsol.karakterCiz(Statik.bosluk, icGenislik), Statik.dikey));

            cerceve.Add(Statik.solAlt + OyunKonsol.karakterCiz(Statik.yatay, icGenislik) + Statik.sagAlt);

            return cerceve.ToArray();
        }
        public static string[] cerceveOlustur(string metin, int padding = OyunKonsol.PADDING)
        {
            return OyunKonsol.cerceveOlustur(new string[] { metin }, padding);
        }
        public static void cerceveYaz(string[] satirlar, int padding = OyunKonsol.PADDING)
        {
            string[] cerceve = OyunKonsol.cerceveOlustur(satirlar, padding);
            foreach (string satir in cerceve)
                Console.WriteLine(satir);

        }
        public static void cerceveYaz(string satir, int padding = OyunKonsol.PADDING)
        {
            string[] cerceve = OyunKonsol.cerceveOlustur(satir, padding);
            foreach (string cSatir in cerceve)
                Console.WriteLine(satir);
        }
        static void karakterYaz(char karakter, int adet)
        {
            Console.Write(OyunKonsol.karakterCiz(karakter, adet));
        }
        static string karakterCiz(char karakter, int adet)
        {
            string satir = "";
            for (int i = 0; i < adet; i++)
                satir += karakter;
            return satir;
        }
    }
}