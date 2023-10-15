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
    public partial class Nueva_Venta : Form
    {
        public Nueva_Venta()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nueva_Venta_Load(object sender, EventArgs e)
        {
            //comboListaTipoPago.Items.Add("Contado");
            //comboListaTipoPago.Items.Add("Cuotas");
        }

        private void comboListaClientes_Click(object sender, EventArgs e)
        {
            //        using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
            //{
            //    connection.Open();
            //    string query = "SELECT Nombre FROM cliente WHERE Visible = 1";
            //    MySqlCommand cmd = new MySqlCommand(query, connection);

            //    using (MySqlDataReader reader = cmd.ExecuteReader())
            //    {
            //        comboListaClientes.Items.Clear();
            //        while (reader.Read())
            //        {
            //            comboListaClientes.Items.Add(reader["Nombre"].ToString());
            //        }
            //    }
            //}




            using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
            {
                connection.Open();
                string query = "SELECT CONCAT(Nombre, ' - ', Telefono) AS ClienteInfo FROM cliente WHERE Visible = 1";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    comboListaClientes.Items.Clear();
                    while (reader.Read())
                    {
                        comboListaClientes.Items.Add(reader["ClienteInfo"].ToString());
                    }
                }
            }
        }

        private void comboListaProductos_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
            {
                connection.Open();
                string query = "SELECT Nombre FROM producto WHERE Visible = 1 AND Cantidad > 0";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    comboListaProductos.Items.Clear();
                    while (reader.Read())
                    {
                        comboListaProductos.Items.Add(reader["Nombre"].ToString());
                    }
                }
            }
        }
    }
}
