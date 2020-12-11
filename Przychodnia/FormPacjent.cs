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
    public partial class FormPacjent : Form
    {
        public FormPacjent()
        {
            InitializeComponent();
        }
        void Odswiez()
        {
            dataGridView1.Refresh();
            var tempListaPacjentow = new BindingList<Pacjent>(Pacjent.listaPacjentow);
            dataGridView1.DataSource = tempListaPacjentow;

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            foreach (Pacjent osoba in Pacjent.listaOsobPomocnicza)
            {
                comboBox1.Items.Add(osoba);
                comboBox2.Items.Add(osoba);
            }

        }
        void WybierzOsobe(ListBox listbox, ComboBox combobox)
        {
            // parametry ktory listbox, combobox
            int index = -1;
            Pacjent item = (Pacjent)combobox.SelectedItem;
            foreach (Pacjent osoba in listbox.Items)
            {
                if (osoba.Pesel == item.Pesel)
                {
                    //listBox1.Items.Remove(czynnosc);
                    index = listbox.Items.IndexOf(osoba);
                }
            }
            if (index >= 0)
            {
                listbox.Items.RemoveAt(index);
                return;
            }
            listbox.Items.Add(item);


            Odswiez();
        }

        private void FormPacjent_Load(object sender, EventArgs e)
        {
            Odswiez();
            
        }

        private void buttonDodaj_Click(object sender, EventArgs e) // dodaje pacjenta
        {
            
            //brakuje walidacji
             Pacjent p = new Pacjent();
            p.Imie = textBox1.Text;
            p.Nazwisko = textBox2.Text;
            p.RokUrodzenia = dateTimePicker1.Value;
            p.Telefon = textBox3.Text;
            p.Email = textBox4.Text;
            p.Pesel = textBox5.Text;

            if (checkBox3.Checked)
            {
                Pacjent.listaOsobPomocnicza.Add(p);
            }
            else
            {
                Pacjent.listaPacjentow.Add(p);
            }

            Odswiez();
        }

        private void buttonOsoby_Click(object sender, EventArgs e) // edytuje listy osob
        {
            Pacjent p = (Pacjent)dataGridView1.CurrentRow.DataBoundItem;
            foreach (Pacjent osoba in listBox1.Items)
            {
                p.ListaOsobDokumentacja.Add(osoba);
            }
            foreach (Pacjent osoba in listBox2.Items)
            {
                p.ListaOsobStanZdrowia.Add(osoba);
            }

            Odswiez();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            WybierzOsobe(listBox1, comboBox1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            WybierzOsobe(listBox2, comboBox2);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.CurrentRow.Index;
                string listaOsobDok = "dokumentacji medycznej: ";
                string listaOsobInf = "informacji o stanie zdrowia:";

                foreach (Pacjent p in Pacjent.listaPacjentow)
                {
                    if (Pacjent.listaPacjentow.IndexOf(p) == index)
                    {
                        foreach (Pacjent osoba in p.ListaOsobDokumentacja)
                        {
                            listaOsobDok = listaOsobDok + " " + osoba;
                        }
                        foreach(Pacjent osoba in p.ListaOsobStanZdrowia)
                        {
                            listaOsobInf = listaOsobInf + " " + osoba; 
                        }
                    }

                }
                label5.Text = listaOsobInf;
                label12.Text = listaOsobDok;
            }
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (row.DataBoundItem.GetType() == typeof(Pacjent))
                    dataGridView1.Rows.RemoveAt(row.Index);
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            Pacjent p = (Pacjent)dataGridView1.CurrentRow.DataBoundItem;
            FormPacjentEdycja form = new FormPacjentEdycja(p);
            form.ShowDialog();

            Odswiez();
        }
    }
}
