using Biblioteca_De_Clases_IEFI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFI_Mascotas
{
    public partial class form_Mascotas : Form
    {
        int? idMascotaSeleccionada;

        public form_Mascotas()
        {
            InitializeComponent();
            cargarTabla();
            limpiarCampos();
        }

        void cargarTabla()
        {
            List<Mascota> listaMascotas = new List<Mascota>();
            listaMascotas = new Mascota().obtenerMascotas();
            tabla_mascotas.DataSource = listaMascotas;
            List<Raza> nombres = new Raza().obtenerNombresRazas();
            combo_idRaza.DataSource = nombres;
            combo_idRaza.ValueMember = "id_raza";
            combo_idRaza.DisplayMember = "Nombre";
            tabla_mascotas.Columns["id_Mascota"].Visible = false;
            tabla_mascotas.Columns["NombreDueño"].Visible = false;
            tabla_mascotas.Columns["id_Raza"].Visible = false;
            tabla_mascotas.Columns["FechaBaja"].Visible = false;
            combo_idRaza.SelectedIndex = -1;
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

        private void tabla_mascotas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idMascotaSeleccionada = int.Parse(tabla_mascotas.CurrentRow.Cells["id_Mascota"].Value.ToString());
            txt_mascota.Text = tabla_mascotas.CurrentRow.Cells["Nombre"].Value.ToString();
            txt_apodo.Text = tabla_mascotas.CurrentRow.Cells["Apodo"].Value.ToString();
            txt_dueño.Text = tabla_mascotas.CurrentRow.Cells["Dueño"].Value.ToString();
            string valorEnGrilla = tabla_mascotas.CurrentRow.Cells["Raza"].Value.ToString();

            foreach (Raza item in combo_idRaza.Items)
            {
                if (item.Nombre == valorEnGrilla)
                {
                    combo_idRaza.SelectedItem = item;
                    break;
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cargarTabla();
        }

        private void btn_obtener_Click(object sender, EventArgs e)
        {
            combo_idRaza.SelectedIndex = -1;
            string nombreMascota = txt_dueño.Text;

            if (!string.IsNullOrWhiteSpace(nombreMascota))
            {
                Mascota mascota = new Mascota().Obtener(nombreMascota);

                if (mascota != null)
                {
                    tabla_mascotas.DataSource = new List<Mascota> { mascota };
                }
                else
                {
                    tabla_mascotas.DataSource = null;
                    MessageBox.Show("Dueño no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("El campo del nombre de dueño está vacío. Por favor, ingrese uno.");
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Mascota oMascota = new Mascota();
                oMascota.Nombre = txt_mascota.Text;
                oMascota.Apodo = txt_apodo.Text;
                oMascota.NombreDueño = txt_dueño.Text;
                oMascota.id_Raza = combo_idRaza.SelectedIndex + 1;
                oMascota.Agregar(oMascota);
                limpiarCampos();
                cargarTabla();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Mascota oMascota = new Mascota();
            oMascota.Nombre = txt_mascota.Text;
            oMascota.Apodo = txt_apodo.Text;
            oMascota.NombreDueño = txt_dueño.Text;
            oMascota.id_Raza = combo_idRaza.SelectedIndex + 1;
            if (idMascotaSeleccionada == null)
            {
                MessageBox.Show("Por favor elija una mascota haciendo doble click para modificar");
            }
            else if (ValidarCampos())
            {
                oMascota.id_Mascota = idMascotaSeleccionada.Value;
                oMascota.Modificar(oMascota);
                limpiarCampos();
                cargarTabla();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (idMascotaSeleccionada == null)
            {
                MessageBox.Show("Por favor elija una mascota haciendo doble click para eliminar");
            }
            else
            {
                new Mascota().Eliminar(idMascotaSeleccionada.Value);
            }
            limpiarCampos();
            cargarTabla();
        }
    }
}