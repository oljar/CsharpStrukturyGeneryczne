using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Zdarzenia
{
    class AgendaManager
    
    // AgendMenager nie jest świadomy kogo zawiadamia
    {
     
        public delegate void AddedAgendaEventHandler(object o, EventArgs e); // nazwa delegatu z użyciem czasu -Added-dodany
        public event AddedAgendaEventHandler AddedAgenda;  // zdarzenie


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

        protected virtual void OnAddedAgenda()
        {
            if (AddedAgenda != null)
            {
                AddedAgenda(this, EventArgs.Empty); //AddedAgenda - daje informację że nastąpiło zdarzenie - to delegat zdarzenia - definicja u góry
            }
        }


        // Klasa programu glównego 
        public void AddAgenda()
        {
            Console.WriteLine("AddAgenda: Zaczynam działanie ...");
            Thread.Sleep(3000);


            //Tutaj trzeba dodać wyzwalacz
            OnAddedAgenda();  // wyzwalacz


            Console.WriteLine("AddAgenda: Skończyłem  działanie...");



        }
    }
}
