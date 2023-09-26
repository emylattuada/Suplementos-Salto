using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kenjhi
{
    public partial class Enviar_Opinion : Form
    {
        public Enviar_Opinion()
        {
            InitializeComponent();
            //string nombre = txtNombreSugerencia.Text;
            //string sugerencia = txtSugerencia.Text;
            txtSugerencia.Text="Ingresa aquí tu sugerencia para el equipo de desarrollo";
            txtSugerencia.ForeColor = System.Drawing.Color.DarkGray;

        }
        private int ClickX = 0, ClickY = 0;
        
        private void pictureBox2_Click(object sender, EventArgs e) //los nombres de estos picturebox los dejamos default, no son de tanta relevancia
        {
            this.Close();
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

        private void txtSugerencia_TextChanged(object sender, EventArgs e)
        {
            //sin usar
        }

        private void txtSugerencia_Click(object sender, EventArgs e)
        {
            if (txtSugerencia.Text == "Ingresa aquí tu sugerencia para el equipo de desarrollo") { txtSugerencia.ForeColor = System.Drawing.Color.White; }
            txtSugerencia.Clear();
        }

        private void btnEnviarSugerencia_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreSugerencia.Text;
            string sugerencia = txtSugerencia.Text;
            string correoOrigen = "info3emt@edusalto.uy"; 
            string contraseniaOrigen = "info3emt21"; 
            string correoDestino = "infinity.codeuy@gmail.com";
            string mensaje = $"Sugerencia para el equipo de desarrollo, enviada por: " + nombre  + "Sugerencia: " + sugerencia;
            enviarCorreo(correoOrigen, contraseniaOrigen, correoDestino, mensaje);
            MessageBox.Show("¡Sugerencia enviada con éxito!");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

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

            correo.Subject = "Nueva sugerencia - Aplicación Suplementos Salto"; // Asunto del correo
            correo.SubjectEncoding = Encoding.UTF8;

            correo.Body = mensaje;
            correo.BodyEncoding = Encoding.UTF8;
            correo.IsBodyHtml = true;

            correo.From = new MailAddress(emisor);

            cliente.Send(correo);
        } //codigo reciclado de cambiar pass form 

    }
}
