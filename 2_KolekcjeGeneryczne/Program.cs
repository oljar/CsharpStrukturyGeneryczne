using System;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {

        static void Main(string[] args)

        //inicjalizacja tabliczy z wartościami -1szy sposób
        {
            Pracownik[] pracownicy = new Pracownik[]
            {
                new Pracownik { Imie="Joe", Nazwisko= "Kowalski" },
                new Pracownik { Imie="Józef", Nazwisko= "Kowalski" },
                new Pracownik { Imie="Robert", Nazwisko= "Lewandowski" },

            };

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine(pracownik.Imie + "  " + pracownik.Nazwisko);
            }


            for (int i = 0; i < pracownicy.Length; i++)
            {

                Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
            }




            //inicjalizacja tablicy  z wartościami - drugi sposób

            Pracownik[] tab = new Pracownik[4];


            tab[0] = new Pracownik { Imie = "Alan", Nazwisko = "Braz" };
            tab[1] = new Pracownik { Imie = "Leon", Nazwisko = "Leonidas" };
            tab[2] = new Pracownik { Imie = "Robert", Nazwisko = "Dab " };
            tab[3] = new Pracownik { Imie = "Wlod", Nazwisko = "Put" };

            foreach (var i in tab)
            {
                Console.WriteLine(i.Imie + "  " + i.Nazwisko);
            }

            //inicjalizacja tablicy  z int

            int[] tablica = new int[4];

            tablica[0] = 1;   
            tablica[1] = 2;   
            tablica[2] = 3;   
            tablica[3] = 4;


            foreach (var i in tablica)
            {
                Console.WriteLine(i);
            }


            //inicjalizacja tablicy  z int

            int[] tablica1 = new int[] { 5, 6, 7, 8 };

            tablica1[0] = 100;

            foreach (var i in tablica1)
            {
                Console.WriteLine(i);
            }



            //powiększenie tablicy przez stworzenie nowej
            Array.Resize(ref tablica1, 31);

            tablica1[30] = 991;
            for (int i = 0; i < tablica1.Length; i++)
            {

                Console.WriteLine(tablica1[i]);
            }




        }


             

    }

    


         
          
          
         
        
        
        
        

    
}