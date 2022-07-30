using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class DictionaryTest

    {
        [TestMethod]
        public void UzywamySlownikaJakMapy()
        {
            var mapa = new Dictionary<int,string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");
            // mapa[1]  - otrzymujemy wartoœæ za pomoc¹ klucza
            Assert.AreEqual("jeden", mapa[1]);

        }

        [TestMethod]
        public void WyszukiwanieWS³owniku()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");
            // mapa.ContainsKey(3) -Sprawdza czy jest klucz 3
            Assert.IsTrue(mapa.ContainsKey(3));

        }

        [TestMethod]
        public void UsuwaieZeS³ownika()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");
            
            // Usuwa element o kluczu 1
            mapa.Remove(1);

            // Count - zlicza iloœæ par
            Assert.AreEqual(2, mapa.Count);
          
        }

        [TestMethod]
        public void CzyszczenieSlownika()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            // Usuwa wszystkie elementy
            mapa.Clear();

            // Count - zlicza iloœæ par
            Assert.AreEqual(0, mapa.Count);

        }

        [TestMethod]
        public void SlownikJakoSlownik()
        {
            var mapa = new Dictionary<string, string>();
            mapa.Add("one", "jeden");
            mapa.Add("two", "dwa");
            mapa.Add("three", "trzy");

            Assert.AreEqual("jeden", mapa["one"]);

        }

    }
}
