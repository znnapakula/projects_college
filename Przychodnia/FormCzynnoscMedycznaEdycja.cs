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
    public partial class FormCzynnoscMedycznaEdycja : Form
    {
        CzynnoscMedyczna cm;
        public FormCzynnoscMedycznaEdycja(CzynnoscMedyczna cm)
        {
            InitializeComponent();
            this.cm = cm;
        }

        private void FormCzynnoscMedycznaEdycja_Load(object sender, EventArgs e)
        {
            textBox1.Text = cm.Nazwa;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            cm.Nazwa = textBox1.Text;

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
