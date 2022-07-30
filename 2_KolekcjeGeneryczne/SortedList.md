SortedList podobny do SortedDictionary.
SortedList przyjmuje rówież klucz i wartość.  Zoptymalizowany pod względem iteracji by jak najszybciej iterować 
SortedDictionary zoptymalizowany względem szybkiego dodawania elementów. 
Kolejność sortowania - wg klucza


Inicjalizacja

var listaPosortowana = new SortedList<int, string>();
listaPosortowana.Add(3, "trzy");