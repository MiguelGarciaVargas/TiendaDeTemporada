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
    public partial class Producto : Form
    {
        public ConexionClass variable_Conexion;
        private int selectedID;
        public Producto()
        {
            InitializeComponent();
            selectedID = -1;
            variable_Conexion = new ConexionClass();
            ConsultarDatos();
        }

        public void InsertaDato()
        {
            string nombre = textBox_nombre.Text;
            string precio = textBox_precio.Text;
            string existencias = textBox_existencias.Text;

            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "INSERT INTO ProductoInfo.Producto(nombre_producto, precio_producto, existencias) " +
                                        "VALUES (@nombre, @precio, @existencias)";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@precio", decimal.Parse(precio));
                    comando.Parameters.AddWithValue("@existencias", int.Parse(existencias));
                    comando.ExecuteNonQuery();

                    textBox_nombre.Text = "";
                    textBox_precio.Text = "";
                    textBox_existencias.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar datos del producto" + ex);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public void EliminarDato()
        {
            selectedID = tabla_producto.CurrentRow.Index;
            int index = Convert.ToInt32(tabla_producto.Rows[selectedID].Cells[0].Value);

            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "DELETE FROM ProductoInfo.Producto WHERE id_producto = " + index;

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.ExecuteNonQuery();

                    textBox_nombre.Text = "";
                    textBox_precio.Text = "";
                    textBox_existencias.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar al producto");
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
            string precio = textBox_precio.Text;
            string existencias = textBox_existencias.Text;
            int index = Convert.ToInt32(tabla_producto.Rows[selectedID].Cells[0].Value);

            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "UPDATE ProductoInfo.Producto " +
                                        "SET nombre_producto = '" + nombre + "', precio_producto = '" + precio + "', existencias = '" + existencias +
                                        "' WHERE id_producto = " + index;
                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.ExecuteNonQuery();

                    textBox_nombre.Text = "";
                    textBox_precio.Text = "";
                    textBox_existencias.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos del producto \n" + ex.Message);
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
                    string sentencia = "SELECT * FROM ProductoInfo.Producto";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    tabla_producto.DataSource = null;
                    tabla_producto.Columns.Clear();
                    tabla_producto.DataSource = tabla;

                    tabla_producto.Columns[0].HeaderText = "Id producto";
                    tabla_producto.Columns[1].HeaderText = "Nombre";
                    tabla_producto.Columns[2].HeaderText = "Precio";
                    tabla_producto.Columns[3].HeaderText = "Existencias";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar datos de productos");
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
                case 0:
                    Cliente pantallaCliente = new Cliente();

                    pantallaCliente.Show();
                    break;
                default:
                    // code block
                    break;
            }
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            InsertaDato();
            ConsultarDatos();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            if (selectedID >= 0)
            {
                EliminarDato();
                ConsultarDatos();
                selectedID = -1;
            }
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            if (selectedID >= 0)
            {
                ActualizarDato();
                ConsultarDatos();
                selectedID = -1;
            }
        }

        private void tabla_producto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedID = tabla_producto.CurrentRow.Index;

            textBox_nombre.Text = tabla_producto.Rows[selectedID].Cells[1].Value.ToString();
            textBox_precio.Text = tabla_producto.Rows[selectedID].Cells[2].Value.ToString();
            textBox_existencias.Text = tabla_producto.Rows[selectedID].Cells[3].Value.ToString();
        }
    }
}
