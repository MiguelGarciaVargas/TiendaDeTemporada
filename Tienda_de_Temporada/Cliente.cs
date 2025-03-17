using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Tienda_de_Temporada
{
    public partial class Cliente : Form
    {   
        public ConexionClass variable_Conexion;
        private int datoSeleccionado = -1;

        public Cliente()
        {
            InitializeComponent();
            variable_Conexion = new ConexionClass();
            ConsultarDatos();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            InsertaDato();
            ConsultarDatos();
        }

        public void ConsultarDatos()
        {
            using(SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "SELECT * FROM ClientesInfo.Cliente";
                    
                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    tabla_cliente.DataSource = null;
                    tabla_cliente.Columns.Clear();
                    tabla_cliente.DataSource = tabla;

                    tabla_cliente.Columns[0].HeaderText = "Id cliente";
                    tabla_cliente.Columns[1].HeaderText = "Nombre";
                    tabla_cliente.Columns[2].HeaderText = "Dirección";
                    tabla_cliente.Columns[3].HeaderText = "Teléfono";
                    tabla_cliente.Columns[4].HeaderText = "Correo";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar datos del cliente");
                }
                finally { 
                    conexion.Close(); 
                }
            }
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
                    string sentencia = "INSERT INTO ClientesInfo.Cliente(nombre_cliente, direccion_cliente, telefono_cliente, correo_cliente) " +
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
            datoSeleccionado = tabla_cliente.CurrentRow.Index;
            int index = Convert.ToInt32(tabla_cliente.Rows[datoSeleccionado].Cells[0].Value);

            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "DELETE FROM ClientesInfo.Cliente WHERE id_cliente = " + index ;

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
                    MessageBox.Show("Error al eliminar al cliente");
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
            int index = Convert.ToInt32(tabla_cliente.Rows[datoSeleccionado].Cells[0].Value);

            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "UPDATE ClientesInfo.Cliente " +
                                        "SET nombre_cliente = '" + nombre + "', direccion_cliente = '" + direccion + "', telefono_cliente = '" + telefono + "', correo_cliente = '" + correo +
                                        "' WHERE id_cliente = " + index;
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
                    if (ex.Message.Contains("UNIQUE KEY"))
                    {
                        MessageBox.Show("Error: Información duplicada");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar los datos del cliente \n" +  ex.Message);
                    }
                    
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void comboBox_pantallas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox_pantallas.SelectedIndex;

            switch (index)
            {
                case 1:
                    Producto pantallaProducto = new Producto();

                    pantallaProducto.Show();
                    break;
                case 2:
                    Temporada pantallaTemporada = new Temporada();

                    pantallaTemporada.Show();
                    break;
                case 3:
                    Proveedor pantallaProveedor = new Proveedor();

                    pantallaProveedor.Show();
                    break;
                case 4:
                    Producto_Temporada pantallaProductoTemporada = new Producto_Temporada();

                    pantallaProductoTemporada.Show();
                    break;

                default:
                    // code block
                    break;
            }
        }

        private void tabla_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            datoSeleccionado = tabla_cliente.CurrentRow.Index;

            textBox_nombre.Text = tabla_cliente.Rows[datoSeleccionado].Cells[1].Value.ToString();
            textBox_direccion.Text = tabla_cliente.Rows[datoSeleccionado].Cells[2].Value.ToString();
            textBox_telefono.Text = tabla_cliente.Rows[datoSeleccionado].Cells[3].Value.ToString();
            textBox_correo.Text = tabla_cliente.Rows[datoSeleccionado].Cells[4].Value.ToString();
        }

        private void button_borrar_Click(object sender, EventArgs e)
        {
            datoSeleccionado = -1;
            textBox_nombre.Text = "";
            textBox_direccion.Text = "";
            textBox_telefono.Text = "";
            textBox_correo.Text = "";
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

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            if (datoSeleccionado >= 0) {
                ActualizarDato();
                ConsultarDatos();
                datoSeleccionado = -1;
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
