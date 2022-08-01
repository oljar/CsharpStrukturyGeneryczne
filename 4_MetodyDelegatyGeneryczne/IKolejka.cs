using System.Collections.Generic;

namespace _4_MetodyDelegatyGeneryczne
{


    //Interfejsy które mocą być  dodawane  oprócz IEnumerable<T>
   ///public interface IKolejka<T> : IEnumerable<T>,IList<T>,ICollection<T>,IDictionary<T,V>,IReadOnlyCollection<T>, ISet<T>, IComparer<T>,IEqualityComparer<T>


    public interface IKolejka<T> : IEnumerable<T> 
    {
        bool JestPelny { get; }
        bool JestPusty { get; }

        T Czytaj();
        void Zapisz(T wartosc);

        IEnumerable<Twyj>ElementJako<Twyj>();

    }
}