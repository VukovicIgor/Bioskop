using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    [Serializable]
    class klRezervacija
    {
        private int idKupca, idProjekcije, brMesta, cenaKarata;

        public klRezervacija(int idKupca, int idProjekcije, int brMesta, int cenaKarata)
        {
            this.idKupca = idKupca;
            this.idProjekcije = idProjekcije;
            this.brMesta = brMesta;
            this.cenaKarata = cenaKarata;
        }

        public int IdKupca { get => idKupca; set => idKupca = value; }
        public int IdProjekcije { get => idProjekcije; set => idProjekcije = value; }
        public int BrMesta { get => brMesta; set => brMesta = value; }
        public int CenaKarata { get => cenaKarata; set => cenaKarata = value; }

        public override string ToString()
        {
            return "ID kupca: " + idKupca + ", ID projekcije: " + idProjekcije + ", broj rez. mesta: " + brMesta + ", cena karata:" + cenaKarata;
        }

        public bool Uporedi(klRezervacija rez)
        {
            return IdKupca==rez.IdKupca && IdProjekcije == rez.IdProjekcije
                && BrMesta == rez.BrMesta && CenaKarata == rez.CenaKarata;
        }
    }
}
