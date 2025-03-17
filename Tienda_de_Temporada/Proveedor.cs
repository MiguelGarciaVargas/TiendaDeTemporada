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

namespace Tienda_de_Temporada
{
    public partial class Proveedor : Form
    {
        public ConexionClass variable_Conexion;
        private int datoSeleccionado = -1;

        public Proveedor()
        {
            InitializeComponent();
            variable_Conexion = new ConexionClass();
            ConsultarDatos();
        }

        public void InsertaDato()
        {
            string nombre = textBox_nombre.Text;
            string direccion = textBox_direccion.Text;
            string correo = textBox_correo.Text;
            string telefono = textBox_telefono.Text;

            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "INSERT INTO ComprasInfo.Proveedor(nombre_proveedor, direccion_proveedor, telefono_proveedor, correo_proveedor) " +
                                        "VALUES (@nombre, @direccion, @telefono, @correo)";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@direccion", direccion);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@correo", correo);
                    comando.ExecuteNonQuery();

                    textBox_nombre.Text = "";
                    textBox_direccion.Text = "";
                    textBox_telefono.Text = "";
                    textBox_correo.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar datos del cliente");
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public void EliminarDato()
        {
            datoSeleccionado = tabla_proveedor.CurrentRow.Index;
            int index = Convert.ToInt32(tabla_proveedor.Rows[datoSeleccionado].Cells[0].Value);

            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "DELETE FROM ComprasInfo.Proveedor WHERE id_proveedor = " + index;

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.ExecuteNonQuery();

                    textBox_nombre.Text = "";
                    textBox_direccion.Text = "";
                    textBox_telefono.Text = "";
                    textBox_correo.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar al proveedor");
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
            string direccion = textBox_direccion.Text;
            string correo = textBox_correo.Text;
            string telefono = textBox_telefono.Text;
            int index = Convert.ToInt32(tabla_proveedor.Rows[datoSeleccionado].Cells[0].Value);

            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "UPDATE ComprasInfo.Proveedor " +
                                        "SET nombre_proveedor = '" + nombre + "', direccion_proveedor = '" + direccion + "', telefono_proveedor = '" + telefono + "', correo_proveedor = '" + correo +
                                        "' WHERE id_proveedor = " + index;
                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.ExecuteNonQuery();

                    textBox_nombre.Text = "";
                    textBox_direccion.Text = "";
                    textBox_telefono.Text = "";
                    textBox_correo.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos del proveedor \n" + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public void ConsultarDatos()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "SELECT * FROM ComprasInfo.Proveedor";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    tabla_proveedor.DataSource = null;
                    tabla_proveedor.Columns.Clear();
                    tabla_proveedor.DataSource = tabla;

                    tabla_proveedor.Columns[0].HeaderText = "Id cliente";
                    tabla_proveedor.Columns[1].HeaderText = "Nombre";
                    tabla_proveedor.Columns[2].HeaderText = "Dirección";
                    tabla_proveedor.Columns[3].HeaderText = "Correo";
                    tabla_proveedor.Columns[4].HeaderText = "Teléfono";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar datos del provedor");
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            InsertaDato();
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

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            if (datoSeleccionado >= 0)
            {
                EliminarDato();
                ConsultarDatos();
                datoSeleccionado = -1;
            }
        }


        private void tabla_proveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datoSeleccionado = tabla_proveedor.CurrentRow.Index;

            textBox_nombre.Text = tabla_proveedor.Rows[datoSeleccionado].Cells[1].Value.ToString();
            textBox_direccion.Text = tabla_proveedor.Rows[datoSeleccionado].Cells[2].Value.ToString();
            textBox_telefono.Text = tabla_proveedor.Rows[datoSeleccionado].Cells[3].Value.ToString();
            textBox_correo.Text = tabla_proveedor.Rows[datoSeleccionado].Cells[4].Value.ToString();
        }
    }
}
