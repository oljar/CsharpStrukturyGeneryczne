using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class KolejkaTest

    {
        [TestMethod]
        public void UzyciePeek()
        {
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);
            // Peek - pobiera ale nie kasuje
            Assert.AreEqual(1, kolejka.Peek());
        }

        [TestMethod]
        public void UzycieContains()
        {
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);
            // Contains() - Sprawdza kolejka czy zawiera element 
            Assert.IsTrue(kolejka.Contains(2));
        }

        [TestMethod]
        public void UzycieToArray()
        {
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);
            // ToArray - Rzutuje na Tablice
            var tablica = kolejka.ToArray();
            kolejka.Dequeue();
            Assert.AreEqual(1, tablica[0]);
            Assert.AreEqual(3,kolejka.Count());
        }

        [TestMethod]
        public void UzycieClear()
        {
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);
            //Czyœci 
            kolejka.Clear();
            Assert.AreEqual(0, kolejka.Count);
        }





    }
}
