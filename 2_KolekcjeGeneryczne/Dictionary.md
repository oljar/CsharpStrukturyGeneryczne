Słownik - do wyszukiwania i lokalizowania elementów wg wartości klucza. 

Inicjalizacjia
var pracownicy = new Dictionary<string, Pracownik>();
            pracownicy.Add("ksywaNowy", new Pracownik { Nazwisko = "Nowak" });



var pracownicy = new Dictionary<string, List<Pracownik>>();
            pracownicy.Add("Barbor", new List<Pracownik>() { new Pracownik { Nazwisko = "Olsza" }, new Pracownik { Nazwisko = "Nowak" } });
            pracownicy["Barbor"].Add(new Pracownik { Nazwisko = "Nowak" });




 // mapa[1]  - otrzymujemy wartość za pomocą klucza
            Assert.AreEqual("jeden", mapa[1]);

Metody:

// mapa.ContainsKey(3) -Sprawdza czy jest klucz 3
Assert.IsTrue(mapa.ContainsKey(3));

// Usuwa element o kluczu 1
mapa.Remove(1);

// Count - zlicza ilość par
Assert.AreEqual(2, mapa.Count);

// Usuwa wszystkie elementy
mapa.Clear();




