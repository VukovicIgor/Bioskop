using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    [Serializable]
    class klKupac : klKorisnik
    {
        private string ime, prezime, email, brTel, pol;
        private DateTime dtpNoviNalog;
        private int admin;

        public klKupac(string ime, string prezime, string email, string brTel, string pol, DateTime dtpNoviNalog, string korisIme, string lozinka, int id, int admin) : base(id,korisIme,lozinka)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.brTel = brTel;
            this.pol = pol;
            this.dtpNoviNalog = dtpNoviNalog;
            this.admin = admin;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string BrTel { get => brTel; set => brTel = value; }
        public string Pol { get => pol; set => pol = value; }
        public DateTime DtpNoviNalog { get => dtpNoviNalog; set => dtpNoviNalog = value; }
        public int Admin { get => admin; set => admin = value; }

        public override string ToString()
        {
            return Ime + " " + Prezime + " " + KorisIme;
        }
    }
}
