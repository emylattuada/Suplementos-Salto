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

namespace kenjhi
{
    public partial class Cambiar_Pass : Form
    {
        public Cambiar_Pass()
        {
            InitializeComponent();
        }

        private void btnVerificarCorreo_Click(object sender, EventArgs e)
        {
            string usuario = txtCambiarUsuario.Text;
            string correo = txtCambiarEmail.Text;

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
                        txtCambiarCodigo.Enabled = true;
                        btnEnviarCodigo.Enabled = true;
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
            string correoOrigen = "info3emt@edusalto.uy"; // Correo de origen
            string contraseniaOrigen = "info3emt21"; // Contraseña del correo de origen
            string correoDestino = txtCambiarEmail.Text; // Correo de destino
            string codigo = GenerarCodigoVerificacion(); // Genera el code de verificar

            string mensaje = $"Tu código de verificación es: {codigo}";

            try
            {
                enviarCorreo(correoOrigen, contraseniaOrigen, correoDestino, mensaje);
                MessageBox.Show("Mensaje enviado al correo. Ingresa el código de 6 dígitos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}");
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

            correo.Subject = "Código de verificación"; // Asunto del correo
            correo.SubjectEncoding = Encoding.UTF8;

            correo.Body = mensaje;
            correo.BodyEncoding = Encoding.UTF8;
            correo.IsBodyHtml = true;

            correo.From = new MailAddress(emisor);

            cliente.Send(correo);
        }

        private string GenerarCodigoVerificacion()
        {
            // generamos un codigo aleatorio para reponerlo en la bd, proximamente agregado
            Random rand = new Random();
            int codigo = rand.Next(100000, 999999);
            return codigo.ToString();
        }
    }
}
