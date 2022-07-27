using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class ListaTest
    {
        [TestMethod]
        public void ListaMo¿emyDodawacNaKoniec()
        {
            List<int> ListaLiczb = new List<int> { 1, 2, 3 };
            //Add- dodawanie na koncu
            ListaLiczb.Add(4);
            Assert.AreEqual(4, ListaLiczb[3]);
        }

        [TestMethod]
        public void ListaMo¿emyDodacNaPozycji()
        {
            List<int> ListaLiczb = new List<int> { 1, 2, 3 };
           
            //Insert(pozycja,liczba)
            ListaLiczb.Insert(1, 8); 
            Assert.AreEqual(8, ListaLiczb[1]);
            
        }

        [TestMethod]
        public void ListaMo¿emyUsuwacElement()
        {
            List<int> ListaLiczb = new List<int> { 1, 2, 3 };

            //Remove usuwanie liczby po wartosci
            ListaLiczb.Remove(3);
            Assert.IsTrue(ListaLiczb.SequenceEqual(new[] { 1, 2 }));

        }

        [TestMethod]
        public void ListaMo¿emyUsuwacElementNaPozycji()
        {
            List<int> ListaLiczb = new List<int> { 1, 2, 3 };

            //RemoveAt usuwanie liczby z okreslonej pozycji
            ListaLiczb.RemoveAt(2);
            Assert.IsTrue(ListaLiczb.SequenceEqual(new[] { 1, 2 }));

        }

        [TestMethod]
        public void ListaMozemyWyszukiwacIndexElementu()
        {
            List<int> ListaLiczb = new List<int> { 1, 2, 3 };

            // IndexOf - wyszukuje pozycje podanego  elementu.  
            
            Assert.AreEqual(ListaLiczb.IndexOf(1),0);

        }

        [TestMethod]
        public void ListaMozemyWyszukiwacCzyZawiera()
        {
            List<int> ListaLiczb = new List<int> { 1, 2, 3 };

            // Contains - czy zawiera  okreslony element

            Assert.IsTrue(ListaLiczb.Contains(1));
        }

        [TestMethod]
        public void ListaMo¿emyDodawacNaKoniecZakresLiczb()
        {
            List<int> ListaLiczb = new List<int> { 1, 2, 3 };
            var zakres = new List<int> { 4, 5, 6 };
            //AddRange - dodanie kolekcji na koniec 
            ListaLiczb.AddRange(zakres);
            Assert.AreEqual(ListaLiczb[5], 6);
           
        }






    }
}
