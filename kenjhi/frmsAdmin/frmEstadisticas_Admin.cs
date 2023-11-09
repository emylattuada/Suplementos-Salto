using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace kenjhi.frmsAdmin
{
    public partial class frmEstadisticas_Admin : Form
    {
        private string connectionString = "Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;";
        int pos = 0;

        public frmEstadisticas_Admin()
        {
            InitializeComponent();
            comboBox1.Items.Add("Semana");
            comboBox1.Items.Add("Mes");
            comboBox1.SelectedItem = "Semana";

            


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxClientes_Click(object sender, EventArgs e)
        {
            labelClientes.Visible = false;
            pictureBoxClientes.Visible = false;

        }

        private void pictureBoxProductos_Click(object sender, EventArgs e)
        {
            labelProductos.Visible = false;
            pictureBoxProductos.Visible = false;
            labelClientes.Visible = false;
            pictureBoxClientes.Visible = false;
            labelPrincipal.Text = "Visualizando gráfico de productos";
            chartProductosMasVendidos.Visible = true;
            labelPrincipal.Location = new System.Drawing.Point(6, 9);
            pictureDetalles.Visible = true;
            linkVerDetalles.Visible = true;
            comboBox1.Visible = true;
            lblFiltro.Visible = true;




        }

        private void CargarGraficoProductosVendidosUltimos7Dias()
        {
            string consulta = "SELECT p.Nombre as NombreProducto, SUM(a.Cantidad) as TotalVendido " +
                              "FROM asignado a " +
                              "INNER JOIN venta v ON a.ID_Venta = v.ID_Venta " +
                              "INNER JOIN producto p ON a.ID_Producto = p.ID_Producto " +
                              "WHERE v.Fecha_Venta BETWEEN DATE_SUB(NOW(), INTERVAL 7 DAY) AND NOW() " +
                              "GROUP BY a.ID_Producto " +
                              "ORDER BY TotalVendido DESC LIMIT 5";  

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                    DataTable tablaProductosVendidos = new DataTable();
                    adaptador.Fill(tablaProductosVendidos);

                    chartProductosMasVendidos.Series.Clear();
                    chartProductosMasVendidos.Titles.Add("Gráfico de productos más vendidos (últimos 7 días)");


                    foreach (DataRow fila in tablaProductosVendidos.Rows)
                    {
                        string nombreProducto = fila["NombreProducto"].ToString();
                        int totalVendido = Convert.ToInt32(fila["TotalVendido"]);

                        chartProductosMasVendidos.Series.Add(nombreProducto);
                        chartProductosMasVendidos.Series[nombreProducto].Points.Add(totalVendido);
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }

        private void CargarGraficoProductosVendidosUltimos30Dias()
        {
            string consulta = "SELECT p.Nombre as NombreProducto, SUM(a.Cantidad) as TotalVendido " +
                              "FROM asignado a " +
                              "INNER JOIN venta v ON a.ID_Venta = v.ID_Venta " +
                              "INNER JOIN producto p ON a.ID_Producto = p.ID_Producto " +
                              "WHERE v.Fecha_Venta BETWEEN DATE_SUB(NOW(), INTERVAL 30 DAY) AND NOW() " +
                              "GROUP BY a.ID_Producto " +
                              "ORDER BY TotalVendido DESC LIMIT 5";  

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                    DataTable tablaProductosVendidos = new DataTable();
                    adaptador.Fill(tablaProductosVendidos);

                    chartProductosMasVendidos.Series.Clear();
                    chartProductosMasVendidos.Titles.Add("Gráfico de productos más vendidos (últimos 30 días)");

                    foreach (DataRow fila in tablaProductosVendidos.Rows)
                    {
                        string nombreProducto = fila["NombreProducto"].ToString();
                        int totalVendido = Convert.ToInt32(fila["TotalVendido"]);

                        chartProductosMasVendidos.Series.Add(nombreProducto);
                        chartProductosMasVendidos.Series[nombreProducto].Points.Add(totalVendido);
                    }

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        

        private void frmEstadisticas_Admin_Load(object sender, EventArgs e)
        {

        }

       

        private void MostrarEstadisticas7Dias()
        {

            string consulta = "SELECT p.Nombre as NombreProducto, SUM(a.Cantidad) as TotalVendido " +
                     "FROM asignado a " +
                     "INNER JOIN venta v ON a.ID_Venta = v.ID_Venta " +
                     "INNER JOIN producto p ON a.ID_Producto = p.ID_Producto " +
                     "WHERE v.Fecha_Venta BETWEEN DATE_SUB(NOW(), INTERVAL 7 DAY) AND NOW() " +
                     "GROUP BY a.ID_Producto " +
                     "ORDER BY TotalVendido DESC LIMIT 5";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                    DataTable tablaProductosVendidos = new DataTable();
                    adaptador.Fill(tablaProductosVendidos);

                    string textoProductos = "Productos más vendidos en los últimos 7 días:\n";

                    foreach (DataRow fila in tablaProductosVendidos.Rows)
                    {
                        string nombreProducto = fila["NombreProducto"].ToString();
                        int totalVendido = Convert.ToInt32(fila["TotalVendido"]);

                        textoProductos += $"{nombreProducto}: {totalVendido} vendidos\n";
                    }

                    MessageBox.Show(textoProductos);


                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void MostrarEstadisticas30Dias()
        {
            string consulta3 = "SELECT p.Nombre as NombreProducto, SUM(a.Cantidad) as TotalVendido " +
                     "FROM asignado a " +
                     "INNER JOIN venta v ON a.ID_Venta = v.ID_Venta " +
                     "INNER JOIN producto p ON a.ID_Producto = p.ID_Producto " +
                     "WHERE v.Fecha_Venta BETWEEN DATE_SUB(NOW(), INTERVAL 30 DAY) AND NOW() " +
                     "GROUP BY a.ID_Producto " +
                     "ORDER BY TotalVendido DESC LIMIT 5";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    MySqlCommand comando = new MySqlCommand(consulta3, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                    DataTable tablaProductosVendidos = new DataTable();
                    adaptador.Fill(tablaProductosVendidos);

                    string textoProductos = "Productos más vendidos en los últimos 30 días:\n";

                    foreach (DataRow fila in tablaProductosVendidos.Rows)
                    {
                        string nombreProducto = fila["NombreProducto"].ToString();
                        int totalVendido = Convert.ToInt32(fila["TotalVendido"]);

                        textoProductos += $"{nombreProducto}: {totalVendido} vendidos\n";
                    }

                    MessageBox.Show(textoProductos);

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkVerDetalles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pos == 1) { MostrarEstadisticas7Dias(); }
            if (pos == 2) { MostrarEstadisticas30Dias(); }
        }

        private void pictureDetalles_Click(object sender, EventArgs e)
        {
            if (pos == 1) { MostrarEstadisticas7Dias(); }
            if (pos == 2) { MostrarEstadisticas30Dias(); }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Semana")
            {
                chartProductosMasVendidos.Series.Clear();
                chartProductosMasVendidos.Titles.Clear();
                pos = 1;
                CargarGraficoProductosVendidosUltimos7Dias();
            }
            else if (comboBox1.SelectedItem.ToString() == "Mes")
            {
                chartProductosMasVendidos.Series.Clear();
                chartProductosMasVendidos.Titles.Clear();
                pos = 2;
                CargarGraficoProductosVendidosUltimos30Dias();
            }
        }
    }
}
