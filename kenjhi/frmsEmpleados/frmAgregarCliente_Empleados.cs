using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace kenjhi
{
    public partial class frmAgregarCliente_Empleados : Form
    {
        private string connectionString = "Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;";

        public frmAgregarCliente_Empleados()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) || string.IsNullOrWhiteSpace(txtNumeroCliente.Text))
            {
                lbl2.Visible = true;
                System.Media.SystemSounds.Exclamation.Play();
                return;
            }

            string nombre = txtNombreCliente.Text;
            string telefono = txtNumeroCliente.Text;
            string direccion = txtDirCliente.Text;
            string email = txtEmail.Text;

            if (!string.IsNullOrEmpty(email) && !Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool clienteExiste = VerificarExistenciaCliente(nombre, telefono);

            if (clienteExiste)
            {
                bool clienteEliminado = VerificarClienteEliminado(nombre, telefono);

                if (clienteEliminado)
                {
                    DialogResult result = MessageBox.Show("Cliente eliminado anteriormente. ¿Desea recuperarlo?", "Recuperar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        RecuperarCliente(nombre, telefono);
                        MessageBox.Show("Cliente recuperado correctamente.", "Cliente recuperado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Cliente ya existe en la base de datos.", "Cliente existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                AgregarCliente(nombre, telefono, direccion, email);
                MessageBox.Show("Nuevo cliente ingresado correctamente.", "Nuevo cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }

        private bool VerificarExistenciaCliente(string nombre, string telefono)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Cliente WHERE Nombre = @Nombre AND Telefono = @Telefono";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool VerificarClienteEliminado(string nombre, string telefono)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Cliente WHERE Nombre = @Nombre AND Telefono = @Telefono AND Visible = 0";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void RecuperarCliente(string nombre, string telefono)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Cliente SET Visible = 1 WHERE Nombre = @Nombre AND Telefono = @Telefono";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void AgregarCliente(string nombre, string telefono, string direccion, string email)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Cliente (Nombre, Telefono, Direccion, Email) VALUES (@Nombre, @Telefono, @Direccion, @Email)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@Email", email);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombreCliente.Text = "";
            txtNumeroCliente.Text = "";
            txtDirCliente.Text = "";
            txtEmail.Text = "";
            lbl2.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
