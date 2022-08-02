using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _4_MetodyDelegatyGeneryczne
{

    //Klasa z  Extension musi być PUBLIC i STATIC
    public static class KolejkaExtensions
    {
        // Metoda rozszerzenia musi mieć słowo kluczowe this z elementem który chcemy rozszerzać (this IKolejka<T>kolejka)
       
        //Metoda również musi być Static

        // Metoda poniższa powoduje konwersję typu
        public static IEnumerable<Twyj> ElementJako<T,Twyj>(this IKolejka<T>kolejka) // Metoda również może przyjmować 1-en lub więcej parametr typu w sygnaturze metody.
        {
            var konwerter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in kolejka)
            {
                Twyj wynik = (Twyj)konwerter.ConvertTo(item, typeof(Twyj));
                yield return (Twyj)wynik;
            }
 
        }

        // Metoda poniższa powoduje drkukowanie
        public static void Drukuj<T>(this IKolejka<T> kolejka)
        {

            foreach(var item in kolejka)
            {
                Console.WriteLine($"Metoda Rozszerzenia{item}");

            }
        }
    
    
    
    }


}

// klasa statyczna nie przyjmuje parametrów Ogólnych - generycznych typu

//  Trzeba usunąć z definicji interfejsu IKolejka - definicję  metody - IEnumerable<Twyj>ElementJako<Twyj>();
//  Można używać ogólnych parametrów typu w metodzie która nie jest częścią klasy generycznej .
//  Można używać wielu ogólnych parametrów typu w sygnaturze- ale to oznacza że każda oboczność jest inną metodą.
// Defifnicja Typu zwracanego nie jest uwzględniania przy sprawdzaniu różnic metody. Tylko nazwa metody z parametrami metody(sygnatura metody),
// oraz parametry wejściowe. 
