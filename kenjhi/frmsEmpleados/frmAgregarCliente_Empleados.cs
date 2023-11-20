using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Linq;

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

            if (txtCICliente.Text.Length > 8)
            {
                MessageBox.Show("La CI ingresada supera los 8 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }



            if (txtNombreCliente.Text.Length > 25)
            {
                MessageBox.Show("El nombre de cliente contiene demasiados caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNumeroCliente.Text.Length > 9)
            {
                MessageBox.Show("El número de teléfono ingresado supera los 9 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (txtDirCliente.Text.Length > 50)
            {
                MessageBox.Show("La dirección ingresada contiene demasiados caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtEmail.Text.Length > 50)
            {
                MessageBox.Show("El correo eléctronico ingresado contiene demasiados caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsNumero(txtNumeroCliente.Text))
            {
                MessageBox.Show("El número de teléfono debe contener solo dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }



            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) || string.IsNullOrWhiteSpace(txtNumeroCliente.Text) || string.IsNullOrEmpty(txtCICliente.Text))
            {
                lbl2.Visible = true;
                System.Media.SystemSounds.Exclamation.Play();
                return;
            }

            string nombre = txtNombreCliente.Text;
            string telefono = txtNumeroCliente.Text;
            string direccion = txtDirCliente.Text;
            string email = txtEmail.Text;
            string ci = txtCICliente.Text;

            if (!string.IsNullOrEmpty(email) && !Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool clienteExiste = VerificarExistenciaCliente(nombre, ci);

            if (clienteExiste)
            {
                bool clienteEliminado = VerificarClienteEliminado(nombre, ci);

                if (clienteEliminado)
                {
                    DialogResult result = MessageBox.Show("Cliente eliminado anteriormente. ¿Desea recuperarlo?", "Recuperar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        RecuperarCliente(nombre, ci);
                        MessageBox.Show("Cliente recuperado correctamente.", "Cliente recuperado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Cliente ya existente en el sistema.", "Cliente existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                AgregarCliente(nombre, telefono, direccion, email, ci);
                MessageBox.Show("Nuevo cliente ingresado correctamente.", "Nuevo cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }


        }

        private bool EsCorreoElectronicoValido(string correo)
        {
            return Regex.IsMatch(correo, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$");
        }

        private bool EsNumero(string cadena)
        {
            return cadena.All(char.IsDigit);
        }

        private bool VerificarExistenciaCliente(string nombre, string ci)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Cliente WHERE Nombre = @Nombre AND CI = @CI";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@CI", ci);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool VerificarClienteEliminado(string nombre, string ci)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Cliente WHERE Nombre = @Nombre AND CI = @CI AND Visible = 0";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@CI", ci);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void RecuperarCliente(string nombre, string ci)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Cliente SET Visible = 1 WHERE Nombre = @Nombre AND CI = @CI";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@CI", ci);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void AgregarCliente(string nombre, string telefono, string direccion, string email, string ci)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Cliente (Nombre, Telefono, Direccion, Email, CI) VALUES (@Nombre, @Telefono, @Direccion, @Email, @CI)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@CI", ci);


                    command.ExecuteNonQuery();
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombreCliente.Text = "";
            txtNumeroCliente.Text = "";
            txtCICliente.Text = "";
            txtEmail.Text = "";
            lbl2.Visible = false;
            txtDirCliente.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
