﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms
{
    public partial class Registracija : Form
    {
        private Korisnik korisnik;
        public bool Edit { get; set; }

        public Registracija()
        {
            InitializeComponent();
            korisnik = new Korisnik();
        }

        public Registracija(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
            UcitajPodatkeOKorisniku();
            Edit = true;
        }

        private void UcitajPodatkeOKorisniku()
        {
            try
            {
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                txtLozinka.Text = korisnik.Lozinka;
                pbSlikaKorisnika.Image = korisnik.Slika;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska -> {ex.Message}");
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {

                korisnik.Ime = txtIme.Text;
                korisnik.Prezime = txtPrezime.Text;
                korisnik.KorisnickoIme = txtKorisnickoIme.Text;
                korisnik.Lozinka = txtLozinka.Text;
                korisnik.Slika = pbSlikaKorisnika.Image;
                if (!Edit) { 
                    korisnik.Id = DBInMemory.RegistrovaniKorisnici.Count + 1;
                    DBInMemory.RegistrovaniKorisnici.Add(korisnik);
                    MessageBox.Show("Registracija je uspješna!");
                }
                else
                    MessageBox.Show("Editovanje je uspješno!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }


        private bool ValidirajUnos()
        {
            if (pbSlikaKorisnika.Image == null)
            {
                err.SetError(pbSlikaKorisnika, Validator.porObaveznaVrijednost);
                return false;
            }
            else
                err.Clear();
            return Validator.ObaveznoPolje(txtIme, err, Validator.porObaveznaVrijednost) &&
                Validator.ObaveznoPolje(txtPrezime, err, Validator.porObaveznaVrijednost);
        }

        private string GenerisiLozinku(int brojZnakova)
        {
            string novaLozinka = string.Empty;
            string dozvoljeniZnakovi = "as#$kdjas94oighs2387239058aijfh!%&/()";
            Random random = new Random();
            int lokacija = 0;
            for (int i = 0; i < brojZnakova; i++)
            {
                lokacija = random.Next(0, dozvoljeniZnakovi.Length);
                novaLozinka += dozvoljeniZnakovi[lokacija];
            }

            return novaLozinka;
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = $"{txtIme.Text.ToLower()}.{txtPrezime.Text.ToLower()}";
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = $"{txtIme.Text.ToLower()}.{txtPrezime.Text.ToLower()}";

        }

        private void Registracija_Load(object sender, EventArgs e)
        {
            txtLozinka.Text = GenerisiLozinku(12);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            char prazan = new char();
            if (txtLozinka.PasswordChar == prazan)
                txtLozinka.PasswordChar = '*';
            else
                txtLozinka.PasswordChar = prazan;
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdUcitajSliku.ShowDialog() == DialogResult.OK)
                {
                    string putanjaDoSlike = ofdUcitajSliku.FileName;
                    Image slika = Image.FromFile(putanjaDoSlike);
                    pbSlikaKorisnika.Image = slika;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska -> {ex.Message}");
            }
        }
    }
}
