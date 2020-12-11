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
    public partial class FormTerminy : Form
    {
        public FormTerminy()
        {
            InitializeComponent();
        }

        void Odswiez()
        {
            dataGridView1.Refresh();
            var tempListaTerminow = new BindingList<Terminy>(Terminy.listaTerminow);
            dataGridView1.DataSource = tempListaTerminow;

            comboBox1.Items.Clear();
            
            foreach (Pracownik p  in Pracownik.listaPracownikow)
            {
                comboBox1.Items.Add(p);              
            }
            foreach (Gabinet gab in Gabinet.listaGabinetow)
            {
                comboBox2.Items.Add(gab);
            }

        }
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Terminy termin = new Terminy();
            termin.Pracownik = (Pracownik)comboBox1.SelectedItem;
            termin.Dzien = dateTimePicker1.Value;
            termin.GodzStart = (int)numericUpDown1.Value;
            termin.GodzStop = (int)numericUpDown2.Value;
            termin.Gabinet = (Gabinet)comboBox2.SelectedItem;
            if (!Terminy.CzyGodzinaOk(numericUpDown1, numericUpDown2))
                return;
            if (!Terminy.CzyDzienJuzJest(termin.Dzien, termin.Pracownik))
                return;
            if (!Terminy.CzyGabinetDostepny(termin.Gabinet, termin))
                return;
            Terminy.listaTerminow.Add(termin);

            Odswiez();
        }

        private void FormTerminy_Load(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (row.DataBoundItem.GetType() == typeof(Terminy))
                    dataGridView1.Rows.RemoveAt(row.Index);
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {

        }
    }
}
