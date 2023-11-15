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

            
            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                conexion.Open();

                string consulta = "SELECT v.ID_Venta, c.Nombre AS NombreCliente, p.Nombre AS NombreProducto, v.Tipo, v.Saldo, v.Fecha_Venta, a.Cantidad AS CantidadComprada " +
                    "FROM venta v " +
                    "INNER JOIN cliente c ON v.ID_Cliente = c.ID_Cliente " +
                    "INNER JOIN asignado a ON v.ID_Venta = a.ID_Venta " +
                    "INNER JOIN producto p ON a.ID_Producto = p.ID_Producto";

                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                DataTable tablaVentas = new DataTable();
                adaptador.Fill(tablaVentas);

                dataGridVentas.DataSource = tablaVentas;

                dataGridVentas.Columns["ID_Venta"].Visible = false;

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
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

                        string consultaActualizar = $"UPDATE venta SET visible = 0 WHERE ID_Venta = {idVenta}";
                        MySqlCommand comandoActualizar = new MySqlCommand(consultaActualizar, conexion);
                        comandoActualizar.ExecuteNonQuery();

                        conexion.Close();

                        dataGridVentas.Rows[rowIndex].Visible = false;

                        MessageBox.Show("Venta ocultada.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ocultar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para ocultar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

                    string consulta = "SELECT v.ID_Venta, c.Nombre AS NombreCliente, p.Nombre AS NombreProducto, v.Tipo, v.Saldo, v.Fecha_Venta, a.Cantidad AS CantidadComprada " +
                        "FROM venta v " +
                        "INNER JOIN cliente c ON v.ID_Cliente = c.ID_Cliente " +
                        "INNER JOIN asignado a ON v.ID_Venta = a.ID_Venta " +
                        "INNER JOIN producto p ON a.ID_Producto = p.ID_Producto";

                    MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                    DataTable tablaVentas = new DataTable();
                    adaptador.Fill(tablaVentas);

                    dataGridVentas.DataSource = tablaVentas;

                    dataGridVentas.Columns["ID_Venta"].Visible = false;

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
                        "WHERE c.Nombre LIKE @textoBusqueda";

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
    }
}
