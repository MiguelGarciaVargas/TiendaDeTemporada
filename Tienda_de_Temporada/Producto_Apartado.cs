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
        private int idApartado;
        private int selectedProductId;

        public Producto_Apartado(int id)
        {
            InitializeComponent();
            id++;
            lblIdApartado.Text = id.ToString();
            idApartado = id;
            variable_Conexion = new ConexionClass();
            Load_ComboBox_Productos();
            ConsultarDatos();
        }


        public void ConsultarDatos()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = @"
                        SELECT 
                            pa.id_producto AS IdProducto, 
                            CONCAT(pa.id_producto, ' - ', p.nombre_producto, ' (', t.nombre, ')') AS Producto,
                            pa.cantidad AS Cantidad,
                            pa.subtotal_apartado AS Subtotal
                        FROM VentasInfo.Producto_Apartado pa 
                        INNER JOIN ProductoInfo.Producto p ON pa.id_producto = p.id_producto 
                        INNER JOIN ProductoInfo.Producto_Temporada pt ON pa.id_producto = pt.id_producto 
                        INNER JOIN ProductoInfo.Temporada t ON pt.id_temporada = t.id_temporada 
                        WHERE pa.id_Apartado = @idApartado;
                        ";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@idApartado", idApartado);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    tabla_prodApart.DataSource = null;
                    tabla_prodApart.Columns.Clear();
                    tabla_prodApart.DataSource = tabla;

                    tabla_prodApart.Columns[0].HeaderText = "Producto";
                    tabla_prodApart.Columns[1].HeaderText = "Cantidad";
                    tabla_prodApart.Columns[2].HeaderText = "Subtotal";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar del apartado" + ex);
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
                    comando.Parameters.AddWithValue("@apartado", idApartado);
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
                        } else
                        {
                            MessageBox.Show("No hay suficientes existencias del producto seleccionado");
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

        public void EliminarDato()
        {
            if (tabla_prodApart.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un registro de apartado para eliminar.");
                return;
            }


            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "DELETE FROM VentasInfo.Producto_Apartado WHERE id_apartado = @id_apartado AND id_producto = @id_producto";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id_apartado", idApartado);
                    comando.Parameters.AddWithValue("@id_producto", selectedProductId);

                    int filasEliminadas = comando.ExecuteNonQuery();
                    if (filasEliminadas > 0)
                        MessageBox.Show("Registro de apartado eliminado correctamente.");
                    else
                        MessageBox.Show("No se encontró el registro a eliminar.");

                    sentencia = "DELETE FROM VentasInfo.Producto_Apartado WHERE id_apartado = @id_apartado";
                    comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id_apartado", idApartado);

                    filasEliminadas = comando.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el apartado:\n" + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void tabla_apartado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita que el usuario haga clic en el encabezado
            {
                DataGridViewRow filaSeleccionada = tabla_prodApart.Rows[e.RowIndex];
                selectedID = tabla_prodApart.CurrentRow.Index;

                try
                {
                    //var rawFechaInicio = tabla_apartado.Rows[datoSeleccionado].Cells[5].Value;
                    //var rawFechaFin = tabla_apartado.Rows[datoSeleccionado].Cells[6].Value;

                    //MessageBox.Show($"Fecha Inicio: {rawFechaInicio} ({rawFechaInicio.GetType()}) \nFecha Fin: {rawFechaFin} ({rawFechaFin.GetType()})");

                    long idProducto = Convert.ToInt64(filaSeleccionada.Cells[0].Value);
                    long cantidad = Convert.ToInt64(filaSeleccionada.Cells[2].Value);
                    selectedProductId = (int)idProducto;

                    combo_producto.SelectedValue = idProducto;
                    textBox_cantidad.Text = cantidad.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos al seleccionar: " + ex.Message);
                }

            }
        }



        private void Load_ComboBox_Productos()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {

                    string sentencia = @"
                        SELECT 
                            p.id_producto, 
                            p.nombre_producto, 
                            t.id_temporada, 
                            t.nombre 
                        FROM ProductoInfo.Producto_Temporada pt
                        INNER JOIN ProductoInfo.Producto p ON pt.id_producto = p.id_producto
                        INNER JOIN ProductoInfo.Temporada t ON pt.id_temporada = t.id_temporada";

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

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            EliminarDato();
            ConsultarDatos();
        }
    }
}
