using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Conferenza : Evento
    {
        public string Relatore { get; set; }
        public double Prezzo { get; set; }

        public Conferenza(string? titolo, DateTime data, int capienza, string relatore, double prezzo) : base(titolo, data, capienza)
        {
            Relatore = relatore;
            Prezzo = prezzo;
        }

        public string PrezzoFormattato()
        {
            return Prezzo.ToString("0.00");
        }

        public override string ToString()
        {
            return $"{DataFormattata()} - {Titolo} - {Relatore} - {PrezzoFormattato()} euro";
        }
    }
}
