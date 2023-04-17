﻿namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main()
        {
            string? titoloProgramma;
            do
            {
                Console.Write("Inserisci il nome del tuo Programma eventi: ");
                titoloProgramma = Console.ReadLine();
            } while (titoloProgramma == null);
            ProgrammaEventi programma = new ProgrammaEventi(titoloProgramma);
            uint n;
            do
            {
                Console.Write("Indica il numero di eventi da inserire: ");
            } while (!uint.TryParse(Console.ReadLine(), out n));

            for(int i = 1; i <= n; i++)
            {
                string? titolo;
                DateTime data;
                int capienza;
                Console.Write($"\nInserisci il nome del {i}° evento: ");
                titolo = Console.ReadLine();
                do
                {
                    Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
                } while (!DateTime.TryParse(Console.ReadLine(), out data));
                do
                {
                    Console.Write("Inserisci il numero di posti totali: ");
                } while (!Int32.TryParse(Console.ReadLine(), out capienza));

                try
                {
                    Evento evento = new Evento(titolo, data, capienza);
                    programma.AggiungiEvento(evento);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Reinserire l'evento");
                    i--;
                }
                finally { Console.Write("\n"); }
            }
            Console.WriteLine($"\nIl numero di eventi nel programma è: {programma.NumeroEventi()}");
            Console.WriteLine("Ecco il tuo programma eventi:");
            Console.WriteLine(programma.ToString());
            DateTime filtro;
            do
            {
                Console.Write("Inserisci una data per sapere che eventi ci saranno (gg//mm/yyyyy): ");
            } while (!DateTime.TryParse(Console.ReadLine(), out filtro));
            Console.WriteLine(ProgrammaEventi.StringaLista(programma.FiltraData(filtro)));
            programma.SvoutaLista();
        }
    }
}