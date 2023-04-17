using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Evento
    {
        private string titolo;
        public string Titolo 
        {
            get
            {
                return titolo;
            }
            set
            {
                if (value == "" || value == null )
                    throw new ArgumentNullException("Errore: il titolo non può essere vuoto");
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
                    throw new ArgumentException("La data inserita non può essere precedente a oggi");
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
                    throw new ArgumentException("Il numero di posti deve essere maggiore di 0");
                capienza = value;
            }
        }
        public uint Prenotati { get; }

        public Evento(string titolo, DateTime data, int capienza)
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
    }
}
