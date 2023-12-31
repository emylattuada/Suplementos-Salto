﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

            string nombreUsuario = txtUsuario.Text;
            string contraseñaIngresada = txtContrasena.Text;
            string contraseñaEncriptada = EncriptarContraseña(contraseñaIngresada);
            string cadenaConexion = "Server=localhost;Database=suple;Uid=suple_admin;Pwd=supleadmin2023!_saltocentro;";
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            try
            {
                conexion.Open();

                string consulta = "SELECT Rol FROM usuarios WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña AND Visible = 1";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@Contraseña", contraseñaEncriptada);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string rol = reader["Rol"].ToString();

                        if (rol == "Admin")
                        {
                            frmMenu_Admin formAdmin = new frmMenu_Admin();
                            formAdmin.Show();
                            this.Hide();
                        }
                        else if (rol == "Empleado")
                        {
                            frmMenu_Empleados formEmpleado = new frmMenu_Empleados();
                            formEmpleado.Show();
                            this.Hide();
                        }
                        else
                        {
                            lbl1.Visible = true;
                        }
                    }
                    else
                    {
                        lbl1.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }

        private string EncriptarContraseña(string contraseña)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)){
                string nombreUsuario = txtUsuario.Text;
                string contraseñaIngresada = txtContrasena.Text;
                string contraseñaEncriptada = EncriptarContraseña(contraseñaIngresada);
                string cadenaConexion = "Server=localhost;Database=suple;Uid=suple_admin;Pwd=supleadmin2023!_saltocentro;";
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);

                try
                {
                    conexion.Open();

                    string consulta = "SELECT Rol FROM usuarios WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@Contraseña", contraseñaEncriptada);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string rol = reader["Rol"].ToString();

                            if (rol == "Admin")
                            {
                                frmMenu_Admin formAdmin = new frmMenu_Admin();
                                formAdmin.Show();
                                this.Hide();
                            }
                            else if (rol == "Empleado")
                            {
                                frmMenu_Empleados formEmpleado = new frmMenu_Empleados();
                                formEmpleado.Show();
                                this.Hide();
                            }
                            else
                            {
                                lbl1.Visible = true;
                            }
                        }
                        else
                        {
                            lbl1.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
                }
                finally
                {
                }

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void linkCambiarPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCambiarPass formCambiarContrasenia = new frmCambiarPass();
            formCambiarContrasenia.Show();
        }

        private void picPass_Click(object sender, EventArgs e)
        {
            if (txtContrasena.PasswordChar == '*')
            {
                txtContrasena.PasswordChar = '\0'; 
            }
           
            picPass.Visible=false;
            picNoVer.Visible = true;
        }

        private void picNoVer_Click(object sender, EventArgs e)
        {
            if (txtContrasena.PasswordChar == '\0')
            {
               
                txtContrasena.PasswordChar = '*'; 
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
