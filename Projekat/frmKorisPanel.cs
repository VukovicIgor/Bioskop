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
    public partial class frmKorisPanel : Form
    {
        FileStream fs;
        BinaryFormatter bf = new BinaryFormatter();
        List<klKorisnik> korisnici;
        string putanjaKorisnici = "korisnici.bin";
        int korisnik;

        public frmKorisPanel(int korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
            if (File.Exists(putanjaKorisnici))
            {
                fs = File.OpenRead(putanjaKorisnici);
                korisnici = bf.Deserialize(fs) as List<klKorisnik>;
                fs.Close();   
            }
            foreach (klKupac kupac in korisnici)
            {
                if (kupac.Id == korisnik)
                {
                    lblIme.Text = "Ime i prezime: "+kupac.Ime + " " + kupac.Prezime;
                    lblKorisIme.Text = "Korisničko ime: "+kupac.KorisIme;
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

        private void PregledRezer(object sender, EventArgs e)
        {
            frmPregledRezervacija PR = new frmPregledRezervacija(korisnik);
            this.Hide();
            PR.ShowDialog();
            this.Close();
        }

        private void Odjava(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Uspešno ste se odjavili.");
            frmPrijava p = new frmPrijava();
            this.Hide();
            p.ShowDialog();
            this.Close();
        }
    }
}
