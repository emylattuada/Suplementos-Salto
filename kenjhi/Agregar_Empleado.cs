using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kenjhi
{
    public partial class Adm_Empleados : Form
    {
        public Adm_Empleados()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text) || string.IsNullOrWhiteSpace(txtEmailEmpleado.Text) ||
             string.IsNullOrWhiteSpace(txtContraseñaEmpleado.Text) || string.IsNullOrWhiteSpace(txtContraseñaEmpleado2.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtContraseñaEmpleado.Text != txtContraseñaEmpleado2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(txtEmailEmpleado.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random rand = new Random();
            int codigo = rand.Next(100000, 999999);
            string codigoVerificacion = codigo.ToString();
            //utlizamos el mismo metodo que en el form de cambiar pass para generar el codigo
            //tambien el metodo de encriptado

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(txtContraseñaEmpleado.Text);
                byte[] hash = sha256.ComputeHash(bytes);
                string contraseñaEncriptada = BitConverter.ToString(hash).Replace("-", "").ToLower();


                string connectionString = "Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                string insertQuery = "INSERT INTO usuarios (NombreUsuario, Contraseña, Rol, Codigo, Email) VALUES (@NombreUsuario, @Contraseña, @Rol, @Codigo, @Email)";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                command.Parameters.AddWithValue("@NombreUsuario", txtNombreEmpleado.Text);
                command.Parameters.AddWithValue("@Contraseña", contraseñaEncriptada);
                command.Parameters.AddWithValue("@Rol", "empleado");
                command.Parameters.AddWithValue("@Codigo", codigoVerificacion);
                command.Parameters.AddWithValue("@Email", txtEmailEmpleado.Text);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Empleado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpiar los campos después de la inserción si es necesario.
                        txtNombreEmpleado.Clear();
                        txtEmailEmpleado.Clear();
                        txtContraseñaEmpleado.Clear();
                        txtContraseñaEmpleado2.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }

            }



        }

        private void picNoVer_Click(object sender, EventArgs e)
        {
            if (txtContraseñaEmpleado.PasswordChar == '\0')
            {

                txtContraseñaEmpleado.PasswordChar = '*';  //cambia de nuevo a vista previa de password
            }
            if (txtContraseñaEmpleado2.PasswordChar == '\0')
            {

                txtContraseñaEmpleado2.PasswordChar = '*';  //cambia de nuevo a vista previa de password
            }
            picNoVer.Visible = false;
            picPass.Visible = true;

        }

        private void picPass_Click(object sender, EventArgs e)
        {
            if (txtContraseñaEmpleado.PasswordChar == '*')
            {

                txtContraseñaEmpleado.PasswordChar = '\0';
            }
            if (txtContraseñaEmpleado2.PasswordChar == '*')
            {

                txtContraseñaEmpleado2.PasswordChar = '\0'; 
            }

            picPass.Visible = false;
            picNoVer.Visible = true;

        }
    }
}
