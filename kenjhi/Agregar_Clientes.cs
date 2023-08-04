using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kenjhi
{
    public partial class Agregar_Clientes : Form
    {
        public Agregar_Clientes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtNombreCliente.Text.Trim();
            string numeroCliente = txtNumeroCliente.Text.Trim();
            string direccionCliente = txtDirCliente.Text.Trim();

            // Verificar que los campos obligatorios estén completos
            if (string.IsNullOrEmpty(nombreCliente) || string.IsNullOrEmpty(numeroCliente))
            {
                //
                //MessageBox.Show("Debes completar los campos obligatorios.", "Campos obligatorios vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SystemSounds.Exclamation.Play();
                lbl2.Visible = true;
                return;
            }

            // Verificar si el cliente ya está registrado en la base de datos
            bool clienteExistente = VerificarClienteExistente(nombreCliente, numeroCliente);

            if (clienteExistente)
            {
                MessageBox.Show("Cliente ya registrado anteriormente.", "Cliente existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarCampos();
                lbl2.Visible = false;
                return;
            }

            // Insertar el nuevo cliente en la base de datos
            InsertarNuevoCliente(nombreCliente, numeroCliente, direccionCliente);

            // Mostrar el mensaje de nuevo cliente agregado
            string mensaje = "Nuevo cliente agregado:\n\n" +
                             "Nombre: " + nombreCliente + "\n" +
                             "Número de teléfono: " + numeroCliente;

            if (!string.IsNullOrEmpty(direccionCliente))
            {
                mensaje += "\nDirección: " + direccionCliente;
            }

            MessageBox.Show(mensaje, "Cliente agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbl2.Visible = false;

            LimpiarCampos();
        }

        private bool VerificarClienteExistente(string nombreCliente, string numeroCliente)
        {
            // Realizar la verificación en la base de datos (implementar según tu estructura de base de datos)
            // Aquí puedes usar una consulta SQL para verificar si ya existe un cliente con el mismo nombre o número de teléfono
            // Si el cliente existe, devuelve true; de lo contrario, devuelve false

            // Ejemplo de implementación:
            using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=negocio_comida_rapida; Uid=jhin; Pwd=jhin444_2023;"))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM clientes WHERE nombre_completo = @nombre OR numero_telefono = @telefono";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombreCliente);
                    command.Parameters.AddWithValue("@telefono", numeroCliente);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void InsertarNuevoCliente(string nombreCliente, string numeroCliente, string direccionCliente)
        {
            // Insertar el nuevo cliente en la base de datos (implementar según tu estructura de base de datos)
            // Aquí puedes usar una consulta SQL o un ORM para insertar los datos en la tabla "clientes"

            // Ejemplo de implementación:
            using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=negocio_comida_rapida; Uid=jhin; Pwd=jhin444_2023;"))
            {
                connection.Open();

                string query = "INSERT INTO clientes (nombre_completo, numero_telefono, direccion) VALUES (@nombre, @telefono, @direccion)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombreCliente);
                    command.Parameters.AddWithValue("@telefono", numeroCliente);
                    command.Parameters.AddWithValue("@direccion", direccionCliente);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void LimpiarCampos()
        {
            // Limpiar los campos de texto
            txtNombreCliente.Text = string.Empty;
            txtNumeroCliente.Text = string.Empty;
            txtDirCliente.Text = string.Empty;
        }
    }
    }

