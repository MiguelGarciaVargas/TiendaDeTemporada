using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tienda_de_Temporada
{
    public class ConexionClass
    {
        //Montse
        //private string cadenaConexion = "Server=DESKTOP-DHHEAFL\\SQLEXPRESS; Database=TiendaDeTemporada; Integrated Security=yes;";
        ////Mike Desktop
        private string cadenaConexion = "Server=DESKTOP-S528AVG\\SQLEXPRESS; Database=TiendaDeTemporada; Integrated Security=yes;";
        //Mike Laptop
        //private string cadenaConexion = "Server=LAPTOP-T3MDEHIJ\\SQLEXPRESS; Database=TiendaDeTemporada; Integrated Security=yes;";

        public string Conexion => cadenaConexion;

        public SqlConnection Conectar()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
