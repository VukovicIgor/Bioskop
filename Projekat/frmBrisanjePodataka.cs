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
    public partial class frmBrisanjePodataka : Form
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


        public frmBrisanjePodataka(int prodavac)
        {
            InitializeComponent();

            korisnici = new List<klKorisnik>();
            filmovi = new List<klFilm>();
            sale = new List<klSala>();
            projekcije = new List<klProjekcija>();
            rezervacije = new List<klRezervacija>();
            this.prodavac = prodavac;

            if (File.Exists(putanjaFilmovi))
            {
                fs = File.OpenRead(putanjaFilmovi);
                filmovi = bf.Deserialize(fs) as List<klFilm>;
                fs.Close();

                foreach (klFilm film in filmovi)
                    cmbBrisanjeFilma.Items.Add(film);
            }
            if (File.Exists(putanjaKorisnici))
            {
                fs = File.OpenRead(putanjaKorisnici);
                korisnici = bf.Deserialize(fs) as List<klKorisnik>;
                fs.Close();

                foreach (klKupac kupac in korisnici)
                    cmbBrisanjeKupca.Items.Add(kupac);
            }
            if (File.Exists(putanjaSala))
            {
                fs = File.OpenRead(putanjaSala);
                sale = bf.Deserialize(fs) as List<klSala>;
                fs.Close();

                foreach (klSala sala in sale)
                    cmbBrisanjeSale.Items.Add(sala);
            }
            if (File.Exists(putanjaProjekcija))
            {
                fs = File.OpenRead(putanjaProjekcija);
                projekcije = bf.Deserialize(fs) as List<klProjekcija>;
                fs.Close();

                foreach (klProjekcija projekcija in projekcije)
                    cmbBrisanjeProjekcije.Items.Add(projekcija);
            }
            if (File.Exists(putanjaRezervacija))
            {
                fs = File.OpenRead(putanjaRezervacija);
                rezervacije = bf.Deserialize(fs) as List<klRezervacija>;
                fs.Close();

                foreach (klRezervacija rezervacija in rezervacije)
                    cmbBrisanjeRezervacije.Items.Add(rezervacija);
            }
        }

        private void Nazad(object sender, EventArgs e)
        {
            frmAdminPanel AP = new frmAdminPanel(prodavac);
            this.Hide();
            AP.ShowDialog();
            this.Close();
        }

        private void Brisati(object sender, EventArgs e)
        {
            if (!(cmbBrisanjeFilma.SelectedItem == null))
            {
                foreach (klProjekcija projekcija in projekcije)
                    if (projekcija.Film.ToString() == cmbBrisanjeFilma.SelectedItem.ToString())
                    {
                        MessageBox.Show("Postoji projekcija za izabrani film i ne može se obrisati!!!");
                        return;
                    }
                for (int i = 0; i < filmovi.Count; i++)
                    if (cmbBrisanjeFilma.SelectedItem == filmovi[i])
                    {
                        filmovi.RemoveAt(i);

                        fs = File.OpenWrite(putanjaFilmovi);
                        bf.Serialize(fs, filmovi);
                        fs.Close();

                        cmbBrisanjeFilma.Items.Clear();

                        foreach (klFilm film in filmovi)
                            cmbBrisanjeFilma.Items.Add(film);

                        MessageBox.Show("Film je obrisan.");
                        cmbBrisanjeFilma.SelectedIndex = -1;
                        return;
                    }
            }
            else if (!(cmbBrisanjeKupca.SelectedItem == null))
            {
                foreach (klProjekcija projekcija in projekcije)
                    if (projekcija.Film.Naziv == (cmbBrisanjeKupca.SelectedItem).ToString())
                    {
                        MessageBox.Show("Postoji rezervacija izabranog kupca!!!");
                        return;
                    }
                for (int i = 0; i < korisnici.Count; i++)
                    if ((cmbBrisanjeKupca.SelectedItem as klKupac).Id == korisnici[i].Id)
                    {
                        korisnici.RemoveAt(i);

                        fs = File.OpenWrite(putanjaKorisnici);
                        bf.Serialize(fs, korisnici);
                        fs.Close();

                        cmbBrisanjeKupca.Items.Clear();
                        foreach (klKupac kupac in korisnici)
                            cmbBrisanjeKupca.Items.Add(kupac);

                        MessageBox.Show("Kupac je obrisan.");
                        cmbBrisanjeKupca.Text = "";
                        return;
                    }
            }
            else if (!(cmbBrisanjeSale.SelectedItem == null))
            {
                foreach (klProjekcija projekcija in projekcije)
                    if (projekcija.Sala == cmbBrisanjeSale.SelectedItem)
                    {
                        MessageBox.Show("Postoje projekcije u izabranoj sali!!!");
                        return;
                    }
                for (int i = 0; i < sale.Count; i++)
                    if (cmbBrisanjeSale.SelectedItem == sale[i])
                    {
                        sale.RemoveAt(i);

                        fs = File.OpenWrite(putanjaSala);
                        bf.Serialize(fs, sale);
                        fs.Close();

                        cmbBrisanjeSale.Items.Clear();
                        foreach (klSala sala in sale)
                            cmbBrisanjeSale.Items.Add(sala);

                        MessageBox.Show("Sala je obrisana.");
                        cmbBrisanjeSale.Text = "";
                        return;
                    }
            }
            else if (!(cmbBrisanjeProjekcije.SelectedItem == null))
            {
                foreach (klRezervacija rezervacija in rezervacije)
                    if (rezervacija.IdProjekcije == (cmbBrisanjeProjekcije.SelectedItem as klProjekcija).Id)
                    {
                        MessageBox.Show("Postoje rezervacije za izabranu projekciju!!!");
                        return;
                    }
                for (int i = 0; i < projekcije.Count; i++)
                    if ((cmbBrisanjeProjekcije.SelectedItem as klProjekcija).Id == projekcije[i].Id)
                    {
                        projekcije.RemoveAt(i);

                        fs = File.OpenWrite(putanjaProjekcija);
                        bf.Serialize(fs, projekcije);
                        fs.Close();

                        cmbBrisanjeProjekcije.Items.Clear();

                        foreach (klProjekcija projekcija in projekcije)
                            cmbBrisanjeProjekcije.Items.Add(projekcija);

                        MessageBox.Show("Projekcija je obrisana.");
                        cmbBrisanjeProjekcije.SelectedIndex = -1;
                        return;
                    }
            }
            else if (!(cmbBrisanjeRezervacije.SelectedItem == null))
            {
                for (int i = 0; i < rezervacije.Count; i++)
                    if (rezervacije[i].Uporedi(cmbBrisanjeRezervacije.SelectedItem as klRezervacija))
                    {
                        for(int j=0;j<projekcije.Count;j++)
                        {
                            if(projekcije[j].Id==rezervacije[i].IdProjekcije)
                            {
                                projekcije[j].SlMesta += rezervacije[i].BrMesta;
                            }
                        }
                        rezervacije.RemoveAt(i);

                        fs = File.OpenWrite(putanjaRezervacija);
                        bf.Serialize(fs, rezervacije);
                        fs.Close();

                        fs = File.OpenWrite(putanjaProjekcija);
                        bf.Serialize(fs, projekcije);
                        fs.Close();

                        cmbBrisanjeRezervacije.Items.Clear();

                        foreach (klRezervacija rezervacija in rezervacije)
                            cmbBrisanjeRezervacije.Items.Add(rezervacija);

                        MessageBox.Show("Rezervacija je obrisana.");

                        cmbBrisanjeRezervacije.SelectedIndex=-1;
                        return;
                    }
            }
        }
    }
}