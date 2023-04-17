namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main()
        {
            Evento evento = new Evento("Pippo", new DateTime(2023, 04, 18), -150);
            Console.WriteLine(evento.ToString());
        }
    }
}