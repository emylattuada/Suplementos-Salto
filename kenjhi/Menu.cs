using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using static kenjhi.formLogin;

namespace kenjhi
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            customizeDesign();
            



        }




        private void customizeDesign()
        {

            panelClientesSubmenu.Visible= false;
            panelMenuSubmenu.Visible= false;
            panelPedidosSubmenu.Visible= false;
        }

        private void hideSubMenu()
        {

            if (panelClientesSubmenu.Visible==true)
                panelClientesSubmenu.Visible = false;
            if(panelMenuSubmenu.Visible==true) 
                panelMenuSubmenu.Visible = false;
            if(panelPedidosSubmenu.Visible ==true)
                panelPedidosSubmenu.Visible=false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible==false)
            {
                hideSubMenu();
                subMenu.Visible=true;
            }
            else
                subMenu.Visible=false;

        }


        private int ClickX = 0, ClickY = 0;


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientesSubmenu);
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            
            openChildForm(new Agregar_Clientes());
            hideSubMenu();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new Ver_Clientes());
            hideSubMenu();

        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new Ver_Clientes());
            hideSubMenu();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuSubmenu);

        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            openChildForm(new Agregar_Producto());
            hideSubMenu();

        }

        private void btnModificarMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new Ver_Productos());
            hideSubMenu();

        }

        private void btnVerMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
    
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPedidosSubmenu);

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

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToString("dddd, d 'de' MMMM yyyy");
        }

        private Form activeForm = null;

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            openChildForm(new Nuevo_Pedido());
        }

        private void SeccionAdmin_Click(object sender, EventArgs e)
        {
            openChildForm(new Modo_Administrador()); //cambiar al form que debo crear

        }

        

        private void labelADM_Click(object sender, EventArgs e)
        {
            openChildForm(new Modo_Administrador()); //cambiar al form que debo crear

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            openChildForm(new Modo_Administrador()); //cambiar al form que debo crear

        }

        private void btnVersion_Click(object sender, EventArgs e)
        {
            openChildForm(new Version());
        }

        private void btnIngresoProductos_Click(object sender, EventArgs e)
        {
            openChildForm(new Ingresos_Producto());

        }

        private void openChildForm(Form childform)
        {
            if(activeForm != null)
            
                activeForm.Close();
                activeForm = childform;
                childform.TopLevel = false;
                childform.FormBorderStyle = FormBorderStyle.None;
                childform.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childform);
                panelChildForm.Tag = childform;
                childform.BringToFront();
                childform.Show();

            

        }
    }
}
