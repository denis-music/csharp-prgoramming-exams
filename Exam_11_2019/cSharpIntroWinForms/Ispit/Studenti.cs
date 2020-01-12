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
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            NoviStudent ns = new NoviStudent();
            if (ns.ShowDialog() == DialogResult.OK)
            {
                SetDataSource();
            }
        }
        private void SetDataSource(List<Student> students = null)
        {
            dgvKorisnici.DataSource = null;
            dgvKorisnici.DataSource = students?? ExamInMemoryDb.Studenti;            
            CalcTotalinfo(dgvKorisnici.DataSource);
        }

        private void CalcTotalinfo(object ds)
        {
            float total = 0;
            int brojac = 0;
            foreach (var item in ds as List<Student>)
            {                
                total += item.Prosjek;
                brojac++;
            }
            if (brojac > 0)
                total /= brojac;
            lblInfo.Text = $"Prikazano {brojac} studenata, a njihov prosjek je {total}";
        }

        private void Studenti_Load(object sender, EventArgs e)
        {
            SetDataSource();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            List<Student> rez = new List<Student>();
            foreach (var student in ExamInMemoryDb.Studenti)
            {
                if (student.BrojIndeksa.ToLower().Contains(txtPretraga.Text.ToLower()))
                    rez.Add(student);
            }
            SetDataSource(rez);

        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Student s = dgvKorisnici.SelectedRows[0].DataBoundItem as Student;
            StudentiPredmeti sp = new StudentiPredmeti(s);
            sp.ShowDialog();

        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = dgvKorisnici.SelectedRows[0].DataBoundItem as Student;
            StudentiPredmeti sp = new StudentiPredmeti(s);
            sp.ShowDialog();
        }
    }
}
