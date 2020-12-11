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
    public partial class FormPacjentEdycja : Form
    {
        Pacjent p;
        public FormPacjentEdycja(Pacjent p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            p.Imie = textBox1.Text;
            p.Nazwisko = textBox2.Text;
            p.RokUrodzenia = dateTimePicker1.Value;
            p.Telefon = textBox3.Text;
            p.Email = textBox4.Text;
            p.Pesel = textBox5.Text;

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FormPacjentEdycja_Load(object sender, EventArgs e)
        {
            textBox1.Text = p.Imie;
            textBox2.Text = p.Nazwisko;
            dateTimePicker1.Value = p.RokUrodzenia;
            textBox3.Text = p.Telefon;
            textBox4.Text = p.Email;
            textBox5.Text = p.Pesel;
        }
    }
}
