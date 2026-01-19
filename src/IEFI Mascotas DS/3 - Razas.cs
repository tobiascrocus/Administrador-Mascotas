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
    public partial class form_Razas : Form
    {
        public form_Razas()
        {
            InitializeComponent();
        }

        void cargarTabla()
        {
            this.razasTableAdapter.Fill(this.iEFI_MascotasDataSet.Razas, null);
            combo_idAnimal.DataSource = this.animalesTableAdapter.GetData("");
            combo_idAnimal.ValueMember = "id_animal";
            combo_idAnimal.DisplayMember = "Nombre";
            limpiarCampos();
        }

        private void form_Razas_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        void limpiarCampos()
        {
            txt_raza.Clear();
            combo_idAnimal.SelectedIndex = -1;
        }

        private bool ValidarCampos()
        {
            string nombreRaza = txt_raza.Text;

            if (string.IsNullOrEmpty(nombreRaza))
            {
                MessageBox.Show("Debes completar los campos antes de continuar.");
                return false;
            }
            if (combo_idAnimal.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un animal antes de continuar.");
                return false;
            }
            return true;
        }

        private void tabla_razas_MouseClick(object sender, MouseEventArgs e)
        {
            txt_raza.Text = tabla_razas.CurrentRow.Cells[1].Value.ToString();
            combo_idAnimal.SelectedValue = tabla_razas.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            cargarTabla();
            limpiarCampos();
        }

        private void btn_obtener_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_raza.Text))
            {
                this.razasTableAdapter.Fill(this.iEFI_MascotasDataSet.Razas, txt_raza.Text);
                combo_idAnimal.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Por favor ingrese el nombre de una raza para buscar.");
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                this.razasTableAdapter.Insert(txt_raza.Text, (int)combo_idAnimal.SelectedValue);
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
                    int idRaza = int.Parse(tabla_razas.CurrentRow.Cells[0].Value.ToString());
                    string nuevoNombre = txt_raza.Text;
                    int nuevoAnimal = (int)combo_idAnimal.SelectedValue;
                    this.razasTableAdapter.Update(idRaza, nuevoNombre, nuevoAnimal);
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
                    int idRaza = int.Parse(tabla_razas.CurrentRow.Cells[0].Value.ToString());
                    this.razasTableAdapter.Delete(idRaza);
                    limpiarCampos();
                    cargarTabla();
                }
            }
        }
    }
}