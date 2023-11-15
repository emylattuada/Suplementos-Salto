using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        int posi = 0;
        private DataTable dataTable;
        private DataTable dataTableClientes;



        public frmEstadisticas_Admin()
        {
            InitializeComponent();
            comboBox1.Items.Add("Semana");
            comboBox1.Items.Add("Mes");
            comboBox1.SelectedItem = "Semana";

            dgvver.Columns["nombre"].Width = 600;
            dgvver.Columns["Cantidad"].Width = 150;
            dgvver.Columns["nombre"].Width = 600;
            dgvverclientes.Columns["nomcliente"].Width = 600;
            dgvverclientes.Columns["Compras"].Width = 150;

            dataTableClientes = new DataTable();

            dataTable = new DataTable();




        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxClientes_Click(object sender, EventArgs e)
        {
            
            chartProductosMasVendidos.Titles.Clear();
            chartProductosMasVendidos.Series.Clear();
            CargarGraficoClientesCompras7Dias();
            labelClientes.Visible = false;
            pictureBoxClientes.Visible = false;
            labelProductos.Visible= false;
            pictureBoxProductos.Visible = false;
            labelPrincipal.Text = "Gráfico de Clientes";
            chartProductosMasVendidos.Visible = true;
            labelPrincipal.Location = new System.Drawing.Point(6, 9);
            lblFiltro.Visible = true;
            comboBox1.Visible = true;
            linkVerDetalles.Visible = true;
            pictureDetalles.Visible = true;
            labelRuta.Text = "Menú principal > Administrador > Estadísticas > Clientes";
            pictureImprimir.Visible = true;
            linkImprimir.Visible = true;


            posi = 1;
           

        }

        private void pictureBoxProductos_Click(object sender, EventArgs e)
        {
            chartProductosMasVendidos.Titles.Clear();
            chartProductosMasVendidos.Series.Clear();
            CargarGraficoProductosVendidosUltimos7Dias();
            labelProductos.Visible = false;
            pictureBoxProductos.Visible = false;
            labelClientes.Visible = false;
            pictureBoxClientes.Visible = false;
            labelPrincipal.Text = "Gráfico de Productos";
            chartProductosMasVendidos.Visible = true;
            labelPrincipal.Location = new System.Drawing.Point(6, 9);
            pictureDetalles.Visible = true;
            linkVerDetalles.Visible = true;
            comboBox1.Visible = true;
            lblFiltro.Visible = true;
            pictureImprimir.Visible = true;
            linkImprimir.Visible = true;
            labelRuta.Text = "Menú principal > Administrador > Estadísticas > Productos";

            pos = 1;
           



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

                    chartProductosMasVendidos.Titles.Clear();
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

                    chartProductosMasVendidos.Titles.Clear();
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
            if(pos==1 && comboBox1.SelectedItem.ToString() == "Semana") {MostrarEstadisticas7Dias(); }
            if (pos == 1 && comboBox1.SelectedItem.ToString() == "Mes") { MostrarEstadisticas30Dias(); }
            if (posi == 1 && comboBox1.SelectedItem.ToString() == "Semana") { MostrarEstadisticasClientesCompras7Dias(); }
            if (posi == 1 && comboBox1.SelectedItem.ToString() == "Mes") { MostrarEstadisticasClientesCompras30Dias(); }





        }

        private void pictureDetalles_Click(object sender, EventArgs e)
        {
            if (pos == 1 && comboBox1.SelectedItem.ToString() == "Semana") { MostrarEstadisticas7Dias(); }
            if (pos == 1 && comboBox1.SelectedItem.ToString() == "Mes") { MostrarEstadisticas30Dias(); }
            if (posi == 1 && comboBox1.SelectedItem.ToString() == "Semana") { MostrarEstadisticasClientesCompras7Dias(); }
            if (posi == 1 && comboBox1.SelectedItem.ToString() == "Mes") { MostrarEstadisticasClientesCompras30Dias(); }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (posi == 1 && comboBox1.SelectedItem.ToString() == "Semana")
            {
                foreach (var series in chartProductosMasVendidos.Series)
                {
                    series.Points.Clear();
                }
                chartProductosMasVendidos.Series.Clear();
                chartProductosMasVendidos.Titles.Clear();
                CargarGraficoClientesCompras7Dias();
            }
             if (posi == 1 && comboBox1.SelectedItem.ToString() == "Mes")
            {
                foreach (var series in chartProductosMasVendidos.Series)
                {
                    series.Points.Clear();
                }
                chartProductosMasVendidos.Series.Clear();
                chartProductosMasVendidos.Titles.Clear();
                CargarGraficoClientesCompras30Dias();
            }
            if (pos == 1 && comboBox1.SelectedItem.ToString() == "Semana")
            {
                foreach (var series in chartProductosMasVendidos.Series)
                {
                    series.Points.Clear();
                }
                chartProductosMasVendidos.Series.Clear();
                chartProductosMasVendidos.Titles.Clear();
                CargarGraficoProductosVendidosUltimos7Dias();
            }
             if (pos == 1 && comboBox1.SelectedItem.ToString() == "Mes")
            {
                foreach (var series in chartProductosMasVendidos.Series)
                {
                    series.Points.Clear();
                }
                chartProductosMasVendidos.Series.Clear();
                chartProductosMasVendidos.Titles.Clear();
                CargarGraficoProductosVendidosUltimos30Dias();
            }




        }

        private void CargarGraficoClientesCompras7Dias()
        {
            
            string consulta = "SELECT c.Nombre as NombreCliente, COUNT(v.ID_Venta) as TotalCompras " +
                              "FROM venta v " +
                              "INNER JOIN cliente c ON v.ID_Cliente = c.ID_Cliente " +
                              "WHERE v.Fecha_Venta BETWEEN DATE_SUB(NOW(), INTERVAL 7 DAY) AND NOW() " +
                              "GROUP BY v.ID_Cliente " +
                              "ORDER BY TotalCompras DESC LIMIT 5";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                    DataTable tablaClientesCompras = new DataTable();
                    adaptador.Fill(tablaClientesCompras);

                    chartProductosMasVendidos.Series.Clear();
                    chartProductosMasVendidos.Titles.Add("Gráfico de clientes con más compras (últimos 7 días)");

                    foreach (DataRow fila in tablaClientesCompras.Rows)
                    {
                        string nombreCliente = fila["NombreCliente"].ToString();
                        int totalCompras = Convert.ToInt32(fila["TotalCompras"]);

                        chartProductosMasVendidos.Series.Add(nombreCliente);
                        chartProductosMasVendidos.Series[nombreCliente].Points.Add(totalCompras);
                    }

                    conexion.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarGraficoClientesCompras30Dias()
        {
            
            string consulta = "SELECT c.Nombre as NombreCliente, COUNT(v.ID_Venta) as TotalCompras " +
                             "FROM venta v " +
                             "INNER JOIN cliente c ON v.ID_Cliente = c.ID_Cliente " +
                             "WHERE v.Fecha_Venta BETWEEN DATE_SUB(NOW(), INTERVAL 30 DAY) AND NOW() " +
                             "GROUP BY v.ID_Cliente " +
                             "ORDER BY TotalCompras DESC LIMIT 5";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                    DataTable tablaClientesCompras = new DataTable();
                    adaptador.Fill(tablaClientesCompras);

                    chartProductosMasVendidos.Series.Clear();
                    chartProductosMasVendidos.Titles.Add("Gráfico de clientes con más compras (últimos 30 días)");

                    foreach (DataRow fila in tablaClientesCompras.Rows)
                    {
                        string nombreCliente = fila["NombreCliente"].ToString();
                        int totalCompras = Convert.ToInt32(fila["TotalCompras"]);

                        chartProductosMasVendidos.Series.Add(nombreCliente);
                        chartProductosMasVendidos.Series[nombreCliente].Points.Add(totalCompras);
                    }

                    conexion.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MostrarEstadisticasClientesCompras7Dias()
        {
            string consulta = "SELECT c.Nombre as NombreCliente, COUNT(v.ID_Venta) as TotalCompras " +
                              "FROM venta v " +
                              "INNER JOIN cliente c ON v.ID_Cliente = c.ID_Cliente " +
                              "WHERE v.Fecha_Venta BETWEEN DATE_SUB(NOW(), INTERVAL 7 DAY) AND NOW() " +
                              "GROUP BY v.ID_Cliente " +
                              "ORDER BY TotalCompras DESC LIMIT 5";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                    DataTable tablaClientesCompras = new DataTable();
                    adaptador.Fill(tablaClientesCompras);

                    string textoClientes = "Clientes con más compras en los últimos 7 días:\n";

                    foreach (DataRow fila in tablaClientesCompras.Rows)
                    {
                        string nombreCliente = fila["NombreCliente"].ToString();
                        int totalCompras = Convert.ToInt32(fila["TotalCompras"]);

                        textoClientes += $"{nombreCliente}: {totalCompras} compras\n";
                    }

                    MessageBox.Show(textoClientes);

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarEstadisticasClientesCompras30Dias()
        {
            string consulta = "SELECT c.Nombre as NombreCliente, COUNT(v.ID_Venta) as TotalCompras " +
                              "FROM venta v " +
                              "INNER JOIN cliente c ON v.ID_Cliente = c.ID_Cliente " +
                              "WHERE v.Fecha_Venta BETWEEN DATE_SUB(NOW(), INTERVAL 30 DAY) AND NOW() " +
                              "GROUP BY v.ID_Cliente " +
                              "ORDER BY TotalCompras DESC LIMIT 5";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                    DataTable tablaClientesCompras = new DataTable();
                    adaptador.Fill(tablaClientesCompras);

                    string textoClientes = "Clientes con más compras en los últimos 30 días:\n";

                    foreach (DataRow fila in tablaClientesCompras.Rows)
                    {
                        string nombreCliente = fila["NombreCliente"].ToString();
                        int totalCompras = Convert.ToInt32(fila["TotalCompras"]);

                        textoClientes += $"{nombreCliente}: {totalCompras} compras\n";
                    }

                    MessageBox.Show(textoClientes);

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearPDF7Dias()
        {
            Font titulo = new Font("Arial", 20, FontStyle.Bold);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;


            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;
                ep.Graphics.DrawString("Productos más vendidos (7 días)", titulo, Brushes.Black, ep.MarginBounds.Left + 462, top - 20, formato);


                foreach (DataGridViewColumn col in dgvver.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, left, top + 38);
                    left += col.Width;

                    if (col.Index < dgvver.ColumnCount - 1)
                        ep.Graphics.DrawLine(Pens.Red, left - 5, top, left - 5, top );
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Yellow, left, top + 75, ep.MarginBounds.Right - left, 6);
                top += 43;

                foreach (DataGridViewRow row in dgvver.Rows)
                {
                    if (row.Index == dgvver.RowCount - 1) break;
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Arial", 13), Brushes.Black, left, top + 48);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top + 40, ep.MarginBounds.Right, top + 40);
                }
            };
            ppd.ShowDialog();

        }

        private void CrearPDF30DiasProductos()
        {
            Font titulo = new Font("Arial", 20, FontStyle.Bold);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;


            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;
                ep.Graphics.DrawString("Productos más vendidos (30 días)", titulo, Brushes.Black, ep.MarginBounds.Left + 462, top - 20, formato);


                foreach (DataGridViewColumn col in dgvver.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, left, top + 38);
                    left += col.Width;

                    if (col.Index < dgvver.ColumnCount - 1)
                        ep.Graphics.DrawLine(Pens.Red, left - 5, top, left - 5, top);
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Yellow, left, top + 75, ep.MarginBounds.Right - left, 6);
                top += 43;

                foreach (DataGridViewRow row in dgvver.Rows)
                {
                    if (row.Index == dgvver.RowCount - 1) break;
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Arial", 13), Brushes.Black, left, top + 48);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top + 40, ep.MarginBounds.Right, top + 40);
                }
            };
            ppd.ShowDialog();

        }
        
        

        private void CargarDatosImprimir7DiasProductos()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
                {
                    conexion.Open();

                    string consulta = "SELECT p.Nombre as NombreProducto, SUM(a.Cantidad) as TotalVendido " +
                                      "FROM asignado a " +
                                      "INNER JOIN venta v ON a.ID_Venta = v.ID_Venta " +
                                      "INNER JOIN producto p ON a.ID_Producto = p.ID_Producto " +
                                      "WHERE v.Fecha_Venta BETWEEN DATE_SUB(NOW(), INTERVAL 7 DAY) AND NOW() " +
                                      "GROUP BY a.ID_Producto " +
                                      "ORDER BY TotalVendido DESC LIMIT 5";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            dataTable.Clear();
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos desde la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void CargarDatosImprimir30Dias()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
                {
                    conexion.Open();

                    string consulta = "SELECT p.Nombre as NombreProducto, SUM(a.Cantidad) as TotalVendido " +
                                      "FROM asignado a " +
                                      "INNER JOIN venta v ON a.ID_Venta = v.ID_Venta " +
                                      "INNER JOIN producto p ON a.ID_Producto = p.ID_Producto " +
                                      "WHERE v.Fecha_Venta BETWEEN DATE_SUB(NOW(), INTERVAL 7 DAY) AND NOW() " +
                                      "GROUP BY a.ID_Producto " +
                                      "ORDER BY TotalVendido DESC LIMIT 5";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            dataTable.Clear();
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos desde la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MostrarDatosEnDataGridView()
        {
            dgvver.Rows.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                dgvver.Rows.Add(row["NombreProducto"], row["TotalVendido"]);
            }
        }

        private void pictureImprimir_Click(object sender, EventArgs e)
        {
            if (pos == 1 && comboBox1.SelectedItem.ToString() == "Semana")
            {
                CargarDatosImprimir7DiasProductos();
                MostrarDatosEnDataGridView();
                CrearPDF7Dias();

            }
            if (pos == 1 && comboBox1.SelectedItem.ToString() == "Mes")
            {
                CargarDatosImprimir30Dias();
                MostrarDatosEnDataGridView();
                CrearPDF30DiasProductos();

            }

            if (posi == 1 && comboBox1.SelectedItem.ToString() == "Semana")
            {
                CargarDatosImprimir7DiasClientes();
                MostrarDatosEnDataGridViewClientes();
                CrearPDF7DiasCliente();


            }

            if (posi == 1 && comboBox1.SelectedItem.ToString() == "Mes")
            {

                CargarDatosImprimir30DiasClientes();
                MostrarDatosEnDataGridViewClientes();
                CrearPDF30DiasCliente();


            }


        }

        private void linkImprimir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pos == 1 && comboBox1.SelectedItem.ToString() == "Semana")
            {
                CargarDatosImprimir7DiasProductos();
                MostrarDatosEnDataGridView();
                CrearPDF7Dias();

            }
            if (pos == 1 && comboBox1.SelectedItem.ToString() == "Mes")
            {
                CargarDatosImprimir30Dias();
                MostrarDatosEnDataGridView();
                CrearPDF30DiasProductos();

            }

            if (posi == 1 && comboBox1.SelectedItem.ToString() == "Semana")
            {
                CargarDatosImprimir7DiasClientes();
                MostrarDatosEnDataGridViewClientes();
                CrearPDF7DiasCliente();


            }

            if (posi == 1 && comboBox1.SelectedItem.ToString() == "Mes")
            {

                CargarDatosImprimir30DiasClientes();
                MostrarDatosEnDataGridViewClientes();
                CrearPDF30DiasCliente();


            }

        }

        private void CargarDatosImprimir7DiasClientes()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    string consulta = "SELECT c.Nombre as NombreCliente, COUNT(v.ID_Venta) as TotalCompras " +
                                      "FROM venta v " +
                                      "INNER JOIN cliente c ON v.ID_Cliente = c.ID_Cliente " +
                                      "WHERE v.Fecha_Venta BETWEEN DATE_SUB(NOW(), INTERVAL 7 DAY) AND NOW() " +
                                      "GROUP BY v.ID_Cliente " +
                                      "ORDER BY TotalCompras DESC LIMIT 5";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            dataTableClientes.Clear();
                            adapter.Fill(dataTableClientes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos de clientes desde la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarDatosImprimir30DiasClientes()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    string consulta = "SELECT c.Nombre as NombreCliente, COUNT(v.ID_Venta) as TotalCompras " +
                                      "FROM venta v " +
                                      "INNER JOIN cliente c ON v.ID_Cliente = c.ID_Cliente " +
                                      "WHERE v.Fecha_Venta BETWEEN DATE_SUB(NOW(), INTERVAL 30 DAY) AND NOW() " +
                                      "GROUP BY v.ID_Cliente " +
                                      "ORDER BY TotalCompras DESC LIMIT 5";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            dataTableClientes.Clear();
                            adapter.Fill(dataTableClientes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos de clientes desde la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MostrarDatosEnDataGridViewClientes()
        {
            dgvverclientes.Rows.Clear();

            foreach (DataRow row in dataTableClientes.Rows)
            {
                dgvverclientes.Rows.Add(row["NombreCliente"], row["TotalCompras"]);
            }
        }

        private void CrearPDF7DiasCliente()
        {
            Font titulo = new Font("Arial", 20, FontStyle.Bold);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;


            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;
                ep.Graphics.DrawString("Clientes con más compras (7 días)", titulo, Brushes.Black, ep.MarginBounds.Left + 462, top - 20, formato);


                foreach (DataGridViewColumn col in dgvverclientes.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, left, top + 38);
                    left += col.Width;

                    if (col.Index < dgvverclientes.ColumnCount - 1)
                        ep.Graphics.DrawLine(Pens.Red, left - 5, top, left - 5, top);
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Yellow, left, top + 75, ep.MarginBounds.Right - left, 6);
                top += 43;

                foreach (DataGridViewRow row in dgvverclientes.Rows)
                {
                    if (row.Index == dgvverclientes.RowCount - 1) break;
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Arial", 13), Brushes.Black, left, top + 48);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top + 40, ep.MarginBounds.Right, top + 40);
                }
            };
            ppd.ShowDialog();

        }

        private void CrearPDF30DiasCliente()
        {
            Font titulo = new Font("Arial", 20, FontStyle.Bold);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;


            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;
                ep.Graphics.DrawString("Clientes con más compras (30 días)", titulo, Brushes.Black, ep.MarginBounds.Left + 462, top - 20, formato);


                foreach (DataGridViewColumn col in dgvverclientes.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, left, top + 38);
                    left += col.Width;

                    if (col.Index < dgvverclientes.ColumnCount - 1)
                        ep.Graphics.DrawLine(Pens.Red, left - 5, top, left - 5, top);
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Yellow, left, top + 75, ep.MarginBounds.Right - left, 6);
                top += 43;

                foreach (DataGridViewRow row in dgvverclientes.Rows)
                {
                    if (row.Index == dgvverclientes.RowCount - 1) break;
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Arial", 13), Brushes.Black, left, top + 48);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top + 40, ep.MarginBounds.Right, top + 40);
                }
            };
            ppd.ShowDialog();

        }







    }
}
