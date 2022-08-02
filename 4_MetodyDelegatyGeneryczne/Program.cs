using System;

namespace _4_MetodyDelegatyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {


            static void KonsolaWypisz(double dane)
            {
                Console.WriteLine($"wypisuję na konsoli - metoda statyczna {dane}");
            }

            // Typ Action pozwala wpisać zmienną która będzie delegatem. Zmienna ta będzie się odnosiła do metody statycznej która  nic nie oddaje np Console.WriteLine();


            // użycie metody statycznej 
            Action<double> drukujA = KonsolaWypisz;

            //poniżej wywołanie metody. 
            drukujA(4.1);



            // uzycie metody anonimowej 
            Action<double> drukujB= delegate (double dane)
            {
                Console.WriteLine($"wypisuję na konsoli - metoda anonimowa {dane}");
            };

            drukujB(3.3);
            
            // uzycie lamdy
            Action<double> drukuj = d => Console.WriteLine($"wypisuję na konsoli - lambda {d}");

            drukuj(12);


            Action<int, int, int> test = (a, b, c) => Console.WriteLine(a+b+c);
            test(1, 2, 3);





            var kolejka = new KolejkaKolowa<double>();


                WprowadzanieDanych(kolejka);

                //KonsolaWypisz  - metoda statyczna

             


                kolejka.Drukuj(drukuj); // Za kulisami Komilator potrafi utworzyć delegata. 
 



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
