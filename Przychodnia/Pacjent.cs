using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    [Serializable]
    public class Pacjent
    {
        string imie;
        string nazwisko;
        string pesel;
        DateTime rokUrodzenia;
        string telefon;
        string email;
        List<Pacjent> listaOsobStanZdrowia = new List<Pacjent>();
        List<Pacjent> listaOsobDokumentacja = new List<Pacjent>();
         public static List<Pacjent> listaOsobPomocnicza = new List<Pacjent>();

        public static List<Pacjent> listaPacjentow = new List<Pacjent>();
        public string Imie
        {
            get => imie;
            set => imie = value;
        }
        
        public string Nazwisko
        {
            get => nazwisko;
            set => nazwisko = value;
        }
        
        public string Pesel
        {
            get => pesel;
            set => pesel = value;
        }
        
        public DateTime RokUrodzenia
        {
            get => rokUrodzenia;
            set => rokUrodzenia = value;
        }
        
        public string Telefon
        {
            get => telefon;
            set => telefon = value;
        }
        
        public string Email
        {
            get => email;
            set => email = value;
        }
        
        public List<Pacjent> ListaOsobStanZdrowia
        {
            get => listaOsobStanZdrowia;
            set => listaOsobStanZdrowia = value;
        }
        public List<Pacjent> ListaOsobDokumentacja
        {
            get => listaOsobDokumentacja;
            set => listaOsobDokumentacja = value;
        }
        
        public override string ToString()
        {
            return this.imie + " " + this.nazwisko;
        }

    }
}
