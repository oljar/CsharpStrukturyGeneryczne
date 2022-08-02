Za pomocą METOD ROZSZERZEŃ można rozszerzać klasę  ale nie zakłuca i nie wymusza (za pomocą interfejsu) jej stosowania.
Używamy gdzie potrzebujemy. - Może żyć w innej przestzeni nazw


Rozszerzenia - Extensions powinny być PUBLIC  i  STATIC
Można używać ogólnych parametrów typu w metodzie która nie jest częścią klasy generycznej .
Można używać wielu ogólnych parametrów typu w sygnaturze- ale to oznacza że każda oboczność jest inną metodą.
Defifnicja Typu zwracanego nie jest uwzględniania przy sprawdzaniu różnic metody. Tylko nazwa metody z parametrami metody(sygnatura metody),
oraz parametry wejściowe. 


Trzeba usunąć z definicji interfejsu IKolejka - definicję  metody - IEnumerable<Twyj>ElementJako<Twyj>();

Klasa statyczna nie przyjmuje parametrów Ogólnych - generycznych typu

Klasa z metodą typu Extenion musi być  STATYCZNA I PUBLICZNA 
Metoda typu  EXTENSION też musi być  STATYCZNA I PUBLICZNA 


Metoda rozszerzenia musi mieć słowo kluczowe this z elementem który chcemy rozszerzać (this IKolejka<T>kolejka) - metoda w oddzielnej klasie np. Extensions
Wywołne w Main .( VS - menu podpowiedzi metoda z strzałką na dół )

kolejka.Drukuj();