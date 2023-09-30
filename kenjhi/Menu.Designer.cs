namespace kenjhi
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSubMenuADM = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnADM_AgregarEmpleado = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            this.btnVersion = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelPedidosSubmenu = new System.Windows.Forms.Panel();
            this.btnVerPedidos = new System.Windows.Forms.Button();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.panelMenuSubmenu = new System.Windows.Forms.Panel();
            this.btnIngresoProductos = new System.Windows.Forms.Button();
            this.btnModificarMenu = new System.Windows.Forms.Button();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelClientesSubmenu = new System.Windows.Forms.Panel();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenuADM.SuspendLayout();
            this.panelPedidosSubmenu.SuspendLayout();
            this.panelMenuSubmenu.SuspendLayout();
            this.panelClientesSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 25);
            this.panel2.TabIndex = 3;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Menú principal";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(800, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(823, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Yellow;
            this.panelSideMenu.Controls.Add(this.panelSubMenuADM);
            this.panelSideMenu.Controls.Add(this.btnAdm);
            this.panelSideMenu.Controls.Add(this.btnVersion);
            this.panelSideMenu.Controls.Add(this.btnCerrarSesion);
            this.panelSideMenu.Controls.Add(this.panelPedidosSubmenu);
            this.panelSideMenu.Controls.Add(this.btnPedidos);
            this.panelSideMenu.Controls.Add(this.panelMenuSubmenu);
            this.panelSideMenu.Controls.Add(this.btnMenu);
            this.panelSideMenu.Controls.Add(this.panelClientesSubmenu);
            this.panelSideMenu.Controls.Add(this.btnClientes);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 25);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(184, 505);
            this.panelSideMenu.TabIndex = 3;
            // 
            // panelSubMenuADM
            // 
            this.panelSubMenuADM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelSubMenuADM.Controls.Add(this.button4);
            this.panelSubMenuADM.Controls.Add(this.button3);
            this.panelSubMenuADM.Controls.Add(this.button1);
            this.panelSubMenuADM.Controls.Add(this.btnADM_AgregarEmpleado);
            this.panelSubMenuADM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuADM.Location = new System.Drawing.Point(0, 480);
            this.panelSubMenuADM.Name = "panelSubMenuADM";
            this.panelSubMenuADM.Size = new System.Drawing.Size(167, 134);
            this.panelSubMenuADM.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(0, 90);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(167, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Estadísticas";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 60);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(167, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "Imprimir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 30);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(167, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ver todos los Empleados";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnADM_AgregarEmpleado
            // 
            this.btnADM_AgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnADM_AgregarEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnADM_AgregarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnADM_AgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADM_AgregarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADM_AgregarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnADM_AgregarEmpleado.Location = new System.Drawing.Point(0, 0);
            this.btnADM_AgregarEmpleado.Name = "btnADM_AgregarEmpleado";
            this.btnADM_AgregarEmpleado.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnADM_AgregarEmpleado.Size = new System.Drawing.Size(167, 30);
            this.btnADM_AgregarEmpleado.TabIndex = 3;
            this.btnADM_AgregarEmpleado.Text = "Agregar empleado";
            this.btnADM_AgregarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADM_AgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnADM_AgregarEmpleado.Click += new System.EventHandler(this.btnADM_AgregarEmpleado_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.BackColor = System.Drawing.Color.Yellow;
            this.btnAdm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdm.FlatAppearance.BorderSize = 0;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.ForeColor = System.Drawing.Color.Black;
            this.btnAdm.Image = global::kenjhi.Properties.Resources.adm;
            this.btnAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdm.Location = new System.Drawing.Point(0, 450);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Padding = new System.Windows.Forms.Padding(0, 0, 44, 0);
            this.btnAdm.Size = new System.Drawing.Size(167, 30);
            this.btnAdm.TabIndex = 10;
            this.btnAdm.Text = "Administrador";
            this.btnAdm.UseVisualStyleBackColor = false;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click_1);
            // 
            // btnVersion
            // 
            this.btnVersion.BackColor = System.Drawing.Color.Yellow;
            this.btnVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVersion.FlatAppearance.BorderSize = 0;
            this.btnVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVersion.ForeColor = System.Drawing.Color.Black;
            this.btnVersion.Image = global::kenjhi.Properties.Resources.informacion__1_;
            this.btnVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVersion.Location = new System.Drawing.Point(0, 614);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.btnVersion.Size = new System.Drawing.Size(167, 40);
            this.btnVersion.TabIndex = 9;
            this.btnVersion.Text = "Versión";
            this.btnVersion.UseVisualStyleBackColor = false;
            this.btnVersion.Click += new System.EventHandler(this.btnVersion_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Yellow;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.Image = global::kenjhi.Properties.Resources.ingresar__1_;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 654);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(167, 40);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelPedidosSubmenu
            // 
            this.panelPedidosSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelPedidosSubmenu.Controls.Add(this.btnVerPedidos);
            this.panelPedidosSubmenu.Controls.Add(this.btnNuevoPedido);
            this.panelPedidosSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPedidosSubmenu.Location = new System.Drawing.Point(0, 375);
            this.panelPedidosSubmenu.Name = "panelPedidosSubmenu";
            this.panelPedidosSubmenu.Size = new System.Drawing.Size(167, 75);
            this.panelPedidosSubmenu.TabIndex = 6;
            // 
            // btnVerPedidos
            // 
            this.btnVerPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVerPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerPedidos.FlatAppearance.BorderSize = 0;
            this.btnVerPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPedidos.ForeColor = System.Drawing.Color.Black;
            this.btnVerPedidos.Location = new System.Drawing.Point(0, 30);
            this.btnVerPedidos.Name = "btnVerPedidos";
            this.btnVerPedidos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnVerPedidos.Size = new System.Drawing.Size(167, 30);
            this.btnVerPedidos.TabIndex = 5;
            this.btnVerPedidos.Text = "Ver todos las ventas";
            this.btnVerPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerPedidos.UseVisualStyleBackColor = false;
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNuevoPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoPedido.FlatAppearance.BorderSize = 0;
            this.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoPedido.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNuevoPedido.Size = new System.Drawing.Size(167, 30);
            this.btnNuevoPedido.TabIndex = 3;
            this.btnNuevoPedido.Text = "Nueva venta";
            this.btnNuevoPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPedido.UseVisualStyleBackColor = false;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.Yellow;
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.Black;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Location = new System.Drawing.Point(0, 345);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(0, 0, 72, 0);
            this.btnPedidos.Size = new System.Drawing.Size(167, 30);
            this.btnPedidos.TabIndex = 5;
            this.btnPedidos.Text = "Ventas";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // panelMenuSubmenu
            // 
            this.panelMenuSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelMenuSubmenu.Controls.Add(this.btnIngresoProductos);
            this.panelMenuSubmenu.Controls.Add(this.btnModificarMenu);
            this.panelMenuSubmenu.Controls.Add(this.btnAgregarPlato);
            this.panelMenuSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuSubmenu.Location = new System.Drawing.Point(0, 235);
            this.panelMenuSubmenu.Name = "panelMenuSubmenu";
            this.panelMenuSubmenu.Size = new System.Drawing.Size(167, 110);
            this.panelMenuSubmenu.TabIndex = 4;
            // 
            // btnIngresoProductos
            // 
            this.btnIngresoProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIngresoProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIngresoProductos.FlatAppearance.BorderSize = 0;
            this.btnIngresoProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoProductos.ForeColor = System.Drawing.Color.Black;
            this.btnIngresoProductos.Location = new System.Drawing.Point(0, 60);
            this.btnIngresoProductos.Name = "btnIngresoProductos";
            this.btnIngresoProductos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnIngresoProductos.Size = new System.Drawing.Size(167, 30);
            this.btnIngresoProductos.TabIndex = 5;
            this.btnIngresoProductos.Text = "Ingresos de productos";
            this.btnIngresoProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresoProductos.UseVisualStyleBackColor = false;
            this.btnIngresoProductos.Click += new System.EventHandler(this.btnIngresoProductos_Click);
            // 
            // btnModificarMenu
            // 
            this.btnModificarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModificarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarMenu.FlatAppearance.BorderSize = 0;
            this.btnModificarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMenu.ForeColor = System.Drawing.Color.Black;
            this.btnModificarMenu.Location = new System.Drawing.Point(0, 30);
            this.btnModificarMenu.Name = "btnModificarMenu";
            this.btnModificarMenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnModificarMenu.Size = new System.Drawing.Size(167, 30);
            this.btnModificarMenu.TabIndex = 4;
            this.btnModificarMenu.Text = "Ver todos los productos\r\n";
            this.btnModificarMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarMenu.UseVisualStyleBackColor = false;
            this.btnModificarMenu.Click += new System.EventHandler(this.btnModificarMenu_Click);
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarPlato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarPlato.FlatAppearance.BorderSize = 0;
            this.btnAgregarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPlato.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarPlato.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAgregarPlato.Size = new System.Drawing.Size(167, 30);
            this.btnAgregarPlato.TabIndex = 3;
            this.btnAgregarPlato.Text = "Agregar producto";
            this.btnAgregarPlato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPlato.UseVisualStyleBackColor = false;
            this.btnAgregarPlato.Click += new System.EventHandler(this.btnAgregarPlato_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Yellow;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 205);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(0, 0, 55, 0);
            this.btnMenu.Size = new System.Drawing.Size(167, 30);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Productos";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelClientesSubmenu
            // 
            this.panelClientesSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelClientesSubmenu.Controls.Add(this.btnModificarCliente);
            this.panelClientesSubmenu.Controls.Add(this.btnAgregarCliente);
            this.panelClientesSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientesSubmenu.Location = new System.Drawing.Point(0, 130);
            this.panelClientesSubmenu.Name = "panelClientesSubmenu";
            this.panelClientesSubmenu.Size = new System.Drawing.Size(167, 75);
            this.panelClientesSubmenu.TabIndex = 2;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModificarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnModificarCliente.Location = new System.Drawing.Point(0, 30);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnModificarCliente.Size = new System.Drawing.Size(167, 30);
            this.btnModificarCliente.TabIndex = 4;
            this.btnModificarCliente.Text = "Ver todos los clientes";
            this.btnModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCliente.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAgregarCliente.Size = new System.Drawing.Size(167, 30);
            this.btnAgregarCliente.TabIndex = 3;
            this.btnAgregarCliente.Text = "Agregar cliente";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Yellow;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 100);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(0, 0, 70, 0);
            this.btnClientes.Size = new System.Drawing.Size(167, 30);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Yellow;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(167, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelChildForm.Controls.Add(this.lblFecha);
            this.panelChildForm.Controls.Add(this.lblHora);
            this.panelChildForm.Controls.Add(this.labelUser);
            this.panelChildForm.Controls.Add(this.labelUsuario);
            this.panelChildForm.Controls.Add(this.lblUsuario);
            this.panelChildForm.Controls.Add(this.pictureBox5);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(184, 25);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(670, 505);
            this.panelChildForm.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Black;
            this.lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Yellow;
            this.lblFecha.Location = new System.Drawing.Point(6, 483);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Black;
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Yellow;
            this.lblHora.Location = new System.Drawing.Point(6, 456);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(37, 16);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(23, 24);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 13);
            this.labelUser.TabIndex = 2;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(23, 483);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(0, 13);
            this.labelUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblUsuario.Location = new System.Drawing.Point(23, 483);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 16);
            this.lblUsuario.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(670, 505);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(854, 530);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suplementos Salto";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMenuADM.ResumeLayout(false);
            this.panelPedidosSubmenu.ResumeLayout(false);
            this.panelMenuSubmenu.ResumeLayout(false);
            this.panelClientesSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelClientesSubmenu;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Panel panelMenuSubmenu;
        private System.Windows.Forms.Button btnModificarMenu;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelPedidosSubmenu;
        private System.Windows.Forms.Button btnVerPedidos;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnVersion;
        private System.Windows.Forms.Button btnIngresoProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelSubMenuADM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnADM_AgregarEmpleado;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}