using System;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa(pojemnosc: 3);

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

            var suma = 0.0;
            Console.WriteLine("W kolejxce jest : ");

            while (!kolejka.JestPusty)
            {
                //Console.WriteLine("\t\t" + kolejka.Czytaj());

                var wartosc = kolejka.Czytaj();

                if (wartosc is double)
                {
                    suma += (double)wartosc;
                }

            }
            Console.WriteLine("\t\t" + suma);
        }
    }
}
