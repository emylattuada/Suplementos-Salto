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

        public frmEstadisticas_Admin()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 7 * 24 * 60 * 60 * 1000; 
            timer1.Tick += timer1_Tick;
            timer1.Start();

            timer2 = new Timer();
            int milisegundosEnUnDia = 24 * 60 * 60 * 1000; 
            long milisegundosEn30Dias = 30L * 24L * 60L * 60L * 1000L; 

            if (milisegundosEn30Dias <= int.MaxValue && milisegundosEn30Dias > 0)
            {
                timer2.Interval = (int)milisegundosEn30Dias;
                timer2.Tick += timer1_Tick; 
                timer2.Start();
            }


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
            lblMasVendido7Dias.Visible = true;

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

            string consulta2 = "SELECT p.Nombre as NombreProducto, SUM(a.Cantidad) as TotalVendido " +
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

                    lblMasVendido7Dias.Text = textoProductos;

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

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
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

                    lblMasVendido7Dias.Text = textoProductos;

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarGraficoProductosVendidosUltimos7Dias();
            
        }

        private void frmEstadisticas_Admin_Load(object sender, EventArgs e)
        {
            CargarGraficoProductosVendidosUltimos7Dias();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CargarGraficoProductosVendidosUltimos30Dias();
        }
    }
}
