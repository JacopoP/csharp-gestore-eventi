using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Evento
    {
        private string? titolo;
        public string? Titolo 
        {
            get
            {
                return titolo;
            }
            set
            {
                if (value == "" || value == null )
                    throw new ArgumentException("Errore: il titolo non può essere vuoto");
                titolo = value;
            } 
        }
        private DateTime data; 
        public DateTime Data 
        {
            get
            {
                return data;
            }
            set
            {
                if (value < DateTime.Now)
                    throw new ArgumentException("Errore: la data inserita non può essere precedente a oggi");
                data = value;
            } 
        }
        private int capienza;
        public int Capienza 
        {
            get
            {
                return capienza;
            } 
            private init
            {
                if (value <= 0)
                    throw new ArgumentException("Errore: il numero di posti deve essere maggiore di 0");
                capienza = value;
            }
        }
        public int Prenotati { get; private set; }

        public Evento(string? titolo, DateTime data, int capienza)
        {
            Titolo = titolo;
            Data = data;
            Capienza = capienza;
            Prenotati = 0;
        }

        public override string ToString()
        {
            return $"{Data.ToString("dd/MM/yyyy")} - {Titolo}";
        }

        public void PrenotaPosti(int n)
        {
            if (n < 0)
                throw new ArgumentException("Valore di posti da prenotare non valido");
            if (n > Capienza - Prenotati)
                throw new ArgumentException("Il valore dei posti che si vuole prenotare eccede quelli disponibili");
            if (data < DateTime.Now)
                throw new Exception("Impossibile prenotare posti per un evento passato");
            Prenotati += n;
        }

        public void DisdiciPosti(int n)
        {
            if (n < 0)
                throw new ArgumentException("Valore di posti da disdire non valido");
            if (n > Prenotati)
                throw new ArgumentException("Il valore delle prenotazioni che si vuole disdire eccede quelle effettuate");
            if (data < DateTime.Now)
                throw new Exception("Impossibile disdire prenotazioni per un evento passato");
            Prenotati -= n;
        }

        public void SituazionePosti()
        {
            Console.WriteLine($"\nNumero di posti prenotati = {Prenotati}");
            Console.WriteLine($"Numero di posti disponibili = {Capienza - Prenotati}");
        }
    }
}
