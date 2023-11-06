using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using System.Security.Cryptography; 
using System.Media;

namespace kenjhi
{
    public partial class frmCambiarPass : Form
    {
        public frmCambiarPass()
        {
            InitializeComponent();

        }
        private int ClickX = 0, ClickY = 0;

        private void btnVerificarCorreo_Click(object sender, EventArgs e)
        {
            string usuario = txtCambiarUsuario.Text;
            string correo = txtCambiarEmail.Text;
            txtNuevaContraseña.PasswordChar = '*';
            txtNuevaContraseña2.PasswordChar = '*';


            string connectionString = "Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM usuarios WHERE NombreUsuario = @Usuario AND email = @Email";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Email", correo);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Usuario y correo válidos.");
                        string correoOrigen = "info3emt@edusalto.uy"; 
                        string contraseniaOrigen = "info3emt21"; 
                        string correoDestino = txtCambiarEmail.Text; 
                        string codigo = GenerarCodigoVerificacion(); 
                        string mensaje = $"Tu código de verificación es: {codigo}";

                        try
                        {
                            enviarCorreo(correoOrigen, contraseniaOrigen, correoDestino, mensaje);
                            MessageBox.Show("Mensaje enviado al correo. Ingresa el código.");

                            string usuario2 = txtCambiarUsuario.Text;
                            ActualizarCodigoEnBaseDeDatos(usuario2, codigo);
                          
                            btnVerificarCodigo.Enabled = true;
                            txtCambiarCodigo.Enabled = true;
                            txtNuevaContraseña2.Enabled = true;
                            picPass.Enabled=true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al enviar el correo: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o correo no válidos.");
                    }
                }
            }
        }

       

        private void enviarCorreo(string emisor, string contrasenia, string receptor, string mensaje)
        {
            SmtpClient cliente = new SmtpClient();
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.Port = 587; 
            cliente.EnableSsl = false; 
            cliente.Credentials = new NetworkCredential(emisor, contrasenia);
            cliente.Host = "mail.edusalto.uy"; 

            MailMessage correo = new MailMessage();

            correo.To.Add(receptor);

            correo.Subject = "Código de verificación"; 
            correo.SubjectEncoding = Encoding.UTF8;

            correo.Body = mensaje;
            correo.BodyEncoding = Encoding.UTF8;
            correo.IsBodyHtml = true;

            correo.From = new MailAddress(emisor);

            cliente.Send(correo);
        }

        private void ActualizarCodigoEnBaseDeDatos(string usuario, string codigo)
        {
            string connectionString = "Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE usuarios SET codigo = @Codigo WHERE NombreUsuario = @Usuario";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                    }
                    else
                    {
                    }
                }
            }
        }

        private string GenerarCodigoVerificacion()
        {
            Random rand = new Random();
            int codigo = rand.Next(100000, 999999);
            return codigo.ToString();
        }

        private void btnVerificarCodigo_Click(object sender, EventArgs e)
        {
            string correo = txtCambiarEmail.Text;
            string codigoIngresado = txtCambiarCodigo.Text;
            string connectionString = "Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT codigo FROM usuarios WHERE email = @Email";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", correo);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string codigoBaseDeDatos = result.ToString();

                        if (codigoIngresado == codigoBaseDeDatos)
                        {
                            MessageBox.Show("Código válido. Puede ingresar la nueva contraseña.", "Código Validado");
                            txtNuevaContraseña.Enabled = true;
                            btnGuardarNuevaContraseña.Enabled=true;

                        }
                        else
                        {
                            MessageBox.Show("El código no es válido.");
                        }
                    }
                    else
                    {
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnGuardarNuevaContraseña_Click(object sender, EventArgs e)
        {
           
            if (txtNuevaContraseña.Text == txtNuevaContraseña2.Text)
            {
                string connectionString = "Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;";

                try
                {

                    string usuario = txtCambiarUsuario.Text;
                    string nuevaContraseña = txtNuevaContraseña.Text;

                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes(nuevaContraseña);
                        byte[] hash = sha256.ComputeHash(bytes);
                        nuevaContraseña = BitConverter.ToString(hash).Replace("-", "").ToLower();
                    }

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string consulta = "UPDATE usuarios SET Contraseña = @NuevaContraseña WHERE NombreUsuario = @Usuario";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                        {
                            cmd.Parameters.AddWithValue("@NuevaContraseña", nuevaContraseña);
                            cmd.Parameters.AddWithValue("@Usuario", usuario);

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Contraseña actualizada con éxito, reinicie la sesión.");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar la contraseña. Verifica el usuario.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void picPass_Click(object sender, EventArgs e)
        {

            if (txtNuevaContraseña.PasswordChar == '*')
            {
                
                txtNuevaContraseña.PasswordChar = '\0'; 
            }
            if (txtNuevaContraseña2.PasswordChar == '*')
            {

                txtNuevaContraseña2.PasswordChar = '\0'; 
            }

            picPass.Visible = false;
            picNoVer.Visible = true;
        }

        private void picNoVer_Click(object sender, EventArgs e)
        {
            if (txtNuevaContraseña.PasswordChar == '\0')
            {

                txtNuevaContraseña.PasswordChar = '*';  
            }
            if (txtNuevaContraseña2.PasswordChar == '\0')
            {

                txtNuevaContraseña2.PasswordChar = '*';  
            }
            picNoVer.Visible = false;
            picPass.Visible = true;
        }

        

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
