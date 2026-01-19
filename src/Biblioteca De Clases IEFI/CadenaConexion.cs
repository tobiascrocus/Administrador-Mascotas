using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_De_Clases_IEFI
{
    public class CadenaConexion
    {
        private string _Cadena = "Data Source=.;Initial Catalog=IEFI Mascotas;Integrated Security=true;";
        public string Cadena { get; set; }
        public CadenaConexion()
        {
            Cadena = _Cadena;
        }
        public string obtenerCadena()
        {
            return Cadena;
        }
    }
}