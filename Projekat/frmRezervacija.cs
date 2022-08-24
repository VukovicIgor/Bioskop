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
    public partial class frmRezervacija : Form
    {
        FileStream fs;
        BinaryFormatter bf = new BinaryFormatter();

        public delegate void Nazad();
        Nazad nazad;

        List<klFilm> filmovi;
        List<klSala> sale;
        List<klProjekcija> projekcije;
        List<klRezervacija> rezervacije;

        string putanjaFilmovi = "filmovi.bin";
        string putanjaSala = "sale.bin";
        string putanjaProjekcija = "projekcije.bin";
        string putanjaRezervacija = "rezervacija.bin";
        int korisnik;
        bool mesta=false;

        public frmRezervacija(int korisnik)
        {
            InitializeComponent();
            var now = DateTime.Now;
            dtpPocetni.MinDate = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            dtpPocetni.MaxDate = DateTime.Today.AddDays(7);
            dtpKrajni.MinDate = DateTime.Today.AddDays(1);
            dtpKrajni.MaxDate = DateTime.Today.AddDays(7);

            filmovi = new List<klFilm>();
            sale = new List<klSala>();
            projekcije = new List<klProjekcija>();
            rezervacije = new List<klRezervacija>();
            this.korisnik = korisnik;

            if (File.Exists(putanjaSala))
            {
                fs = File.OpenRead(putanjaSala);
                sale = bf.Deserialize(fs) as List<klSala>;
                fs.Close();

                foreach (klSala sala in sale)
                {
                    cmbSala.Items.Add(sala);
                    cmbSala.DisplayMember = "BrSale";
                }
            }
            else
                sale = new List<klSala>();

            if (File.Exists(putanjaFilmovi))
            {
                fs = File.OpenRead(putanjaFilmovi);
                filmovi = bf.Deserialize(fs) as List<klFilm>;
                fs.Close();

                foreach (klFilm film in filmovi)
                {
                    cmbNaziv.Items.Add(film);
                    cmbNaziv.DisplayMember = "Naziv";
                }
            }
            else
                filmovi = new List<klFilm>();

            if (File.Exists(putanjaProjekcija))
            {
                fs = File.OpenRead(putanjaProjekcija);
                projekcije = bf.Deserialize(fs) as List<klProjekcija>;
                fs.Close();
            }
            else
                projekcije = new List<klProjekcija>();

            if (File.Exists(putanjaRezervacija))
            {
                fs = File.OpenRead(putanjaRezervacija);
                rezervacije = bf.Deserialize(fs) as List<klRezervacija>;
                fs.Close();
            }
            else
                rezervacije = new List<klRezervacija>();
        }

        private void Vratiti(object sender, EventArgs e)
        {
            nazad = new Nazad(vracanje);
            nazad();
        }

        private void PrikazProjekcija(object sender, EventArgs e)
        {
            if (cmbSala.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali salu!!!");
                nudBrojMesta.Value = 1;
                txtUkupnaCena.Text = "";
                return;
            }
            else if (cmbNaziv.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali film!!!");
                nudBrojMesta.Value = 1;
                txtUkupnaCena.Text = "";
                return;
            }
            else
            {
                lbProjekcije.Items.Clear();
                foreach (klProjekcija pro in projekcije)
                {
                    if (dtpPocetni.Value.Date <= pro.DatProjekcije.Date && pro.DatProjekcije.Date <= dtpKrajni.Value.Date && (cmbSala.SelectedItem as klSala).Id == pro.Sala.Id && (cmbNaziv.SelectedItem as klFilm).Naziv == pro.Film.Naziv.ToString())
                    {
                        lbProjekcije.Items.Add(pro);
                    }
                }
            }
            if (lbProjekcije.Items.Count == 0)
            {
                MessageBox.Show("Nema projekcija za izabrane opcije!!!");
                nudBrojMesta.Value = 1;
                txtUkupnaCena.Text = "";
            }
        }

        private void BrojMesta(object sender, EventArgs e)
        {
            if(lbProjekcije.SelectedItem!=null)
            {
                txtUkupnaCena.Text = ((lbProjekcije.SelectedItem as klProjekcija).CenaKarte * int.Parse(nudBrojMesta.Value.ToString())).ToString()+" din";
            }
            else if(lbProjekcije.SelectedItem == null && !mesta)
            {
                MessageBox.Show("Niste izabrali projekciju!!!");
                mesta = true;
                nudBrojMesta.Value = 1;
            }
            mesta = false;
        }

        private void Zbir(object sender, EventArgs e)
        {
            if (lbProjekcije.SelectedItem != null)
            {
                txtUkupnaCena.Text = ((lbProjekcije.SelectedItem as klProjekcija).CenaKarte * int.Parse(nudBrojMesta.Value.ToString())).ToString()+" din";
            }
        }

        private void Rezervisi(object sender, EventArgs e)
        {
            if(lbProjekcije.SelectedItem==null)
            {
                MessageBox.Show("Niste izabrali projekciju!!!");
                return;
            }
            
            if((lbProjekcije.SelectedItem as klProjekcija).SlMesta < nudBrojMesta.Value)
            {
                MessageBox.Show($"Nema zadati broj mesta za izabranu projekciju. Slobodan broj mesta je {(lbProjekcije.SelectedItem as klProjekcija).SlMesta}");
                return;
            }

            rezervacije.Add(new klRezervacija(korisnik, (lbProjekcije.SelectedItem as klProjekcija).Id, int.Parse(nudBrojMesta.Value.ToString()), int.Parse(txtUkupnaCena.Text)));
            
            fs = File.OpenWrite(putanjaRezervacija);
            bf.Serialize(fs, rezervacije);
            fs.Close();

            for (int i = 0; i < projekcije.Count; i++)
            {
                if (projekcije[i].Id == rezervacije[rezervacije.Count - 1].IdProjekcije)
                {
                    projekcije[i].SlMesta -= rezervacije[rezervacije.Count - 1].BrMesta;
                }
            }

            fs = File.OpenWrite(putanjaProjekcija);
            bf.Serialize(fs, projekcije);
            fs.Close();

            MessageBox.Show("Uspešno ste rezervisali.");
        }

        public void vracanje()
        {
            frmKorisPanel KP = new frmKorisPanel(korisnik);
            this.Hide();
            KP.ShowDialog();
            this.Close();
        }
    }
}