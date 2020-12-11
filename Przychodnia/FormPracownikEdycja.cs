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
    public partial class FormPracownikEdycja : Form
    {
        Pracownik p;
        public FormPracownikEdycja(Pracownik p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void FormPracownikEdycja_Load(object sender, EventArgs e)
        {
            foreach (CzynnoscMedyczna czynnosc in CzynnoscMedyczna.listaCzynnosci)
                comboBox1.Items.Add(czynnosc);

            textBox1.Text = p.Imię;
            textBox2.Text = p.Nazwisko;
            numericUpDown1.Value = p.RokRozpoczeciaPracy;
            foreach(CzynnoscMedyczna czynnosc in p.ListaCzynnosciPracownika)
            {
                listBox1.Items.Add(czynnosc);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = -1;
            CzynnoscMedyczna item = (CzynnoscMedyczna)comboBox1.SelectedItem;
            foreach (CzynnoscMedyczna czynnosc in listBox1.Items)
            {
                if (czynnosc.Nazwa == item.Nazwa)
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

            listBox1.Refresh();
            
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            p.Imię = textBox1.Text;
            p.Nazwisko = textBox2.Text;
            p.RokRozpoczeciaPracy = (int)numericUpDown1.Value;

            p.ListaCzynnosciPracownika.Clear();

            foreach (CzynnoscMedyczna czynnosc in listBox1.Items)
            {
                p.ListaCzynnosciPracownika.Add(czynnosc);
            }
            DialogResult = DialogResult.OK;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
    }


