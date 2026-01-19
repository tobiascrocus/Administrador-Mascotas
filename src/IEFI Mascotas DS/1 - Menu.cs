using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFI_Mascotas_DS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Animales_Click(object sender, EventArgs e)
        {
            form_Animales formularioAnimales = new form_Animales();
            formularioAnimales.ShowDialog();
        }

        private void btn_Razas_Click(object sender, EventArgs e)
        {
            form_Razas formularioRazas = new form_Razas();
            formularioRazas.ShowDialog();
        }

        private void btn_Mascotas_Click(object sender, EventArgs e)
        {
            form_Mascotas formularioMascotas = new form_Mascotas();
            formularioMascotas.ShowDialog();
        }
    }
}