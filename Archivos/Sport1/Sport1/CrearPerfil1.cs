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
    public partial class CrearPerfil1 : Form
    {
        public Inicio f2;
        string nombre;
        public CrearPerfil1()
        {
            InitializeComponent();
        }

        private void BtnAceptarPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.pasarDatos(nombre);
            f2.Show();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            
            
        }

        private void CmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rol = cmbRol.SelectedIndex;
            rol++;
        }

        private void CmbDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int deporte = cmbDeporte.SelectedIndex;
            deporte++;
        }
    }
}
