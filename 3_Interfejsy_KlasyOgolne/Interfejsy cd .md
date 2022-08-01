W C# są gotowe inekterfejsy generyczne  które pozwalają na narzucanie określonych metod 

 Poniżej Interfejsy które mocą być  dodawane  oprócz IEnumerable<T>
 public interface IKolejka<T> : IEnumerable<T>,IList<T>,ICollection<T>,IDictionary<T,V>,IReadOnlyCollection<T>, ISet<T>, IComparer<T>,IEqualityComparer<T>

