HashSet - zbiór (unikalnych przedmotów)- zestaw 
Nie można pobrać losowego elementu za pomocą indeksu jak w kolejce i stosie
HashSet nie jest związany  kolejnością dodawanie - nie podlega FiFo / LiFo 
W HashSet nie znamy kolejności przechowwywania elementów.
Kilka Elementów takich samych jest redukowanych do 1go tego samego elementu. 

Aby HashSet wykrył że dany typy - obiekt referencyjny - jest musi być ten sam obiekt.
Typy wartości - int, double, datetime - są świetnie sprawdzane i nie ma możliwości dubla.

Inicjalizacja:
//
HashSet<int> set = new HashSet<int>();
//
var set1 = new HashSet<int> { 1, 2, 3, 4 };
HashSet<Pracownik> setString = new HashSet<Pracownik>();
setString.Add(new Pracownik { Imie = "Jaro" });
//


Metody : 
set1.Add() - Dodaje do zestawu element - zwraca True ( gdy jest dodany element) lub False 


// IntersectWith pozwala na wydzielenie części wspólnej.
set1.IntersectWith(set2);


// setEquals - sprawdza czy zbiory  są te same 
Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));


 // suma zbiorow
 set1.UnionWith(set2);

// różnica zbiorów
set1.SymmetricExceptWith(set2);

// usuwa określony element
set1.Remove(1);

// usuwa element z warunkiem określonym lambdą
set1.RemoveWhere(x => x>1 );

// set1.Contains - czy zawiera określony element 
Assert.IsTrue(set1.Contains(3));






