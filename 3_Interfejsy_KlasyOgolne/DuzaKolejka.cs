using System.Collections;
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

        public  virtual bool JestPelny => throw new System.NotImplementedException();    //dodano virtual

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






        // przy dodaniu do definicji interfejsu IKoleka ,  interfejsu IEnumerable<T> jest wymagana implementacja poniższych metod w klasie " Dzuża Kolejka"

        public IEnumerator<T> GetEnumerator()

        {

            //można zrobić jakieś filtrowanie   

            //foreach (var item in kolejka)
            //yield return item;

            return kolejka.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //można zrobić jakieś filtrowanie   


            //foreach (var item in kolejka)
            //yield return item;

            return GetEnumerator();

        }
    }
}