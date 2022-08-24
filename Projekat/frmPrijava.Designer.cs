
namespace Projekat
{
    partial class frmPrijava
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label14 = new System.Windows.Forms.Label();
            this.cmbPol = new System.Windows.Forms.ComboBox();
            this.chkPrikazRegSifre = new System.Windows.Forms.CheckBox();
            this.chkPrikazLogSifre = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNovSifra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNovKorisIme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNoviNalog = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNovPrezime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNovIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrijavSifra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrijavKorisIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPonNovSifra = new System.Windows.Forms.TextBox();
            this.chkUslovi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 15);
            this.label14.TabIndex = 61;
            this.label14.Text = "Pol:";
            // 
            // cmbPol
            // 
            this.cmbPol.FormattingEnabled = true;
            this.cmbPol.Items.AddRange(new object[] {
            "Muško",
            "Žensko",
            "Ostalo"});
            this.cmbPol.Location = new System.Drawing.Point(119, 311);
            this.cmbPol.Name = "cmbPol";
            this.cmbPol.Size = new System.Drawing.Size(138, 23);
            this.cmbPol.TabIndex = 45;
            // 
            // chkPrikazRegSifre
            // 
            this.chkPrikazRegSifre.AutoSize = true;
            this.chkPrikazRegSifre.Location = new System.Drawing.Point(401, 316);
            this.chkPrikazRegSifre.Name = "chkPrikazRegSifre";
            this.chkPrikazRegSifre.Size = new System.Drawing.Size(85, 19);
            this.chkPrikazRegSifre.TabIndex = 53;
            this.chkPrikazRegSifre.Text = "Prikaži šifre";
            this.chkPrikazRegSifre.UseVisualStyleBackColor = true;
            this.chkPrikazRegSifre.CheckedChanged += new System.EventHandler(this.RegSifre);
            // 
            // chkPrikazLogSifre
            // 
            this.chkPrikazLogSifre.AutoSize = true;
            this.chkPrikazLogSifre.Location = new System.Drawing.Point(119, 120);
            this.chkPrikazLogSifre.Name = "chkPrikazLogSifre";
            this.chkPrikazLogSifre.Size = new System.Drawing.Size(86, 19);
            this.chkPrikazLogSifre.TabIndex = 36;
            this.chkPrikazLogSifre.Text = "Prikaži šifru";
            this.chkPrikazLogSifre.UseVisualStyleBackColor = true;
            this.chkPrikazLogSifre.CheckedChanged += new System.EventHandler(this.PrSifra);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 15);
            this.label13.TabIndex = 57;
            this.label13.Text = "Prihvatam";
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistracija.Location = new System.Drawing.Point(24, 386);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(514, 52);
            this.btnRegistracija.TabIndex = 56;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.Registruj);
            // 
            // btnPrijava
            // 
            this.btnPrijava.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrijava.Location = new System.Drawing.Point(334, 62);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(204, 52);
            this.btnPrijava.TabIndex = 37;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.Prijava);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(104, 355);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 17);
            this.linkLabel1.TabIndex = 54;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "uslove korišćenja.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 52;
            this.label9.Text = "Ponovite šifru:";
            // 
            // txtNovSifra
            // 
            this.txtNovSifra.Location = new System.Drawing.Point(400, 256);
            this.txtNovSifra.Name = "txtNovSifra";
            this.txtNovSifra.Size = new System.Drawing.Size(138, 23);
            this.txtNovSifra.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 50;
            this.label10.Text = "Šifra:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 49;
            this.label11.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(400, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "petar@email.com";
            this.txtEmail.Size = new System.Drawing.Size(138, 23);
            this.txtEmail.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 15);
            this.label12.TabIndex = 47;
            this.label12.Text = "Korisničko ime:";
            // 
            // txtNovKorisIme
            // 
            this.txtNovKorisIme.Location = new System.Drawing.Point(399, 195);
            this.txtNovKorisIme.Name = "txtNovKorisIme";
            this.txtNovKorisIme.Size = new System.Drawing.Size(138, 23);
            this.txtNovKorisIme.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "Broj telefona:";
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(119, 282);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.PlaceholderText = "0612345678";
            this.txtBrojTelefona.Size = new System.Drawing.Size(138, 23);
            this.txtBrojTelefona.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Datum rođenja:";
            // 
            // dtpNoviNalog
            // 
            this.dtpNoviNalog.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNoviNalog.Location = new System.Drawing.Point(119, 253);
            this.dtpNoviNalog.Name = "dtpNoviNalog";
            this.dtpNoviNalog.Size = new System.Drawing.Size(138, 23);
            this.dtpNoviNalog.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Prezime:";
            // 
            // txtNovPrezime
            // 
            this.txtNovPrezime.Location = new System.Drawing.Point(119, 224);
            this.txtNovPrezime.Name = "txtNovPrezime";
            this.txtNovPrezime.Size = new System.Drawing.Size(138, 23);
            this.txtNovPrezime.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ime:";
            // 
            // txtNovIme
            // 
            this.txtNovIme.Location = new System.Drawing.Point(119, 195);
            this.txtNovIme.Name = "txtNovIme";
            this.txtNovIme.Size = new System.Drawing.Size(138, 23);
            this.txtNovIme.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nemate nalog? Napravite novi!!!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Šifra";
            // 
            // txtPrijavSifra
            // 
            this.txtPrijavSifra.Location = new System.Drawing.Point(119, 91);
            this.txtPrijavSifra.Name = "txtPrijavSifra";
            this.txtPrijavSifra.Size = new System.Drawing.Size(138, 23);
            this.txtPrijavSifra.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Korisničko ime";
            // 
            // txtPrijavKorisIme
            // 
            this.txtPrijavKorisIme.Location = new System.Drawing.Point(119, 62);
            this.txtPrijavKorisIme.Name = "txtPrijavKorisIme";
            this.txtPrijavKorisIme.Size = new System.Drawing.Size(138, 23);
            this.txtPrijavKorisIme.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Prijavljivanje:";
            // 
            // txtPonNovSifra
            // 
            this.txtPonNovSifra.Location = new System.Drawing.Point(400, 285);
            this.txtPonNovSifra.Name = "txtPonNovSifra";
            this.txtPonNovSifra.Size = new System.Drawing.Size(138, 23);
            this.txtPonNovSifra.TabIndex = 52;
            // 
            // chkUslovi
            // 
            this.chkUslovi.AutoSize = true;
            this.chkUslovi.Location = new System.Drawing.Point(28, 357);
            this.chkUslovi.Name = "chkUslovi";
            this.chkUslovi.Size = new System.Drawing.Size(15, 14);
            this.chkUslovi.TabIndex = 62;
            this.chkUslovi.UseVisualStyleBackColor = true;
            // 
            // frmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.chkUslovi);
            this.Controls.Add(this.txtPonNovSifra);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbPol);
            this.Controls.Add(this.chkPrikazRegSifre);
            this.Controls.Add(this.chkPrikazLogSifre);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNovSifra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNovKorisIme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNoviNalog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNovPrezime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNovIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrijavSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrijavKorisIme);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPrijava";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbPol;
        private System.Windows.Forms.CheckBox chkPrikazRegSifre;
        private System.Windows.Forms.CheckBox chkPrikazLogSifre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNovSifra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNovKorisIme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNoviNalog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNovPrezime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNovIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrijavSifra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrijavKorisIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPonNovSifra;
        private System.Windows.Forms.CheckBox chkUslovi;
    }
}