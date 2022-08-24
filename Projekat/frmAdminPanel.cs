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
    public partial class frmAdminPanel : Form
    {
        FileStream fs;
        BinaryFormatter bf = new BinaryFormatter();
        List<klKorisnik> korisnici;
        string putanjaKorisnici = "korisnici.bin";

        int prodavac;
        public frmAdminPanel(int prodavac)
        {
            InitializeComponent();
            this.prodavac = prodavac;
            if (File.Exists(putanjaKorisnici))
            {
                fs = File.OpenRead(putanjaKorisnici);
                korisnici = bf.Deserialize(fs) as List<klKorisnik>;
                fs.Close();
            }

            foreach (klKupac kupac in korisnici)
            {
                if(kupac.Id==prodavac)
                {
                    lblIme.Text = "Ime i prezime: "+kupac.Ime + " " + kupac.Prezime;
                    lblKorisIme.Text = "Korisničko ime: "+kupac.KorisIme;
                }
            }
        }

        private void Dodaj(object sender, EventArgs e)
        {
            frmDodavanjePodataka DP = new frmDodavanjePodataka(prodavac);
            this.Hide();
            DP.ShowDialog();
            this.Close();
        }

        private void Izmena(object sender, EventArgs e)
        {
            frmIzmenaPodataka IP = new frmIzmenaPodataka(prodavac);
            this.Hide();
            IP.ShowDialog();
            this.Close();
        }

        private void Brisanje(object sender, EventArgs e)
        {
            frmBrisanjePodataka BP = new frmBrisanjePodataka(prodavac);
            this.Hide();
            BP.ShowDialog();
            this.Close();
        }

        private void Odjava(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Uspešno ste se odjavili.");
            frmPrijava P = new frmPrijava();
            this.Hide();
            P.ShowDialog();
            this.Close();
        }
    }
}
