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
    public partial class FormCzynnnoscMedyczna : Form
    {
        
        public FormCzynnnoscMedyczna()
        {
            InitializeComponent();
        }

        private void FormCzynnnoscMedyczna_Load(object sender, EventArgs e)
        {
            Odswiez();
       
        }

        private void buttonDodaj_Click(object sender, EventArgs e) //dodaje czynnosc do listy
        {
            //jeśli nie pusty textbox
            CzynnoscMedyczna cm = new CzynnoscMedyczna();
            cm.Nazwa = textBox1.Text;
            CzynnoscMedyczna.listaCzynnosci.Add(cm);

            
            Odswiez();

        }
        void Odswiez()
        {
            dataGridView1.Refresh();
            var tempListaCzynnosci = new BindingList<CzynnoscMedyczna>(CzynnoscMedyczna.listaCzynnosci);
            dataGridView1.DataSource = tempListaCzynnosci;
        }

        private void buttonUsun_Click(object sender, EventArgs e) //usuwa czynnosc z listy
        {
            //jesli indeks pasuje
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (row.DataBoundItem.GetType() == typeof(CzynnoscMedyczna))
                    dataGridView1.Rows.RemoveAt(row.Index);

            Odswiez();
        }

        private void buttonEdytuj_Click(object sender, EventArgs e) //uruchamia form edycji
        {
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            CzynnoscMedyczna cm = (CzynnoscMedyczna)dataGridView1.CurrentRow.DataBoundItem;
            FormCzynnoscMedycznaEdycja form = new FormCzynnoscMedycznaEdycja(cm);
            form.ShowDialog();

            Odswiez();
        }
    }
}
