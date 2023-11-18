using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kenjhi.frmsAdmin
{
    public partial class frmVerVentas_Admin : Form
    {
        public frmVerVentas_Admin()
        {
            InitializeComponent();
            txtBusquedaDGV.Text = "Ingresa un nombre para realizar la búsqueda";
            txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
            dataGridVentas.RowTemplate.Height = 40;
            dataGridVentas.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);


            CargaDatosDGV();


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

   

        private void txtBusquedaDGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBusquedaDGV.Text.Length == 0)
            {
                labelresultado1.Visible = false;
                labelresultado2.Visible = false;
                try
                {
                    MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                    conexion.Open();

                    string consulta = "SELECT v.ID_Venta, c.ID_Cliente, c.Nombre AS NombreCliente, p.Nombre AS NombreProducto, v.Tipo, v.Saldo, v.Fecha_Venta, a.Cantidad AS CantidadComprada " +
                         "FROM venta v " +
                         "INNER JOIN cliente c ON v.ID_Cliente = c.ID_Cliente " +
                         "INNER JOIN asignado a ON v.ID_Venta = a.ID_Venta " +
                         "INNER JOIN producto p ON a.ID_Producto = p.ID_Producto " +
                         "WHERE v.devuelto = 1";


                    MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                    DataTable tablaVentas = new DataTable();
                    adaptador.Fill(tablaVentas);

                    dataGridVentas.DataSource = tablaVentas;

                    dataGridVentas.Columns["ID_Venta"].Visible = false;
                    dataGridVentas.Columns["ID_Cliente"].Visible = false;

                    dataGridVentas.Columns["NombreCliente"].HeaderText = "Nombre del Cliente";
                    dataGridVentas.Columns["NombreProducto"].HeaderText = "Nombre del Producto";
                    dataGridVentas.Columns["Tipo"].HeaderText = "Tipo";
                    dataGridVentas.Columns["Saldo"].HeaderText = "Saldo Pesos UYU";
                    dataGridVentas.Columns["Fecha_Venta"].HeaderText = "Fecha de Compra";
                    dataGridVentas.Columns["Fecha_Venta"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    dataGridVentas.Columns["CantidadComprada"].HeaderText = "Cantidad Comprada";

                    dataGridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error al cargar los datos de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           

            if (txtBusquedaDGV.Text.Length > 0)
            {
                string textoBusqueda = txtBusquedaDGV.Text;
                using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                {
                    conexion.Open();
                    string consulta = "SELECT v.ID_Venta, c.Nombre AS NombreCliente, p.Nombre AS NombreProducto, v.Tipo, v.Saldo, v.Fecha_Venta, a.Cantidad AS CantidadComprada " +
                        "FROM venta v " +
                        "INNER JOIN cliente c ON v.ID_Cliente = c.ID_Cliente " +
                        "INNER JOIN asignado a ON v.ID_Venta = a.ID_Venta " +
                        "INNER JOIN producto p ON a.ID_Producto = p.ID_Producto " +
                        "WHERE c.Nombre LIKE @textoBusqueda AND v.devuelto = 1";  

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridVentas.DataSource = dataTable;
                        dataGridVentas.Columns["ID_Venta"].Visible = false;
                        if (dataTable.Rows.Count == 0)
                        {

                            labelresultado1.Visible = true;
                            labelresultado2.Visible = true;
                        }
                        else
                        {
                            labelresultado1.Visible = false;
                            labelresultado2.Visible = false;
                        }
                    }
                }
            }



        }



        private void txtBusquedaDGV_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBusquedaDGV.Text == "Ingresa un nombre para realizar la búsqueda") { txtBusquedaDGV.Clear(); txtBusquedaDGV.ForeColor = System.Drawing.Color.White; }

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
                

            if (dataGridVentas.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridVentas.SelectedRows[0].Index;
                int idVenta = Convert.ToInt32(dataGridVentas.Rows[rowIndex].Cells["ID_Venta"].Value);

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                    {
                        conexion.Open();

                        string consultaIDCliente = $"SELECT ID_Cliente FROM venta WHERE ID_Venta = {idVenta}";
                        MySqlCommand comandoIDCliente = new MySqlCommand(consultaIDCliente, conexion);
                        int idCliente = Convert.ToInt32(comandoIDCliente.ExecuteScalar());

                        string consultaDatosVenta = $"SELECT ID_Producto, Cantidad FROM asignado WHERE ID_Venta = {idVenta}";
                        MySqlCommand comandoDatosVenta = new MySqlCommand(consultaDatosVenta, conexion);
                        MySqlDataReader reader = comandoDatosVenta.ExecuteReader();

                        List<Tuple<int, int>> productosDevolver = new List<Tuple<int, int>>();

                        while (reader.Read())
                        {
                            int idProducto = reader.GetInt32("ID_Producto");
                            int cantidad = reader.GetInt32("Cantidad");
                            productosDevolver.Add(new Tuple<int, int>(idProducto, cantidad));
                        }

                        reader.Close();

                        foreach (var productoDevolver in productosDevolver)
                        {
                            int idProducto = productoDevolver.Item1;
                            int cantidad = productoDevolver.Item2;

                            string consultaActualizarStock = $"UPDATE producto SET Cantidad = Cantidad + {cantidad} WHERE ID_Producto = {idProducto}";
                            MySqlCommand comandoActualizarStock = new MySqlCommand(consultaActualizarStock, conexion);
                            comandoActualizarStock.ExecuteNonQuery();
                        }

                        string consultaActualizarCliente = $"UPDATE venta SET Saldo = 0, Cuotas = 0, devuelto = 0 WHERE ID_Venta = {idVenta}";
                        MySqlCommand comandoActualizarCliente = new MySqlCommand(consultaActualizarCliente, conexion);
                        comandoActualizarCliente.ExecuteNonQuery();

                        conexion.Close();

                        MessageBox.Show("Devolución exitosa.", "Devolución", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnDevolucion.Visible = false;
                        txtBusquedaDGV.Clear();
                        CargaDatosDGV();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la devolución: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para realizar la devolución.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void dataGridVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDevolucion.Visible = true;
        }

        private void CargaDatosDGV()
        {

            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                conexion.Open();

                string consulta = "SELECT v.ID_Venta, c.ID_Cliente, c.Nombre AS NombreCliente, p.Nombre AS NombreProducto, v.Tipo, v.Saldo, v.Fecha_Venta, a.Cantidad AS CantidadComprada " +
                     "FROM venta v " +
                     "INNER JOIN cliente c ON v.ID_Cliente = c.ID_Cliente " +
                     "INNER JOIN asignado a ON v.ID_Venta = a.ID_Venta " +
                     "INNER JOIN producto p ON a.ID_Producto = p.ID_Producto " +
                     "WHERE v.devuelto = 1";


                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                DataTable tablaVentas = new DataTable();
                adaptador.Fill(tablaVentas);

                dataGridVentas.DataSource = tablaVentas;

                dataGridVentas.Columns["ID_Venta"].Visible = false;
                dataGridVentas.Columns["ID_Cliente"].Visible = false;

                dataGridVentas.Columns["NombreCliente"].HeaderText = "Nombre del Cliente";
                dataGridVentas.Columns["NombreProducto"].HeaderText = "Nombre del Producto";
                dataGridVentas.Columns["Tipo"].HeaderText = "Tipo";
                dataGridVentas.Columns["Saldo"].HeaderText = "Saldo Pesos UYU";
                dataGridVentas.Columns["Fecha_Venta"].HeaderText = "Fecha de Compra";
                dataGridVentas.Columns["Fecha_Venta"].DefaultCellStyle.Format = "dd/MM/yyyy";

                dataGridVentas.Columns["CantidadComprada"].HeaderText = "Cantidad Comprada";

                dataGridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
