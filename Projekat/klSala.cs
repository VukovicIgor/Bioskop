using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    [Serializable]
    class klSala
    {
        private int id, brSale, brSedista;

        public klSala(int id, int brSale, int brSedista)
        {
            this.Id = id;
            this.BrSale = brSale;
            this.BrSedista = brSedista;
        }

        public int Id { get => id; set => id = value; }
        public int BrSale { get => brSale; set => brSale = value; }
        public int BrSedista { get => brSedista; set => brSedista = value; }

        public override string ToString()
        {
            return "Broj sale: "+brSale+" Broj mesta: "+brSedista;
        }
    }
}
