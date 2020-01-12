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
    public partial class StudentiPredmeti : Form
    {

        public Student Student { get; set; }
        public StudentiPredmeti(Student s)
        {
            InitializeComponent();
            Student = s;
        }       

        private void StudentiPredmeti_Load(object sender, EventArgs e)
        {
            txtBrojIndeksa.Text = Student.BrojIndeksa;
            txtIme.Text = Student.Ime;
            txtPrezime.Text = Student.Prezime;
            txtEmail.Text = Student.Email;
            pbSlikaKorisnika.Image = Student.Slika;
            dataGridView1.DataSource = Student.Polozeni;
        }
    }
}
