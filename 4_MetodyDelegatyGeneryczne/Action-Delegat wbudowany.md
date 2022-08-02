Delegat Action pozwala na podpięcie pod zmienną metody typu Void

 static void KonsolaWypisz(double dane)
            {
                Console.WriteLine($"wypisuję na konsoli - metoda statyczna {dane}");
            }


 Typ Action pozwala wpisać zmienną która będzie delegatem. Zmienna ta będzie się odnosiła do metody statycznej która  nic nie oddaje np Console.WriteLine();


            // użycie metody statycznej 
            Action<double> drukujA = KonsolaWypisz;

            //poniżej wywołanie metody. 
            drukujA(4.1);



            // uzycie metody anonimowej 
            Action<double> drukujB= delegate (double dane)
            {
                Console.WriteLine($"wypisuję na konsoli - metoda anonimowa {dane}");
            };

            drukujB(3.3);
            
            // uzycie lamdy
            Action<double> drukuj = d => Console.WriteLine($"wypisuję na konsoli - lambda {d}");

            drukuj(12);


            Action<int, int, int> test = (a, b, c) => Console.WriteLine(a+b+c);
            test(1, 2, 3);