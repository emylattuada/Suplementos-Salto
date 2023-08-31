using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kenjhi
{
    public partial class Cambiar_Pass : Form
    {
        public Cambiar_Pass()
        {
            InitializeComponent();
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

        private void txtCambiarPassUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCambiarPassUser.Text == "Ingresa tu usuario") { txtCambiarPassUser.Clear(); txtCambiarPassUser.ForeColor = System.Drawing.Color.White; }

            if (txtCambiarContra1.Text == "Nueva contraseña") { txtCambiarContra1.Clear(); txtCambiarContra1.ForeColor = System.Drawing.Color.White; }

            if (txtCambiarContra2.Text == "Nueva contraseña") { txtCambiarContra2.Clear(); txtCambiarContra2.ForeColor = System.Drawing.Color.White; }

        }
    }
}
