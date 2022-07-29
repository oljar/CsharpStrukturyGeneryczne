using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class HashSetTest

    {
        [TestMethod]
        public void IntersectSets()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2,3,4 };
            // IntersectWith pozwala na wydzielenie cz�ci wsp�lnej.
            set1.IntersectWith(set2);

            // setEquals - sprawdza czy zbiory  s� te same 
            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));

          
        }


        [TestMethod]
        public void UnionSets()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            // suma zbiorow
            set1.UnionWith(set2);
            Assert.IsTrue(set1.SetEquals(new[] { 1,2,3,4 }));

        }
        [TestMethod]
        public void SymmetricExceptWith()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            // r�nica zbior�w
            set1.SymmetricExceptWith(set2);
            Assert.IsTrue(set1.SetEquals(new[] { 1, 4 }));

        }

        [TestMethod]
        public void RemoveSets()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            // usuwa okre�lony element
            set1.Remove(1);
            Assert.AreEqual(2,set1.Count());

        }

        [TestMethod]
        public void RemoveWhereSets()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            // usuwa element z warunkiem okre�lonym lambd�
            set1.RemoveWhere(x => x>1 );
            Assert.AreEqual(1, set1.Count);

        }

        [TestMethod]
        public void ContainsSets()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            // set1.Contains - czy zawiera okre�lony element 

            Assert.IsTrue(set1.Contains(3));

        }










    }
}
