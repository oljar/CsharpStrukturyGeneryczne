Modyfikacja  aby wywłać parametry do odbiorcy SMSSender.cs

1)Tworzymy klasę AgendaEventArgs która dziedziczy po EventArgs/ to co chcemy przesyłać
{
		
        public class Agenda
            {
                public DateTime AgendaDate { get; set; }

                public string AgendaName { get; set; }

            }
}

2) W klasie AgendaManager zamiast EventArgs (2-gi parametr) należy wstawić AgendaEventArgs e

Visual Studio wyświetli błędy. 

3.  W klasie AgendaMenager / metoda - AddAgenda jako parametr wejściowy musi być Agenda new agenda
    oraz konstruktor noewgo obiektu
    

    Do Publishera trzeba dodać obiekt wysyłany

protected virtual void OnAddedAgenda (Agenda newAgenda)
{
  if (AddedAgenda != null)
  (AddedAgenda(this, new AgendaEventArgs() { Agenda = newAgenda });

}


3.Metoda klasy instancji Addktóra jest w Program main (główny program ) oraz delegat który jest tam zawarty również muszą posiadać 
   
public void AddAgenda(Agenda newAgenda)
{
.........
OnAddedAgenda(newAgenda);
.......
}

4. SMSSender musi również być przystosowany do otrzymywania obiektu

public void OnAddedAgenda(object o, AgendaEventArgs e)
        {
            Console.WriteLine("SMS został wysłany  Data : " + e.Agenda.AgendaDate);
        }


 5. Aby skrócoć i nie pisać delegatu można od razu napisać event generyczny
    EventHandler<TEventArgs>
    public event EventHandler<AgendaEventArgs> AddedAgend
