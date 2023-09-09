using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kenjhi
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            txtUsuario.Text = "Ingresa tu usuario";
            txtContrasena.Text = "Ingresa tu contraseña";
            txtUsuario.ForeColor = System.Drawing.Color.DarkGray;
            txtContrasena.ForeColor= System.Drawing.Color.DarkGray;
            txtContrasena.PasswordChar = '*';

        }
        private int ClickX = 0, ClickY = 0;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsuario.Text=="Ingresa tu usuario") { txtUsuario.Clear(); txtUsuario.ForeColor = System.Drawing.Color.White; }
            
            if (txtContrasena.Text == "Ingresa tu contraseña") { txtContrasena.Clear(); txtContrasena.ForeColor = System.Drawing.Color.White; }


        }

        private void txtContrasena_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingresa tu usuario") { txtUsuario.Clear(); txtUsuario.ForeColor = System.Drawing.Color.White; }

            if (txtContrasena.Text == "Ingresa tu contraseña") { txtContrasena.Clear(); txtContrasena.ForeColor = System.Drawing.Color.White; }
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    lbl1.Visible = false; // Restablece el estado de lbl1 antes de verificar el acceso

            //    MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;");
            //    conexion.Open();

            //    MySqlCommand comandos = new MySqlCommand();
            //    comandos.Connection = conexion;

            //    string consulta = "SELECT NombreUsuario, Contraseña FROM usuarios WHERE NombreUsuario = '" + txtUsuario.Text + "' AND Contraseña = '" + txtContrasena.Text + "'";

            //    comandos.CommandText = consulta;
            //    MySqlDataReader datos = comandos.ExecuteReader();

            //    if (datos.Read())
            //    {
            //        frmPrincipal principal = new frmPrincipal();
            //        principal.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        lbl1.Visible = true; // Muestra el mensaje de error si el acceso es denegado
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString() + "\nIngrese algo correcto");
            //} //comente esto para probar otro codigo

            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            string rol = "";

            string connectionString = "Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para verificar el usuario y obtener el rol
                    string query = "SELECT Rol FROM usuarios WHERE NombreUsuario = @Usuario AND Contraseña = @Contrasena";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        rol = reader["Rol"].ToString();

                        if (rol == "admin")
                        {
                            // Abre el Form1
                            frmPrincipal formAdmin= new frmPrincipal();
                            formAdmin.Show();
                            this.Hide();

                        }
                        else if (rol == "empleado")
                        {
                            // Abre el Form2
                            prueba formEmpleado = new prueba();
                            formEmpleado.Show();
                            this.Hide();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }
        }

        public static class Utilidad
        {
            public static string NombreUsuarioActual { get; set; }
        }//sin utilidad aun


        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            {

                //try
                //{
                //    MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;");
                //    conexion.Open();

                //    MySqlCommand comandos = new MySqlCommand();
                //    comandos.Connection = conexion;

                //    string consulta = "SELECT NombreUsuario, Contraseña FROM usuarios WHERE NombreUsuario = '" + txtUsuario.Text + "' AND Contraseña = '" + txtContrasena.Text + "'";

                //    comandos.CommandText = consulta;
                //    MySqlDataReader datos = comandos.ExecuteReader();

                //    if (datos.Read())
                //    {
                //        //MessageBox.Show("Bienvenido " + datos["nombre_usuario"] + "\nTu contraseña es: " + datos["contrasena"]);

                //        frmPrincipal principal = new frmPrincipal();
                //        principal.Show();
                //        this.Hide();
                //        lbl1.Visible = false;
                //    }
                //    else
                //    {
                //        lbl1.Visible = true;
                //        //MessageBox.Show("Acceso Denegado");
                //    }

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.ToString() + "\nIngrese algo correcto");
                //}

                string usuario = txtUsuario.Text;
                string contrasena = txtContrasena.Text;
                string rol = "";

                string connectionString = "Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Consulta para verificar el usuario y obtener el rol
                        string query = "SELECT Rol FROM usuarios WHERE NombreUsuario = @Usuario AND Contraseña = @Contrasena";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            rol = reader["Rol"].ToString();

                            if (rol == "admin")
                            {
                                //para adm
                                frmPrincipal formAdmin = new frmPrincipal();
                                formAdmin.Show();
                                this.Hide();
                            }
                            else if (rol == "empleado")
                            {
                                //form normal
                                prueba formEmpleado = new prueba();
                                formEmpleado.Show();
                                this.Hide();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Credenciales incorrectas");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error de conexión: " + ex.Message);
                    }
                }

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void linkCambiarPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cambiar_Pass formCambiarContrasenia = new Cambiar_Pass();
            formCambiarContrasenia.Show();
        }

        private void picPass_Click(object sender, EventArgs e)
        {
            if (txtContrasena.PasswordChar == '*')
            {
                // Cambia el carácter de contraseña a texto normal
                txtContrasena.PasswordChar = '\0'; // '\0' representa el carácter nulo
            }
            //else
            //{
            //    // Cambia el carácter de contraseña de vuelta a '*'
            //    txtContrasena.PasswordChar = '*';
            //}
            picPass.Visible=false;
            picNoVer.Visible = true;
        }

        private void picNoVer_Click(object sender, EventArgs e)
        {
            if (txtContrasena.PasswordChar == '\0')
            {
               
                txtContrasena.PasswordChar = '*';  //cambia de nuevo a vista previa de password
            }
            picNoVer.Visible = false;
            picPass.Visible = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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



    }
}
