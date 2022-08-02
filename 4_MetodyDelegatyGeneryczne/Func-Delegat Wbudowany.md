Func<double, double> potegowanie = d => d * d;
            Func<double, double, double> dodaj = (x, y) => x + y;
            drukuj(potegowanie(2));
            drukuj(dodaj(2, 4));

            // Delegat Func pozwala na podpięcie pod zmienną typu który coś zwraca
            // Nadaje się świetnie do obliczeń matemetycznych
            // Ostatnim parametrem zawsze jest typ zwracany