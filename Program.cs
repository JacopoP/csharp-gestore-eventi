namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Inserisci il nome dell'evento: ");
            string? titolo = Console.ReadLine();
            DateTime data;
            do
            {
                Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
            } while (!DateTime.TryParse(Console.ReadLine(), out data));
            int capienza;
            do
            {
                Console.Write("Inserisci il numero di posti totali: ");
            } while (!Int32.TryParse(Console.ReadLine(), out capienza));

            try
            {
                Evento evento = new Evento(titolo, data, capienza);
                Console.WriteLine(evento.ToString());
                int prenotati;
                do
                {
                    Console.Write("Quanti posti vuoi prenotare? ");
                } while (!Int32.TryParse(Console.ReadLine(), out prenotati));
                evento.PrenotaPosti(prenotati);
                string? risposta;
                int disdetti;
                do
                {
                    evento.SituazionePosti();
                    Console.Write("\nVuoi disdire dei posti (si/no) ");
                    risposta = Console.ReadLine();
                    if(risposta == "si")
                    {
                        do
                        {
                            Console.Write("Indica il numero di posti da disdire: ");
                        }while(!Int32.TryParse(Console.ReadLine(), out disdetti));
                        evento.DisdiciPosti(disdetti);
                    }
                } while (risposta == "si");
                Console.WriteLine("Ok, va bene!");
                evento.SituazionePosti();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}