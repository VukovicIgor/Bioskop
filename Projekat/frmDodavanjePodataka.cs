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
    public partial class frmDodavanjePodataka : Form
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

        public frmDodavanjePodataka(int prodavac)
        {
            this.prodavac = prodavac;
            InitializeComponent();
            dtpNovDatum.MaxDate = DateTime.Today;
            dtpDatumProjek.MinDate = DateTime.Today;
            dtpDatumProjek.MaxDate = DateTime.Today.AddDays(7);

            korisnici = new List<klKorisnik>();
            filmovi = new List<klFilm>();
            sale = new List<klSala>();
            projekcije = new List<klProjekcija>();
            rezervacije = new List<klRezervacija>();

            if (File.Exists(putanjaFilmovi))
            {
                fs = File.OpenRead(putanjaFilmovi);
                filmovi = bf.Deserialize(fs) as List<klFilm>;
                fs.Close();

                foreach (klFilm film in filmovi)
                {
                    cmbIzaberiFilm.Items.Add(film);
                    cmbIzaberiFilm.DisplayMember = "Naziv";
                }
            }
            if (File.Exists(putanjaKorisnici))
            {
                fs = File.OpenRead(putanjaKorisnici);
                korisnici = bf.Deserialize(fs) as List<klKorisnik>;
                fs.Close();

                foreach (klKupac kupac in korisnici)
                    cmbIzaberiKupca.Items.Add(kupac.Id);
            }
            if (File.Exists(putanjaSala))
            {
                fs = File.OpenRead(putanjaSala);
                sale = bf.Deserialize(fs) as List<klSala>;
                fs.Close();

                foreach (klSala sala in sale)
                {
                    cmbIzaberiSalu.Items.Add(sala);
                    cmbIzaberiSalu.DisplayMember = "BrSale";
                }
            }
            if (File.Exists(putanjaProjekcija))
            {
                fs = File.OpenRead(putanjaProjekcija);
                projekcije = bf.Deserialize(fs) as List<klProjekcija>;
                fs.Close();

                foreach (klProjekcija proj in projekcije)
                    cmbIzaberiProjekciju.Items.Add(proj.Id);
            }
            if (File.Exists(putanjaRezervacija))
            {
                fs = File.OpenRead(putanjaRezervacija);
                rezervacije = bf.Deserialize(fs) as List<klRezervacija>;
                fs.Close();
            }
        }

        private void Nazad(object sender, EventArgs e)
        {
            frmAdminPanel AP = new frmAdminPanel(prodavac);
            this.Hide();
            AP.ShowDialog();
            this.Close();
        }

        private void Dodaj(object sender, EventArgs e)
        {
            int trajanje, granica;
            if (txtDodajFilm.Text.Trim().Length > 0 || txtDodajZanr.Text.Trim().Length > 0 || txtDodajTrajanje.Text.Trim().Length > 0 || txtDodajGranicu.Text.Trim().Length > 0)
            {
                if (txtDodajFilm.Text.Trim().Length == 0)
                    MessageBox.Show("Niste uneli naziv filma!!!");
                else if (txtDodajZanr.Text.Trim().Length == 0)
                    MessageBox.Show("Niste uneli žanr filma!!!");
                else if (!int.TryParse(txtDodajTrajanje.Text, out trajanje))
                    MessageBox.Show("Niste uneli vreme projekcije!!!");
                else if (!int.TryParse(txtDodajGranicu.Text, out granica))
                    MessageBox.Show("Niste uneli granicu za godine!!!");
                else if (!dtpNovDatum.Checked)
                    MessageBox.Show("Niste izabrali datum!!!");
                else
                {
                    filmovi.Add(new klFilm(txtDodajFilm.Text, txtDodajZanr.Text, filmovi.Count, trajanje, granica));
                    cmbIzaberiFilm.Items.Add(filmovi[filmovi.Count - 1]);
                    cmbIzaberiFilm.DisplayMember = "Naziv";

                    fs = File.OpenWrite(putanjaFilmovi);
                    bf.Serialize(fs, filmovi);
                    fs.Close();

                    MessageBox.Show("Uspesno ste dodali film u bazu.");
                    txtDodajFilm.Text = "";
                    txtDodajZanr.Text = "";
                    txtDodajTrajanje.Text = "";
                    txtDodajGranicu.Text = "";
                    return;
                }
            }
            int admin = 0;
            if (txtDodajIme.Text.Trim().Length > 0 || txtDodajPrezime.Text.Trim().Length > 0 || txtDodajBroj.Text.Trim().Length > 0 || cmbDodajPol.Text.Trim().Length > 0 || txtNovEmail.Text.Trim().Length > 0 || txtUnosKoris.Text.Trim().Length > 0 || txtUnosSifra.Text.Trim().Length > 0 || chkProdavac.Checked)
            {
                if (txtDodajIme.Text.Trim().Length == 0)
                    MessageBox.Show("Niste uneli ime kupca!!!");
                else if (txtDodajPrezime.Text.Trim().Length == 0)
                    MessageBox.Show("Niste uneli prezime kupca!!!");
                else if (txtDodajBroj.Text.Trim().Length == 0)
                    MessageBox.Show("Niste uneli broj telefona!!!");
                else if (cmbDodajPol.Text.Trim().Length == 0)
                    MessageBox.Show("Niste izabrali pol korisnika!!!");
                else if (txtNovEmail.Text.Trim().Length == 0)
                    MessageBox.Show("Niste uneli Email!!!");
                else if (txtUnosKoris.Text.Trim().Length == 0)
                    MessageBox.Show("Niste uneli korisničko ime!!!");
                else if (txtUnosSifra.Text.Trim().Length == 0)
                    MessageBox.Show("Niste uneli šifru!!!");
                else
                {
                    int id;
                    if (korisnici.Count == 0)
                    {
                        id = 1;
                    }
                    else
                    {
                        id = korisnici[korisnici.Count - 1].Id + 1;
                    }
                    if(chkProdavac.Checked)
                    {
                        admin = 1;
                    }
                    korisnici.Add(new klKupac(txtDodajIme.Text, txtDodajPrezime.Text, txtNovEmail.Text, txtDodajBroj.Text, cmbDodajPol.Text, dtpNovDatum.Value, txtUnosKoris.Text, txtUnosSifra.Text, id,admin));

                    fs = File.OpenWrite(putanjaKorisnici);
                    bf.Serialize(fs, korisnici);
                    fs.Close();

                    MessageBox.Show("Uspešno ste uneli kupca.");
                    txtDodajIme.Text = "";
                    txtDodajPrezime.Text = "";
                    txtDodajBroj.Text = "";
                    cmbDodajPol.Text = "";
                    txtNovEmail.Text = "";
                    txtUnosKoris.Text = "";
                    txtUnosSifra.Text = "";
                    chkProdavac.Checked = false;
                    dtpNovDatum.Value = DateTime.Today;
                }
            }
            int brSale, brMesta;
            if (txtDodajSalu.Text.Trim().Length > 0 || txtDodajMesta.Text.Trim().Length > 0)
            {
                if (!int.TryParse(txtDodajSalu.Text, out brSale))
                    MessageBox.Show("Niste dodali salu!!!");
                else if (!int.TryParse(txtDodajMesta.Text, out brMesta))
                    MessageBox.Show("Niste dodali broj mesta!!!");
                else
                {
                    sale.Add(new klSala(sale.Count, brSale, brMesta));
                    cmbIzaberiSalu.Items.Add(sale[sale.Count - 1]);
                    cmbIzaberiSalu.DisplayMember = "BrSale";

                    fs = File.OpenWrite(putanjaSala);
                    bf.Serialize(fs, sale);
                    fs.Close();

                    MessageBox.Show("Uspešno ste dodali salu.");
                    txtDodajSalu.Text = "";
                    txtDodajMesta.Text = "";
                }
            }
            int cena, idPro;
            if (cmbIzaberiFilm.Text.Trim().Length > 0 || txtDodajVreme.Text.Trim().Length > 0 || cmbIzaberiSalu.Text.Trim().Length > 0 || txtDodajCenu.Text.Trim().Length > 0) //OVDE TREBA NESTO ZA INT)//
            {
                if (cmbIzaberiFilm.Text.Trim().Length == 0)
                    MessageBox.Show("Niste izabrali film za izmenu projekcije!!!");
                else if (!dtpDatumProjek.Checked)
                    MessageBox.Show("Niste izabrali datum projekcije!!!");
                else if (txtDodajVreme.Text.Trim().Length == 0)
                    MessageBox.Show("NIste izabrali vreme projekcije!!!");
                else if (cmbIzaberiSalu.Text.Trim().Length == 0)
                    MessageBox.Show("Niste izabrali salu za projekciju!!!");
                else if (!int.TryParse(txtDodajCenu.Text, out cena))
                    MessageBox.Show("Niste izabrali cenu!!!");
                else
                {
                    if (projekcije.Count == 0)
                    {
                        idPro = 1;
                    }
                    else
                    {
                        idPro = projekcije[projekcije.Count - 1].Id + 1;
                    }
                    foreach (klFilm film in filmovi)
                    {
                        if (film.Naziv == cmbIzaberiFilm.Text)
                            projekcije.Add(new klProjekcija(idPro, film, txtDodajVreme.Text, cmbIzaberiSalu.SelectedItem as klSala, dtpDatumProjek.Value, cena, (cmbIzaberiSalu.SelectedItem as klSala).BrSedista));
                    }
                    cmbIzaberiProjekciju.Items.Add(projekcije[projekcije.Count - 1].Id);

                    fs = File.OpenWrite(putanjaProjekcija);
                    bf.Serialize(fs, projekcije);
                    fs.Close();

                    MessageBox.Show("Uspešno ste dodali projekciju.");
                    cmbIzaberiFilm.Text = "";
                    txtDodajVreme.Text = "";
                    cmbIzaberiSalu.Text = "";
                    txtDodajCenu.Text = "";
                    dtpDatumProjek.Value = DateTime.Today;
                }
            }
            int idKupca, idProjekcije, brTrazenihMesta, ukCena = 0;
            if (cmbIzaberiKupca.Text.Trim().Length > 0 || cmbIzaberiProjekciju.Text.Trim().Length > 0 || txtRezervacijaMesta.Text.Trim().Length > 0)
            {
                if (!int.TryParse(cmbIzaberiKupca.Text, out idKupca))
                    MessageBox.Show("Niste izabrali id kupca!!!");
                else if (!int.TryParse(cmbIzaberiProjekciju.Text, out idProjekcije))
                    MessageBox.Show("Niste izabrali id projekcije!!!");
                else if (!int.TryParse(txtRezervacijaMesta.Text, out brTrazenihMesta) || brTrazenihMesta<=0)
                    MessageBox.Show("Niste uneli dobar broj mesta!!!");
                else
                {
                    for (int i = 0; i < projekcije.Count; i++)
                    {
                        if (projekcije[i].Id == (int)cmbIzaberiProjekciju.SelectedItem)
                        {
                            ukCena = (projekcije[i].CenaKarte * brTrazenihMesta);
                            txtUkupnaCena.Text = ukCena.ToString();
                            if(projekcije[i].SlMesta < brTrazenihMesta)
                            {
                                MessageBox.Show($"Nema zadati broj mesta za izabranu projekciju. Slobodan broj mesta je {projekcije[i].SlMesta}");
                                break;
                            }
                            projekcije[i].SlMesta -= brTrazenihMesta;
                            rezervacije.Add(new klRezervacija(idKupca, idProjekcije, brTrazenihMesta, ukCena));

                            fs = File.OpenWrite(putanjaRezervacija);
                            bf.Serialize(fs, rezervacije);
                            fs.Close();

                            fs = File.OpenWrite(putanjaProjekcija);
                            bf.Serialize(fs, projekcije);
                            fs.Close();

                            MessageBox.Show("Uspešno ste dodali rezervaciju.");
                            cmbIzaberiKupca.Text = "";
                            cmbIzaberiProjekciju.Text = "";
                            txtRezervacijaMesta.Text = "";
                            break;
                        }
                    }
                }
            }
        }

        private void Zbir(object sender, EventArgs e)
        {
            int ukCena = 0, brTrazenihMesta;
            if (!int.TryParse(txtRezervacijaMesta.Text, out brTrazenihMesta));
            foreach (klProjekcija pro in projekcije)
                if (pro.Id == (int)cmbIzaberiProjekciju.SelectedItem)
                {
                    ukCena = (pro.CenaKarte * brTrazenihMesta);
                    txtUkupnaCena.Text = ukCena.ToString() + " dinara";
                    break;
                }
        }
    }
}
