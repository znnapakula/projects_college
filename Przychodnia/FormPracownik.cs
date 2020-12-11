using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class FormPracownik : Form
    {
        public FormPracownik()
        {
            InitializeComponent();
        }

        private void FormPracownik_Load(object sender, EventArgs e)
        {
            
            Odswiez();
        }

        void Odswiez()
        {
            dataGridView1.Refresh();
            var tempListaPracownikow = new BindingList<Pracownik>(Pracownik.listaPracownikow);
            dataGridView1.DataSource = tempListaPracownikow;

            comboBox1.Items.Clear();
            foreach (CzynnoscMedyczna czynnosc in CzynnoscMedyczna.listaCzynnosci)
                comboBox1.Items.Add(czynnosc);

           

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            //brakuje walidacji
            Pracownik p = new Pracownik();
            p.Imię = textBox1.Text;
            p.Nazwisko = textBox2.Text;
            p.RokRozpoczeciaPracy = (int)numericUpDown1.Value;
            
            foreach(CzynnoscMedyczna czynnosc in listBox1.Items)
            {
                p.ListaCzynnosciPracownika.Add(czynnosc);
            }

            Pracownik.listaPracownikow.Add(p);


            Odswiez();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = -1;
            CzynnoscMedyczna item = (CzynnoscMedyczna)comboBox1.SelectedItem;
            foreach(CzynnoscMedyczna czynnosc in listBox1.Items)
            {
               if( czynnosc.Nazwa == item.Nazwa)
                {
                    //listBox1.Items.Remove(czynnosc);
                    index = listBox1.Items.IndexOf(czynnosc);
                } 
            }
            if (index >= 0)
            {
                listBox1.Items.RemoveAt(index);
                return;
            }
            listBox1.Items.Add(item);


            Odswiez();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.CurrentRow.Index;
                string lista = "Czynność: ";

                foreach (Pracownik p in Pracownik.listaPracownikow)
                {
                    if (Pracownik.listaPracownikow.IndexOf(p) == index)
                    {
                        foreach (CzynnoscMedyczna czynnosc in p.ListaCzynnosciPracownika)
                        {
                            lista = lista + " " + czynnosc;
                        }
                    }

                }
                label5.Text = lista;
            }
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (row.DataBoundItem.GetType() == typeof(Pracownik))
                    dataGridView1.Rows.RemoveAt(row.Index);
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            Pracownik p = (Pracownik)dataGridView1.CurrentRow.DataBoundItem;
            FormPracownikEdycja form = new FormPracownikEdycja(p);
            form.ShowDialog();

            Odswiez();
        }
    }
}
