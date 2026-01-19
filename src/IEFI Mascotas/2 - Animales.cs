using Biblioteca_De_Clases_IEFI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFI_Mascotas
{
    public partial class form_Animales : Form
    {
        int? idAnimalSeleccionado;

        public form_Animales()
        {
            InitializeComponent();
            cargarTabla();
        }

        void cargarTabla()
        {
            List<Animal> listaAnimales = new List<Animal>();
            listaAnimales = new Animal().obtenerAnimales();
            tabla_animales.DataSource = listaAnimales;
            tabla_animales.Columns["id_Animal"].Visible = false;
            tabla_animales.Columns["FechaBaja"].Visible = false;
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

        private void tabla_animales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idAnimalSeleccionado = int.Parse(tabla_animales.CurrentRow.Cells["id_Animal"].Value.ToString());
            txt_animal.Text = tabla_animales.CurrentRow.Cells["Nombre"].Value.ToString();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cargarTabla();
        }

        private void btn_obtener_Click(object sender, EventArgs e)
        {
            string nombreAnimal = txt_animal.Text;

            if (!string.IsNullOrWhiteSpace(nombreAnimal))
            {
                Animal animal = new Animal().Obtener(nombreAnimal);

                if (animal != null)
                {
                    tabla_animales.DataSource = new List<Animal> { animal };
                }
                else
                {
                    tabla_animales.DataSource = null;
                    MessageBox.Show("Animal no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("El campo de el nombre de animal está vacío. Por favor, ingrese un nombre de animal.");
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Animal oAnimal = new Animal();
                oAnimal.Nombre = txt_animal.Text;
                oAnimal.Agregar(oAnimal);
                limpiarCampos();
                cargarTabla();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
            Animal oAnimal = new Animal();
            oAnimal.Nombre = txt_animal.Text;
            if (idAnimalSeleccionado == null)
            {
                MessageBox.Show("Por favor elija un animal haciendo doble click para modificar");
            }
            else
            {
                oAnimal.id_Animal = idAnimalSeleccionado.Value;
                oAnimal.Modificar(oAnimal);
            }
            limpiarCampos();
            cargarTabla();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
            if (idAnimalSeleccionado == null)
            {
                MessageBox.Show("Por favor elija una animal haciendo doble click para eliminar");
            }
            else
            {
                new Animal().Eliminar(idAnimalSeleccionado.Value);
            }
            limpiarCampos();
            cargarTabla();
            }
        }
    }
}