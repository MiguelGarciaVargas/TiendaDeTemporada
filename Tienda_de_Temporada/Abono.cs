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
    public partial class Abono : Form
    {
        public ConexionClass variable_Conexion;
        private int selectedID;
        private int idApartado;
        private int cantidadSelected;
        public Abono(int id)
        {
            idApartado = id;
            InitializeComponent();
            variable_Conexion = new ConexionClass();
            loadStart();
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
	                        a.id_abono AS idAbono, a.cantidad AS Cantidad, a.fecha_abono AS Fecha
	                        FROM VentasInfo.Abono a
	                        INNER JOIN VentasInfo.Apartado ap ON a.id_apartado = ap.id_apartado
                            WHERE a.id_apartado = @id; 
                        ";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id", idApartado);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    tabla_prodApart.DataSource = null;
                    tabla_prodApart.Columns.Clear();
                    tabla_prodApart.DataSource = tabla;

                    tabla_prodApart.Columns[0].HeaderText = "ID Abono";
                    tabla_prodApart.Columns[1].HeaderText = "Cantidad";
                    tabla_prodApart.Columns[2].HeaderText = "Fecha de Abono";

                    textBox_cantidad.Text = "";
                    cantidadSelected = -1;
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
                    decimal cantidad = Convert.ToDecimal(textBox_cantidad.Text);

                    if (cantidad <= 0)
                    {
                        MessageBox.Show("El abono debe ser mayor a 0.");
                        return;
                    }

                    string sentencia = @"
                            INSERT INTO VentasInfo.Abono (id_apartado, cantidad, fecha_abono)
                                VALUES (@id, @cantidad, GETDATE()); ";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id", idApartado);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    comando.ExecuteNonQuery();

                    textBox_cantidad.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar datos del Abono" + ex);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public void UpdateAbono()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    decimal nuevaCantidad = Convert.ToDecimal(textBox_cantidad.Text);

                    if (nuevaCantidad <= 0)
                    {
                        MessageBox.Show("La cantidad debe ser mayor a 0.");
                        return;
                    }

                    string sentencia = @"
                UPDATE VentasInfo.Abono
                SET cantidad = @cantidad
                WHERE id_abono = @idAbono;";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@cantidad", nuevaCantidad);
                    comando.Parameters.AddWithValue("@idAbono", selectedID); // Este lo debes tener guardado al seleccionar el abono

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Abono actualizado correctamente");
                    textBox_cantidad.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar abono: " + ex.Message);
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
                    long idAbono = Convert.ToInt64(filaSeleccionada.Cells[0].Value);
                    long cantidad = Convert.ToInt64(filaSeleccionada.Cells[1].Value);
                    selectedID = (int)idAbono;
                    cantidadSelected = (int)cantidad;
                    textBox_cantidad.Text = cantidad.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos al seleccionar: " + ex.Message);
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
                        string resultado = reader["Resultado"].ToString();
                        lblIdApartado.Text = resultado;
                    }
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

        private void button_agregar_Click(object sender, EventArgs e)
        {
            InsertaDato();
            ConsultarDatos();
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            UpdateAbono();
            ConsultarDatos();
        }
    }
}
