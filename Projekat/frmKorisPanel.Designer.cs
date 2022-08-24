
namespace Projekat
{
    partial class frmKorisPanel
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKorisIme = new System.Windows.Forms.Label();
            this.lbOdjava = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 67);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pregled rezervacije";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PregledRezer);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "Rezerviši karte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Rezervisi);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIme.Location = new System.Drawing.Point(116, 59);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(318, 25);
            this.lblIme.TabIndex = 5;
            this.lblIme.Text = "OVDE TREBA DA PISE IME I PREZIME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Korisnik:";
            // 
            // lblKorisIme
            // 
            this.lblKorisIme.AutoSize = true;
            this.lblKorisIme.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKorisIme.Location = new System.Drawing.Point(116, 84);
            this.lblKorisIme.Name = "lblKorisIme";
            this.lblKorisIme.Size = new System.Drawing.Size(283, 25);
            this.lblKorisIme.TabIndex = 8;
            this.lblKorisIme.Text = "OVDE TREBA DA PISE KORIS IME";
            // 
            // lbOdjava
            // 
            this.lbOdjava.AutoSize = true;
            this.lbOdjava.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOdjava.Location = new System.Drawing.Point(435, 9);
            this.lbOdjava.Name = "lbOdjava";
            this.lbOdjava.Size = new System.Drawing.Size(59, 21);
            this.lbOdjava.TabIndex = 9;
            this.lbOdjava.TabStop = true;
            this.lbOdjava.Text = "Odjava";
            this.lbOdjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Odjava);
            // 
            // frmKorisPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 202);
            this.Controls.Add(this.lbOdjava);
            this.Controls.Add(this.lblKorisIme);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmKorisPanel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Korisnički panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKorisIme;
        private System.Windows.Forms.LinkLabel lbOdjava;
    }
}