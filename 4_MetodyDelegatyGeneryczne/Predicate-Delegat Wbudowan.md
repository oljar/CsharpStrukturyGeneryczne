// Delegat Predicate<Tin> zwraca wartość bool  

Predicate<double> jestWiekszeOdDwa = d => d > 2;

drukuj1(jestWiekszeOdDwa(potegowanie(dodaj(1, 1))));
