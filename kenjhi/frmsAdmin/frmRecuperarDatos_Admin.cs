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
                dataGridRecuperarDatos.ReadOnly = true;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
