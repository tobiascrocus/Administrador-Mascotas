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
    public partial class form_Animales : Form
    {
        public form_Animales()
        {
            InitializeComponent();
        }

        void cargarTabla()
        {
            this.animalesTableAdapter.Fill(this.iEFI_MascotasDataSet.Animales, null);
        }

        private void form_Animales_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        void limpiarCampos()
        {
            txt_animal.Clear();
        }

        private bool ValidarCampos()
        {
            string nombreAnimal = txt_animal.Text;

            if (string.IsNullOrEmpty(nombreAnimal))
            {
                MessageBox.Show("Debes completar los campos antes de continuar.");
                return false;
            }

            return true;
        }

        private void tabla_animales_MouseClick(object sender, MouseEventArgs e)
        {
            txt_animal.Text = tabla_animales.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            cargarTabla();
            limpiarCampos();
        }

        private void btn_obtener_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_animal.Text))
            {
                this.animalesTableAdapter.Fill(this.iEFI_MascotasDataSet.Animales, txt_animal.Text);
            }
            else
            {
                MessageBox.Show("Por favor ingrese el nombre de un animal para buscar.");
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                this.animalesTableAdapter.Insert(txt_animal.Text);
                cargarTabla();
                limpiarCampos();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea modificar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    int idAnimal = int.Parse(tabla_animales.CurrentRow.Cells[0].Value.ToString());
                    string nuevoNombre = txt_animal.Text;
                    this.animalesTableAdapter.Update(idAnimal, nuevoNombre);
                    cargarTabla();
                    limpiarCampos();
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int idAnimal = int.Parse(tabla_animales.CurrentRow.Cells[0].Value.ToString());
                this.animalesTableAdapter.Delete(idAnimal);
                limpiarCampos();
                cargarTabla();
            }
            }
        }
    }
}