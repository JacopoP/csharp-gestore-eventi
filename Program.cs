namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Evento evento = new Evento("Pippo", new DateTime(2023, 04, 18), 150);
                evento.PrenotaPosti(10);
                Console.WriteLine(evento.Prenotati);
                evento.DisdiciPosti(-3);
                Console.WriteLine(evento.Prenotati);
                Console.WriteLine(evento.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}