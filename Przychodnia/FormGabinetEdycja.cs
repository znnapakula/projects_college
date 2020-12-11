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
    public partial class FormGabinetEdycja : Form
    {
        Gabinet gab;
        public FormGabinetEdycja(Gabinet gab)
        {
            InitializeComponent();
            this.gab = gab;
        }

        private void FormGabinetEdycja_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = gab.Nr;
        }

        private void buttonOk_Click_1(object sender, EventArgs e)
        {
            gab.Nr = (int)numericUpDown1.Value;

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
