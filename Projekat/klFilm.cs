using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    [Serializable]
    class klFilm
    {
        private string naziv, zanr;
        private int id, trajanje, granica;

        public klFilm(string naziv, string zanr, int id, int trajanje, int granica)
        {
            this.Naziv = naziv;
            this.Zanr = zanr;
            this.Id = id;
            this.Trajanje = trajanje;
            this.Granica = granica;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Zanr { get => zanr; set => zanr = value; }
        public int Id { get => id; set => id = value; }
        public int Trajanje { get => trajanje; set => trajanje = value; }
        public int Granica { get => granica; set => granica = value; }

        public override string ToString()
        {
            return Naziv + ", " + Zanr + " " + trajanje + " min. " + granica + "+ godina";
        }
    }

}
