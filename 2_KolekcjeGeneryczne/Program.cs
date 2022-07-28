using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Ania", Nazwisko = "Kowal" });
            kolejka.Enqueue(new Pracownik { Imie = "Joe", Nazwisko = "Smith" });
            kolejka.Enqueue(new Pracownik { Imie = "Tom", Nazwisko = "Zalesky" });
            
            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + "  " + pracownik.Nazwisko);
            }
        
        }


             

    }

    


         
          
          
         
        
        
        
        

    
}