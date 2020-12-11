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
    public partial class FormGabinet : Form
    {
        public FormGabinet()
        {
            InitializeComponent();
        }
        void Odswiez()
        {
            dataGridView1.Refresh();
            var tempListaGabinetow = new BindingList<Gabinet>(Gabinet.listaGabinetow);
            dataGridView1.DataSource = tempListaGabinetow;
        }

        private void FormGabinet_Load(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            //jeśli nie pusty textbox
            Gabinet gab = new Gabinet();
            gab.Nr = (int)numericUpDown1.Value;
            Gabinet.listaGabinetow.Add(gab);


            Odswiez();
        }

        private void buttonUsuń_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (row.DataBoundItem.GetType() == typeof(Gabinet))
                    dataGridView1.Rows.RemoveAt(row.Index);

            Odswiez();
        }

        private void buttonEdycja_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            Gabinet g = (Gabinet)dataGridView1.CurrentRow.DataBoundItem;
            FormGabinetEdycja form = new FormGabinetEdycja(g);
            form.ShowDialog();

            Odswiez();
        }
    }
}
