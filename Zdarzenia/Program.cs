using System;

namespace Zdarzenia
{
    class Program
    {
        static void Main(string[] args)
        {

            AgendaManager agmr = new AgendaManager();

            SMSSender sms = new SMSSender();   // instancja odbiorcy

            // Rejsetracja - wskazanie odbiorcy - smsSender -jest odbiorcą , oczekuje na zdarzenie
            // Rejestracja  musi być dokonana przed wydarzeniem
            agmr.AddedAgenda += sms.OnAddedAgenda; //  




            // Wywołanie metody programu głównego 
            agmr.AddAgenda();
          



           


            Console.ReadKey();
        }

      
    }
}
