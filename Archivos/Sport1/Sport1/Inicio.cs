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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnCrearPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearPerfil1 f3 = new CrearPerfil1();
            f3.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Button btnPerfil1 = new Button();
            btnPerfil1.DialogResult = DialogResult.OK;
            btnPerfil1.Text = "Perfil 1";
            btnPerfil1.Location = new Point (24,38);
            btnPerfil1.Size = new Size(160, 70);
            Controls.Add(btnPerfil1);
        }
    }
}
