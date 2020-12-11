using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Przychodnia
{
    public partial class Form1 : Form
    {      
  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void czynnosc_Click(object sender, EventArgs e) //otwiera form czynności
        {
            FormCzynnnoscMedyczna f = new FormCzynnnoscMedyczna();
            f.ShowDialog();
        }

        private void pracownicy_Click(object sender, EventArgs e) //otwiera form pracownicy
        {
            FormPracownik f = new FormPracownik();
            f.ShowDialog();
        }

        private void gabinety_Click(object sender, EventArgs e) // otwiera form gabinety
        {
            FormGabinet f = new FormGabinet();
            f.ShowDialog();
        }

        private void pacjenci_Click(object sender, EventArgs e) // otwiera form pacjenci
        {
            FormPacjent f = new FormPacjent();
            f.ShowDialog();
        }

        private void datyIGodzinyPracy_Click(object sender, EventArgs e)
        {
            FormTerminy f = new FormTerminy();
            f.ShowDialog();
        }

        private void zaplanowane_Click(object sender, EventArgs e)
        {
            FormCzynnoscZaplanowana f = new FormCzynnoscZaplanowana();
            f.ShowDialog();
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            Serializacja.Zapisz();
        }
        

        private void buttonWczytaj_Click(object sender, EventArgs e)
        {
            Serializacja.Wczytaj();
        }
        
    }
}
