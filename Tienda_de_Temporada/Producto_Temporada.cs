using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Globalization;
using System.Windows.Forms;

namespace Tienda_de_Temporada
{
    public partial class Producto_Temporada : Form
    {
        public ConexionClass variable_Conexion;
        private int selectedID;
        public Producto_Temporada()
        {
            InitializeComponent();
            selectedID = -1;
            variable_Conexion = new ConexionClass();
            ConsultarDatos();
        }

        private void Load_ComboBox_Productos()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {

                    string sentencia = "SELECT id_producto, nombre_producto FROM ProductoInfo.Producto";
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
        private void Load_ComboBox_Temporada()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {

                    string sentencia = "SELECT id_temporada, nombre, fecha_inicio, fecha_fin FROM ProductoInfo.Temporada";
                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);


                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        List<KeyValuePair<long, string>> productos = new List<KeyValuePair<long, string>>();
                        CultureInfo cultura = new CultureInfo("es-ES");
                        while (lector.Read())
                        {
                            long id_temporada = lector.GetInt64(0);
                            string nombreTemporada = lector.GetString(1);
                            DateTime fechaInicio = lector.GetDateTime(2);
                            DateTime fechaFin = lector.GetDateTime(3);

                            string mesInicio = cultura.DateTimeFormat.GetMonthName(fechaInicio.Month);
                            string mesFin = cultura.DateTimeFormat.GetMonthName(fechaFin.Month);

                            string textoCombo = $"{nombreTemporada} ({mesInicio} - {mesFin})";

                            productos.Add(new KeyValuePair<long, string>(id_temporada, textoCombo));

                        }
                        combo_temporada.DataSource = productos;
                        combo_temporada.DisplayMember = "Value";
                        combo_temporada.ValueMember = "Key";

                        combo_temporada.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar temporadas" + ex);
                }
                finally
                {
                    conexion.Close();
                }
            }

        }

        private void Producto_Temporada_Load(object sender, EventArgs e)
        {
            ConsultarDatos();
            Load_ComboBox_Productos();
            Load_ComboBox_Temporada();
        }

        public void ConsultarDatos()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = @" SET LANGUAGE Spanish; SELECT 
                        pt.id_producto_temporada AS Id, 
                        CONCAT(p.id_producto, ' - ', p.nombre_producto) AS Producto, 
                        CONCAT(t.nombre, ' (', DATENAME(MONTH, t.fecha_inicio), ' - ', DATENAME(MONTH, t.fecha_fin), ')') AS Temporada
                        FROM ProductoInfo.Producto_Temporada pt 
                        INNER JOIN ProductoInfo.Producto p ON pt.id_producto = p.id_producto 
                        INNER JOIN ProductoInfo.Temporada t ON pt.id_temporada = t.id_temporada;";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    tabla_prodTemp.DataSource = null;
                    tabla_prodTemp.Columns.Clear();
                    tabla_prodTemp.DataSource = tabla;

                    // Ajustar nombres de columnas visibles
                    tabla_prodTemp.Columns[0].HeaderText = "ID";
                    tabla_prodTemp.Columns["Producto"].HeaderText = "Producto";
                    tabla_prodTemp.Columns["Temporada"].HeaderText = "Temporada";

                    combo_producto.SelectedIndex = -1;
                    combo_temporada.SelectedIndex = -1;
                    selectedID = -1;

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

        private void button_agregar_Click(object sender, EventArgs e)
        {
            InsertaDato();
            ConsultarDatos();
        }

        public void InsertaDato()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    conexion.Open();
                    string sentencia = "INSERT INTO ProductoInfo.Producto_Temporada (id_producto, id_temporada) VALUES (@id_producto, @id_temporada)";

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id_producto", (long)combo_producto.SelectedValue);
                    comando.Parameters.AddWithValue("@id_temporada", (long)combo_temporada.SelectedValue);

                    comando.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la vinculacion Producto-Temporada: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            if (selectedID >= 0)
            {
                ActualizarDato();
                ConsultarDatos();
            }
            else
            {
                MessageBox.Show("Seleccione una tupla");
            }

        }

        public void ActualizarDato()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    int datoSeleccionado = tabla_prodTemp.CurrentRow.Index;
                    int index = Convert.ToInt32(tabla_prodTemp.Rows[datoSeleccionado].Cells[0].Value);
                    conexion.Open();


                    string sentencia = "UPDATE ProductoInfo.Producto_Temporada " +
                                        "SET id_producto = '" + (long)combo_producto.SelectedValue +
                                        "', id_temporada =' " + (long)combo_temporada.SelectedValue +
                                        "' WHERE id_producto_temporada = " + index;


                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id", (long)selectedID);
                    comando.Parameters.AddWithValue("@id_producto", (long)combo_producto.SelectedValue);
                    comando.Parameters.AddWithValue("@id_temporada", (long)combo_temporada.SelectedValue);

                    comando.ExecuteNonQuery();


                    //textBox_nombre.Text = "";
                    //calendar_fecha_inicio.SetDate(DateTime.Now);
                    //calendar_fecha_fin.SetDate(DateTime.Now);

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

        public void EliminarDato()
        {
            int datoSeleccionado = tabla_prodTemp.CurrentRow.Index;
            int index = Convert.ToInt32(tabla_prodTemp.Rows[datoSeleccionado].Cells[0].Value);
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "DELETE FROM ProductoInfo.Producto_Temporada WHERE id_producto_temporada = " + index;

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.ExecuteNonQuery();


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

        private void tabla_prodTemp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita clic en el encabezado
            {
                DataGridViewRow filaSeleccionada = tabla_prodTemp.Rows[e.RowIndex];
                selectedID = tabla_prodTemp.CurrentRow.Index;

                try
                {
                    // Leer los valores de las columnas ocultas
                    long idProducto = Convert.ToInt64(filaSeleccionada.Cells["IdProducto"].Value);
                    long idTemporada = Convert.ToInt64(filaSeleccionada.Cells["IdTemporada"].Value);

                    // Asignar los valores correctos a los ComboBox
                    combo_producto.SelectedValue = idProducto;
                    combo_temporada.SelectedValue = idTemporada;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos en los ComboBox: " + ex.Message);
                }
            }
        }


        private void button_eliminar_Click(object sender, EventArgs e)
        {
            if (selectedID >= 0)
            {
                EliminarDato();
                ConsultarDatos();
            }
            else
            {
                MessageBox.Show("Seleccione una tupla");
            }

        }
    }
}
