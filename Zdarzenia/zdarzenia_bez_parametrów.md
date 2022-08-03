1. Utworzenie delegata i  zdarzenia w AgendaMenager - clasa AgendaMenager

    {
      public delegate void AddedAgendaEventHandler(object o, EventArgs e); // nazwa delegatu z użyciem czasu -Added-dodany
      public event AddedAgendaEventHandler AddedAgenda;  // zdarzenie
    }

    nazwa delegatu z użyciem czasu -Added-dodany
    delegat musi mieć dwa parametry(object o, EventArgs e)
    AddedAgenda - event 



2.   Następnie trzeba zrobić publisher - metodę która będzie uruchaminany gdy Event ma być publikowany. - będzie krzyczał "Hello tu się coś stało ""

 ///  Event publisher powinien być : (konwencja)
        /// 1. Protected
        /// 2. virtual
        /// 3. void
        /// 4 Nazwa zaczyna się na " On"

    piszemy PUBLISHER- wydawce eventu


    {
           protected virtual void OnAddedAgenda()
        {
            if (AddedAgenda != null)              // sprawdzamy czy ktoś się zarejestrował- jeśli tak  to do zdarzenia przekazywane są parametry i zdarzenie jest podnoszone. 
            {
                AddedAgenda(this, EventArgs.Empty); //AddedAgenda - daje informację że nastąpiło zdarzenie - to delegat zdarzenia - definicja u góry
            }
        }
    }


3.  Wyzwalaczem zdarzenia jest wywołanie   OnAddedAgenda()      w klasie AgendaManager - metoda AddAgenda()
    {
        OnAddedAgenda()
    }



4. klasa SMSsender będzie odbiorcą Eventu - obiorca musi mieć ilość argumnetów i nazwę jak u Publishera
    {
      
        public void OnAddedAgenda(object o, EventArgs e)
        {
            Console.WriteLine("SMS został wysłany ");
        }
    }

5. Następnie trzeba zarejestrować Event  w Program/Main


    Pierw trzeba zrobić instancję klasy : ( gdzie wysłać)

    SMSSender sms = new SMSSender();   // instancja odbiorcy

    Rejestracja metody odbiorcy
    {
     agmr.AddedAgenda += sms.OnAddedAgenda; 
    }

    Należy pamiętać aby rejestracja eventu była przed zdarzeniem a nie po. 





