using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tienda_de_Temporada
{
    public partial class Temporada : Form
    {
        public ConexionClass variable_Conexion;
        private int datoSeleccionado = -1;
        public Temporada()
        {
            InitializeComponent();
            variable_Conexion = new ConexionClass();
            ConsultarDatos();
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            if (datoSeleccionado >= 0)
            {
                ActualizarDato();
                ConsultarDatos();
                datoSeleccionado = -1;
            }
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            InsertaDato();
            ConsultarDatos();
        }

        public void ConsultarDatos()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "SELECT * FROM ProductoInfo.Temporada";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    tabla_temporada.DataSource = null;
                    tabla_temporada.Columns.Clear();
                    tabla_temporada.DataSource = tabla;

                    tabla_temporada.Columns[0].HeaderText = "Id temporada";
                    tabla_temporada.Columns[1].HeaderText = "Nombre";
                    tabla_temporada.Columns[2].HeaderText = "Fecha de inicio";
                    tabla_temporada.Columns[3].HeaderText = "Fecha de fin";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar datos de la temporada" + ex);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public void InsertaDato()
        {
            string nombre = textBox_nombre.Text;
            DateTime fecha_inicio = calendar_fecha_inicio.SelectionStart;
            DateTime fecha_fin = calendar_fecha_fin.SelectionStart;

            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "INSERT INTO ProductoInfo.Temporada(nombre, fecha_inicio, fecha_fin) " +
                                        "VALUES (@nombre, @fecha_inicio, @fecha_fin)";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                    comando.Parameters.AddWithValue("@fecha_fin", fecha_fin);
                    comando.ExecuteNonQuery();

                    textBox_nombre.Text = "";
                    calendar_fecha_inicio.SetDate(DateTime.Now);
                    calendar_fecha_fin.SetDate(DateTime.Now);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar datos del cliente" + ex);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            if (datoSeleccionado >= 0)
            {
                EliminarDato();
                ConsultarDatos();
                datoSeleccionado = -1;
            }
        }

        public void EliminarDato()
        {
            datoSeleccionado = tabla_temporada.CurrentRow.Index;
            int index = Convert.ToInt32(tabla_temporada.Rows[datoSeleccionado].Cells[0].Value);
            Console.WriteLine("dxcfvghjk");
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "DELETE FROM ProductoInfo.Temporada WHERE id_temporada = " + index;

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.ExecuteNonQuery();

                    textBox_nombre.Text = "";
                    calendar_fecha_inicio.SetDate(DateTime.Now);
                    calendar_fecha_fin.SetDate(DateTime.Now);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la temporada");
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public void ActualizarDato()
        {
            string nombre = textBox_nombre.Text;
            string fecha_inicio = calendar_fecha_inicio.SelectionStart.Date.ToString("yyyy-MM-dd"); ;
            string fecha_fin = calendar_fecha_fin.SelectionStart.Date.ToString("yyyy-MM-dd"); ;

            int index = Convert.ToInt32(tabla_temporada.Rows[datoSeleccionado].Cells[0].Value);

            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "UPDATE ProductoInfo.Temporada " +
                                        "SET nombre_temporada = '" + nombre + "', fecha_inicio = '" + fecha_inicio + "', fecha_fin = '" + fecha_fin +
                                        "' WHERE id_temporada = " + index;
                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.ExecuteNonQuery();

                    textBox_nombre.Text = "";
                    calendar_fecha_inicio.SetDate(DateTime.Now);
                    calendar_fecha_fin.SetDate(DateTime.Now);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos de la temporada \n" + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }


        }

        private void tabla_temporada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            datoSeleccionado = tabla_temporada.CurrentRow.Index;

            textBox_nombre.Text = tabla_temporada.Rows[datoSeleccionado].Cells[1].Value.ToString();
            DateTime fecha = DateTime.Parse(tabla_temporada.Rows[datoSeleccionado].Cells[2].Value.ToString());
            calendar_fecha_inicio.SetDate(fecha);
            fecha = DateTime.Parse(tabla_temporada.Rows[datoSeleccionado].Cells[3].Value.ToString());
            calendar_fecha_fin.SetDate(fecha);
        }

        private void calendar_fecha_inicio_DateChanged(object sender, DateRangeEventArgs e)
        {
            calendar_fecha_fin.MinDate = calendar_fecha_inicio.SelectionStart;
        }

        private void calendar_fecha_fin_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
