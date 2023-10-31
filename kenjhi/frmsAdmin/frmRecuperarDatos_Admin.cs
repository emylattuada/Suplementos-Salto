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
    public partial class frmRecuperarDatos_Admin : Form
    {
        public frmRecuperarDatos_Admin()
        {

            InitializeComponent();
            dataGridRecuperarDatos.RowTemplate.Height = 40;
            dataGridRecuperarDatos.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            txtBusquedaDGV.Text = "Ingresa un nombre para realizar la búsqueda";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRecuperarDatos_Admin_Load(object sender, EventArgs e)
        {


        }


        private void CargarDatosClientes()
        {


            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"); ;
                conexion.Open();

                string consulta = "SELECT ID_Cliente, Nombre, Telefono, Direccion, Email FROM Cliente WHERE visible=0";


                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                System.Data.DataTable tablaClientes = new System.Data.DataTable();
                adaptador.Fill(tablaClientes);

                dataGridRecuperarDatos.DataSource = tablaClientes;

                dataGridRecuperarDatos.Columns["ID_Cliente"].HeaderText = "ID";
                dataGridRecuperarDatos.Columns["ID_Cliente"].Visible = false;
                dataGridRecuperarDatos.Columns["Nombre"].HeaderText = "Cliente";
                dataGridRecuperarDatos.Columns["Telefono"].HeaderText = "Numero de teléfono";
                dataGridRecuperarDatos.Columns["Direccion"].HeaderText = "Dirección";
                dataGridRecuperarDatos.Columns["Email"].HeaderText = "Correo electrónico";

                dataGridRecuperarDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn column in dataGridRecuperarDatos.Columns)
                {
                    column.ReadOnly = true;
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxClientes_Click(object sender, EventArgs e)
        {
            pictureBoxProductos.Visible = false;
            labelProductos.Visible = false;
            pictureBoxClientes.Visible = false;
            labelClientes.Visible = false;
            pictureBoxCategorias.Visible = false;
            labelCategorias.Visible = false;
            pictureBoxEmpleados.Visible = false;
            labelEmpleados.Visible = false;

            dataGridRecuperarDatos.Visible = true;
            CargarDatosClientes();
            labelPrincipal.Text = "Visualizando Clientes eliminados";
            labelBuscar.Visible = true;
            txtLinea.Visible = true;
            txtBusquedaDGV.Visible = true;



        }

        private void BusquedaClientes()
        {
            if (txtBusquedaDGV.Text.Length == 0)
            {
                try
                {
                    MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"); ;
                    conexion.Open();

                    string consulta = "SELECT ID_Cliente, Nombre, Telefono, Direccion, Email FROM Cliente WHERE visible=0";


                    MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                    System.Data.DataTable tablaClientes = new System.Data.DataTable();
                    adaptador.Fill(tablaClientes);

                    dataGridRecuperarDatos.DataSource = tablaClientes;

                    // Configurar las columnas
                    dataGridRecuperarDatos.Columns["ID_Cliente"].HeaderText = "ID";
                    dataGridRecuperarDatos.Columns["ID_Cliente"].Visible = false;
                    dataGridRecuperarDatos.Columns["Nombre"].HeaderText = "Cliente";
                    dataGridRecuperarDatos.Columns["Telefono"].HeaderText = "Numero de teléfono";
                    dataGridRecuperarDatos.Columns["Direccion"].HeaderText = "Dirección";
                    dataGridRecuperarDatos.Columns["Email"].HeaderText = "Correo electrónico";

                    // Ajustar el ancho de las columnas
                    dataGridRecuperarDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (lblSinResultado.Visible == true)
                    {
                        lblSinResultado.Visible = false;
                    }
                    if (lblSinResultado2.Visible == true)
                    {
                        lblSinResultado2.Visible = false;
                    } //probar


                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            if (txtBusquedaDGV.Text.Length > 0)
            {
                string textoBusqueda = txtBusquedaDGV.Text;
                using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM cliente WHERE Visible = 0 AND Nombre LIKE @textoBusqueda";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridRecuperarDatos.DataSource = dataTable;
                        dataGridRecuperarDatos.Columns["Visible"].Visible = false;
                        if (dataTable.Rows.Count == 0)
                        {
                            dataGridRecuperarDatos.Visible = true;
                            dataGridRecuperarDatos.Visible = true;

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




        private void txtBusquedaDGV_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBusquedaDGV.Text == "Ingresa un nombre para realizar la búsqueda") { txtBusquedaDGV.Clear(); txtBusquedaDGV.ForeColor = System.Drawing.Color.White; }

        }

        private void txtBusquedaDGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            BusquedaClientes();
        }

        private void dataGridRecuperarDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRecuperar.Visible = true;
        }

        private void RecuperarCliente()
        {

            if (dataGridRecuperarDatos.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dataGridRecuperarDatos.SelectedRows[0].Cells["ID_Cliente"].Value);

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
                    {
                        conexion.Open();

                        string consultaActualizar = $"UPDATE Cliente SET visible=1 WHERE ID_Cliente={idCliente}";
                        MySqlCommand comandoActualizar = new MySqlCommand(consultaActualizar, conexion);
                        comandoActualizar.ExecuteNonQuery();

                        conexion.Close();

                        // Ocultar la fila seleccionada en el DataGridView
                        dataGridRecuperarDatos.SelectedRows[0].Visible = false;


                    }
                }
                catch /*(Exception ex)*/
                {
                    MessageBox.Show("Cliente recuperado.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                CargarDatosClientes();
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            RecuperarCliente();
        }
    }
}
