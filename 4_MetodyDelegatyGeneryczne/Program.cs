using System;

namespace _4_MetodyDelegatyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {

            Action<double> drukuj = x => Console.WriteLine(x);


            // Delegat Func pozwala na podpięcie pod zmienną typu który coś zwraca
            // Nadaje się świetnie do obliczeń matemetycznych
            // Ostatnim parametrem zawsze jest typ zwracany

            Func<double, double> potegowanie = d => d * d;
            Func<double, double, double> dodaj = (x, y) => x + y;
            drukuj(potegowanie(2));
            drukuj(dodaj(2, 4));

            Action<bool> drukuj1 = x => Console.WriteLine(x);

            // Delegat Predicate<Tin> zwraca wartość bool  
            Predicate<double> jestWiekszeOdDwa = d => d > 2;

            drukuj1(jestWiekszeOdDwa(potegowanie(dodaj(1, 1))));


          
        }
    }


    public class Osoba


    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }



    }

}
