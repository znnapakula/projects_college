using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    [Serializable]
    public class Terminy
    {
        Pracownik pracownik;
        DateTime dzien;
        int godzStart = 6;
        int godzStop  = 7;
        Gabinet gabinet;

        public static List<Terminy> listaTerminow = new List<Terminy>();

        public Pracownik Pracownik
        {
            get => pracownik;
            set => pracownik = value;
        }
        public DateTime Dzien
        {
            get => dzien;
            set => dzien = value;
        }
        public int GodzStart
        {
            get => godzStart;
            set => godzStart = value;
        }
        public int GodzStop
        {
            get => godzStop;
            set => godzStop = value;
        }
        public Gabinet Gabinet
        {
            get => gabinet;
            set => gabinet = value;
        }

        public static bool CzyGodzinaOk(NumericUpDown numberupdownStart, NumericUpDown numericUpDownStop)
        {
            bool flaga = true;

            if(numberupdownStart.Value >= numericUpDownStop.Value)
            {
                MessageBox.Show("Podane błędne godziny");
                flaga = false;
            }

            return flaga;
        }
        public static bool CzyDzienJuzJest(DateTime dzien, Pracownik p)
        {
            bool flaga = true;
            if(p != null)
            {
                foreach (Terminy termin in listaTerminow)
                {
                    if (termin.pracownik.Imię == p.Imię && termin.pracownik.Nazwisko == p.Nazwisko)
                    {
                        if (termin.dzien.Month == dzien.Month && termin.dzien.Day == dzien.Day)
                        {
                            MessageBox.Show("Tego dnia już jest termin");
                            flaga = false;
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano pracownika");
                flaga = false;
            }
            return flaga;
        }
        public static bool CzyGabinetDostepny(Gabinet gabWybrany, Terminy terminWybrany)
        {
            bool flaga = true;
            if(gabWybrany == null)
            {
                flaga = false;
                return flaga;
            }
            foreach(Terminy termin in Terminy.listaTerminow)
            {
                if(gabWybrany.Nr == termin.gabinet.Nr)
                    if(terminWybrany.dzien.Month == termin.dzien.Month && terminWybrany.dzien.Day == termin.dzien.Day)
                    {
                        if(!((terminWybrany.godzStart < termin.godzStart && terminWybrany.godzStop < termin.godzStart) || (terminWybrany.godzStart > termin.godzStop)))
                        {
                            MessageBox.Show("Gabinet jest w tym czasie zajęty");
                            flaga = false;
                        }
                    }
            }

            return flaga;
        }
    }
}
