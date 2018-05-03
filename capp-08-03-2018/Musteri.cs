using System;

namespace capp_08_03_2018
{
    class Musteri
    {
        string isim;
        int gun, ay, yil;
        public int[] DogumTarihi
        {
            get
            {
                return new int[] { gun, ay, yil };
            }
            set
            {
                gun = value[0];
                ay = (value.Length > 1) ? value[1] : ay;
                yil = (value.Length > 2) ? value[2] : yil;
            }
        }
        public string Isim
        {
            get
            {
                return isim;
            }
        }
        public Musteri(string isim = "İsimsiz")
        {
            this.isim = isim;
        }

    }
}
