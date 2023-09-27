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
using System.Media;

namespace kenjhi
{
    public partial class Cambiar_Pass : Form
    {
        public Cambiar_Pass()
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


            string connectionString = "Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;";
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
                        //txtCambiarCodigo.Enabled = true;
                        //btnEnviarCodigo.Enabled = true; este btn lo eliminamos
                        //txtCambiarCodigo.Visible= true;
                        string correoOrigen = "info3emt@edusalto.uy"; // Correo de origen
                        string contraseniaOrigen = "info3emt21"; // Contraseña del correo de origen
                        string correoDestino = txtCambiarEmail.Text; // Correo de destino
                        string codigo = GenerarCodigoVerificacion(); // Genera el código de verificación

                        string mensaje = $"Tu código de verificación es: {codigo}";

                        try
                        {
                            enviarCorreo(correoOrigen, contraseniaOrigen, correoDestino, mensaje);
                            MessageBox.Show("Mensaje enviado al correo. Ingresa el código.");

                            // Actualizar el código en la base de datos
                            string usuario2 = txtCambiarUsuario.Text;
                            ActualizarCodigoEnBaseDeDatos(usuario2, codigo);
                            //btnEnviarCodigo.Visible=false;
                            //btnVerificarCodigo.Visible = true;
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

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            //string correoOrigen = "info3emt@edusalto.uy"; // Correo de origen
            //string contraseniaOrigen = "info3emt21"; // Contraseña del correo de origen
            //string correoDestino = txtCambiarEmail.Text; // Correo de destino
            //string codigo = GenerarCodigoVerificacion(); // Genera el code de verificar

            //string mensaje = $"Tu código de verificación es: {codigo}";

            //try
            //{
            //    enviarCorreo(correoOrigen, contraseniaOrigen, correoDestino, mensaje);
            //    MessageBox.Show("Mensaje enviado al correo. Ingresa el código de 6 dígitos.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error al enviar el correo: {ex.Message}");
            //}

            //string correoOrigen = "info3emt@edusalto.uy"; // Correo de origen
            //string contraseniaOrigen = "info3emt21"; // Contraseña del correo de origen
            //string correoDestino = txtCambiarEmail.Text; // Correo de destino
            //string codigo = GenerarCodigoVerificacion(); // Genera el código de verificación

            //string mensaje = $"Tu código de verificación es: {codigo}";

            //try
            //{
            //    enviarCorreo(correoOrigen, contraseniaOrigen, correoDestino, mensaje);
            //    MessageBox.Show("Mensaje enviado al correo. Ingresa el código.");

            //    // Actualizar el código en la base de datos
            //    string usuario = txtCambiarUsuario.Text;
            //    ActualizarCodigoEnBaseDeDatos(usuario, codigo);
            //    //btnEnviarCodigo.Visible=false;
            //    btnVerificarCodigo.Visible=true;   
            //    txtCambiarCodigo.Enabled=true;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error al enviar el correo: {ex.Message}");
            //}
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

            correo.Subject = "Código de verificación"; // Asunto del correo
            correo.SubjectEncoding = Encoding.UTF8;

            correo.Body = mensaje;
            correo.BodyEncoding = Encoding.UTF8;
            correo.IsBodyHtml = true;

            correo.From = new MailAddress(emisor);

            cliente.Send(correo);
        }

        private void ActualizarCodigoEnBaseDeDatos(string usuario, string codigo)
        {
            string connectionString = "Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;";
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
                        //MessageBox.Show("Código actualizado en la base de datos.");
                    }
                    else
                    {
                        //MessageBox.Show("No se pudo actualizar el código en la base de datos.");
                    }
                }
            }
        }

        private string GenerarCodigoVerificacion()
        {
            // generamos un codigo aleatorio para reponerlo en la bd, proximamente agregado
            Random rand = new Random();
            int codigo = rand.Next(100000, 999999);
            return codigo.ToString();
        }

        private void btnVerificarCodigo_Click(object sender, EventArgs e)
        {
            string correo = txtCambiarEmail.Text;
            string codigoIngresado = txtCambiarCodigo.Text;
            string connectionString = "Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;";
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
                            //MessageBox.Show("El código es válido.");
                            MessageBox.Show("Código válido. Puede ingresar la nueva contraseña.", "Código Validado");
                            //y habilitamos los ultimos txt y boton para poder subir esos datos a la bd y terminar el cambio de password
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
                        //MessageBox.Show("El correo no está registrado en la base de datos."); esto no lo vamos a usar, pero lo puse para poder darme cuenta si se cargaba o no sin ir al localhost
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
            string usuario = txtCambiarUsuario.Text;
            string nuevaContraseña = txtNuevaContraseña.Text;

            // Realiza la actualización de la contraseña en la base de datos
            if(txtNuevaContraseña.Text == txtNuevaContraseña2.Text)
            {

                string connectionString = "Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE usuarios SET Contraseña = SHA(@NuevaContraseña) WHERE NombreUsuario = @Usuario";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@NuevaContraseña", nuevaContraseña);
                        cmd.Parameters.AddWithValue("@Usuario", usuario);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            SystemSounds.Asterisk.Play();
                            MessageBox.Show("Contraseña actualizada. Inicia sesión nuevamente.", "Contraseña Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            SystemSounds.Exclamation.Play();
                            MessageBox.Show("No se pudo actualizar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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

                txtNuevaContraseña2.PasswordChar = '\0'; //era mejor poner un yy pero asi tambien esta simple, lo dejamos asi
            }

            picPass.Visible = false;
            picNoVer.Visible = true;
        }

        private void picNoVer_Click(object sender, EventArgs e)
        {
            if (txtNuevaContraseña.PasswordChar == '\0')
            {

                txtNuevaContraseña.PasswordChar = '*';  //cambia de nuevo a vista previa de password
            }
            if (txtNuevaContraseña2.PasswordChar == '\0')
            {

                txtNuevaContraseña2.PasswordChar = '*';  //cambia de nuevo a vista previa de password
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
