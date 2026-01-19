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
    public partial class form_Mascotas : Form
    {
        public form_Mascotas()
        {
            InitializeComponent();
        }

        void cargarTabla()
        {
            this.mascotasTableAdapter.Fill(this.iEFI_MascotasDataSet.Mascotas, null);
            combo_idRaza.DataSource = this.razasTableAdapter.GetData("");
            combo_idRaza.ValueMember = "id_raza";
            combo_idRaza.DisplayMember = "NombreRaza";
            limpiarCampos();
        }

        private void form_Mascotas_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        void limpiarCampos()
        {
            txt_mascota.Clear();
            txt_apodo.Clear();
            txt_dueño.Clear();
            combo_idRaza.SelectedIndex = -1;
        }

        private bool ValidarCampos()
        {
            string nombreMascota = txt_mascota.Text;
            string apodoMascota = txt_apodo.Text;
            string dueñoMascota = txt_dueño.Text;

            if (string.IsNullOrEmpty(nombreMascota) || string.IsNullOrEmpty(apodoMascota) || string.IsNullOrEmpty(dueñoMascota))
            {
                MessageBox.Show("Debes completar todos los campos antes de continuar.");
                return false;
            }
            if (combo_idRaza.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar una raza antes de continuar.");
                return false;
            }
            return true;
        }

        private void tabla_mascotas_MouseClick(object sender, MouseEventArgs e)
        {
            txt_mascota.Text = tabla_mascotas.CurrentRow.Cells[1].Value.ToString();
            txt_apodo.Text = tabla_mascotas.CurrentRow.Cells[2].Value.ToString();
            txt_dueño.Text = tabla_mascotas.CurrentRow.Cells[3].Value.ToString();
            combo_idRaza.SelectedValue = tabla_mascotas.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            cargarTabla();
            limpiarCampos();
        }

        private void btn_obtener_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_dueño.Text))
            {
                this.mascotasTableAdapter.Fill(this.iEFI_MascotasDataSet.Mascotas, txt_dueño.Text);
                txt_mascota.Clear();
                txt_apodo.Clear();
                combo_idRaza.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Por favor ingrese el nombre de un dueño para buscar.");
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                this.mascotasTableAdapter.Insert(txt_mascota.Text, txt_apodo.Text, txt_dueño.Text, (int)combo_idRaza.SelectedValue);
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
                    int idMascota = int.Parse(tabla_mascotas.CurrentRow.Cells[0].Value.ToString());
                    string nuevoNombre = txt_mascota.Text;
                    string nuevoApodo = txt_apodo.Text;
                    string nuevoDueño = txt_dueño.Text;
                    int nuevaRaza = (int)combo_idRaza.SelectedValue;
                    this.mascotasTableAdapter.Update(idMascota, nuevoNombre, nuevoApodo, nuevoDueño, nuevaRaza);
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
                    int idMascota = int.Parse(tabla_mascotas.CurrentRow.Cells[0].Value.ToString());
                    this.mascotasTableAdapter.Delete(idMascota);
                    limpiarCampos();
                    cargarTabla();
                }
            }
        }
    }
}