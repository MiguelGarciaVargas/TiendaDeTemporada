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
    public partial class Apartado : Form
    {
        public ConexionClass variable_Conexion;
        private int datoSeleccionado = -1;

        public Apartado()
        {
            InitializeComponent();
            variable_Conexion = new ConexionClass();
            ConsultarDatos();
            Load_ComboBox_Apartado();
        }

        private void Load_ComboBox_Apartado()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {

                    //string sentencia = @"
                    //    SELECT 
                    //    id_tarjeta_cliente AS ID,
                    //    CONCAT(banco, ' - ', tipo, ' (****-****-****-', RIGHT(numero_tarjeta, 4), ') Exp: ', 
                    //    FORMAT(fecha_vencimiento, 'MM/yyyy')) AS Tarjeta 
                    //    FROM ClientesInfo.Tarjeta_Cliente;";

                    string sentencia = @"
                        SELECT 
                        id_tarjeta_cliente AS ID,
                        CONCAT('*',RIGHT(numero_tarjeta, 3)) AS Numero,
                        banco AS Banco,
                        c.nombre_cliente AS Nombre
                        FROM ClientesInfo.Tarjeta_Cliente tc
                        INNER JOIN ClientesInfo.Cliente c ON tc.id_cliente = c.id_cliente;";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        List<KeyValuePair<long, string>> tarjetas = new List<KeyValuePair<long, string>>();
                        while (lector.Read())
                        {
                            long idTarjeta = lector.GetInt64(0);
                            string numero = lector.GetString(1);
                            string banco = lector.GetString(2);
                            string nombre = lector.GetString(3);

                            string textoTarjeta = $"{numero} ({banco}) - {nombre}";

                            tarjetas.Add(new KeyValuePair<long, string>(idTarjeta, textoTarjeta));
                        }

                        combo_tarjetas.DataSource = tarjetas;
                        combo_tarjetas.DisplayMember = "Value";
                        combo_tarjetas.ValueMember = "Key";
                        combo_tarjetas.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar tarjetas" + ex);
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
                    string sentencia = @"SET LANGUAGE Spanish;
                                            SELECT 
                                                id_apartado AS 'IdApartado',
                                                total_apartado AS 'Total',
                                                saldo_pendiente AS 'Saldo Pendiente',
                                                estado AS 'Estado',
                                                a.id_tarjeta_cliente AS 'IdTarjeta',
                                                CONCAT('*', RIGHT(tc.numero_tarjeta, 3), ' (', tc.banco, ') - ', c.nombre_cliente) AS 'Tarjeta',
                                                fecha_creacion AS 'Fecha de Inicio', 
                                                a.fecha_vencimiento AS 'Fecha de Vencimiento'
                                                    FROM VentasInfo.Apartado a
                                                    INNER JOIN ClientesInfo.Tarjeta_Cliente tc ON a.id_tarjeta_cliente = tc.id_tarjeta_cliente
                                                    INNER JOIN ClientesInfo.Cliente c ON tc.id_cliente = c.id_cliente;
                                            ";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    tabla_apartado.DataSource = null;
                    tabla_apartado.Columns.Clear();
                    tabla_apartado.DataSource = tabla;
                    tabla_apartado.Refresh();

                    // Asegurar que hay columnas antes de intentar modificarlas
                    if (tabla_apartado.Columns.Count > 0)
                    {
                        tabla_apartado.Columns["IdApartado"].HeaderText = "IdApartado";
                        tabla_apartado.Columns["Total"].HeaderText = "Total";
                        tabla_apartado.Columns["Saldo Pendiente"].HeaderText = "Saldo Pendiente";
                        tabla_apartado.Columns["Estado"].HeaderText = "Estado";
                        tabla_apartado.Columns["IdTarjeta"].HeaderText = "IdTarjeta";
                        tabla_apartado.Columns["Tarjeta"].HeaderText = "Tarjeta";
                        tabla_apartado.Columns["Fecha de Inicio"].HeaderText = "Fecha de inicio";
                        tabla_apartado.Columns["Fecha de Vencimiento"].HeaderText = "Fecha de Vencimiento";

                        // Ocultar la columna de ID de la tarjeta
                        tabla_apartado.Columns["IdTarjeta"].Visible = false;

                        tabla_apartado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                        // Ajustar anchos de columnas manualmente
                        tabla_apartado.Columns["IdApartado"].Width = 70;
                        tabla_apartado.Columns["Total"].Width = 120;
                        tabla_apartado.Columns["Saldo Pendiente"].Width = 130;
                        tabla_apartado.Columns["Estado"].Width = 120;
                        tabla_apartado.Columns["Tarjeta"].Width = 300;
                        tabla_apartado.Columns["Fecha de Inicio"].Width = 120;
                        tabla_apartado.Columns["Fecha de Vencimiento"].Width = 120;

                    }
                    else
                    {
                        MessageBox.Show("Las columnas no se han generado correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


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
            DateTime fecha_inicio = calendar_fecha_inicio.SelectionStart;
            DateTime fecha_fin = calendar_fecha_fin.SelectionStart;

            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    if (combo_tarjetas.SelectedValue == null)
                    {
                        MessageBox.Show("Selecciona una tarjeta antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Detiene la ejecución
                    }

                    conexion.Open();
                    string sentencia = @"
                        INSERT INTO VentasInfo.Apartado 
                        (id_tarjeta_cliente, total_apartado, fecha_creacion, fecha_vencimiento, saldo_pendiente, estado) 
                        VALUES (@id_tarjeta, 0, @fecha_inicio, @fecha_fin, 0, 'En proceso');";

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id_tarjeta", (long)combo_tarjetas.SelectedValue);
                    comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                    comando.Parameters.AddWithValue("@fecha_fin", fecha_fin);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Apartado insertado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar datos del cliente: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public void ActualizarDato()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    if (tabla_apartado.CurrentRow == null)
                    {
                        MessageBox.Show("Selecciona un registro de apartado para actualizar.");
                        return;
                    }

                    int idApartado = Convert.ToInt32(tabla_apartado.CurrentRow.Cells[0].Value);
                    DateTime nuevaFechaVencimiento = calendar_fecha_fin.SelectionStart;
                    long nuevaTarjetaCliente = (long)combo_tarjetas.SelectedValue;
                    string nuevoEstado = "En proceso"; // Puedes hacer que esto cambie según otro ComboBox si lo necesitas

                    conexion.Open();

                    string sentencia = @"
                        UPDATE VentasInfo.Apartado 
                        SET id_tarjeta_cliente = @id_tarjeta, 
                            fecha_vencimiento = @fecha_vencimiento, 
                        estado = @estado 
                        WHERE id_apartado = @id_apartado";

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id_apartado", idApartado);
                    comando.Parameters.AddWithValue("@id_tarjeta", nuevaTarjetaCliente);
                    comando.Parameters.AddWithValue("@fecha_vencimiento", nuevaFechaVencimiento);
                    comando.Parameters.AddWithValue("@estado", nuevoEstado);

                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                        MessageBox.Show("Registro de apartado actualizado correctamente.");
                    else
                        MessageBox.Show("No se encontró el registro a actualizar.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos del apartado:\n" + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public void EliminarDato()
        {
            if (tabla_apartado.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un registro de apartado para eliminar.");
                return;
            }

            int idApartado = Convert.ToInt32(tabla_apartado.CurrentRow.Cells[0].Value);


            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    string sentencia = "DELETE FROM VentasInfo.Apartado WHERE id_apartado = @id_apartado";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id_apartado", idApartado);

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

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            if (datoSeleccionado >= 0)
            {
                EliminarDato();
                ConsultarDatos();
                datoSeleccionado = -1;
            }
        }


        private void tabla_apartado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita que el usuario haga clic en el encabezado
            {
                DataGridViewRow filaSeleccionada = tabla_apartado.Rows[e.RowIndex];
                datoSeleccionado = tabla_apartado.CurrentRow.Index;

                try
                {
                    long idApartado = Convert.ToInt64(filaSeleccionada.Cells[0].Value);
                    long idTarjeta = Convert.ToInt64(filaSeleccionada.Cells[4].Value);

                    combo_tarjetas.SelectedValue = idTarjeta;

                    DateTime fecha = DateTime.Parse(tabla_apartado.Rows[datoSeleccionado].Cells[5].Value.ToString());
                    calendar_fecha_inicio.SetDate(fecha);
                    fecha = DateTime.Parse(tabla_apartado.Rows[datoSeleccionado ].Cells[6].Value.ToString());
                    calendar_fecha_fin.SetDate(fecha);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos al seleccionar: " + ex.Message);
                }

            }
        }


        private void calendar_fecha_inicio_DateChanged(object sender, DateRangeEventArgs e)
        {
            calendar_fecha_fin.MinDate = calendar_fecha_inicio.SelectionStart;
        }

        private void combo_tarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_tarjetas.SelectedValue == null)
                return; // Evita errores si no hay selección

            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {
                    conexion.Open();
                    string sentencia = "SELECT fecha_vencimiento FROM ClientesInfo.Tarjeta_Cliente WHERE id_tarjeta_cliente = @id_tarjeta";
                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id_tarjeta", (long)combo_tarjetas.SelectedValue);

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        DateTime fechaVencimientoTarjeta = Convert.ToDateTime(resultado);

                        // 🔹 Limita la selección en `calendar_fecha_fin`
                        calendar_fecha_fin.MaxDate = fechaVencimientoTarjeta;
                        calendar_fecha_inicio.MaxDate = fechaVencimientoTarjeta;

                        // 🔹 Si la fecha de vencimiento seleccionada es mayor, corregirla
                        if (calendar_fecha_fin.SelectionStart > fechaVencimientoTarjeta)
                        {
                            calendar_fecha_fin.SetDate(fechaVencimientoTarjeta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error al obtener la fecha de vencimiento de la tarjeta: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
    }
}
