﻿namespace kenjhi
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelPedidosSubmenu = new System.Windows.Forms.Panel();
            this.btnVerPedidos = new System.Windows.Forms.Button();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.panelMenuSubmenu = new System.Windows.Forms.Panel();
            this.btnVerMenu = new System.Windows.Forms.Button();
            this.btnModificarMenu = new System.Windows.Forms.Button();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelClientesSubmenu = new System.Windows.Forms.Panel();
            this.btnVerClientes = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSideMenu.SuspendLayout();
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
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 25);
            this.panel2.TabIndex = 3;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(799, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 21);
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
            this.panelSideMenu.BackColor = System.Drawing.Color.White;
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
            this.panelSideMenu.Size = new System.Drawing.Size(181, 505);
            this.panelSideMenu.TabIndex = 3;
            // 
            // panelPedidosSubmenu
            // 
            this.panelPedidosSubmenu.BackColor = System.Drawing.Color.White;
            this.panelPedidosSubmenu.Controls.Add(this.btnVerPedidos);
            this.panelPedidosSubmenu.Controls.Add(this.btnModificarPedido);
            this.panelPedidosSubmenu.Controls.Add(this.btnNuevoPedido);
            this.panelPedidosSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPedidosSubmenu.Location = new System.Drawing.Point(0, 396);
            this.panelPedidosSubmenu.Name = "panelPedidosSubmenu";
            this.panelPedidosSubmenu.Size = new System.Drawing.Size(181, 103);
            this.panelPedidosSubmenu.TabIndex = 6;
            // 
            // btnVerPedidos
            // 
            this.btnVerPedidos.BackColor = System.Drawing.Color.White;
            this.btnVerPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerPedidos.FlatAppearance.BorderSize = 0;
            this.btnVerPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPedidos.ForeColor = System.Drawing.Color.Black;
            this.btnVerPedidos.Location = new System.Drawing.Point(0, 60);
            this.btnVerPedidos.Name = "btnVerPedidos";
            this.btnVerPedidos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnVerPedidos.Size = new System.Drawing.Size(181, 30);
            this.btnVerPedidos.TabIndex = 5;
            this.btnVerPedidos.Text = "Ver todos las ventas";
            this.btnVerPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerPedidos.UseVisualStyleBackColor = false;
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.BackColor = System.Drawing.Color.White;
            this.btnModificarPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarPedido.FlatAppearance.BorderSize = 0;
            this.btnModificarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPedido.ForeColor = System.Drawing.Color.Black;
            this.btnModificarPedido.Location = new System.Drawing.Point(0, 30);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnModificarPedido.Size = new System.Drawing.Size(181, 30);
            this.btnModificarPedido.TabIndex = 4;
            this.btnModificarPedido.Text = "Modificar venta";
            this.btnModificarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPedido.UseVisualStyleBackColor = false;
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.BackColor = System.Drawing.Color.White;
            this.btnNuevoPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoPedido.FlatAppearance.BorderSize = 0;
            this.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoPedido.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNuevoPedido.Size = new System.Drawing.Size(181, 30);
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
            this.btnPedidos.Location = new System.Drawing.Point(0, 366);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(0, 0, 66, 0);
            this.btnPedidos.Size = new System.Drawing.Size(181, 30);
            this.btnPedidos.TabIndex = 5;
            this.btnPedidos.Text = "Ventas";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // panelMenuSubmenu
            // 
            this.panelMenuSubmenu.BackColor = System.Drawing.Color.White;
            this.panelMenuSubmenu.Controls.Add(this.btnVerMenu);
            this.panelMenuSubmenu.Controls.Add(this.btnModificarMenu);
            this.panelMenuSubmenu.Controls.Add(this.btnAgregarPlato);
            this.panelMenuSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuSubmenu.Location = new System.Drawing.Point(0, 263);
            this.panelMenuSubmenu.Name = "panelMenuSubmenu";
            this.panelMenuSubmenu.Size = new System.Drawing.Size(181, 103);
            this.panelMenuSubmenu.TabIndex = 4;
            // 
            // btnVerMenu
            // 
            this.btnVerMenu.BackColor = System.Drawing.Color.White;
            this.btnVerMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerMenu.FlatAppearance.BorderSize = 0;
            this.btnVerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMenu.ForeColor = System.Drawing.Color.Black;
            this.btnVerMenu.Location = new System.Drawing.Point(0, 60);
            this.btnVerMenu.Name = "btnVerMenu";
            this.btnVerMenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnVerMenu.Size = new System.Drawing.Size(181, 30);
            this.btnVerMenu.TabIndex = 5;
            this.btnVerMenu.Text = "Ver el menú";
            this.btnVerMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerMenu.UseVisualStyleBackColor = false;
            this.btnVerMenu.Click += new System.EventHandler(this.btnVerMenu_Click);
            // 
            // btnModificarMenu
            // 
            this.btnModificarMenu.BackColor = System.Drawing.Color.White;
            this.btnModificarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarMenu.FlatAppearance.BorderSize = 0;
            this.btnModificarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMenu.ForeColor = System.Drawing.Color.Black;
            this.btnModificarMenu.Location = new System.Drawing.Point(0, 30);
            this.btnModificarMenu.Name = "btnModificarMenu";
            this.btnModificarMenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnModificarMenu.Size = new System.Drawing.Size(181, 30);
            this.btnModificarMenu.TabIndex = 4;
            this.btnModificarMenu.Text = "Modificar el menú";
            this.btnModificarMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarMenu.UseVisualStyleBackColor = false;
            this.btnModificarMenu.Click += new System.EventHandler(this.btnModificarMenu_Click);
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.BackColor = System.Drawing.Color.White;
            this.btnAgregarPlato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarPlato.FlatAppearance.BorderSize = 0;
            this.btnAgregarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPlato.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarPlato.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAgregarPlato.Size = new System.Drawing.Size(181, 30);
            this.btnAgregarPlato.TabIndex = 3;
            this.btnAgregarPlato.Text = "Agregar plato al menú";
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
            this.btnMenu.Location = new System.Drawing.Point(0, 233);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(0, 0, 55, 0);
            this.btnMenu.Size = new System.Drawing.Size(181, 30);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Productos";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelClientesSubmenu
            // 
            this.panelClientesSubmenu.BackColor = System.Drawing.Color.White;
            this.panelClientesSubmenu.Controls.Add(this.btnVerClientes);
            this.panelClientesSubmenu.Controls.Add(this.btnModificarCliente);
            this.panelClientesSubmenu.Controls.Add(this.btnAgregarCliente);
            this.panelClientesSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientesSubmenu.Location = new System.Drawing.Point(0, 130);
            this.panelClientesSubmenu.Name = "panelClientesSubmenu";
            this.panelClientesSubmenu.Size = new System.Drawing.Size(181, 103);
            this.panelClientesSubmenu.TabIndex = 2;
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.BackColor = System.Drawing.Color.White;
            this.btnVerClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerClientes.FlatAppearance.BorderSize = 0;
            this.btnVerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClientes.ForeColor = System.Drawing.Color.Black;
            this.btnVerClientes.Location = new System.Drawing.Point(0, 60);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnVerClientes.Size = new System.Drawing.Size(181, 30);
            this.btnVerClientes.TabIndex = 5;
            this.btnVerClientes.Text = "Ver todos los clientes";
            this.btnVerClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerClientes.UseVisualStyleBackColor = false;
            this.btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.White;
            this.btnModificarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnModificarCliente.Location = new System.Drawing.Point(0, 30);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnModificarCliente.Size = new System.Drawing.Size(181, 30);
            this.btnModificarCliente.TabIndex = 4;
            this.btnModificarCliente.Text = "Modificar cliente";
            this.btnModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCliente.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAgregarCliente.Size = new System.Drawing.Size(181, 30);
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
            this.btnClientes.Size = new System.Drawing.Size(181, 30);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Black;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(181, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 3);
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
            this.panelChildForm.Location = new System.Drawing.Point(181, 25);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(673, 505);
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
            this.pictureBox5.Size = new System.Drawing.Size(673, 505);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Panel panelMenuSubmenu;
        private System.Windows.Forms.Button btnVerMenu;
        private System.Windows.Forms.Button btnModificarMenu;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelPedidosSubmenu;
        private System.Windows.Forms.Button btnVerPedidos;
        private System.Windows.Forms.Button btnModificarPedido;
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
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}