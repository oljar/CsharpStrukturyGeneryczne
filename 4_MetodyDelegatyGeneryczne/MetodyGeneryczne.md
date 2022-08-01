Metody generyczne służą również zaoszczędzeniu kodu. 

Deklarację poniższej  metody  wstawiono do IKolejka
{
	IEnumerable<Twyj>ElementJako<Twyj>();
}

Wyjściowe elementy są zdefinowana przez - IEnumerable<Twyj>

W nazwie ElementJako jest <Twyj> - dzięki temu nazwa będzie różna przy różnych parametrach

Następnie w klasie DużaKolejka - implementacja

Parametry które przyjmuje metoda  również  są definiowane (jak są)   przez <T> 