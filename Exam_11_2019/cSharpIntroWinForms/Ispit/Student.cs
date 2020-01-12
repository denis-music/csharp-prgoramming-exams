using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.Ispit
{
    public class Student
    {
        public string BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Image Slika { get; set; }
        public List<Predmet> Polozeni { get; set; }
        public float Prosjek { get; set; }
        public int BrojPolozenih { get; set; }
        public string Email { get; set; }
        public void DodajPolozeni (Predmet p)
        {

        }

    }
    public class Predmet
    {
        public string Naziv { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
    }

    class ExamInMemoryDb
    {
        public static List<Student> Studenti { get; set; }
        static ExamInMemoryDb()
        {
            Studenti = new List<Student>();        
        }        
    }

}
