
namespace Projekat
{
    partial class frmRezervacija
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
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.nudBrojMesta = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNaziv = new System.Windows.Forms.ComboBox();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPocetni = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpKrajni = new System.Windows.Forms.DateTimePicker();
            this.lbProjekcije = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojMesta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(435, 439);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 46;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.Vratiti);
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRezervisi.Location = new System.Drawing.Point(520, 416);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(181, 46);
            this.btnRezervisi.TabIndex = 45;
            this.btnRezervisi.Text = "Rezerviši";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.Rezervisi);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(148, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ukupna cena:";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrikazi.Location = new System.Drawing.Point(11, 150);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(689, 34);
            this.btnPrikazi.TabIndex = 42;
            this.btnPrikazi.Text = "Prikaži dostupne projekcije";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.PrikazProjekcija);
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.Location = new System.Drawing.Point(148, 439);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.ReadOnly = true;
            this.txtUkupnaCena.Size = new System.Drawing.Size(136, 23);
            this.txtUkupnaCena.TabIndex = 33;
            // 
            // nudBrojMesta
            // 
            this.nudBrojMesta.Location = new System.Drawing.Point(12, 439);
            this.nudBrojMesta.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBrojMesta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBrojMesta.Name = "nudBrojMesta";
            this.nudBrojMesta.Size = new System.Drawing.Size(108, 23);
            this.nudBrojMesta.TabIndex = 44;
            this.nudBrojMesta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBrojMesta.ValueChanged += new System.EventHandler(this.BrojMesta);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Broj mesta:";
            // 
            // cmbNaziv
            // 
            this.cmbNaziv.FormattingEnabled = true;
            this.cmbNaziv.Location = new System.Drawing.Point(520, 108);
            this.cmbNaziv.Name = "cmbNaziv";
            this.cmbNaziv.Size = new System.Drawing.Size(180, 23);
            this.cmbNaziv.TabIndex = 41;
            // 
            // cmbSala
            // 
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(353, 108);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(157, 23);
            this.cmbSala.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Naziv:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sala:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Početni datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Filteri:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Rezervacija projekcija";
            // 
            // dtpPocetni
            // 
            this.dtpPocetni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPocetni.Location = new System.Drawing.Point(12, 108);
            this.dtpPocetni.Name = "dtpPocetni";
            this.dtpPocetni.Size = new System.Drawing.Size(161, 23);
            this.dtpPocetni.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Krajnji datum:";
            // 
            // dtpKrajni
            // 
            this.dtpKrajni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKrajni.Location = new System.Drawing.Point(183, 108);
            this.dtpKrajni.Name = "dtpKrajni";
            this.dtpKrajni.Size = new System.Drawing.Size(164, 23);
            this.dtpKrajni.TabIndex = 39;
            // 
            // lbProjekcije
            // 
            this.lbProjekcije.FormattingEnabled = true;
            this.lbProjekcije.ItemHeight = 15;
            this.lbProjekcije.Location = new System.Drawing.Point(12, 190);
            this.lbProjekcije.Name = "lbProjekcije";
            this.lbProjekcije.Size = new System.Drawing.Size(688, 214);
            this.lbProjekcije.TabIndex = 43;
            this.lbProjekcije.SelectedIndexChanged += new System.EventHandler(this.Zbir);
            // 
            // frmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 471);
            this.Controls.Add(this.lbProjekcije);
            this.Controls.Add(this.dtpPocetni);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtUkupnaCena);
            this.Controls.Add(this.nudBrojMesta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbNaziv);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.dtpKrajni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRezervacija";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Rezervacija";
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojMesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnRezervisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.NumericUpDown nudBrojMesta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbNaziv;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPocetni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpKrajni;
        private System.Windows.Forms.ListBox lbProjekcije;
    }
}