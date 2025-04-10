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
        private int cantidadSelected;
        string nombreApartado;
        bool sePuedeModificar;

        public Producto_Apartado(int id, bool sePuedeModificar)
        {
            idApartado = id;
            this.sePuedeModificar = sePuedeModificar;
            InitializeComponent();
            variable_Conexion = new ConexionClass();
            loadStart();
            Load_ComboBox_Productos();
            ConsultarDatos();
        }

        private void loadStart()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = @"
                                SELECT 
                        CAST(id_apartado AS varchar) + 
                        ' - ' + 
                        c.nombre_cliente + 
                        ' (' + 
                        CONVERT(varchar, a.fecha_vencimiento, 3) + 
                        ')' AS Resultado
                        FROM VentasInfo.Apartado a
                        INNER JOIN ClientesInfo.Tarjeta_Cliente tc ON a.id_tarjeta_cliente = tc.id_tarjeta_cliente
                        INNER JOIN ClientesInfo.Cliente c ON tc.id_cliente = c.id_cliente
                        WHERE id_apartado = @id;";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);

                    comando.Parameters.AddWithValue("@id", idApartado);
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        nombreApartado = reader["Resultado"].ToString();
                        lblIdApartado.Text = nombreApartado;
                    }

                    button_agregar.Visible = sePuedeModificar;
                    button_actualizar.Visible = sePuedeModificar;
                    button_eliminar.Visible = sePuedeModificar;
                    label_existencias.Visible = sePuedeModificar;
                    label_nombre.Visible = sePuedeModificar;
                    combo_producto.Visible = sePuedeModificar;
                    textBox_cantidad.Visible = sePuedeModificar;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar Apartado: " + ex.Message);
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
                    string sentencia = @"
                        SELECT 
                            @nombreApartado AS NombreApartado,
                            pa.id_producto AS IdProducto, 
                            CONCAT(pt.id_producto_temporada, ' - ', p.nombre_producto, ' (', t.nombre, ')') AS Producto,
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
                    comando.Parameters.AddWithValue("@nombreApartado", nombreApartado);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    tabla_prodApart.DataSource = null;
                    tabla_prodApart.Columns.Clear();
                    tabla_prodApart.DataSource = tabla;

                    tabla_prodApart.Columns[0].HeaderText = "Id Producto-Apartado";
                    tabla_prodApart.Columns[1].HeaderText = "Id Producto-Apartado";
                    tabla_prodApart.Columns[2].HeaderText = "Producto";
                    tabla_prodApart.Columns[3].HeaderText = "Cantidad";
                    tabla_prodApart.Columns[4].HeaderText = "Subtotal";

                    // Ajustar anchos

                    tabla_prodApart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    tabla_prodApart.Columns[0].Width = 200;
                    tabla_prodApart.Columns[1].Width = 0;
                    tabla_prodApart.Columns[2].Width = 400;
                    tabla_prodApart.Columns[3].Width = 100;
                    tabla_prodApart.Columns[4].Width = 150;

                    tabla_prodApart.Columns[1].Visible = false;


                    combo_producto.SelectedValue = -1;
                    textBox_cantidad.Text = "";
                    cantidadSelected = -1;
                    selectedProductId = -1;
                    selectedID = -1;

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
                    MessageBox.Show("Error al insertar producto al apartado");
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

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            int existencias = lector.GetInt32(0);
                            decimal precio = lector.GetDecimal(1);

                            if (cantidad <= existencias)
                            {
                                return precio;
                            }
                            else
                            {
                                MessageBox.Show("No hay suficientes existencias del producto seleccionado");
                            }
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

        public decimal hayExistenciasActualizar(long idProductoNuevo, int nuevaCantidad)
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "SELECT existencias, precio_producto FROM ProductoInfo.Producto WHERE id_producto = @id";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id", idProductoNuevo);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            int existencias = lector.GetInt32(0);
                            decimal precio = lector.GetDecimal(1);

                            int disponibles = existencias;

                            // Si no cambió de producto, se libera la cantidad anterior antes de volver a validar
                            if (idProductoNuevo == selectedProductId)
                            {
                                disponibles += cantidadSelected;
                            }

                            if (nuevaCantidad <= disponibles)
                            {
                                return precio;
                            }
                            else
                            {
                                MessageBox.Show("No hay suficientes existencias del producto seleccionado");
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al consultar existencias del producto");
                }
                finally
                {
                    conexion.Close();
                }

                return -1;
            }
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

                    long idProducto = Convert.ToInt64(filaSeleccionada.Cells[1].Value); // ya no [0]
                    long cantidad = Convert.ToInt64(filaSeleccionada.Cells[3].Value);   // ya no [2]
                    selectedProductId = (int)idProducto;
                    cantidadSelected = (int)cantidad;
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
                            CONCAT(p.id_producto, ' - ', p.nombre_producto, ' (', t.nombre, ')') AS Producto
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
                            string comboText = $"{nameProd}";
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

        public void UpdateDato()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    int cantidad = Convert.ToInt32(textBox_cantidad.Text);
                    long nuevoProductoId = (long)combo_producto.SelectedValue;

                    // Este método usa selectedProductId y cantidadSelected internamente
                    decimal precio = hayExistenciasActualizar(nuevoProductoId, cantidad);

                    if (precio == -1)
                        return;

                    decimal subtotal = precio * cantidad;
                    // Luego haces el UPDATE como ya lo tienes


                    string sentencia = "UPDATE VentasInfo.Producto_Apartado " +
                                       "SET id_producto = @nuevoProducto, " +
                                       "    cantidad = @nuevaCantidad, " +
                                       "    subtotal_apartado = @nuevoSubtotal " +
                                       "WHERE id_apartado = @apartado AND id_producto = @productoAnterior;";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@nuevoProducto", nuevoProductoId);
                    comando.Parameters.AddWithValue("@nuevaCantidad", cantidad);
                    comando.Parameters.AddWithValue("@nuevoSubtotal", subtotal);
                    comando.Parameters.AddWithValue("@apartado", idApartado); // Este debe ser global como ya lo estás usando
                    comando.Parameters.AddWithValue("@productoAnterior", selectedProductId); // El que se seleccionó antes

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Producto actualizado correctamente");
                    textBox_cantidad.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar producto del apartado");
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
            // Evita que el primer dígito sea 0
            if (textBox_cantidad.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
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

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            UpdateDato();
            ConsultarDatos();
        }
    }
}
