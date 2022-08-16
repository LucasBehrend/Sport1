using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport1
{
    public partial class CrearPerfil : Form
    {
        public CrearPerfil()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string nombre1 = txtNombre.Text;

        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipo = cmbTipo.SelectedIndex;
            tipo++;
        }
    }
}
