Klasa generyczna <T> - klasa ogólna - można wstawić zamiast T dowyolny typ danych, dowolną klasę . Ma to na celu zwięzłość kodu. 
  public class KolejkaKolowa<T>
    {
        private T[] bufor;
        //...
        
    }


    Należy użyć paramretru typu przy konstrułownaiu obiektu wymaganego typu ( np kolejka kołowa)  - ogólny argument <string>; <int> ; <object; <klasaWlasna>; 


    {
        var kolejka = new KolejkaKolowa <string>();

    }