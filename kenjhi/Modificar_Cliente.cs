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
    public partial class Modificar_Cliente : Form
    {
        public Modificar_Cliente()
        {
            InitializeComponent();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(txtIDModificar.Text);
            string nuevoNombre = txtNombreModificar.Text.Trim();
            string nuevoNumero = txtNumeroModificar.Text.Trim();
            string nuevaDireccion = txtDirModificar.Text.Trim();

            using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=negocio_comida_rapida; Uid=jhin; Pwd=jhin444_2023;"))
            {
                connection.Open();

                string query = "UPDATE clientes SET nombre_completo = @nombre, numero_telefono = @numero, direccion = @direccion WHERE id_cliente = @id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nuevoNombre);
                    command.Parameters.AddWithValue("@numero", nuevoNumero);
                    command.Parameters.AddWithValue("@direccion", nuevaDireccion);
                    command.Parameters.AddWithValue("@id", idCliente);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Datos del cliente actualizados correctamente.", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un cliente con el ID especificado.", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
