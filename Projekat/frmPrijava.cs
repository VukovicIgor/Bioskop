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
    public partial class frmPrijava : Form
    {
        FileStream fs;
        BinaryFormatter bf = new BinaryFormatter();
        string putanjaKorisnici = "korisnici.bin";
        List<klKorisnik> korisnici;

        public frmPrijava()
        {
            InitializeComponent();
            txtPrijavSifra.UseSystemPasswordChar = true;
            dtpNoviNalog.MaxDate = DateTime.Now;
            txtNovSifra.UseSystemPasswordChar = true;
            txtPonNovSifra.UseSystemPasswordChar = true;

            if (File.Exists(putanjaKorisnici))
            {
                fs = File.OpenRead(putanjaKorisnici);
                korisnici = bf.Deserialize(fs) as List<klKorisnik>;
                fs.Close();
            }
            else
                korisnici = new List<klKorisnik>();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUslovi U = new frmUslovi();
            U.Show();
        }

        private void Registruj(object sender, EventArgs e)
        {
            if (txtNovIme.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli ime!!!");
                return;
            }
            else if (txtNovPrezime.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli prezime!!!");
                return;
            }
            else if (!dtpNoviNalog.Checked)
            {
                MessageBox.Show("Niste uneli datum rođenja!!!");
                return;
            }
            else if (txtBrojTelefona.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli broj telefona!!!");
                return;
            }
            else if (cmbPol.SelectedIndex == -1)
            {
                MessageBox.Show("Niste izabrali pol!!!");
                return;
            }
            else if (txtNovKorisIme.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli korisničko ime!!!");
                return;
            }
            else if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli email!!!");
                return;
            }
            else if (txtNovSifra.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli šifru!!!");
                return;
            }
            else if (txtPonNovSifra.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste ponovili šifru!!!");
                return;
            }
            else if (txtNovSifra.Text != txtPonNovSifra.Text)
            {
                MessageBox.Show("Šifre se nepoklapaju!!!");
                return;
            }
            else if (!chkUslovi.Checked)
            {
                MessageBox.Show("Niste prihvatili uslove korišćenja!!!");
                return;
            }
            foreach(klKupac kupac in korisnici)
            {
                if(kupac.KorisIme==txtNovKorisIme.Text)
                {
                    MessageBox.Show("Postoji korisnik sa unetim korisničkim imenom!!!");
                    return;
                }
                if(kupac.Email==txtEmail.Text)
                {
                    MessageBox.Show("Postoji korisnik sa unetim email-om!!!");
                    return;
                }
            }
            int id;
            int admin=0;
            if(korisnici.Count==0)
            {
                id = 1;
            }
            else
            {
                id = korisnici[korisnici.Count - 1].Id + 1;
            }
            korisnici.Add(new klKupac(txtNovIme.Text,txtNovPrezime.Text,txtEmail.Text,txtBrojTelefona.Text,cmbPol.Text,dtpNoviNalog.Value,txtNovKorisIme.Text,txtNovSifra.Text,id,admin));
            MessageBox.Show("Uspešno ste se registrovali.");
            txtBrojTelefona.Text = "";
            txtEmail.Text = "";
            txtNovIme.Text = "";
            txtNovKorisIme.Text = "";
            txtNovPrezime.Text = "";
            txtNovSifra.Text = "";
            txtPonNovSifra.Text = "";
            cmbPol.Text = " ";
            dtpNoviNalog.Value = DateTime.Today;
            
            fs = File.OpenWrite(putanjaKorisnici);
            bf.Serialize(fs, korisnici);
            fs.Close();
        }

        private void PrSifra(object sender, EventArgs e)
        {
            if (chkPrikazLogSifre.Checked)
                txtPrijavSifra.UseSystemPasswordChar = false;
            else
                txtPrijavSifra.UseSystemPasswordChar = true;
        }

        private void RegSifre(object sender, EventArgs e)
        {
            if (chkPrikazRegSifre.Checked)
            {
                txtNovSifra.UseSystemPasswordChar = false;
                txtPonNovSifra.UseSystemPasswordChar = false;
            }
            else
            {
                txtNovSifra.UseSystemPasswordChar = true;
                txtPonNovSifra.UseSystemPasswordChar = true;
            }
        }

        private void Prijava(object sender, EventArgs e)
        {
            if (txtPrijavKorisIme.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli korisničko ime!!!");
                return;
            }

            else if (txtPrijavSifra.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli šifru!!!");
                return;
            }

            else if (!File.Exists(putanjaKorisnici) && korisnici.Count == 0)
            {
                MessageBox.Show("Uneti kupac ne postoji!!!");
                return;
            }

            foreach (klKupac kupac in korisnici)
            {
                if (txtPrijavKorisIme.Text == kupac.KorisIme && txtPrijavSifra.Text == kupac.Lozinka)
                {
                    if (kupac.Admin == 1)
                    {
                        MessageBox.Show("Prijavili ste se kao prodavac.");
                        txtPrijavKorisIme.Text = "";
                        txtPrijavSifra.Text = "";
                        frmAdminPanel AP = new frmAdminPanel(kupac.Id);
                        this.Hide();
                        AP.ShowDialog();
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Prijavili ste se kao kupac.");
                        txtPrijavKorisIme.Text = "";
                        txtPrijavSifra.Text = "";
                        frmKorisPanel KP = new frmKorisPanel(kupac.Id);
                        this.Hide();
                        KP.ShowDialog();
                        this.Close();
                        return;
                    }
                }
            }
            MessageBox.Show("Pogrešno korisničko ime ili lozinka");
            }
    }
}