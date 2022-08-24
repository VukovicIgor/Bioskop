using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class frmPregledRezervacija : Form
    {
        FileStream fs;
        BinaryFormatter bf = new BinaryFormatter();

        List<klProjekcija> projekcije;
        List<klRezervacija> rezervacije;

        string putanjaProjekcija = "projekcije.bin";
        string putanjaRezervacija = "rezervacija.bin";
        int korisnik;

        public frmPregledRezervacija(int korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;

            projekcije = new List<klProjekcija>();
            rezervacije = new List<klRezervacija>();

            if (File.Exists(putanjaProjekcija))
            {
                fs = File.OpenRead(putanjaProjekcija);
                projekcije = bf.Deserialize(fs) as List<klProjekcija>;
                fs.Close();
            }

            if (File.Exists(putanjaRezervacija))
            {
                fs = File.OpenRead(putanjaRezervacija);
                rezervacije = bf.Deserialize(fs) as List<klRezervacija>;
                fs.Close();

                foreach(klRezervacija rez in rezervacije)
                {

                    if (rez.IdKupca == korisnik)
                        lbRezervacije.Items.Add(rez);
                }
            }
        }

        private void Rezervisi(object sender, EventArgs e)
        {
            frmRezervacija RZ = new frmRezervacija(korisnik);
            this.Hide();
            RZ.ShowDialog();
            this.Close();
        }

        private void Nazad(object sender, EventArgs e)
        {
            frmKorisPanel KP = new frmKorisPanel(korisnik);
            this.Hide();
            KP.ShowDialog();
            this.Close();
        }

        private void Obrisi(object sender, EventArgs e)
        {
            if (lbRezervacije.SelectedItem == null)
            {
                MessageBox.Show("Nemate rezervacije!!!");
            }
            for (int i = 0; i < rezervacije.Count; i++)
                if (rezervacije[i].Uporedi(lbRezervacije.SelectedItem as klRezervacija))
                {
                    foreach (klProjekcija pro in projekcije)
                    {
                        if (pro.Id == rezervacije[i].IdProjekcije)
                            pro.SlMesta += rezervacije[i].BrMesta;
                    }
                    rezervacije.RemoveAt(i);

                    fs = File.OpenWrite(putanjaRezervacija);
                    bf.Serialize(fs, rezervacije);
                    fs.Close();

                    lbRezervacije.Items.Clear();

                    foreach (klRezervacija rezervacija in rezervacije)
                        lbRezervacije.Items.Add(rezervacija);

                    MessageBox.Show("Rezervacija je obrisana.");
                    return;
                }
        }
    }
}
