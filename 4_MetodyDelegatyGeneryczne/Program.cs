﻿using System;

namespace _4_MetodyDelegatyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
           
                var kolejka = new KolejkaKolowa<double>(pojemnosc:3);

                 // Dodałem subskrybenta do tego wydarzenia.
                kolejka.elementusuniety += Kolejka_elementUsuniety;

                WprowadzanieDanych(kolejka);

           

              



                

            }



        private static void Kolejka_elementUsuniety(object sender,ElementUsunietyEventArgs<double> e)
        {
            Console.WriteLine("kolejka jest pełna.Element usuniety to {0}  Nowy element to {1} ", e.ElementUsuniety, e.ElementNowy);
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
