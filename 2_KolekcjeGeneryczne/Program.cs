using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kolejka();

            // Stos();

            // HashSet();


            //LinkedList1();
            //LinkedList2();


            //Dictionary1();

            //Dictionary2();

            //SortedDictionary();


            //SortedList();

            // SortedList_2();

            var pracownicy = new DzialyKolekcja();

            pracownicy.Add("Sprzedaż", new Pracownik { Nazwisko = "Brzęczyszczykiewicz" })
                      .Add("Sprzedaż", new Pracownik { Nazwisko = "Kaczor" })
                      .Add("Sprzedaż", new Pracownik { Nazwisko = "Bar" })
                      .Add("Sprzedaż", new Pracownik { Nazwisko = "Jar" });







            pracownicy.Add("Handlowy", new Pracownik { Nazwisko = "Tayor" })
                  .Add("Handlowy", new Pracownik { Nazwisko = "Willis" })
                  .Add("Handlowy", new Pracownik { Nazwisko = "Mae" })
                  .Add("Handlowy", new Pracownik { Nazwisko = "Jare" });



            foreach (var dzial in pracownicy)
            {
                Console.WriteLine(dzial.Key);
                foreach ( var pracownik in dzial.Value)
                {
                    Console.WriteLine("\t" + pracownik.Nazwisko);

                }
            }

        }

        private static void SortedList_2()
        {
            var set1 = new SortedSet<int>();
            set1.Add(8);
            set1.Add(7);
            set1.Add(6);
            set1.Add(5);
            set1.Add(90);
            set1.Add(70);
            set1.Add(1);
            set1.Add(17);
            set1.Add(17);
            set1.Add(36);
            set1.Add(10);

            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }

            var set2 = new SortedSet<string>();
            set2.Add("d");
            set2.Add("z");
            set2.Add("w");
            set2.Add("a");
            set2.Add("g");
            set2.Add("h");
            set2.Add("j");
            set2.Add("k");
            set2.Add("k");
            set2.Add("r");
            set2.Add("t");

            foreach (var item in set2)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedList()
        {
            var listaPosortowana = new SortedList<int, string>();
            listaPosortowana.Add(3, "trzy");
            listaPosortowana.Add(1, "jeden");
            listaPosortowana.Add(4, "cztery");
            listaPosortowana.Add(2, "dwa");

            foreach (var item in listaPosortowana)

            {
                Console.WriteLine(item.Value);

            }
        }

        private static void SortedDictionary()
        {


            // Sortuje kolejność klucza przy wypisywaniu. 

            var pracownicy = new SortedDictionary<string, List<Pracownik>>();


            pracownicy.Add("Kontroli", new List<Pracownik> { new Pracownik {Imie = "Olek", Nazwisko = "Dżugaszwili" },
                                                           new Pracownik {Imie = "Szymon", Nazwisko = "Swade" },
                                                           new Pracownik {Imie = "Wiesław", Nazwisko = "Orłowski" } });


            pracownicy.Add("Handlowy", new List<Pracownik> { new Pracownik {Imie = "Adam", Nazwisko = "Nowak" },
                                                           new Pracownik {Imie = "Tomek", Nazwisko = "As" },
                                                           new Pracownik {Imie = "Robert", Nazwisko = "Wars" } });





            pracownicy.Add("Napraw", new List<Pracownik> { new Pracownik {Imie = "Radosław", Nazwisko = "Gugała" },
                                                           new Pracownik {Imie = "Sławomir", Nazwisko = "Mocny" },
                                                          });




            foreach (var item in pracownicy)
            {
                Console.WriteLine($"Dział:{item.Key} ; ilość pracowników:{item.Value.Count}");
            }
        }

        private static void Dictionary2()
        {

            //Inicjalizacja słownika 

            var pracownicy = new Dictionary<string, List<Pracownik>>();
            pracownicy.Add("Barbor", new List<Pracownik>() { new Pracownik { Nazwisko = "Olsza" }, new Pracownik { Nazwisko = "Nowak" } });
            pracownicy["Barbor"].Add(new Pracownik { Nazwisko = "Nowak" });

            foreach (var item in pracownicy)
            {
                Console.WriteLine();
                Console.WriteLine("Firma : " + item.Key);

                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine(pracownik.Nazwisko);
                }

            }


            var pracownicyDzial = new Dictionary<string, List<Pracownik>>();
            pracownicyDzial.Add("Ksiegowosc", new List<Pracownik>() { new Pracownik { Nazwisko = "Więcek" },
                                                                      new Pracownik { Nazwisko = "Kaczor" },
                                                                      new Pracownik { Nazwisko = "Wisniewski" },
                                                                                                            });

            pracownicyDzial["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Wielowiejski" });


            pracownicyDzial.Add("KontrolaJakosci", new List<Pracownik>() { new Pracownik { Nazwisko = "Żubr" },
                                                                      new Pracownik { Nazwisko = "Wiśniewski" },
                                                                      new Pracownik { Nazwisko = "Formela" },
                                                                                                            });

            pracownicyDzial["KontrolaJakosci"].Add(new Pracownik { Nazwisko = "Waldorf" });







            foreach (var item in pracownicyDzial)

            {
                Console.WriteLine();
                Console.WriteLine("Dział : " + item.Key);

                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine(pracownik.Nazwisko);
                }

            }



            Console.WriteLine();
            var lista = new List<string>();


            foreach (var item in pracownicyDzial.Keys)
            {
                lista.Add(item);

            }

            Console.WriteLine($"lista działów {lista[1]}");
            foreach (var item in pracownicyDzial["Ksiegowosc"])
            {
                Console.WriteLine(item.Nazwisko);
            }
        }

        private static void Dictionary1()
        {
            //Inicjalizacja słownika 
            // Dictionary<string, Pracownik> pracownicy = new Dictionary<string, Pracownik>();
            var pracownicy = new Dictionary<string, Pracownik>();
            pracownicy.Add("ksywaNowy", new Pracownik { Nazwisko = "Nowak" });
            pracownicy.Add("ksywaAnioł", new Pracownik { Nazwisko = "Anioł" });
            pracownicy.Add("KsywaBlacha", new Pracownik { Nazwisko = "Balcerek" });

            var kowal = pracownicy["ksywaNowy"];
            foreach (var pracownik in pracownicy)

            {

                Console.WriteLine($"Klucz - {pracownik.Key}   Wartość - {pracownik.Value.Nazwisko} ");

            }
        }

        private static void LinkedList1()
        {
            LinkedList<int> lista = new LinkedList<int>();

            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);

            // First pobiera pierwszy element
            var elementPierwszy = lista.First;

            // Last pobiera ostatni element
            var elementOstatni = lista.Last;


            // AddAfter wstawia po wskazanym elemencie określony element 
            lista.AddAfter(elementPierwszy, 1000);


            // AddBefore wstawia po wskazanym elemencie określony element 
            lista.AddBefore(elementPierwszy, 5551);

            foreach (var item in lista)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine();

            //inny sposób przechodznia przez listę 
            var wezel = lista.First;
            while (wezel != null)
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }

        private static void LinkedList2()
        {
            LinkedList<int> lista = new LinkedList<int>();

            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);
            lista.AddLast(1);
            lista.AddLast(2);

            foreach (var item in lista)
            {
                Console.WriteLine(item);

            }
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