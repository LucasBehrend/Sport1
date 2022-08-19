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
        int pos = 38;
        int cantPerfiles = 0;
        string[] nombres = new string[1000];
        public void pasarDatos (string hola)
        {
            nombres[cantPerfiles] = hola;
            cantPerfiles++;            
        }
        
        
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
            //cant de  perfiles
            

            for (int p = 0; p < cantPerfiles; p++)
            {
                Button btnPerfil1 = new Button();
                btnPerfil1.DialogResult = DialogResult.OK;
                btnPerfil1.Text = "Perfil " + cantPerfiles;
                btnPerfil1.Location = new Point(24, pos);
                pos += 500;
                btnPerfil1.Size = new Size(160, 70);
                Controls.Add(btnPerfil1);

            }
        }
    }
}
