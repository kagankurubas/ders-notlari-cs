using System;

namespace capp_19_02_2018
{
    class Program
    {
        const sbyte TOPLA = 0;
        const sbyte CIKAR = 1;
        const sbyte CARP = 2;
        const sbyte BOL = 3;
        static float islem(int islem, params float[] girdiler)
        {
            switch (islem)
            {
                case TOPLA:
                    float sonuc = 0;
                    foreach (float i in girdiler)
                    {
                        sonuc += i;
                    }
                    return sonuc;
                case CIKAR:
                    float sonuc2 = girdiler[0];
                    for (int i = 1; i < girdiler.Length; i++)
                    {
                        sonuc2 -= girdiler[i];
                    }
                    return sonuc2;
                case CARP:
                    float sonuc3 = 1;
                    foreach (float i in girdiler)
                    {
                        sonuc3 *= i;
                    }
                    return sonuc3;
                case BOL:
                    float sonuc4 = girdiler[0];
                    for (int i = 1; i < girdiler.Length; i++)
                    {
                        sonuc4 /= girdiler[i];
                    }
                    return sonuc4;
                default:
                    Exception parametreHata = new Exception("Geçerli bir işlem parametresi girilemedi.");
                    throw parametreHata;
            }
        }
        static void Main(string[] args)
        {
            if (args.Length > 2)
            {
                sbyte islemTur = -1;
                switch (args[0])
                {
                    case "topla":
                        islemTur = TOPLA;
                        break;
                    case "çıkar":
                        islemTur = CIKAR;
                        break;
                    case "çarp":
                        islemTur = CARP;
                        break;
                    case "böl":
                        islemTur = BOL;
                        break;
                    default:
                        Exception parametreHata = new Exception("Geçerli bir işlem parametresi girilemedi.");
                        throw parametreHata;
                }
                float[] girdiler = new float[args.Length - 1];
                for (int i = 1; i < args.Length; i++)
                {
                    girdiler[i - 1] = float.Parse(args[i]);
                }
                try
                {
                    Console.WriteLine(islem(islemTur, girdiler));
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Bir hata meydana geldi.");
                }
            }
            else
                Console.WriteLine("Yetersiz parametreler.");
        }
    }
}
