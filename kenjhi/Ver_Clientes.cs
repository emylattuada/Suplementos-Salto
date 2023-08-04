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
            // Conexión a la base de datos
            using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=negocio_comida_rapida; Uid=jhin; Pwd=jhin444_2023;"))
            {
                connection.Open();

                // Consulta SQL para obtener todos los clientes
                string query = "SELECT id_cliente AS 'ID', nombre_completo AS 'Nombre', numero_telefono AS 'Número de teléfono', direccion AS 'Dirección' FROM clientes";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Crear un objeto DataTable para almacenar los resultados de la consulta
                    DataTable dataTable = new DataTable();

                    // Utilizar un objeto MySqlDataAdapter para llenar el DataTable con los resultados de la consulta
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Asignar el DataTable como origen de datos del DataGridView
                    dataGridClientes.DataSource = dataTable;

                    // Establecer los encabezados de columna personalizados
                    dataGridClientes.Columns["ID"].HeaderText = "ID";
                    dataGridClientes.Columns["Nombre"].HeaderText = "Nombre";
                    dataGridClientes.Columns["Número de teléfono"].HeaderText = "Número de teléfono";
                    dataGridClientes.Columns["Dirección"].HeaderText = "Dirección";
                }
            }

            // Establecer el tamaño mínimo de la columna "Nombre" a 100
            dataGridClientes.Columns["Nombre"].MinimumWidth = 100;
            // Establecer el tamaño mínimo de la columna "Número de teléfono" a 80
            dataGridClientes.Columns["Número de teléfono"].MinimumWidth = 150;
            // Establecer el tamaño mínimo de la columna "Dirección" a 30
            dataGridClientes.Columns["Dirección"].MinimumWidth = 245;



        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
