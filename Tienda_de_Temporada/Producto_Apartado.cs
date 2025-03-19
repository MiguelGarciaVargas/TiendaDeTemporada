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
    public partial class Producto_Apartado : Form
    {
        public ConexionClass variable_Conexion;
        private int selectedID;

        public Producto_Apartado()
        {
            InitializeComponent();
            variable_Conexion = new ConexionClass();
            Load_ComboBox_Productos();
            Load_ComboBox_Apartado();
            ConsultarDatos();
        }


        public void ConsultarDatos()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = @"
                        SELECT id_apartado, id_producto, cantidad, subtotal_apartado FROM VentasInfo.Producto_Apartado
                        ";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    tabla_prodApart.DataSource = null;
                    tabla_prodApart.Columns.Clear();
                    tabla_prodApart.DataSource = tabla;

                    tabla_prodApart.Columns[0].HeaderText = "ID Apartado";
                    tabla_prodApart.Columns[1].HeaderText = "ID Producto";
                    tabla_prodApart.Columns[2].HeaderText = "Cantidad";
                    tabla_prodApart.Columns[3].HeaderText = "Subtotal";

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
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    int cantidad = Convert.ToInt32(textBox_cantidad.Text);
                    decimal precio = hayExistencias((long)combo_producto.SelectedValue, Convert.ToInt32(cantidad));

                    if (precio == -1)
                    {
                        return;
                    }

                    decimal subtotal = precio * cantidad; 


                    string sentencia = "INSERT INTO VentasInfo.Producto_Apartado(id_producto, id_apartado, cantidad, subtotal_apartado)" +
                                        "VALUES (@producto, @apartado, @cantidad, @subtotal)";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@producto", (long)combo_producto.SelectedValue);
                    comando.Parameters.AddWithValue("@apartado", (long)combo_apartado.SelectedValue);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    comando.Parameters.AddWithValue("@subtotal", subtotal);
                    comando.ExecuteNonQuery();

                    textBox_cantidad.Text = "";

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

        public decimal hayExistencias(long id, int cantidad)
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "SELECT existencias, precio_producto FROM ProductoInfo.Producto WHERE " +
                        "id_producto = @idProducto";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@idProducto", id);

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read()) {
                        int existencias = lector.GetInt32(0);
                        decimal precio = lector.GetDecimal(1);

                        if (cantidad <= Convert.ToInt32(existencias))
                        {
                            return precio;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No hay suficientes existencias del producto seleccionado");
                }
                finally
                {
                    conexion.Close();
                }
            }

            return -1;
        }



        private void Load_ComboBox_Productos()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {

                    string sentencia = "SELECT p.id_producto, p.nombre_producto, t.id_temporada, t.nombre " +
                        "FROM ProductoInfo.Producto_Temporada pt" +
                        "INNER JOIN ProductoInfo.Producto p ON pt.id_producto = p.id_producto" +
                        "INNER JOIN ProductoInfo.Temporada t ON pt.id_temproada = t.id_temporada";
                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);


                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        List<KeyValuePair<long, string>> productos = new List<KeyValuePair<long, string>>();
                        while (lector.Read())
                        {
                            long idProd = lector.GetInt64(0);
                            string nameProd = lector.GetString(1);
                            string comboText = $"{idProd} - {nameProd}";
                            productos.Add(new KeyValuePair<long, string>(idProd, comboText));

                        }
                        combo_producto.DataSource = productos;
                        combo_producto.DisplayMember = "Value";
                        combo_producto.ValueMember = "Key";

                        combo_producto.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar productos" + ex);
                }
                finally
                {
                    conexion.Close();
                }
            }

        }

        private void Load_ComboBox_Apartado()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {

                    string sentencia = "SELECT id_apartado FROM VentasInfo.Apartado";
                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);


                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        List<KeyValuePair<long, string>> apartado = new List<KeyValuePair<long, string>>();
                        while (lector.Read())
                        {
                            long idApartado = lector.GetInt64(0);
                            string comboText = $"{idApartado}";
                            apartado.Add(new KeyValuePair<long, string>(idApartado, comboText));

                        }
                        combo_apartado.DataSource = apartado;
                        combo_apartado.DisplayMember = "Value";
                        combo_apartado.ValueMember = "Key";
                        combo_apartado.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar productos" + ex);
                }
                finally
                {
                    conexion.Close();
                }
            }

        }

        private void Producto_Apartado_Load(object sender, EventArgs e)
        {

        }

        private void textBox_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números y la tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            InsertaDato();
            ConsultarDatos();
        }
    }
}
