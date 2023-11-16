using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kenjhi
{
    public partial class frmClientesDeudores_Empleados : Form
    {
        private ToolTip toolTipAyuda;
        private const string cadenaConexion = "Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;";



        public frmClientesDeudores_Empleados()
        {
            InitializeComponent();
            CargarClientesCuotas();
            txtBusquedaDGV.Text = "Ingresa un nombre de cliente para realizar la búsqueda";
            txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
            dataGridDeudores.RowTemplate.Height = 40;
            dataGridDeudores.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            dataGridDeudores.ReadOnly = true;
            toolTipAyuda = new ToolTip();




        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarClientesCuotas()
        {
           

            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

                string consulta = "SELECT venta.ID_Venta, cliente.Nombre AS 'Nombre del Cliente', producto.Nombre AS 'Nombre del Producto', venta.Cuotas, venta.Saldo " +
                                  "FROM cliente " +
                                  "INNER JOIN venta ON cliente.ID_Cliente = venta.ID_Cliente " +
                                  "INNER JOIN asignado ON venta.ID_Venta = asignado.ID_Venta " +
                                  "INNER JOIN producto ON asignado.ID_Producto = producto.ID_Producto " +
                                  "WHERE venta.Tipo = 'Cuotas' AND venta.Saldo > 0";

                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                DataTable tablaDeudores = new DataTable();
                adaptador.Fill(tablaDeudores);
                dataGridDeudores.DataSource = tablaDeudores;
                dataGridDeudores.Columns["ID_Venta"].Visible = false; 
                dataGridDeudores.Columns["Nombre del Cliente"].HeaderText = "Nombre del Cliente";
                dataGridDeudores.Columns["Nombre del Producto"].HeaderText = "Nombre del Producto";
                dataGridDeudores.Columns["Cuotas"].HeaderText = "Cuotas";
                dataGridDeudores.Columns["Saldo"].HeaderText = "Saldo";

                dataGridDeudores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn column in dataGridDeudores.Columns)
                {
                    column.ReadOnly = true;
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }



        }


        private void btnPagarCuotas_Click(object sender, EventArgs e)
        {
            if (dataGridDeudores.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridDeudores.SelectedRows[0];

                int idVenta = Convert.ToInt32(filaSeleccionada.Cells["ID_Venta"].Value);

                decimal saldoActual = Convert.ToDecimal(filaSeleccionada.Cells["Saldo"].Value);
                int cuotasActuales = Convert.ToInt32(filaSeleccionada.Cells["Cuotas"].Value);

                int cuotasAPagar = ShowNumericUpDownMessageBox(cuotasActuales);

                if (cuotasAPagar > 0)
                {
                    decimal monto = saldoActual / cuotasActuales * cuotasAPagar;

                    try
                    {
                        MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                        conexion.Open();

                        string actualizarVentas = "UPDATE venta SET Cuotas = Cuotas - @Cuotas, Saldo = Saldo - @Monto WHERE ID_Venta = @ID_Venta";
                        MySqlCommand comandoActualizarVentas = new MySqlCommand(actualizarVentas, conexion);
                        comandoActualizarVentas.Parameters.AddWithValue("@Cuotas", cuotasAPagar);
                        comandoActualizarVentas.Parameters.AddWithValue("@Monto", monto);
                        comandoActualizarVentas.Parameters.AddWithValue("@ID_Venta", idVenta);
                        comandoActualizarVentas.ExecuteNonQuery();

                        string insertarPago = "INSERT INTO pagos (ID_Venta, Fecha_Pagos, Monto) VALUES (@ID_Venta, @Fecha, @Monto)";
                        MySqlCommand comandoInsertarPago = new MySqlCommand(insertarPago, conexion);
                        comandoInsertarPago.Parameters.AddWithValue("@ID_Venta", idVenta);
                        comandoInsertarPago.Parameters.AddWithValue("@Fecha", DateTime.Now);
                        comandoInsertarPago.Parameters.AddWithValue("@Monto", monto);
                        comandoInsertarPago.ExecuteNonQuery();

                        MessageBox.Show("Pago registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarClientesCuotas();
                        conexion.Close();
                        txtBusquedaDGV.Clear();
                        btnPagarCuotas.Visible = false;
                        txtBusquedaDGV.ForeColor=System.Drawing.Color.White;    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al procesar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para realizar el pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

       

        private int ShowNumericUpDownMessageBox(int maxCuotas)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Ingrese cuotas a pagar",
                StartPosition = FormStartPosition.CenterScreen
            };

            NumericUpDown numericUpDown = new NumericUpDown()
            {
                Left = 50,
                Top = 30,
                Width = 200,
                Maximum = maxCuotas,
                Minimum = 1
            };

            Button okButton = new Button() { Text = "Aceptar", Left = 50, Top = 70, Width = 200, DialogResult = DialogResult.OK };
            okButton.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(numericUpDown);
            prompt.Controls.Add(okButton);

            return prompt.ShowDialog() == DialogResult.OK ? (int)numericUpDown.Value : 0;
        }


        private void dataGridDeudores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnPagarCuotas.Visible = true;
        }

        private void txtBusquedaDGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

                if (txtBusquedaDGV.Text.Length == 0)
                {
                    if (lblSinResultado.Visible == true && lblSinResultado2.Visible == true)
                    {
                        lblSinResultado.Visible = false; lblSinResultado2.Visible = false;
                    }
                    
                    string consulta = "SELECT venta.ID_Venta, cliente.Nombre AS 'Nombre del Cliente', producto.Nombre AS 'Nombre del Producto', venta.Cuotas, venta.Saldo " +
                                      "FROM cliente " +
                                      "INNER JOIN venta ON cliente.ID_Cliente = venta.ID_Cliente " +
                                      "INNER JOIN asignado ON venta.ID_Venta = asignado.ID_Venta " +
                                      "INNER JOIN producto ON asignado.ID_Producto = producto.ID_Producto " +
                                      "WHERE venta.Tipo = 'Cuotas' AND venta.Saldo > 0";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                    DataTable tablaDeudores = new DataTable();
                    adaptador.Fill(tablaDeudores);
                    dataGridDeudores.DataSource = tablaDeudores;
                    dataGridDeudores.Columns["ID_Venta"].Visible = false;
                    dataGridDeudores.Columns["Nombre del Cliente"].HeaderText = "Nombre del Cliente";
                    dataGridDeudores.Columns["Nombre del Producto"].HeaderText = "Nombre del Producto";
                    dataGridDeudores.Columns["Cuotas"].HeaderText = "Cuotas";
                    dataGridDeudores.Columns["Saldo"].HeaderText = "Saldo";

                    dataGridDeudores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    foreach (DataGridViewColumn column in dataGridDeudores.Columns)
                    {
                        column.ReadOnly = true;
                    }
                }
                else
                {
                    string textoBusqueda = txtBusquedaDGV.Text;
                    string consulta = "SELECT venta.ID_Venta, cliente.Nombre AS 'Nombre del Cliente', producto.Nombre AS 'Nombre del Producto', venta.Cuotas, venta.Saldo " +
                                      "FROM cliente " +
                                      "INNER JOIN venta ON cliente.ID_Cliente = venta.ID_Cliente " +
                                      "INNER JOIN asignado ON venta.ID_Venta = asignado.ID_Venta " +
                                      "INNER JOIN producto ON asignado.ID_Producto = producto.ID_Producto " +
                                      "WHERE venta.Tipo = 'Cuotas' AND venta.Saldo > 0 " +
                                      "AND (cliente.Nombre LIKE @textoBusqueda OR producto.Nombre LIKE @textoBusqueda)";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridDeudores.DataSource = dataTable;
                        dataGridDeudores.Columns["ID_Venta"].Visible = false;
                        if (dataTable.Rows.Count == 0)
                        {
                            lblSinResultado.Visible = true;
                            lblSinResultado2.Visible = true;
                        }
                        else
                        {
                            lblSinResultado.Visible = false;
                            lblSinResultado2.Visible = false;
                        }
                    }
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }

        private void txtBusquedaDGV_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBusquedaDGV.Text == "Ingresa un nombre de cliente para realizar la búsqueda") { txtBusquedaDGV.Clear(); txtBusquedaDGV.ForeColor = System.Drawing.Color.White; }

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
