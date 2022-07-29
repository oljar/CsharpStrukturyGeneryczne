using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class LinkedListTest

    {
        [TestMethod]
        public void DodaniePoElemencie()
        {

            var lista = new LinkedList<string>();
            lista.AddLast("Jaro");
            lista.AddLast("Tom");

            // AddAfter = dodaje element po wêŸle
            lista.AddAfter(lista.First, "Ola");

            Assert.AreEqual("Ola", lista.First.Next.Value);

        }

        [TestMethod]
        public void DodaniePrzedElementem()
        { 
            var lista = new LinkedList<string>();
            lista.AddLast("Jaro");
            lista.AddLast("Tom");

            // AddBefore = dodaje element przed wêz³em
            lista.AddBefore(lista.First, "Ola");

            Assert.AreEqual("Ola", lista.First.Value);

        }


        [TestMethod]
        public void UsuwanieElementuOstatniego()
        {
            var lista = new LinkedList<string>();
            lista.AddLast("Jaro");
            lista.AddLast("Tom");

            // RemoveLast = usuwa ostatni element 
            lista.RemoveLast();

            Assert.AreEqual("Jaro", lista.Last.Value);

            // Metody Remove , RemoveLast,RemoveFirst 
        }


        [TestMethod]
        public void UsuwanieWêz³a()
        {
            var lista = new LinkedList<string>();
            lista.AddLast("Jaro");
            lista.AddLast("Tom");

            // Remove - usuwa wskazany wêze³
            lista.Remove(lista.First);

            Assert.AreEqual("Tom", lista.Last.Value);

            // Metody Remove , RemoveLast,RemoveFirst 
        }


        [TestMethod]
        public void CzyListazawieraElement()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("Tom");
            lista.AddLast("Jaro");

            // Czy lista zawiera podany element. 
            Assert.IsTrue(lista.Contains("Tom"));
        }


        [TestMethod]
        public void CzyszczenieListy()
        {
            var lista = new LinkedList<string>();
            lista.AddFirst("Tom");
            lista.AddLast("Jaro");
            
            // Czyszczenie listy
            lista.Clear();
            Assert.AreEqual(0,lista.Count);
        }


    }
}
