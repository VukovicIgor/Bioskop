using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    [Serializable]
    class klProjekcija
    {
        private int id;
        private klFilm film;
        private string vreme;
        private klSala sala;
        private DateTime datProjekcije;
        private int cenaKarte;
        private int slMesta;

        public klProjekcija(int id, klFilm film, string vreme, klSala sala, DateTime datProjekcije, int cenaKarte, int slMesta)
        {
            this.Id = id;
            this.Film = film;
            this.Vreme = vreme;
            this.Sala = sala;
            this.DatProjekcije = datProjekcije;
            this.CenaKarte = cenaKarte;
            this.slMesta = slMesta;
        }

        public int Id { get => id; set => id = value; }
        public string Vreme { get => vreme; set => vreme = value; }
        public DateTime DatProjekcije { get => datProjekcije; set => datProjekcije = value; }
        public int CenaKarte { get => cenaKarte; set => cenaKarte = value; }
        internal klFilm Film { get => film; set => film = value; }
        internal klSala Sala { get => sala; set => sala = value; }
        public int SlMesta { get => slMesta; set => slMesta = value; }

        public override string ToString()
        {
            return film.Naziv+ ", sala " + sala.BrSale + " " +datProjekcije.ToString("dd/MM/yyyy/") + " " +vreme + " " +cenaKarte+" din.";
        }
    }
}
