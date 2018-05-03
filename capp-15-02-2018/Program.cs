using System;

namespace capp_15_02_2018
{
    class Program
    {
        static long Fibonacci(int index, long a = 1, long b = 1)
        {
            Console.WriteLine(a);
            if (index == 1)
                return a;
            else if (index == 2)
                return b;
            else
                return Fibonacci(index - 1, b, a + b);
        }
        static long Toplam(long son, long bas = 1, long deger = 0)
        {
            if (son == bas)
                return son + deger;
            return Toplam(son - 1, bas, son + deger);
        }
        static string Ters(string girdi)
        {
            if (girdi.Length == 1)
                return girdi;
            return girdi[girdi.Length - 1] + Ters(girdi.Substring(0, girdi.Length - 1));
        }
        static void Main(string[] args)
        {
            //Console.Write("n = ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0}. sayıya kadar olan fibonacci dizisi:", n);
            //Console.WriteLine(Fibonacci(n));

            //Console.WriteLine(Toplam(n, 10));

            Console.WriteLine(Ters("anan za xd"));
        }
    }
}
