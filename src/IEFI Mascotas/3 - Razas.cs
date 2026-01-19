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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IEFI_Mascotas
{
    public partial class form_Razas : Form
    {
        int? idRazaSeleccionada;

        public form_Razas()
        {
            InitializeComponent();
            cargarTabla();
            limpiarCampos();
        }

        void cargarTabla()
        {
            List<Raza> listaRazas = new List<Raza>();
            listaRazas = new Raza().obtenerRazas();
            tabla_razas.DataSource = listaRazas;
            List<Animal> nombres = new Animal().obtenerNombresAnimales();
            combo_idAnimal.DataSource = nombres;
            combo_idAnimal.ValueMember = "id_animal";
            combo_idAnimal.DisplayMember = "Nombre";
            tabla_razas.Columns["id_Raza"].Visible = false;
            tabla_razas.Columns["id_Animal"].Visible = false;
            tabla_razas.Columns["FechaBaja"].Visible = false;
            combo_idAnimal.SelectedIndex = -1;
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

        private void tabla_razas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idRazaSeleccionada = int.Parse(tabla_razas.CurrentRow.Cells["id_Raza"].Value.ToString());
            txt_raza.Text = tabla_razas.CurrentRow.Cells["Nombre"].Value.ToString();
            string valorEnGrilla = tabla_razas.CurrentRow.Cells["Animal"].Value.ToString();

            foreach (Animal item in combo_idAnimal.Items)
            {
                if (item.Nombre == valorEnGrilla)
                {
                    combo_idAnimal.SelectedItem = item;
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
            combo_idAnimal.SelectedIndex = -1;
            string nombreRaza = txt_raza.Text;

            if (!string.IsNullOrWhiteSpace(nombreRaza))
            {
                Raza raza = new Raza().Obtener(nombreRaza);

                if (raza != null)
                {
                    tabla_razas.DataSource = new List<Raza> { raza };
                }
                else
                {
                    tabla_razas.DataSource = null;
                    MessageBox.Show("Raza no encontrada.");
                }
            }
            else
            {
                MessageBox.Show("El campo de el nombre de raza está vacío. Por favor, ingrese una raza.");
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Raza oRaza = new Raza();
                oRaza.Nombre = txt_raza.Text;
                oRaza.id_Animal = combo_idAnimal.SelectedIndex + 1;
                oRaza.Agregar(oRaza);
                limpiarCampos();
                cargarTabla();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Raza oRaza = new Raza();
            oRaza.Nombre = txt_raza.Text;
            oRaza.id_Animal = combo_idAnimal.SelectedIndex + 1;
            if (idRazaSeleccionada == null)
            {
                MessageBox.Show("Por favor elija una raza haciendo doble click para modificar");
            }
            else if (ValidarCampos())
            {
                oRaza.id_Raza = idRazaSeleccionada.Value;
                oRaza.Modificar(oRaza);
                limpiarCampos();
                cargarTabla();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (idRazaSeleccionada == null)
            {
                MessageBox.Show("Por favor elija una raza haciendo doble click para eliminar");
            }
            else
            {
                new Raza().Eliminar(idRazaSeleccionada.Value);
            }
            limpiarCampos();
            cargarTabla();
        }
    }
}