using System;

namespace capp_19_04_2018
{
    class Sepet
    {
        private const string BOS_SLOT = "-boş-";
        private string[] meyveler;
        public Sepet(int eleman = 1)
        {
            meyveler = new string[eleman];
            for (int i = 0; i < meyveler.Length; i++)
            {
                meyveler[i] = BOS_SLOT;
            }
        }
        public string this[int index]
        {
            get { return meyveler[index]; }
            set { meyveler[index] = value; }
        }
    }
}
