using System;

namespace capp_22_02_2018
{
    class Program
    {
        static double alan(double yaricap)
        {
            return Math.PI * Math.Pow(yaricap, 2);
        }
        static void sayi(int girdi, int son = 0)
        {
            if (girdi < son)
            {
                Exception hata = new Exception("Başlangıç değeri bitiş değerinden büyük olmalı.");
                throw hata;
            }
            Console.Write("{0} ", girdi);
            if (girdi == son)
            {
                Console.WriteLine();
                return;
            }
            sayi(girdi - 1, son);
        }
        static double VKIHesapla(double uzunluk, double agirlik)
        {
            return agirlik / Math.Pow(uzunluk / 100, 2);
        }
        static string VKIAnaliz(double vki)
        {
            if (vki > 45.0)
                return "Aşırı Obez III. Sınıf";
            else if (vki > 35.0)
                return "Obez II. Sınıf";
            else if (vki > 30.0)
                return "Obez I. Sınıf";
            else if (vki > 25.0)
                return "Fazla Kilolu";
            else if (vki > 18.5)
                return "Normal";
            else
                return "Zayıf";
        }
        static void Main(string[] args)
        {
            Console.Write("Boy (cm): ");
            double boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilo (kg): ");
            double kilo = Convert.ToDouble(Console.ReadLine());
            double vki = VKIHesapla(boy, kilo);
            Console.WriteLine("Vücut Kitle İndeksiniz: {1}\nDurumunuz: {0}", VKIAnaliz(vki), vki);
        }
    }
}
