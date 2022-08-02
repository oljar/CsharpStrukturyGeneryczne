 {   
            // Delegat Converter<Tin,Tout>
            Converter<double, string> KonwerterString = d => d.ToString();
            Converter<double, DateTime> KonwerterDateTime = d => new DateTime(2018,1,1).AddDays(d);


            var a = KonwerterString(3.1);
            Console.WriteLine((a is string) );


            var b = KonwerterDateTime(2);
            Console.WriteLine((b));

 }
 Delegat Convert pozwala na konwertowanie typów - Delegat Converter<Tin,Tout>