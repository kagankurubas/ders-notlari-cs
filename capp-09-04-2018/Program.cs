using System;

namespace capp_09_04_2018
{
    class Kompleks
    {
        private double mGercek;
        private double mSanal;
        public double Gercek
        {
            get
            {
                return mGercek;
            }
            set
            {
                mGercek = value;
            }
        }
        public double Sanal
        {
            get
            {
                return mSanal;
            }
            set
            {
                mSanal = value;
            }
        }
        public Kompleks(double a, double b)
        {
            mGercek = a;
            mSanal = b;
        }
        public Kompleks()
        {
            mGercek = 0;
            mSanal = 0;
        }
        public Kompleks(Kompleks a)
        {
            mGercek = a.Gercek;
            mSanal = a.Sanal;
        }
        public void Yazdir()
        {
            Console.Write("{0} ", mGercek, mSanal);
            if (mSanal > 0)
                Console.Write("+ {0}j", mSanal);
            else
                Console.Write("- {0}j", mSanal);
            Console.WriteLine();
        }
        public static Kompleks operator +(Kompleks a, Kompleks b)
        {
            double GercekToplam = a.Gercek + b.Gercek;
            double SanalToplam = a.Sanal + b.Sanal;
            return new Kompleks(GercekToplam, SanalToplam);
        }
        public static Kompleks operator +(Kompleks a, double b)
        {
            double GercekToplam = a.Gercek + b;
            return new Kompleks(GercekToplam, a.Sanal);
        }
        public static Kompleks operator *(Kompleks a, Kompleks b)
        {
            double Sanal1 = a.Gercek * b.Sanal;
            double Sanal2 = a.Sanal * b.Gercek;
            double SanalCarpim = Sanal1 + Sanal2;

            double Gercek1 = a.Gercek * b.Gercek;
            double Gercek2 = a.Sanal * b.Sanal;
            double GercekCarpim = Gercek1 - Gercek2;

            return new Kompleks(GercekCarpim, SanalCarpim);
        }
        public static bool operator |(Kompleks a, Kompleks b)
        {
            if ((a.mSanal != 0 || a.mGercek != 0) | (b.mSanal != 0 || b.mGercek != 0))
                return true;
            else
                return false;
        }
        public static bool operator &(Kompleks a, Kompleks b)
        {
            if ((a.mSanal == 0 && a.mGercek == 0) | (b.mSanal == 0 && b.mGercek == 0))
                return false;
            else
                return true;
        }
        public static bool operator !(Kompleks a)
        {
            if (a.mSanal != 0 | a.mGercek != 0)
                return true;
            else
                return false;
        }
        public static implicit operator double(Kompleks a)
        {
            return a.mGercek;
        }
        public static implicit operator Kompleks(double a)
        {
            return new Kompleks(a, 0);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kompleks a = new Kompleks(-5, 9);
            Kompleks b = new Kompleks(1, 2);
            Kompleks c = a + b;
            c.Yazdir();
            Kompleks d = a + (double)7;
            d.Yazdir();
            Kompleks e = a + 5.6;
            e.Yazdir();
            Kompleks f = a * b;
            f.Yazdir();

            Console.WriteLine("---------------");

            Kompleks g = new Kompleks(5, 1);
            Kompleks h = new Kompleks(0, 1);
            Kompleks i = new Kompleks(0, 0);
            Kompleks j = new Kompleks(0, 0);
            if (g & h)
                Console.WriteLine("g & h -> doğru");
            else
                Console.WriteLine("g & h -> yanlış");
            if (g | i)
                Console.WriteLine("g | i -> doğru");
            else
                Console.WriteLine("g | i -> yanlış");
            if (i | j)
                Console.WriteLine("i | j -> doğru");
            else
                Console.WriteLine("i | j -> yanlış");
            if (!h)
                Console.WriteLine("!h -> doğru");
            else
                Console.WriteLine("!h -> yanlış");
            if (!i)
                Console.WriteLine("!i -> doğru");
            else
                Console.WriteLine("!i -> yanlış");

            Console.WriteLine("---------------");

            Kompleks kompleks = new Kompleks(5, 1);
            double k = kompleks;
            Console.WriteLine(k);
            kompleks = 6.2;
            Console.WriteLine(kompleks.Gercek);
            Console.WriteLine(kompleks.Sanal);
        }
    }
}
