﻿using System;

namespace _3_Interfejsy_KlasyOgolne
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var kolejka = new KolejkaKolowa<double> ();


                WprowadzanieDanych(kolejka);

                foreach (var item in kolejka)
                {
                    Console.WriteLine($" wyliczenie z pętli {item}");

                }




                PrzetwarzanieDanych(kolejka);

            }

            static void PrzetwarzanieDanych(IKolejka<double> kolejka)

            {
                var suma = 0.0;
                Console.WriteLine("W naszej kolejce jest :");

                while (!kolejka.JestPusty)
                {
                    suma += kolejka.Czytaj();
                }

                Console.WriteLine(suma);
            }



           
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
        {
            while (true)
            {

                var wartosc = 0.0;
                var wartoscwejsciowa = Console.ReadLine();
                if (double.TryParse(wartoscwejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
        }
    }


        public class Osoba


        {
            public string Imie { get; set; }
            public string Nazwisko { get; set; }



        }


}







