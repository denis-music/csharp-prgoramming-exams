namespace cSharpIntroWinForms.Ispit
{
    partial class Studenti
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
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.BrojIndeksa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProsjecnaOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrojIndeksa,
            this.Ime,
            this.Prezime,
            this.ProsjecnaOcjena,
            this.BrojPolozeni});
            this.dgvKorisnici.Location = new System.Drawing.Point(12, 41);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(790, 265);
            this.dgvKorisnici.TabIndex = 3;
            this.dgvKorisnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnici_CellContentClick);
            // 
            // BrojIndeksa
            // 
            this.BrojIndeksa.DataPropertyName = "BrojIndeksa";
            this.BrojIndeksa.HeaderText = "Broj indeksa";
            this.BrojIndeksa.Name = "BrojIndeksa";
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // ProsjecnaOcjena
            // 
            this.ProsjecnaOcjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProsjecnaOcjena.DataPropertyName = "Prosjek";
            this.ProsjecnaOcjena.HeaderText = "Prosječna ocjena";
            this.ProsjecnaOcjena.Name = "ProsjecnaOcjena";
            // 
            // BrojPolozeni
            // 
            this.BrojPolozeni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPolozeni.DataPropertyName = "BrojPolozenih";
            this.BrojPolozeni.HeaderText = "Broj polozenih";
            this.BrojPolozeni.Name = "BrojPolozeni";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(124, 15);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(470, 20);
            this.txtPretraga.TabIndex = 5;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.Location = new System.Drawing.Point(704, 13);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(98, 23);
            this.btnDodajKorisnika.TabIndex = 4;
            this.btnDodajKorisnika.Text = "Novi student";
            this.btnDodajKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unesite broj indeksa:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(9, 314);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Prikazi detalje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnDodajKorisnika);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Studenti";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Studenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojIndeksa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProsjecnaOcjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozeni;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button button1;
    }
}