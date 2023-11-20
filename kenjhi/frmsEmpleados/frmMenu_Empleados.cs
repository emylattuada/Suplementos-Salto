using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kenjhi.frmsAdmin;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using static kenjhi.formLogin;

namespace kenjhi
{
    public partial class frmMenu_Empleados : Form
    {
        public frmMenu_Empleados()
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
            
            openChildForm(new frmAgregarCliente_Empleados());
            hideSubMenu();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVerClientes_Empleados());
            hideSubMenu();

        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVerClientes_Admin());
            hideSubMenu();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuSubmenu);

        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAgregarProducto_Empleados());
            hideSubMenu();

        }

        private void btnModificarMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVerProducto_Empleados());
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
            openChildForm(new frmNuevaVenta_Empleados());
            hideSubMenu();

        }

        private void SeccionAdmin_Click(object sender, EventArgs e)
        {
            
            
        }

        

        private void labelADM_Click(object sender, EventArgs e)
        {
            
           

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnVersion_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVersion());
        }

        private void btnIngresoProductos_Click(object sender, EventArgs e)
        {
            openChildForm(new frmIngresosProducto_Empleados());
            hideSubMenu();


        }

       

       

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVerVentas_Empleados());
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVerIngresosProductos_Empleados());
            hideSubMenu();
        }

        private void btnVerCategorias_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAgregarCategoria_Empleados());
            hideSubMenu();
        }

       

        private void btnADM_Imprimir_Click(object sender, EventArgs e)
        {
            
        }

        public void openChildForm(Form childform)
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

        private void btnAgregarCliente_MouseEnter(object sender, EventArgs e)
        {
            CambioColorEntrar(btnAgregarCliente);
        }

        private void CambioColorEntrar(Button boton) {
        
        boton.BackColor = Color.Black;
        boton.ForeColor = Color.Yellow;

        }

        private void btnAgregarCliente_MouseLeave(object sender, EventArgs e)
        {
            CambioColorSalir(btnAgregarCliente);

        }

        private void btnModificarCliente_MouseEnter(object sender, EventArgs e)
        {
            CambioColorEntrar(btnModificarCliente);

        }

        private void btnModificarCliente_MouseLeave(object sender, EventArgs e)
        {
            CambioColorSalir(btnModificarCliente);

        }

        private void btnAgregarPlato_MouseEnter(object sender, EventArgs e)
        {
            CambioColorEntrar(btnAgregarPlato);

        }

        private void btnAgregarPlato_MouseLeave(object sender, EventArgs e)
        {
            CambioColorSalir(btnAgregarPlato);

        }

        private void btnModificarMenu_MouseEnter(object sender, EventArgs e)
        {
            CambioColorEntrar(btnModificarMenu);

        }

        private void btnModificarMenu_MouseLeave(object sender, EventArgs e)
        {
            CambioColorSalir(btnModificarMenu);

        }

        private void btnIngresoProductos_MouseEnter(object sender, EventArgs e)
        {
            CambioColorEntrar(btnIngresoProductos);

        }

        private void btnIngresoProductos_MouseLeave(object sender, EventArgs e)
        {
            CambioColorSalir(btnIngresoProductos);

        }

        private void btnAgregarCategoria_MouseEnter(object sender, EventArgs e)
        {
            CambioColorEntrar(btnAgregarCategoria);
        }

        private void btnAgregarCategoria_MouseLeave(object sender, EventArgs e)
        {
            CambioColorSalir(btnAgregarCategoria);
        }

        private void btnVerCategorias_MouseEnter(object sender, EventArgs e)
        {
            CambioColorEntrar(btnAgregarCategorias);
        }

        private void btnVerCategorias_MouseLeave(object sender, EventArgs e)
        {
            CambioColorSalir(btnAgregarCategorias);
        }

        private void btnNuevoPedido_MouseEnter(object sender, EventArgs e)
        {
            CambioColorEntrar(btnNuevoPedido);
        }

        private void btnNuevoPedido_MouseLeave(object sender, EventArgs e)
        {
            CambioColorSalir(btnNuevoPedido);
        }

        private void btnVerPedidos_MouseEnter(object sender, EventArgs e)
        {
            CambioColorEntrar(btnVerPedidos);
        }

        private void btnVerPedidos_MouseLeave(object sender, EventArgs e)
        {
            CambioColorSalir(btnVerPedidos);
        }

       

       

        private void btnVerCategorias_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmVerCategorias_Empleados());
            hideSubMenu();
        }

        private void btnVerCategorias_MouseEnter_1(object sender, EventArgs e)
        {
            CambioColorEntrar(btnVerCategorias);
        }

        private void btnVerCategorias_MouseLeave_1(object sender, EventArgs e)
        {
            CambioColorSalir(btnVerCategorias);
        }

        private void btnDeudores_Click(object sender, EventArgs e)
        {
            openChildForm(new frmClientesDeudores_Empleados());
            hideSubMenu();
        }

        private void btnDeudores_MouseEnter(object sender, EventArgs e)
        {
            CambioColorEntrar(btnDeudores);
        }

        private void btnDeudores_MouseLeave(object sender, EventArgs e)
        {
            CambioColorSalir(btnDeudores);
        }

        

        private void CambioColorSalir(Button boton)
        {
            boton.BackColor= Color.FromArgb(255, 255, 128);
            boton.ForeColor = Color.Black;

        }
    }
}
