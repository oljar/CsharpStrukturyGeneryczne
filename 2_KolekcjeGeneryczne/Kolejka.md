Kolejka Generyczna -Pierwszy element wchodzi - Pierwszy wychodzi -   FIFO 
Np. Zamówienia w sklepie internetowym . Kto pierwszy przyszedł zostaje obsłużony. 
Np. Kolejka pracowników przy biurku. 
Np. Używana  do obsługi żądań. 

Element który przychodzi jest oustawiany na końcu kolejki.Nie ma dostępu losowego przez index



Metoda Enquque() stawia element na końcu kolejki 
Metoda Dequeue() pobiera pierwszy element z kolejki- oraz usuwa ten element
Metoda Peek - pobiera aktulny element - podgąda co jest na pierwszym miejscu kolejki - nie usuwa.
Metoda Contains - Sprawdza czy dany element jest w kolejce oddaje True/False 

{
	Queue<Pracownik> kolejka = new Queue<Pracownik>();
	kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
	var pracownik = kolejka.Dequeue(); - pobiera - usuwa
	var pracownik = kolejka.Peek();  - pobiera -  nieusuwa
	kolejka.Contains(2) // zwraca True/False jak zawiera element
	kolejka.ToArray() - zrzuca do TABLICY
	kolejka.Clear() - czyści kolejkę.  - Assert.AreEqual(0, kolejka.Count);
	kolejka.Count() liczy ilość elementów. 

	}

