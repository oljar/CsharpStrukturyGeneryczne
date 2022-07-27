	
        inicjalizacja tabliczy z wartościami -1szy sposób
        {
             List<Pracownik> pracownicy = new List<Pracownik> 
            {
                new Pracownik { Imie="Joe", Nazwisko= "Kowalski" },
                new Pracownik { Imie="Józef", Nazwisko= "Kowalski" },
                new Pracownik { Imie="Robert", Nazwisko= "Lewandowski" },

            };
        }



        inicjalizacja tabliczy z wartościami -2szy sposób

        {
            List<Pracownik> pracownicy2 = new List<Pracownik>();

            pracownicy2.Add(new Pracownik { Imie = "Elon", Nazwisko = "Musk" });
            pracownicy2.Add(new Pracownik { Imie = "Robert", Nazwisko = "Lewandowski" });

        {



	Lista C# pozwala na dodawanie dowolnie elementów.
	Długość list sprawdzamy metodą  count a nie length jak w tablicy.
	Metodą pozwalającą na dodawanie elementów listy jest   ***.Add(x)

    METODY LIST

    1)  Add- dodawanie elementu na koncu
    2)  Insert(pozycja,liczba)- dodawanie elementu wg pozycji
    3)  Remove - usuwanie liczby po wartosci
    4)  RemoveAt - usuwanie liczby z okreslonej pozycji
    5)  IndexOf - wyszukuje pozycje podanego  elementu. 
    6)  Contains - czy zawiera  okreslony element
    7)  AddRange - dodanie kolekcji na koniec.
