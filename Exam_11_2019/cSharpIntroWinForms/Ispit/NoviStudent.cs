using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.Ispit
{
    public partial class NoviStudent : Form
    {
        public Student Student { get; set; }
        public NoviStudent()
        {
            InitializeComponent();
            Student = new Student();
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {

        }

        private void pbSlikaKorisnika_Click(object sender, EventArgs e)
        {
            if (ofdUcitajSliku.ShowDialog() == DialogResult.OK)
            {
                string lokacija = ofdUcitajSliku.FileName;
                pbSlikaKorisnika.Image = Image.FromFile(lokacija);
                
            }
        }

        private void NoviStudent_Load(object sender, EventArgs e)
        {

            int brojCifara = ExamInMemoryDb.Studenti.Count.ToString().Length;
            string dodatak = "";
            for (int i = 0; i < 3 - brojCifara; i++)
                dodatak += "0";
            dodatak += (ExamInMemoryDb.Studenti.Count + 1).ToString();
            txtBrojIndeksa.Text = $"IB190{dodatak}";
            txtEmail.Text = txtBrojIndeksa.Text.ToLower() + "@edu.fit.ba";
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            Student.BrojIndeksa = txtBrojIndeksa.Text;
            Student.Ime = txtIme.Text;
            Student.Prezime = txtPrezime.Text;
            Student.Slika = pbSlikaKorisnika.Image;
            Student.Email = txtEmail.Text;
            Student.Prosjek = 0;
            Student.BrojPolozenih = 5;
            Student.Polozeni = new List<Predmet>();
            for (int i = 0; i < 5; i++)
            {
                Predmet p = new Predmet()
                {
                    DatumPolaganja = DateTime.Now,
                    Naziv = $"Predmet{i + 1}",
                    Ocjena = new Random().Next(6, 10)
                };
                Student.Polozeni.Add(p);
                Student.Prosjek += p.Ocjena;
            }Student.Prosjek /= Student.BrojPolozenih;
            ExamInMemoryDb.Studenti.Add(Student);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
