using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Kolejka();

            Stos();

            HashSet();

        }

        private static void HashSet()
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Add(6);
            set.Add(7);
            set.Add(8);
            set.Add(9);

            var test1 = set.Add(10);
            var test2 = set.Add(10);
            Console.WriteLine($"Pierwsze dodanie 10 {test1}");
            Console.WriteLine($"Drugie dodanie 10 {test2}");


            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            // Add zwraca True jak nastąpi dodoanie do zbioru 
            Console.WriteLine($"Pierwsze dodanie 10 {test1}");
            Console.WriteLine($"Drugie dodanie 10 {test2}");




            HashSet<Pracownik> setString = new HashSet<Pracownik>();
            setString.Add(new Pracownik { Imie = "Jaro" });

            setString.Add(new Pracownik { Imie = "Jaro" });


            // Dwa różne same obiekty więc Kompilator nie wychwyci że są te same. 

            foreach (var item in setString)
            {

                Console.WriteLine(item.Imie);
            }
            Console.WriteLine("Dwa różne same obiekty więc Kompilator nie wychwyci że są te same");



            // Jeśli będzie ten sam obiekt to kompilator to wykryje.


            HashSet<Pracownik> setNowyString = new HashSet<Pracownik>();
            var pracownik = new Pracownik { Imie = "Jaro" };

            var testA = setNowyString.Add(pracownik);
            var testB = setNowyString.Add(pracownik);
            Console.WriteLine();
            Console.WriteLine($"Jeśli obiekt jest ten sam kompilator to wychwyci ");
            Console.WriteLine($"Pierwsze dodanie { testA }");
            Console.WriteLine($"Drugie dodanie { testB }");
        }

        private static void Stos()
        {
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Ania", Nazwisko = "Kowal" });
            stos.Push(new Pracownik { Imie = "Joe", Nazwisko = "Smith" });
            stos.Push(new Pracownik { Imie = "Tom", Nazwisko = "Zalesky" });
            Console.WriteLine();

            Console.WriteLine("Stos");

            while (stos.Count > 0)

            {
                var pracownik = stos.Pop();
                Console.WriteLine(pracownik.Imie + "  " + pracownik.Nazwisko);
            }
        }

        private static void Kolejka()
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Ania", Nazwisko = "Kowal" });
            kolejka.Enqueue(new Pracownik { Imie = "Joe", Nazwisko = "Smith" });
            kolejka.Enqueue(new Pracownik { Imie = "Tom", Nazwisko = "Zalesky" });


            Console.WriteLine("Kolejka");

            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + "  " + pracownik.Nazwisko);
            }
        }

    }

    


         
          
          
         
        
        
        
        

    
}