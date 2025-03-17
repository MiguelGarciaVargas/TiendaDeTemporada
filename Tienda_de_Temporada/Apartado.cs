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
        }

        private void Load_ComboBox_Apartado()
        {
            using (SqlConnection conexion = variable_Conexion.Conectar())
            {
                try
                {

                    string sentencia = @"
                        SELECT 
                        id_tarjeta_cliente AS ID,
                        CONCAT(banco, ' - ', tipo, ' (****-****-****-', RIGHT(numero_tarjeta, 4), ') Exp: ', 
                        FORMAT(fecha_vencimiento, 'MM/yyyy')) AS Tarjeta 
                        FROM ClientesInfo.Tarjeta_Cliente;";
                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        List<KeyValuePair<long, string>> tarjetas = new List<KeyValuePair<long, string>>();
                        while (lector.Read())
                        {
                            long idTarjeta = lector.GetInt64(0);
                            string textoTarjeta = lector.GetString(1);

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
                    string sentencia = @"
                        SET LANGUAGE Spanish;
                        SELECT 
                        id_apartado AS 'ID Apartado',
                        total_apartado AS 'Total Apartado',
                        saldo_pendiente AS 'Saldo Pendiente',
                        estado AS 'Estado',
                        id_tarjeta_cliente AS 'Tarjeta Cliente',
                        FORMAT(fecha_creacion, 'dd/MM/yyyy') AS 'Fecha de Inicio',
                        FORMAT(fecha_vencimiento, 'dd/MM/yyyy') AS 'Fecha de Fin'
                        FROM VentasInfo.Apartado;";

                    conexion.Open();

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    tabla_apartado.DataSource = null;
                    tabla_apartado.Columns.Clear();
                    tabla_apartado.DataSource = tabla;

                    tabla_apartado.Columns[0].HeaderText = "ID Apartado";
                    tabla_apartado.Columns[1].HeaderText = "Total";
                    tabla_apartado.Columns[2].HeaderText = "Saldo Pendiente";
                    tabla_apartado.Columns[3].HeaderText = "Estado";
                    tabla_apartado.Columns[4].HeaderText = "Tarjeta";
                    tabla_apartado.Columns[5].HeaderText = "Fecha de inicio";
                    tabla_apartado.Columns[6].HeaderText = "Fecha de fin";



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
                    conexion.Open();
                    string sentencia = @"
                        INSERT INTO VentasInfo.Apartado 
                        (id_tarjeta_cliente, total_apartado, fecha_creacion, fecha_vencimiento, saldo_pendiente, estado) 
                        VALUES (@id_tarjeta, 1, @fecha_inicio, @fecha_fin, 1, 'En proceso');";

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

                try
                {
                    // Guardar índice de la fila seleccionada
                    datoSeleccionado = e.RowIndex;

                    // Obtener valores de la fila seleccionada
                    long idTarjetaCliente = Convert.ToInt64(filaSeleccionada.Cells["Tarjeta Cliente"].Value);
                    DateTime fechaInicio = Convert.ToDateTime(filaSeleccionada.Cells["Fecha de Inicio"].Value);
                    DateTime fechaFin = Convert.ToDateTime(filaSeleccionada.Cells["Fecha de Fin"].Value);
                    string estado = filaSeleccionada.Cells["Estado"].Value.ToString();

                    // Asignar valores a los controles del formulario
                    combo_tarjetas.SelectedValue = idTarjetaCliente;
                    calendar_fecha_inicio.SelectionStart = fechaInicio;
                    calendar_fecha_fin.SelectionStart = fechaFin;

                    // Si tienes un ComboBox para el estado, lo puedes asignar así:
                    // combo_estado.SelectedItem = estado;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos en los ComboBox: " + ex.Message);
                }
            }
        }

    }
}
