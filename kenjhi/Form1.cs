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
            try
            {
                lbl1.Visible = false; // Restablece el estado de lbl1 antes de verificar el acceso

                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;");
                conexion.Open();

                MySqlCommand comandos = new MySqlCommand();
                comandos.Connection = conexion;

                string consulta = "SELECT NombreUsuario, Contraseña FROM usuarios WHERE NombreUsuario = '" + txtUsuario.Text + "' AND Contraseña = '" + txtContrasena.Text + "'";

                comandos.CommandText = consulta;
                MySqlDataReader datos = comandos.ExecuteReader();

                if (datos.Read())
                {
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    lbl1.Visible = true; // Muestra el mensaje de error si el acceso es denegado
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\nIngrese algo correcto");
            }
        }

        public static class Utilidad
        {
            public static string NombreUsuarioActual { get; set; }
        }


        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            {

                try
                {
                    MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;");
                    conexion.Open();

                    MySqlCommand comandos = new MySqlCommand();
                    comandos.Connection = conexion;

                    string consulta = "SELECT NombreUsuario, Contraseña FROM usuarios WHERE NombreUsuario = '" + txtUsuario.Text + "' AND Contraseña = '" + txtContrasena.Text + "'";

                    comandos.CommandText = consulta;
                    MySqlDataReader datos = comandos.ExecuteReader();

                    if (datos.Read())
                    {
                        //MessageBox.Show("Bienvenido " + datos["nombre_usuario"] + "\nTu contraseña es: " + datos["contrasena"]);

                        frmPrincipal principal = new frmPrincipal();
                        principal.Show();
                        this.Hide();
                        lbl1.Visible = false;
                    }
                    else
                    {
                        lbl1.Visible = true;
                        //MessageBox.Show("Acceso Denegado");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "\nIngrese algo correcto");
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
           //pendiente
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
