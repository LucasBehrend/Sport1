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
            Inicio_Load(null, null);
        }
        
        
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnCrearPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearPerfil1 f3 = new CrearPerfil1();
            f3.f2 = this;
            f3.Show();
        }

        private void click_btn_perfil(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("hola" + btn.Text);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //cant de  perfiles
            if (cantPerfiles > 0)
            {


                Button btnPerfil1 = new Button();
                btnPerfil1.DialogResult = DialogResult.OK;
                btnPerfil1.Text = "Perfil" + cantPerfiles;
                btnPerfil1.Location = new Point(24, pos);
                pos += 100;
                btnPerfil1.Size = new Size(160, 70);
                btnPerfil1.Click += new System.EventHandler(this.click_btn_perfil);
                Controls.Add(btnPerfil1);
                


            }
            
        }
    }
}
