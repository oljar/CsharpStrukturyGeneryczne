using System.Collections.Generic;

namespace _3_Interfejsy_KlasyOgolne
{
    public class DuzaKolejka<T>:IKolejka<T>
    {

        public  Queue<T> kolejka;

        public DuzaKolejka()
        {
             kolejka = new Queue<T>();
        }

        public  bool JestPelny => throw new System.NotImplementedException();    //dodano virtual

        public virtual bool JestPusty       //dodano virtual
        {

            get
            {
                return kolejka.Count == 0;
            }


        }
            

        public virtual T Czytaj()       //dodano virtual
        {
            return kolejka.Dequeue();
        }

        public virtual void Zapisz(T wartosc) //dodano virtual
        {
            kolejka.Enqueue(wartosc);
        }
    }
}