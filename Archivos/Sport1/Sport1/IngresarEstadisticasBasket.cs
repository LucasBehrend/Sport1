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
    public partial class IngresarEstadisticasBasket : Form
    {
        public int[] fechaBasket = new int[2000];
        public int diaBasket;
        public int mesBasket;
        public int añoBasket;
        public int fechaBas;
        public string puntosBasket;
        public string asistenciasBasket;
        public string faltasBasket;
        public string minJugBasket;
        public string tirosFalBasket;
        public string bloqueosBasket;
        CrearPerfil1 formCrearPerfil1;
        public IngresarEstadisticasBasket()
        {
            InitializeComponent();
        }

        private void IngresarEstadisticas_Load(object sender, EventArgs e)
        {

        }

        private void CmbDiaBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            diaBasket = cmbDiaBasket.SelectedIndex;
        }

        private void CmbMesBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesBasket = cmbDiaBasket.SelectedIndex;
        }

        private void CmbAñoBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            añoBasket = cmbDiaBasket.SelectedIndex;
        }

        private void TxtPuntosBasket_TextChanged(object sender, EventArgs e)
        {
            puntosBasket = txtPuntosBasket.Text;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            asistenciasBasket = txtaAsistenicasBasket.Text;
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            faltasBasket = txtFaltasBasket.Text;
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            minJugBasket = txtMinJugBasket.Text;
        }

        private void TxtTirosFal_TextChanged(object sender, EventArgs e)
        {
            tirosFalBasket = txtTirosFal.Text;
        }

        private void TxtBloqueosBasket_TextChanged(object sender, EventArgs e)
        {
            bloqueosBasket = txtBloqueosBasket.Text;
        }

        private void BtnIngresarBasket_Click(object sender, EventArgs e)
        {
            if ()
        }
    }
}
