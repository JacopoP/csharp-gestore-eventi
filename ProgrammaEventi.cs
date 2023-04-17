using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class ProgrammaEventi
    {
        public string Titolo { get; set; }
        public List<Evento> Eventi { get; set; }

        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;
            Eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento ev)
        {
            Eventi.Add(ev);
        }

        public List<Evento> FiltraData(DateTime data)
        {
            return (List<Evento>) Eventi.Where(x => x.Data == data);
        }

        public static string StringaLista(List<Evento> lista)
        {
            string stringaLista = "";
            foreach (Evento ev in lista)
            {
                stringaLista += ev.ToString();
            }
            return stringaLista;
        }

        public int NumeroEventi()
        {
            return Eventi.Count;
        }

        public void SvoutaLista()
        {
            Eventi.Clear();
        }

        public override string ToString()
        {
            string stringaLista = Titolo + "\n";
            foreach (Evento ev in Eventi)
            {
                stringaLista += ev.ToString();
            }
            return stringaLista;
        }
    }
}
