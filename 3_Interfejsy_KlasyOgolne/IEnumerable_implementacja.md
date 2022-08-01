Przy dodaniu do definicji interfejsu IKoleka ,  interfejsu IEnumerable<T> jest wymagana implementacja poniższych metod w klasie " Dzuża Kolejka"
Należy użyć podpowiadania .clt VS



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