
namespace Projekat
{
    partial class frmAdminPanel
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKorisIme = new System.Windows.Forms.Label();
            this.lbOdjava = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 73);
            this.button3.TabIndex = 13;
            this.button3.Text = "Brisanje podataka";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Brisanje);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 73);
            this.button2.TabIndex = 12;
            this.button2.Text = "Izmena podataka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Izmena);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 73);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dodaj podatke";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Dodaj);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIme.Location = new System.Drawing.Point(89, 69);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(283, 20);
            this.lblIme.TabIndex = 10;
            this.lblIme.Text = "OVDE UPISATI IME I PREZIME PRODAVCA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Prodavac:";
            // 
            // lblKorisIme
            // 
            this.lblKorisIme.AutoSize = true;
            this.lblKorisIme.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKorisIme.Location = new System.Drawing.Point(89, 99);
            this.lblKorisIme.Name = "lblKorisIme";
            this.lblKorisIme.Size = new System.Drawing.Size(212, 20);
            this.lblKorisIme.TabIndex = 14;
            this.lblKorisIme.Text = "OVDE UPISATI IME PRODAVCA";
            // 
            // lbOdjava
            // 
            this.lbOdjava.AutoSize = true;
            this.lbOdjava.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOdjava.Location = new System.Drawing.Point(332, 9);
            this.lbOdjava.Name = "lbOdjava";
            this.lbOdjava.Size = new System.Drawing.Size(59, 21);
            this.lbOdjava.TabIndex = 15;
            this.lbOdjava.TabStop = true;
            this.lbOdjava.Text = "Odjava";
            this.lbOdjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Odjava);
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 307);
            this.Controls.Add(this.lbOdjava);
            this.Controls.Add(this.lblKorisIme);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAdminPanel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Kontrolni panel prodavca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKorisIme;
        private System.Windows.Forms.LinkLabel lbOdjava;
    }
}