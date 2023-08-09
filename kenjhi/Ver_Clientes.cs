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
    public partial class Ver_Clientes : Form
    {

        public Ver_Clientes()
        {
            InitializeComponent();

            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"); ;
                conexion.Open();

                string consulta = "SELECT ID_Cliente, Nombre, Telefono, Direccion, Email FROM Cliente";

                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                System.Data.DataTable tablaClientes = new System.Data.DataTable();
                adaptador.Fill(tablaClientes);

                dataGridClientes.DataSource = tablaClientes;

                // Configurar las columnas
                dataGridClientes.Columns["ID_Cliente"].HeaderText = "ID";
                dataGridClientes.Columns["ID_Cliente"].Visible = false;
                dataGridClientes.Columns["Nombre"].HeaderText = "Cliente";
                dataGridClientes.Columns["Telefono"].HeaderText = "Numero de teléfono";
                dataGridClientes.Columns["Direccion"].HeaderText = "Dirección";
                dataGridClientes.Columns["Email"].HeaderText = "Correo electrónico";

                // Ajustar el ancho de las columnas
                dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT ID_Cliente, Nombre, Email, Telefono FROM Cliente", connection))
                    {
                        MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                        adapter.Update((DataTable)dataGridClientes.DataSource);
                    }

                    MessageBox.Show("Datos actualizados.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblSinGuardar.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
        }

        private void dataGridClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblSinGuardar.Visible = true;
            btnGuardarCambios.Visible = true;
        }

        private void dataGridClientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //lblSinGuardar.Visible = true;
        }
    }
}
