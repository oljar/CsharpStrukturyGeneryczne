using System;
using System.Collections.Generic;
using System.Text;

namespace Zdarzenia
{
    class SMSSender
    {
     // SMSSender - będzie odbiorcą Eventu.

     // Odbiorca musi mieć ilość argumnetów i nazwę jak u Publishera


        public void OnAddedAgenda(object o, AgendaEventArgs e)
        {
            Console.WriteLine("SMS został wysłany  Data : " + e.Agenda.AgendaDate + "Tytuł"+ e.Agenda.AgendaName);
        }

    }
}
