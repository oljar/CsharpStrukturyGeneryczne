
using System;

using _1_TypyGeneryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1_TypyGeneryczneTest
{
    [TestClass]
    public class KolejkaKo³owaTest
    {
        [TestMethod]
        public void NowaKolejkaJestPusta()
        {
            var kolejka = new KolejkaKolowa();
            Assert.IsTrue(kolejka.JestPusty);
                }

        [TestMethod]
        public void KolejkaTrzyelementowaJestPelna ()
        {
            var kolejka = new KolejkaKolowa(pojemnosc:3);

            kolejka.Zapisz(2);
            kolejka.Zapisz(19.2);
            kolejka.Zapisz(2);

            Assert.IsTrue(kolejka.JestPelny);
        }

        [TestMethod]
        public void PierwszyWchodziPierwszyWychodzi()
        {
            var kolejka = new KolejkaKolowa(pojemnosc: 3);
            var wartosc1 = 10;
            var wartosc2 = 20;




            kolejka.Zapisz(wartosc1);
            kolejka.Zapisz(wartosc2);

            Assert.AreEqual(wartosc1,kolejka.Czytaj());
            Assert.AreEqual(wartosc2,kolejka.Czytaj());
            Assert.IsTrue(kolejka.JestPusty);
        }

        [TestMethod]
        public void NadpisujePoPrzektoczeniuPojemnosci()
        {
            var kolejka = new KolejkaKolowa(pojemnosc: 3);
            var wartosci= new[] { 1, 31.21, 11, 1, 2, 3 };
           

            foreach (var wartosc  in wartosci)
                {

                    kolejka.Zapisz(wartosc);
                }
            Assert.IsTrue(kolejka.JestPelny);
            Assert.AreEqual(wartosci[3], kolejka.Czytaj());
            Assert.AreEqual(wartosci[4], kolejka.Czytaj());
            Assert.AreEqual(wartosci[5], kolejka.Czytaj());
            Assert.IsTrue(kolejka.JestPusty);
        }




    }
}
