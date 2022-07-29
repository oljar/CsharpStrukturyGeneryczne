Kolekcja - LinkedList( podwójnie łączona lista )   to lista która umożliwia uproszczenia kopiowania , wstawiania , usuwania ,przenoszenia, kasowania tekstu.
Każdy element który zamierzamy dodać do listy LinkedList zawiera wskaźnik na element poprzedni i wcześniejszy . 
W kodzie można sprawdzić jaki element jest przed lub za . 
Można wstawiać lub modyfikować elementy w dowolnym miejscu lej listy oraz dmożna pobrać elementy które są za lub przed. 
Metody w tej liscie są bardzo wydajne


// Inicjalizacja
LinkedList<int> lista = new LinkedList<int>();


// First pobiera pierwszy element
var elementPierwszy = lista.First;


// Last pobiera ostatni element
var elementOstatni = lista.Last;


// AddAfter wstawia po wskazanym elemencie określony element 
lista.AddAfter(elementPierwszy, 1000);

// AddBefore wstawia po wskazanym elemencie określony element 
lista.AddBefore(elementPierwszy, 5551);


 //inny sposób przechodznia przez listę 
var wezel = lista.First;
while (wezel != null)
{
    Console.WriteLine(wezel.Value);
    wezel = wezel.Next;
}


  // AddAfter = dodaje element po węźle
  lista.AddAfter(lista.First, "Ola");


  // AddBefore = dodaje element przed węzłem
  lista.AddBefore(lista.First, "Ola");

  // RemoveLast = usuwa ostatni element 
  lista.RemoveLast();

  // Remove - usuwa wskazany węzeł
  lista.Remove(lista.First);

  // Czy lista zawiera podany element. 
  Assert.IsTrue(lista.Contains("Tom"));

   // Czyszczenie listy
   lista.Clear();




