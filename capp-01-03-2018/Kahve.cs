using System;

namespace capp_01_03_2018
{
    class Kahve
    {
        const string COKTANHAZIR = "Kahve çoktan hazırlandı!";
        const string FAZLASEKER = "5 şekerden fazla atamazsınız!";
        const string SEKERYOK = "Çıkarıcak şeker kalmadı!";
        private string kaynak;
        private int seker;
        private bool filtre;
        private bool sutlu;
        private bool hazir;

        public bool sekerEkle(int seker)
        {
            if (this.seker + seker > 5)
            {
                hataYazdir(FAZLASEKER);
                return false;
            }
            this.seker += seker;
            return true;
        }

        public bool sekerCikar()
        {
            if (this.seker < 1)
            {
                hataYazdir(SEKERYOK);
                return false;
            }
            this.seker -= 1;
            return true;
        }

        public Kahve hazirla()
        {
            this.hazir = true;
            return this;
        }

        public void kaynakSec(string kaynak)
        {
            if (this.hazir)
                hataYazdir(COKTANHAZIR);
            else
                this.kaynak = kaynak;
        }

        public void sutEkle()
        {
            if (this.hazir)
                hataYazdir(COKTANHAZIR);
            else
                this.sutlu = true;
        }

        public void suz()
        {
            if (this.hazir)
                hataYazdir(COKTANHAZIR);
            else
                this.filtre = true;
        }

        private void hataYazdir(string hata)
        {
            Console.WriteLine(hata);
        }

        public void kahveYazdir()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", this.kaynak, this.seker == 0 ? "Şekersiz" : Convert.ToString(this.seker) + " şekerli", this.sutlu == true ? "Sütlü" : "Sütsüz", this.filtre == true ? "Filtreli" : "Filtresiz");
        }
    }
}
