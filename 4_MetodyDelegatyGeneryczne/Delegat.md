Delegat zwykły - Pozwala za pomocą zmiennej nadać odniesienie do metody.
1. Tworzymy metodę statyczną Drukuj  w klasie

public static void Drukuj<T>(this IKolejka<T> kolejka,Drukarka wydruk)
// this jest wpisane ze względu na to że jest to metoda rozszerzająca. 

którą będziemy wywoływać w Main:
kolejka.Drukuj(konsolaWyjscie);

2. Deklarujemy DELEGAT też w klasie KolejkaExtensions.cs

// Deklaracja delegatu
    public delegate void Drukarka(object dane);

3. W Program.cs deklarujemy zmienną  - konsolaWyjscie - jest to DELEGAT . W Parametrze konstruktora posiada konsolaWypisz - metodę statyczną.

 Drukarka konsolaWyjscie = new Drukarka(KonsolaWypisz)

 4. Tworzymy metodę statyczną KonsolaWypisz - którą można wg potrzeby zmieniać.  

 static void KonsolaWypisz(object dane)//   Tu możnaby podstawić metodę druku na papier lub zapisu w bazie danych.
            {
                Console.WriteLine($"Wypisuję za pomocą delegata {dane}");

            }
5. Wywołanie w Program / Main

kolejka.Drukuj(konsolaWyjscie);


/// 
Do delegata wstawiamy metodę statyczną

