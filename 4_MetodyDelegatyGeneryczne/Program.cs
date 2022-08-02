using System;

namespace _4_MetodyDelegatyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            static void KonsolaWypisz(object dane)//   Tu możnaby podstawić metodę druku na papier lub zapisu w bazie danych.
            {
                Console.WriteLine($"Wypisuję za pomocą delegata {dane}");

            }

            
                var kolejka = new KolejkaKolowa<double>();


                WprowadzanieDanych(kolejka);

                //KonsolaWypisz  - metoda statyczna

                Drukarka konsolaWyjscie = new Drukarka(KonsolaWypisz);// konsolaWyjście - delegat - używa metody statycznej jako parametru


                //Wywołanie Statycznej metody Drukuj z KolejkaExtension  parametrem jest obiekt konsolaWyjście klasy Drukarka czyli DELEGAT. 

                
                // Poniżej użycie metody Drukuj z delegatem
                
                kolejka.Drukuj(konsolaWyjscie);




                var elementyJakoInt = kolejka.ElementJako<double,int>();



                foreach (var item in elementyJakoInt)
                {
                    Console.WriteLine(item);

                }



                PrzetwarzanieDanych(kolejka);

            

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
