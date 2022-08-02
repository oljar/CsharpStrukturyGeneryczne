using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _4_MetodyDelegatyGeneryczne
{   
    
    // Deklaracja delegatu

    public static class KolejkaExtensions
    {
        public static IEnumerable<Twyj> ElementJako<T,Twyj>(this IKolejka<T>kolejka) 
        {
            var konwerter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in kolejka)
            {
                Twyj wynik = (Twyj)konwerter.ConvertTo(item, typeof(Twyj));
                yield return (Twyj)wynik;
            }
 
        }


        // Statyczna metoda Drukuj definiuje  
     
        public static void Drukuj<T>(this IKolejka<T> kolejka,Action<T> wydruk) // W 2-im parametrze dodano obiekt wydruk - typ Drukarka
         // zmienna wydruk  jest typem delegatem czyli zmienną która posiada odniesienie do metody. 
        
        {

            foreach(var item in kolejka)
            {
                wydruk(item);
                 
            }
        }
    
    
    
    }


}

