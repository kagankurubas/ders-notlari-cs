using System;

namespace capp_05_03_2018
{
    class Toplama
    {
        int x;
        int y;
        public Toplama(int x, int y)
        {
            Console.WriteLine("Yapıcı metot çalıştı.");
            this.x = x;
            this.y = y;
        }
        public int Islem()
        {
            return x + y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Toplama t = new Toplama(25, 30);
            Console.WriteLine(t.Islem());
        }
    }
}
