using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    [Serializable]
    public class Pracownik
    {
        string imie;
        string nazwisko;
        int rokRozpoczeciaPracy;
        List<CzynnoscMedyczna> listaCzynnosciPracownika = new List<CzynnoscMedyczna>();

        public static List<Pracownik> listaPracownikow = new List<Pracownik>();

        public string Imię
        {
            get => imie;
            set => imie = value;
        }
        public string Nazwisko
        {
            get => nazwisko;
            set => nazwisko = value;
        }
        public int RokRozpoczeciaPracy
        {
            get => rokRozpoczeciaPracy;
            set => rokRozpoczeciaPracy = value;
        }
        public List<CzynnoscMedyczna> ListaCzynnosciPracownika
        {
            get => listaCzynnosciPracownika;
            set => listaCzynnosciPracownika = value;
        }
        
        public override string ToString()
        {
            return this.imie + " " + this.nazwisko;
        }

    }
}
