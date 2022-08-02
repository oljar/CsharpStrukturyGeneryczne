using System;
using System.Collections.Generic;
using System.Text;

namespace _4_MetodyDelegatyGeneryczne
{



    public class KolejkaKolowa<T> : DuzaKolejka<T>
    {

        private int _pojemnosc;


        public KolejkaKolowa(int pojemnosc = 5)
        {
            _pojemnosc = pojemnosc; 
        }

        public override void Zapisz(T wartosc)
        {
            base.Zapisz(wartosc);

            if (kolejka.Count > _pojemnosc)
            {
               var usuniety = kolejka.Dequeue();
                PoUsunieciuElementu(usuniety, wartosc);
               
            }
        }

        private void PoUsunieciuElementu(T usuniety, T wartosc)
        {
            if (elementusuniety != null)
            {
                var args = new ElementUsunietyEventArgs<T>(usuniety, wartosc);
                elementusuniety(this, args);
            }
        }

        public override bool JestPelny
        {

            get
            {
                return kolejka.Count == _pojemnosc;
            }
        }

        // EventArgs - 
        //Pierwszy parametr obsługi zdarzenia jest sender- nadawca zdarzenia typ object - object sender 

        // Drugi parametr - to TEventArgs - element do obsługi zdarzeń. 
        public event EventHandler<ElementUsunietyEventArgs<T>> elementusuniety;

    }

    public class ElementUsunietyEventArgs<T>:EventArgs
    {
        public T ElementUsuniety { get; set; }
        public T ElementNowy { get; set; }

        public ElementUsunietyEventArgs(T elementUsuniety , T elementNowy)

        {
            ElementUsuniety = elementUsuniety;
            ElementNowy = elementNowy;

        }




    }
}