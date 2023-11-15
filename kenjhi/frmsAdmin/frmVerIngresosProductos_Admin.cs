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

namespace kenjhi
{
    public partial class frmVerIngresosProductos_Admin : Form
    {
        public frmVerIngresosProductos_Admin()
        {
            InitializeComponent();
            txtBusquedaDGV.Text = "Ingresa un nombre de producto para realizar la búsqueda";
            txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
            dataGridIngresosProd.RowTemplate.Height = 40;
            dataGridIngresosProd.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            dataGridIngresosProd.ReadOnly = true;
            CargarDatosDGV();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatosDGV()
        {

            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                conexion.Open();

                string consulta = "SELECT i.ID_Ingreso, p.Nombre AS NombreProducto, i.Cantidad, i.Fecha_Ingreso " +
                                  "FROM ingresos i " +
                                  "INNER JOIN producto p ON i.ID_Producto = p.ID_Producto";

                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                DataTable tablaIngresos = new DataTable();
                adaptador.Fill(tablaIngresos);

                dataGridIngresosProd.DataSource = tablaIngresos;

                dataGridIngresosProd.Columns["ID_Ingreso"].Visible = false;

                dataGridIngresosProd.Columns["NombreProducto"].HeaderText = "Nombre del Producto";
                dataGridIngresosProd.Columns["Cantidad"].HeaderText = "Cantidad";
                dataGridIngresosProd.Columns["Fecha_Ingreso"].HeaderText = "Fecha de Ingreso";
                dataGridIngresosProd.Columns["Fecha_Ingreso"].DefaultCellStyle.Format = "dd/MM/yyyy";


                dataGridIngresosProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos de ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtBusquedaDGV_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBusquedaDGV.Text == "Ingresa un nombre de producto para realizar la búsqueda") { txtBusquedaDGV.Clear(); txtBusquedaDGV.ForeColor = System.Drawing.Color.White; }

        }

        private void txtBusquedaDGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBusquedaDGV.Text.Length == 0)
            {
                lblSinResultado.Visible = false;
                lblSinResultado2.Visible = false;
                try
                {
                    MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                    conexion.Open();

                    string consulta = "SELECT i.ID_Ingreso, p.Nombre AS NombreProducto, i.Cantidad, i.Fecha_Ingreso " +
                        "FROM ingresos i " +
                        "INNER JOIN producto p ON i.ID_Producto = p.ID_Producto";

                    MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                    DataTable tablaIngresos = new DataTable();
                    adaptador.Fill(tablaIngresos);

                    dataGridIngresosProd.DataSource = tablaIngresos;

                    dataGridIngresosProd.Columns["ID_Ingreso"].Visible = false;

                    dataGridIngresosProd.Columns["NombreProducto"].HeaderText = "Nombre del Producto";
                    dataGridIngresosProd.Columns["Cantidad"].HeaderText = "Cantidad";
                    dataGridIngresosProd.Columns["Fecha_Ingreso"].HeaderText = "Fecha de Ingreso";
                    dataGridIngresosProd.Columns["Fecha_Ingreso"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    dataGridIngresosProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error al cargar los datos de ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (txtBusquedaDGV.Text.Length > 0)
            {
                string textoBusqueda = txtBusquedaDGV.Text;
                using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                {
                    conexion.Open();
                    string consulta = "SELECT i.ID_Ingreso, p.Nombre AS NombreProducto, i.Cantidad, i.Fecha_Ingreso " +
                        "FROM ingresos i " +
                        "INNER JOIN producto p ON i.ID_Producto = p.ID_Producto " +
                        "WHERE p.Nombre LIKE @textoBusqueda";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridIngresosProd.DataSource = dataTable;
                        dataGridIngresosProd.Columns["ID_Ingreso"].Visible = false;
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
            }

        }
    }
}
