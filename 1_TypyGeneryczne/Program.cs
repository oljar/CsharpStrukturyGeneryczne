using System;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            var kolejkaInt = new KolejkaKolowa<int>();
            var kolejkaString = new KolejkaKolowa<string>(1000);
            var kolejkaOsob = new KolejkaKolowa<Osoba>();
            kolejkaOsob.Zapisz(new Osoba { Imie = "Włodzimierz", Nazwisko = "LeN" });
            kolejkaOsob.Zapisz(new Osoba { Imie = "Józef", Nazwisko = "Stalowy" });
            kolejkaOsob.Zapisz(new Osoba { Imie = "Adolf", Nazwisko = "Wąsaty" });
            kolejkaOsob.Zapisz(new Osoba { Imie = "Wład", Nazwisko = "Głupkowaty" });

            while (!kolejkaOsob.JestPusty)
            {
                //Console.WriteLine("\t\t" + kolejka.Czytaj());
                var wynik = kolejkaOsob.Czytaj().Imie;

                Console.WriteLine(wynik);


            }
            


            //while (true)
            //{

            //    var wartosc = 0.0;
            //    var wartoscwejsciowa = Console.ReadLine();
            //    if (double.TryParse(wartoscwejsciowa, out wartosc))
            //    {
            //        kolejka.Zapisz(wartosc);
            //        continue;
            //    }
            //    break;
            //}

            //var suma = 0.0;
           
            //Console.WriteLine("W kolejxce jest : ");

            //while (!kolejka.JestPusty)
            //{
            //    //Console.WriteLine("\t\t" + kolejka.Czytaj());
            //    suma += kolejka.Czytaj();
               

            //}
            //Console.WriteLine(suma);
        }
    }


    public class Osoba


    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }



    }












}
