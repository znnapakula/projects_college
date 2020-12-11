using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class FormCzynnoscZaplanowana : Form
    {
        public FormCzynnoscZaplanowana()
        {
            InitializeComponent();
        }
        void Odswiez()
        {
            dataGridView1.Refresh();
            var tempListaZaplanowanych = new BindingList<CzynnoscZaplanowana>(CzynnoscZaplanowana.listaCzynnosciZaplanowanych);
            dataGridView1.DataSource = tempListaZaplanowanych;

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            foreach (Pacjent pacjent in Pacjent.listaPacjentow) // wszyscy
            {
                comboBox1.Items.Add(pacjent);
            }
            foreach (CzynnoscMedyczna czynnoscMed in CzynnoscMedyczna.listaCzynnosci) // wszystkie
            {
                comboBox2.Items.Add(czynnoscMed);
            }
            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) // kiedy wybieramy czynnosc
        {
            comboBox3.Items.Clear();
            foreach (Pracownik pracownik in Pracownik.listaPracownikow) // pracownicy z czynnością
            {
                CzynnoscMedyczna czynnoscWybrana = (CzynnoscMedyczna)comboBox2.SelectedItem;
                foreach (CzynnoscMedyczna czynnosc in pracownik.ListaCzynnosciPracownika)
                {
                    if (czynnosc.Nazwa == czynnoscWybrana.Nazwa)
                    {
                        comboBox3.Items.Add(pracownik);
                        continue;
                    }
                }
            }
        }

        private void FormCzynnoscZaplanowana_Load(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e) // kiedy wybieramy dzien
        {
            comboBox5.Items.Clear();
            Pracownik pracownikWybrany = (Pracownik)comboBox3.SelectedItem;
            int dzienWybrany = (int)comboBox4.SelectedItem;
                      
            foreach (Terminy termin in Terminy.listaTerminow)
            {
                if (termin.Pracownik.Imię == pracownikWybrany.Imię && termin.Pracownik.Nazwisko == pracownikWybrany.Nazwisko && termin.Dzien.Day == dzienWybrany)
                {
                    for (int i = 6; i < 24; i++)
                    {
                        if (i >= termin.GodzStart && i <= termin.GodzStop)
                        {
                            comboBox5.Items.Add(i);
                            
                        }
                     }
                }
             }
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) // kiedy wybieramy pracownika 
        {
            comboBox4.Items.Clear();
            Pracownik pracownikWybrany = (Pracownik)comboBox3.SelectedItem;
            foreach (Terminy termin in Terminy.listaTerminow)
            {
                if (termin.Pracownik.Imię == pracownikWybrany.Imię && termin.Pracownik.Nazwisko == pracownikWybrany.Nazwisko)
                {
                    comboBox4.Items.Add(termin.Dzien.Day);
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e) // kiedy wybieramy godzinę
        {
            comboBox6.Items.Clear();
            int godzinaWybrana = (int)comboBox5.SelectedItem;
            bool juzJest = false;
            
            decimal godzinaPlusMinuty;
            for(decimal i = 0.00m; i < 0.60m; i = i + 0.10m)
            {
                juzJest = false;
                godzinaPlusMinuty = godzinaWybrana + i;
                foreach(CzynnoscZaplanowana wizyta in CzynnoscZaplanowana.listaCzynnosciZaplanowanych)
                {
                    if(wizyta.Godzina == godzinaPlusMinuty)
                    {
                        juzJest = true;
                        break;
                    }
                }
                if (juzJest)
                    continue;
                comboBox6.Items.Add(godzinaPlusMinuty);
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e) // dodajemy wizyte
        {
            CzynnoscZaplanowana wizyta = new CzynnoscZaplanowana();

            wizyta.Pacjent = (Pacjent)comboBox1.SelectedItem;
            wizyta.Czynnosc = (CzynnoscMedyczna)comboBox2.SelectedItem;
            wizyta.Pracownik = (Pracownik)comboBox3.SelectedItem;
            wizyta.Dzien = (DateTime)comboBox4.SelectedItem;
            wizyta.Godzina = (decimal)comboBox6.SelectedItem;
            wizyta.Gabinet = (Gabinet)(Terminy.listaTerminow[SzukajGabinetu(wizyta.Pracownik,wizyta.Dzien)].Gabinet);

            CzynnoscZaplanowana.listaCzynnosciZaplanowanych.Add(wizyta);

            Odswiez();
        }
        int SzukajGabinetu(Pracownik pracownik, DateTime dzien)
        {
            int indeksGabinetu = 0;
            foreach(Terminy termin in Terminy.listaTerminow)
            {
                if (pracownik == termin.Pracownik && dzien == termin.Dzien)
                    indeksGabinetu = Terminy.listaTerminow.IndexOf(termin);
            }
            return indeksGabinetu;
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (row.DataBoundItem.GetType() == typeof(CzynnoscZaplanowana))
                    dataGridView1.Rows.RemoveAt(row.Index);
        }
    }

 }

