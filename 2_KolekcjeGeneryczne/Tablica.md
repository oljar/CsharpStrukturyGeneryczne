{
Pracownik[] pracownicy = new Pracownik[]
            {
                new Pracownik { Imie="Joe", Nazwisko= "Kowalski" },
                new Pracownik { Imie="Józef", Nazwisko= "Kowalski" },
                new Pracownik { Imie="Robert", Nazwisko= "Lewandowski" },

            };



 Pracownik[] tab = new Pracownik[4];


            tab[0] = new Pracownik { Imie = "Alan", Nazwisko = "Braz" };
            tab[1] = new Pracownik { Imie = "Leon", Nazwisko = "Leonidas" };
            tab[2] = new Pracownik { Imie = "Robert", Nazwisko = "Dab " };
            tab[3] = new Pracownik { Imie = "Wlod", Nazwisko = "Put" };




int[] tablica1 = new int[] { 5, 6, 7, 8 };

tablica1[0] = 100;

}

W tablicach C# nie można dodawać elementów. Nie działają metody ADD, INSERT, APPEND itp.

Zmiana zawartości tablicy 
tablica [i] = x

Zmianę wielkości tablicy można dokonać tworząc nową tablicę - ale jest to niewydajne.

{
Array.Resize(ref tablica1, 31);
}


