
namespace Projekat
{
    partial class frmBrisanjePodataka
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
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.cmbBrisanjeRezervacije = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBrisanjeProjekcije = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBrisanjeSale = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBrisanjeKupca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBrisanjeFilma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(344, 189);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(93, 24);
            this.btnNazad.TabIndex = 23;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.Nazad);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(177, 189);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(93, 24);
            this.btnObrisi.TabIndex = 22;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.Brisati);
            // 
            // cmbBrisanjeRezervacije
            // 
            this.cmbBrisanjeRezervacije.FormattingEnabled = true;
            this.cmbBrisanjeRezervacije.Location = new System.Drawing.Point(12, 148);
            this.cmbBrisanjeRezervacije.Name = "cmbBrisanjeRezervacije";
            this.cmbBrisanjeRezervacije.Size = new System.Drawing.Size(425, 23);
            this.cmbBrisanjeRezervacije.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Rezervacija";
            // 
            // cmbBrisanjeProjekcije
            // 
            this.cmbBrisanjeProjekcije.FormattingEnabled = true;
            this.cmbBrisanjeProjekcije.Location = new System.Drawing.Point(224, 89);
            this.cmbBrisanjeProjekcije.Name = "cmbBrisanjeProjekcije";
            this.cmbBrisanjeProjekcije.Size = new System.Drawing.Size(213, 23);
            this.cmbBrisanjeProjekcije.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Projekcija";
            // 
            // cmbBrisanjeSale
            // 
            this.cmbBrisanjeSale.FormattingEnabled = true;
            this.cmbBrisanjeSale.Location = new System.Drawing.Point(12, 89);
            this.cmbBrisanjeSale.Name = "cmbBrisanjeSale";
            this.cmbBrisanjeSale.Size = new System.Drawing.Size(206, 23);
            this.cmbBrisanjeSale.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sala";
            // 
            // cmbBrisanjeKupca
            // 
            this.cmbBrisanjeKupca.FormattingEnabled = true;
            this.cmbBrisanjeKupca.Location = new System.Drawing.Point(224, 38);
            this.cmbBrisanjeKupca.Name = "cmbBrisanjeKupca";
            this.cmbBrisanjeKupca.Size = new System.Drawing.Size(213, 23);
            this.cmbBrisanjeKupca.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Korisnik";
            // 
            // cmbBrisanjeFilma
            // 
            this.cmbBrisanjeFilma.FormattingEnabled = true;
            this.cmbBrisanjeFilma.Location = new System.Drawing.Point(12, 38);
            this.cmbBrisanjeFilma.Name = "cmbBrisanjeFilma";
            this.cmbBrisanjeFilma.Size = new System.Drawing.Size(206, 23);
            this.cmbBrisanjeFilma.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Film";
            // 
            // frmBrisanjePodataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 220);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.cmbBrisanjeRezervacije);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBrisanjeProjekcije);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBrisanjeSale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBrisanjeKupca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBrisanjeFilma);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmBrisanjePodataka";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Brisanje podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ComboBox cmbBrisanjeRezervacije;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBrisanjeProjekcije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBrisanjeSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBrisanjeKupca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBrisanjeFilma;
        private System.Windows.Forms.Label label1;
    }
}