using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    [Serializable]
    class klKorisnik
    {
        protected int id;
        protected string korisIme;
        protected string lozinka;

        public int Id { get => id; set => id = value; }
        public string KorisIme { get => korisIme; set => korisIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }

        public klKorisnik(int id, string korisIme, string lozinka)
        {
            this.Id = id;
            this.KorisIme = korisIme;
            this.Lozinka = lozinka;
        }


    }
}
