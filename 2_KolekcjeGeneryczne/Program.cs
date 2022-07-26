using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {

        static void Main(string[] args)

        //inicjalizacja tabliczy z wartościami -1szy sposób
        {
             List<Pracownik> pracownicy = new List<Pracownik> 
            {
                new Pracownik { Imie="Joe", Nazwisko= "Kowalski" },
                new Pracownik { Imie="Józef", Nazwisko= "Kowalski" },
                new Pracownik { Imie="Robert", Nazwisko= "Lewandowski" },

            };

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine(pracownik.Imie + "  " + pracownik.Nazwisko);
            }


            //zamiast pracownicy.lenght - pracownicy count


            for (int i = 0; i < pracownicy.Count; i++)
            {

                Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
            }

            //inicjalizacja tabliczy z wartościami -2gi sposób
            List<Pracownik> pracownicy2 = new List<Pracownik>();

            pracownicy2.Add(new Pracownik { Imie = "Elon", Nazwisko = "Musk" });
            pracownicy2.Add(new Pracownik { Imie = "Robert", Nazwisko = "Lewandowski" });




            foreach (var pracownik in pracownicy2)
            {
                Console.WriteLine(pracownik.Imie + "  " + pracownik.Nazwisko);
            }


            //inicjalizacja tabliczy z wartościami -1szy sposób
            List<int> listaLiczb = new List<int> { 1, 2, 3, 4, 5 };


            //inicjalizacja tabliczy z wartościami -2gi sposób
            List<int> listaLiczb2 = new List<int>();
            listaLiczb.Add(1);
            listaLiczb.Add(5);
            listaLiczb.Add(10);


            foreach (var i in listaLiczb)
            {
                Console.WriteLine(i);
            }

            foreach (var i in listaLiczb2)
            {
                Console.WriteLine(i);
            }



        }


             

    }

    


         
          
          
         
        
        
        
        

    
}