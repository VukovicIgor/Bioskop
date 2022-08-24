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
    public partial class frmIzmenaPodataka : Form
    {
        FileStream fs;
        BinaryFormatter bf = new BinaryFormatter();

        List<klKorisnik> korisnici;
        List<klFilm> filmovi;
        List<klSala> sale;
        List<klProjekcija> projekcije;
        List<klRezervacija> rezervacije;

        string putanjaFilmovi = "filmovi.bin";
        string putanjaKorisnici = "korisnici.bin";
        string putanjaSala = "sale.bin";
        string putanjaProjekcija = "projekcije.bin";
        string putanjaRezervacija = "rezervacija.bin";
        int prodavac;

        public frmIzmenaPodataka(int prodavac)
        {
            this.prodavac = prodavac;
            InitializeComponent();
            dtpRodjenje.MaxDate = DateTime.Now;
            dtpDatumProjekcije.MinDate = DateTime.Today;
            dtpDatumProjekcije.MaxDate = DateTime.Today.AddDays(7);

            if (File.Exists(putanjaFilmovi))
            {
                fs = File.OpenRead(putanjaFilmovi);
                filmovi = bf.Deserialize(fs) as List<klFilm>;
                fs.Close();

                foreach (klFilm film in filmovi)
                {
                    cmbInfoOFilmu.Items.Add(film);
                    cmbInfoOFilmu.DisplayMember = "toString";
                    cmbProjFilm.Items.Add(film);
                    cmbProjFilm.DisplayMember = "naziv";
                }
            }
            if (File.Exists(putanjaKorisnici))
            {
                fs = File.OpenRead(putanjaKorisnici);
                korisnici = bf.Deserialize(fs) as List<klKorisnik>;
                fs.Close();

                foreach (klKupac kupac in korisnici)
                {
                    cmbInfoKupca.Items.Add(kupac);
                    cmbRezIdKupca.Items.Add(kupac);
                    cmbRezIdKupca.DisplayMember = "Id";
                }
            }
            if (File.Exists(putanjaSala))
            {
                fs = File.OpenRead(putanjaSala);
                sale = bf.Deserialize(fs) as List<klSala>;
                fs.Close();

                foreach (klSala sala in sale)
                {
                    cmbInfoSale.Items.Add(sala);
                    cmbProjSala.Items.Add(sala);
                    cmbProjSala.DisplayMember = "BrSale";
                }
            }
            if (File.Exists(putanjaProjekcija))
            {
                fs = File.OpenRead(putanjaProjekcija);
                projekcije = bf.Deserialize(fs) as List<klProjekcija>;
                fs.Close();

                foreach (klProjekcija projekcija in projekcije)
                {
                    cmbInfoOProjekcija.Items.Add(projekcija);
                    cmbRezIdProj.Items.Add(projekcija);
                    cmbRezIdProj.DisplayMember = "Id";
                }
            }
            if (File.Exists(putanjaRezervacija))
            {
                fs = File.OpenRead(putanjaRezervacija);
                rezervacije = bf.Deserialize(fs) as List<klRezervacija>;
                fs.Close();

                foreach (klRezervacija rezervacija in rezervacije)
                {
                    cmbInfoORezervacija.Items.Add(rezervacija);
                }
            }
        }

        private void Nazad(object sender, EventArgs e)
        {
            frmAdminPanel AP = new frmAdminPanel(prodavac);
            this.Hide();
            AP.ShowDialog();
            this.Close();
        }

        private void IzmenaFilma(object sender, EventArgs e)
        {
            klFilm film = cmbInfoOFilmu.SelectedItem as klFilm;
            txtNazivFilma.Text = film.Naziv;
            txtZanr.Text = film.Zanr;
            txtTrajanje.Text = film.Trajanje.ToString();
            txtGranica.Text = film.Granica.ToString();
        }

        private void IzmenaKorisnika(object sender, EventArgs e)
        {
            klKupac kupac = cmbInfoKupca.SelectedItem as klKupac;
            txtIme.Text = kupac.Ime;
            txtPrezime.Text = kupac.Prezime;
            dtpRodjenje.Value = kupac.DtpNoviNalog;
            txtTelefon.Text = kupac.BrTel;
            cmbPol.SelectedItem = kupac.Pol;
            txtEmail.Text = kupac.Email;
            txtKorisIme.Text = kupac.KorisIme;
            txtIzmenaSifre.Text = kupac.Lozinka;
            if (kupac.Admin == 1)
                chkProdavac.Checked = true;
            else
                chkProdavac.Checked = false;
        }

        private void IzmenaSale(object sender, EventArgs e)
        {
            klSala sala = cmbInfoSale.SelectedItem as klSala;
            txtBrojSale.Text = sala.BrSale.ToString();
            txtSedistaSale.Text = sala.BrSedista.ToString();
        }

        private void IzmenaProjekcije(object sender, EventArgs e)
        {
            klProjekcija projekcija = cmbInfoOProjekcija.SelectedItem as klProjekcija;
            for (int i = 0; i < cmbProjFilm.Items.Count; i++)
            {
                cmbProjFilm.SelectedIndex = i;
                if ((cmbProjFilm.SelectedItem as klFilm).Id == projekcija.Film.Id)
                    break;
            }
            for (int i = 0; i < cmbProjSala.Items.Count; i++)
            {
                cmbProjSala.SelectedIndex = i;
                if ((cmbProjSala.SelectedItem as klSala).Id == projekcija.Sala.Id)
                    break;
            }
            txtVreme.Text = projekcija.Vreme;
            dtpDatumProjekcije.Value = projekcija.DatProjekcije.Date;
            txtCenaKarte.Text = projekcija.CenaKarte.ToString();
        }

        private void IzmenaRezervacija(object sender, EventArgs e)
        {
            klRezervacija rezervacija = cmbInfoORezervacija.SelectedItem as klRezervacija;
            for (int i = 0; i < cmbRezIdKupca.Items.Count; i++)
            {
                cmbRezIdKupca.SelectedIndex = i;
                if (rezervacija.IdKupca == int.Parse(cmbRezIdKupca.Text))
                    break;
            }
            for (int i = 0; i < cmbRezIdKupca.Items.Count; i++)
            {
                cmbRezIdProj.SelectedIndex = i;
                if (rezervacija.IdProjekcije == int.Parse(cmbRezIdProj.Text))
                    break;
            }

            txtBrojMesta.Text = rezervacija.BrMesta.ToString();
            txtUkupnaCena.Text = rezervacija.CenaKarata.ToString();
        }

        private void Izmena(object sender, EventArgs e)
        {
            int trajanje, granica;
            if (cmbInfoOFilmu.SelectedItem != null)
            {
                if (txtNazivFilma.Text.Trim().Length == 0 || txtZanr.Text.Trim().Length == 0 || txtTrajanje.Text.Trim().Length == 0 || txtGranica.Text.Trim().Length == 0
                    || !(int.TryParse(txtTrajanje.Text, out trajanje)) || !(int.TryParse(txtGranica.Text, out granica)))
                    MessageBox.Show("Niste uneli neko polje za film!!!");
                else
                {
                    for (int i = 0; i < filmovi.Count; i++)
                    {
                        if ((cmbInfoOFilmu.SelectedItem as klFilm).Naziv == filmovi[i].Naziv)
                        {
                            filmovi[i].Naziv = txtNazivFilma.Text;
                            filmovi[i].Zanr = txtZanr.Text;
                            filmovi[i].Trajanje = trajanje;
                            filmovi[i].Granica = granica;
                            MessageBox.Show("Uspešno ste ažurirali film.");

                            fs = File.OpenWrite(putanjaFilmovi);
                            bf.Serialize(fs, filmovi);
                            fs.Close();

                            txtNazivFilma.Text = " ";
                            txtZanr.Text = " ";
                            txtTrajanje.Text = " ";
                            txtGranica.Text = " ";
                            cmbInfoOFilmu.Items.Clear();
                            cmbInfoOFilmu.Text = "";
                            foreach (klFilm film in filmovi)
                                cmbInfoOFilmu.Items.Add(film);
                            break;
                        }
                    }
                }
            }
            if (cmbInfoKupca.SelectedItem != null)
            {
                if (txtIme.Text.Trim().Length == 0 || txtPrezime.Text.Trim().Length == 0 ||
                    dtpRodjenje.Value == null || txtTelefon.Text.Trim().Length == 0 ||
                    cmbPol.SelectedItem == null || txtEmail.Text.Trim().Length == 0 ||
                    txtKorisIme.Text.Trim().Length == 0 || txtIzmenaSifre.Text.Trim().Length==0)
                    MessageBox.Show("Niste uneli neko polje za kupca!!!");
                else
                {
                    for (int i = 0; i < korisnici.Count; i++)
                    {
                        if ((cmbInfoKupca.SelectedItem as klKorisnik).KorisIme == korisnici[i].KorisIme)
                        {
                            if (korisnici[i] is klKupac)
                            {

                                (korisnici[i] as klKupac).Ime = txtIme.Text;
                                (korisnici[i] as klKupac).Prezime = txtPrezime.Text;
                                (korisnici[i] as klKupac).DtpNoviNalog = dtpRodjenje.Value;
                                (korisnici[i] as klKupac).BrTel = txtTelefon.Text;
                                (korisnici[i] as klKupac).Pol = cmbPol.SelectedItem.ToString();
                                (korisnici[i] as klKupac).Email = txtEmail.Text;
                                (korisnici[i] as klKupac).KorisIme = txtKorisIme.Text;
                                (korisnici[i] as klKupac).Lozinka = txtIzmenaSifre.Text;
                                if (chkProdavac.Checked)
                                    (korisnici[i] as klKupac).Admin = 1;
                                else
                                    (korisnici[i] as klKupac).Admin = 0;
                            }

                            fs = File.OpenWrite(putanjaKorisnici);
                            bf.Serialize(fs, korisnici);
                            fs.Close();

                            MessageBox.Show("Uspešno ste ažurirali kupca.");

                            txtIme.Text = "";
                            txtPrezime.Text = "";
                            dtpRodjenje.Value = DateTime.Today;
                            txtTelefon.Text = "";
                            cmbPol.SelectedIndex = -1;
                            txtEmail.Text = "";
                            txtKorisIme.Text = "";
                            txtIzmenaSifre.Text = "";
                            chkProdavac.Checked = false;
                            cmbInfoKupca.Items.Clear();
                            cmbInfoKupca.Text = "";
                            foreach (klKupac kupac in korisnici)
                                cmbInfoKupca.Items.Add(kupac);
                            break;
                        }
                    }
                }
            }
            int brojSale, brojMesta;
            if (cmbInfoSale.SelectedItem != null)
            {
                if (!(int.TryParse(txtBrojSale.Text, out brojSale)) || !(int.TryParse(txtSedistaSale.Text, out brojMesta)))
                    MessageBox.Show("Niste uneli neko polje za salu!!!");
                else
                {
                    for (int i = 0; i < sale.Count; i++)
                    {
                        if ((cmbInfoSale.SelectedItem as klSala).Id == sale[i].Id)
                        {
                            sale[i].BrSale = brojSale;
                            sale[i].BrSedista = brojMesta;

                            fs = File.OpenWrite(putanjaSala);
                            bf.Serialize(fs, sale);
                            fs.Close();

                            MessageBox.Show("Uspešno ste ažurirali sale.");

                            txtBrojSale.Text = "";
                            txtSedistaSale.Text = "";
                            cmbInfoSale.Items.Clear();
                            cmbInfoSale.Text = "";
                            foreach (klSala sala in sale)
                                cmbInfoSale.Items.Add(sala);
                            break;
                        }
                    }
                }
            }
            if (cmbInfoOProjekcija.SelectedItem != null)
            {
                if (cmbProjFilm.SelectedItem == null || txtVreme.Text.Trim().Length == 0
                    || cmbProjSala.SelectedItem == null || txtCenaKarte.Text.Trim().Length == 0)
                    MessageBox.Show("Niste uneli neko polje za projekciju!!!");
                else
                {
                    for (int i = 0; i < projekcije.Count; i++)
                    {
                        if (projekcije[i] == cmbInfoOProjekcija.SelectedItem as klProjekcija)
                        {
                            projekcije[i].Film = cmbProjFilm.SelectedItem as klFilm;
                            projekcije[i].Vreme = txtVreme.Text;
                            projekcije[i].Sala = cmbProjSala.SelectedItem as klSala;
                            projekcije[i].DatProjekcije = dtpDatumProjekcije.Value;
                            projekcije[i].CenaKarte = int.Parse(txtCenaKarte.Text);

                            fs = File.OpenWrite(putanjaProjekcija);
                            bf.Serialize(fs, projekcije);
                            fs.Close();

                            MessageBox.Show("Uspesno ste ažurirali projekciju");

                            cmbProjFilm.SelectedIndex = -1;
                            txtVreme.Text = "";
                            cmbProjSala.SelectedIndex=-1;
                            txtCenaKarte.Text = "";
                            cmbInfoOProjekcija.Items.Clear();
                            cmbInfoOProjekcija.Text = "";
                            foreach (klProjekcija projekcija in projekcije)
                                cmbInfoOProjekcija.Items.Add(projekcija);
                            break;
                        }
                    }
                }
            }
            int brMesta;
            if (cmbInfoORezervacija.SelectedItem != null)
            {
                if (cmbRezIdKupca.SelectedItem == null || cmbRezIdProj.SelectedItem == null ||
                    !(int.TryParse(txtBrojMesta.Text, out brMesta)) || brMesta<=0)
                    MessageBox.Show("Niste uneli neko polje za rezervaciju!!!");
                else
                {
                    for (int i = 0; i < rezervacije.Count; i++)
                    {
                        if (rezervacije[i].Uporedi(cmbInfoORezervacija.SelectedItem as klRezervacija))
                        {
                            rezervacije[i].IdProjekcije = int.Parse(cmbRezIdProj.Text);
                            rezervacije[i].IdKupca = int.Parse(cmbRezIdKupca.Text);
                            rezervacije[i].CenaKarata = int.Parse(txtUkupnaCena.Text);
                            for (int j = 0; j < projekcije.Count; j++)
                            {
                                if (projekcije[j].Id == rezervacije[i].IdProjekcije)
                                {
                                    if (rezervacije[i].BrMesta < brMesta)
                                    {
                                        if (projekcije[j].SlMesta >= Math.Abs(rezervacije[i].BrMesta - brMesta))
                                            projekcije[j].SlMesta -= Math.Abs(rezervacije[i].BrMesta - brMesta);
                                        else
                                        {
                                            MessageBox.Show($"Nema zadati broj mesta za izabranu projekciju. Slobodan broj mesta je {projekcije[j].SlMesta}");
                                            break;
                                        }
                                    }
                                    else if (rezervacije[i].BrMesta > brMesta)
                                        projekcije[j].SlMesta += Math.Abs(rezervacije[i].BrMesta - brMesta);
                                    rezervacije[i].BrMesta = brMesta;
                                    fs = File.OpenWrite(putanjaRezervacija);
                                    bf.Serialize(fs, rezervacije);
                                    fs.Close();

                                    fs = File.OpenWrite(putanjaProjekcija);
                                    bf.Serialize(fs, projekcije);
                                    fs.Close();

                                    MessageBox.Show("Uspesno ste ažurirali rezervaciju");

                                    cmbInfoORezervacija.Items.Clear();
                                    cmbInfoORezervacija.Text = "";

                                    foreach (klRezervacija rezervacija in rezervacije)
                                        cmbInfoORezervacija.Items.Add(rezervacija);

                                    cmbRezIdKupca.SelectedIndex=-1;
                                    cmbRezIdProj.SelectedIndex=-1;
                                    txtBrojMesta.Text = "";
                                    txtUkupnaCena.Text = "";
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
