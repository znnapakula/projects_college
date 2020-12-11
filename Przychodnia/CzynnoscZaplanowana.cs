using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    [Serializable]
    public class CzynnoscZaplanowana
    {
        Pacjent pacjent;
        CzynnoscMedyczna czynnosc;
        DateTime dzien;
        decimal godzina;
        Gabinet gabinet;
        Pracownik pracownik;

        public static List<CzynnoscZaplanowana> listaCzynnosciZaplanowanych = new List<CzynnoscZaplanowana>();

        public Pacjent Pacjent
        {
            get => pacjent;
            set => pacjent = value;
        }
        public CzynnoscMedyczna Czynnosc
        {
            get => czynnosc;
            set => czynnosc = value;
        }
        public DateTime Dzien
        {
            get => dzien;
            set => dzien = value;
        }
        public decimal Godzina
        {
            get => godzina;
            set => godzina = value;
        }
        public Pracownik Pracownik
        {
            get => pracownik;
            set => pracownik = value;
        }
        public Gabinet Gabinet
        {
            get => gabinet;
            set => gabinet = value;
        }

    }
}
