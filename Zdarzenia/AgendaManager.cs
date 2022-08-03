using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Zdarzenia
{
    class AgendaManager
    
    // AgendMenager nie jest świadomy kogo zawiadamia
    {
     
        //wersja dłuższa
        //public delegate void AddedAgendaEventHandler(object o, AgendaEventArgs e); // nazwa delegatu z użyciem czasu -Added-dodany
        //public event AddedAgendaEventHandler AddedAgenda;  // zdarzenie

        public event EventHandler<AgendaEventArgs> AddedAgenda;   // wersja skrócona




        //  Następnie trzeba zrobić publisher - metodę która będzie uruchaminan gdy Event ma być publikowany. 

        /// <summary>
        ///  Event publisher powinien być : (konwencja)
        /// 1. Protected
        /// 2. virtual
        /// 3. void
        /// 4 Nazwa zaczyna się na " On"
        /// 
        /// 
        /// </summary>


        //poniżej Publisher 

        protected virtual void OnAddedAgenda(Agenda newAgenda)
        {
            if (AddedAgenda != null)
            {
                AddedAgenda(this, new AgendaEventArgs() { Agenda = newAgenda });
            }
        }

        // Klasa programu glównego 
        public void AddAgenda(Agenda newAgenda)
        {
            Console.WriteLine("AddAgenda: Zaczynam działanie ...");
            Thread.Sleep(3000);


            //Tutaj trzeba dodać wywołanie 
            OnAddedAgenda(newAgenda);  // wyzwalacz


            Console.WriteLine("AddAgenda: Skończyłem  działanie...");



        }
    }
}
