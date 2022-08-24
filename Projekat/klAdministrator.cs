using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    class klAdministrator : klKorisnik
    {
        public klAdministrator(int id, string korisIme, string lozinka) : base(id, korisIme, lozinka)
        {
        }
    }
}
