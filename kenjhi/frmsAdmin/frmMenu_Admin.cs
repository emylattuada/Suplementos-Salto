using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using kenjhi.frmsAdmin;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using static kenjhi.formLogin;

namespace kenjhi
{
    public partial class frmMenu_Admin : Form
    {
        string connectionString = "Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;";
        private string originalNombreUsuario;
        private string originalEmail;
        public frmMenu_Admin()
        {
            InitializeComponent();
            customizeDesign();
            picturePerfil = new PictureBox();
            picturePerfil.Size = new Size(100, 100); 
            picturePerfil.SizeMode = PictureBoxSizeMode.Zoom; 
            picturePerfil.Image = Properties.Resources.perfil_menu_adm; 
            picturePerfil.Paint += pictureBox5_Paint;
            ObtenerDatosAdmin();

        }

        

        private void ObtenerDatosAdmin()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    string consulta = "SELECT NombreUsuario, email FROM usuarios WHERE Rol = 'Admin' AND Visible = 1 LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                originalNombreUsuario = reader["NombreUsuario"].ToString();
                                originalEmail = reader["email"].ToString();

                                txtNombreUsuario.Text = originalNombreUsuario;
                                txtEmail.Text = originalEmail;
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron datos para el rol de Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customizeDesign()
        {

            panelClientesSubmenu.Visible= false;
            panelMenuSubmenu.Visible= false;
            panelPedidosSubmenu.Visible= false;
            panelSubMenuADM.Visible= false;
        }

        


        private void hideSubMenu()
        {

            if (panelClientesSubmenu.Visible==true)
                panelClientesSubmenu.Visible = false;
            if(panelMenuSubmenu.Visible==true) 
                panelMenuSubmenu.Visible = false;
            if(panelPedidosSubmenu.Visible ==true)
                panelPedidosSubmenu.Visible=false;
            if (panelSubMenuADM.Visible == true)
                panelSubMenuADM.Visible = false;
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
            
            openChildForm(new frmAgregarCliente_Admin());
            hideSubMenu();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVerClientes_Admin());
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
            openChildForm(new frmNuevaVenta_Admin());
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
            openChildForm(new frmIngresosProducto_Admin());
            hideSubMenu();


        }

        private void btnAdm_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuADM);


        }

        private void btnADM_AgregarEmpleado_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAgregarEmpleado_Admin());
            hideSubMenu();

        }

        private void btnADM_VerEmpleados_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVerEmpleados_Admin());
            hideSubMenu();
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVerVentas_Admin());
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVerIngresosProductos_Admin());
            hideSubMenu();
        }

        private void btnVerCategorias_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAgregarCategoria_Admin());
            hideSubMenu();
        }

        private void btnRecuperarDatos_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRecuperarDatos_Admin());
            hideSubMenu();
        }

        private void btnADM_Estadisticas_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEstadisticas_Admin());
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

       

        private void btnADM_AgregarEmpleado_MouseEnter(object sender, EventArgs e)
        {
            CambioColorEntrar(btnADM_AgregarEmpleado);
        }

        private void btnADM_AgregarEmpleado_MouseLeave(object sender, EventArgs e)
        {
            CambioColorSalir(btnADM_AgregarEmpleado);
        }

        private void btnADM_VerEmpleados_MouseEnter(object sender, EventArgs e)
        {
            CambioColorEntrar(btnADM_VerEmpleados);
        }

        private void btnADM_VerEmpleados_MouseLeave(object sender, EventArgs e)
        {
            CambioColorSalir(btnADM_VerEmpleados);
        }

        private void btnADM_Estadisticas_MouseEnter(object sender, EventArgs e)
        {
            CambioColorEntrar(btnADM_Estadisticas);
        }

        private void btnADM_Estadisticas_MouseLeave(object sender, EventArgs e)
        {
            CambioColorSalir(btnADM_Estadisticas);
        }

        private void btnRecuperarDatos_MouseEnter(object sender, EventArgs e)
        {
            CambioColorEntrar(btnRecuperarDatos);
        }

        private void btnRecuperarDatos_MouseLeave(object sender, EventArgs e)
        {
            CambioColorSalir(btnRecuperarDatos);
        }

        private void btnVerCategorias_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmVerCategorias_Admin());
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
            openChildForm(new frmClientesDeudores_Admin());
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

        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picturePerfil_Click(object sender, EventArgs e)
        {
            panelCuenta.Visible = !panelCuenta.Visible;

        }

        private void linkNombre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtNombreUsuario.Enabled = true;
            btnGuardar.Enabled = true;
            txtNombreUsuario.ForeColor= Color.Black;
        }

        private void linkCorreo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEmail.Enabled = true;
            btnGuardar.Enabled = true;
            txtEmail.ForeColor = Color.Black;


        }

        private void panelCuenta_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radio = 50; 
                path.AddArc(0, 0, radio, radio, 180, 90);
                path.AddArc(panelCuenta.Width - radio, 0, radio, radio, 270, 90);
                path.AddArc(panelCuenta.Width - radio, panelCuenta.Height - radio, radio, radio, 0, 90);
                path.AddArc(0, panelCuenta.Height - radio, radio, radio, 90, 90);
                panelCuenta.Region = new Region(path);
            }
        }

        private void pictureCerrarSesion_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void linkCambiarPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCambiarPass formCambiarContrasenia = new frmCambiarPass();
            formCambiarContrasenia.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text.Length > 45) {

                MessageBox.Show("El nombre de usuario contiene demasiados caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            
            }

            if (txtEmail.Text.Length > 35)
            {
                MessageBox.Show("El correo eléctronico ingresado contiene demasiados caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nuevoNombreUsuario = txtNombreUsuario.Text;
            string nuevoEmail = txtEmail.Text;

            if (!string.IsNullOrEmpty(nuevoEmail) && !Regex.IsMatch(nuevoEmail, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nuevoNombreUsuario == originalNombreUsuario && nuevoEmail == originalEmail)
            {
                MessageBox.Show("No has cambiado ningún dato. Realiza cambios antes de actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    string consulta = "UPDATE usuarios SET NombreUsuario = @NombreUsuario, email = @Email WHERE Rol = 'Admin' AND Visible = 1";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", nuevoNombreUsuario);
                        cmd.Parameters.AddWithValue("@Email", nuevoEmail);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Datos actualizados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNombreUsuario.Enabled = false;
                            txtEmail.Enabled = false;

                            originalNombreUsuario = nuevoNombreUsuario;
                            originalEmail = nuevoEmail;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al actualizar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CambioColorSalir(Button boton)
        {
            boton.BackColor= Color.FromArgb(255, 255, 128);
            boton.ForeColor = Color.Black;

        }
    }
}
