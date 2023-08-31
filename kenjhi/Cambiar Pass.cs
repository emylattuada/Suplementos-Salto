using MySql.Data.MySqlClient;
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

namespace kenjhi
{
    public partial class Cambiar_Pass : Form
    {
        private string connectionString = "Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"; 

        public Cambiar_Pass()
        {
            InitializeComponent();
            //MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;");
            
            txtCambiarPassUser.Text = "Ingresa tu usuario";
            txtCambiarContra1.Text = "Nueva contraseña";
            txtCambiarContra2.Text = "Nueva contraseña";
            txtCambiarContra1.PasswordChar = '*';
            txtCambiarContra2.PasswordChar = '*';
            txtCambiarPassUser.ForeColor = System.Drawing.Color.DarkGray;
            txtCambiarContra1.ForeColor = System.Drawing.Color.DarkGray;
            txtCambiarContra2.ForeColor = System.Drawing.Color.DarkGray;




        }
        private int ClickX = 0, ClickY = 0;

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panelArribaCambiarPass_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                ClickX = e.X;
                ClickY = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X - ClickX);
                this.Top = this.Top + (e.Y - ClickY);
            }
        }

        private void btnGuardarNuevaPass_Click(object sender, EventArgs e)
        {
            string usuario = txtCambiarPassUser.Text.Trim();
            string nuevaContraseña = txtCambiarContra1.Text;
            string confirmarContraseña = txtCambiarContra2.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(nuevaContraseña) || string.IsNullOrEmpty(confirmarContraseña))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nuevaContraseña != confirmarContraseña)
            {
                lblError.Visible = true;
                
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string updateQuery = "UPDATE usuarios SET Contraseña = @nuevaContraseña WHERE NombreUsuario = @usuario";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@nuevaContraseña", nuevaContraseña);
                    command.Parameters.AddWithValue("@usuario", usuario);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Contraseña cambiada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                    }
                    else
                    {
                        lblError.Visible = true;
                        //SystemSounds.Hand.Play();
                        System.Media.SystemSounds.Exclamation.Play();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarFormulario()
        {
            txtCambiarPassUser.Clear();
            txtCambiarContra1.Clear();
            txtCambiarContra2.Clear();
            lblError.Visible = false;
        }
        private void txtCambiarPassUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCambiarPassUser.Text == "Ingresa tu usuario") { txtCambiarPassUser.Clear(); txtCambiarPassUser.ForeColor = System.Drawing.Color.White; }

            if (txtCambiarContra1.Text == "Nueva contraseña") { txtCambiarContra1.Clear(); txtCambiarContra1.ForeColor = System.Drawing.Color.White; }

            if (txtCambiarContra2.Text == "Nueva contraseña") { txtCambiarContra2.Clear(); txtCambiarContra2.ForeColor = System.Drawing.Color.White; }

        }
    }
}
