namespace _3_Interfejsy_KlasyOgolne
{
    public interface IKolejka<T>
    {
        bool JestPelny { get; }
        bool JestPusty { get; }

        T Czytaj();
        void Zapisz(T wartosc);
    }
}