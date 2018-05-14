using System;
using System.Collections.Generic;

namespace direnc_kodlari_oyunu
{
    class Statik
    {
        static public string[] renkTablosu = {
            "   Siyah",
            "Kahverng",
            " Kırmızı",
            " Turuncu",
            "    Sarı",
            "   Yeşil",
            "    Mavi",
            "     Mor",
            "     Gri",
            "   Beyaz",
        };
        static public ConsoleColor[] renkDegerleri = {
            ConsoleColor.White,
            ConsoleColor.White,
            ConsoleColor.White,
            ConsoleColor.White,
            ConsoleColor.White,
            ConsoleColor.White,
            ConsoleColor.White,
            ConsoleColor.White,
            ConsoleColor.White,
            ConsoleColor.White,
        };
        public const char solUst = '┌';
        public const char solAlt = '└';
        public const char sagAlt = '┘';
        public const char sagUst = '┐';
        public const char yatay = '─';
        public const char dikey = '│';
        public const char bosluk = ' ';
    }
}