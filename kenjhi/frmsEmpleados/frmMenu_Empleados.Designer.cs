﻿namespace kenjhi
{
    partial class frmMenu_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu_Empleados));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelPedidosSubmenu = new System.Windows.Forms.Panel();
            this.btnDeudores = new System.Windows.Forms.Button();
            this.btnVerPedidos = new System.Windows.Forms.Button();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.panelMenuSubmenu = new System.Windows.Forms.Panel();
            this.btnVerCategorias = new System.Windows.Forms.Button();
            this.btnAgregarCategorias = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnIngresoProductos = new System.Windows.Forms.Button();
            this.btnModificarMenu = new System.Windows.Forms.Button();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.panelClientesSubmenu = new System.Windows.Forms.Panel();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label1S = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnVersion = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelPedidosSubmenu.SuspendLayout();
            this.panelMenuSubmenu.SuspendLayout();
            this.panelClientesSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Yellow;
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
            // panelPedidosSubmenu
            // 
            this.panelPedidosSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelPedidosSubmenu.Controls.Add(this.btnDeudores);
            this.panelPedidosSubmenu.Controls.Add(this.btnVerPedidos);
            this.panelPedidosSubmenu.Controls.Add(this.btnNuevoPedido);
            this.panelPedidosSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPedidosSubmenu.Location = new System.Drawing.Point(0, 445);
            this.panelPedidosSubmenu.Name = "panelPedidosSubmenu";
            this.panelPedidosSubmenu.Size = new System.Drawing.Size(167, 90);
            this.panelPedidosSubmenu.TabIndex = 6;
            // 
            // btnDeudores
            // 
            this.btnDeudores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeudores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeudores.FlatAppearance.BorderSize = 0;
            this.btnDeudores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeudores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeudores.ForeColor = System.Drawing.Color.Black;
            this.btnDeudores.Location = new System.Drawing.Point(0, 60);
            this.btnDeudores.Name = "btnDeudores";
            this.btnDeudores.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDeudores.Size = new System.Drawing.Size(167, 30);
            this.btnDeudores.TabIndex = 7;
            this.btnDeudores.Text = "Deudores";
            this.btnDeudores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeudores.UseVisualStyleBackColor = false;
            this.btnDeudores.Click += new System.EventHandler(this.btnDeudores_Click);
            this.btnDeudores.MouseEnter += new System.EventHandler(this.btnDeudores_MouseEnter);
            this.btnDeudores.MouseLeave += new System.EventHandler(this.btnDeudores_MouseLeave);
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
            this.btnVerPedidos.Text = "Ver ventas";
            this.btnVerPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerPedidos.UseVisualStyleBackColor = false;
            this.btnVerPedidos.Click += new System.EventHandler(this.btnVerPedidos_Click);
            this.btnVerPedidos.MouseEnter += new System.EventHandler(this.btnVerPedidos_MouseEnter);
            this.btnVerPedidos.MouseLeave += new System.EventHandler(this.btnVerPedidos_MouseLeave);
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
            this.btnNuevoPedido.MouseEnter += new System.EventHandler(this.btnNuevoPedido_MouseEnter);
            this.btnNuevoPedido.MouseLeave += new System.EventHandler(this.btnNuevoPedido_MouseLeave);
            // 
            // panelMenuSubmenu
            // 
            this.panelMenuSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelMenuSubmenu.Controls.Add(this.btnVerCategorias);
            this.panelMenuSubmenu.Controls.Add(this.btnAgregarCategorias);
            this.panelMenuSubmenu.Controls.Add(this.btnAgregarCategoria);
            this.panelMenuSubmenu.Controls.Add(this.btnIngresoProductos);
            this.panelMenuSubmenu.Controls.Add(this.btnModificarMenu);
            this.panelMenuSubmenu.Controls.Add(this.btnAgregarPlato);
            this.panelMenuSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuSubmenu.Location = new System.Drawing.Point(0, 230);
            this.panelMenuSubmenu.Name = "panelMenuSubmenu";
            this.panelMenuSubmenu.Size = new System.Drawing.Size(167, 180);
            this.panelMenuSubmenu.TabIndex = 4;
            // 
            // btnVerCategorias
            // 
            this.btnVerCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVerCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerCategorias.FlatAppearance.BorderSize = 0;
            this.btnVerCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCategorias.ForeColor = System.Drawing.Color.Black;
            this.btnVerCategorias.Location = new System.Drawing.Point(0, 150);
            this.btnVerCategorias.Name = "btnVerCategorias";
            this.btnVerCategorias.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnVerCategorias.Size = new System.Drawing.Size(167, 30);
            this.btnVerCategorias.TabIndex = 8;
            this.btnVerCategorias.Text = "Ver categorías";
            this.btnVerCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCategorias.UseVisualStyleBackColor = false;
            this.btnVerCategorias.Click += new System.EventHandler(this.btnVerCategorias_Click_1);
            this.btnVerCategorias.MouseEnter += new System.EventHandler(this.btnVerCategorias_MouseEnter_1);
            this.btnVerCategorias.MouseLeave += new System.EventHandler(this.btnVerCategorias_MouseLeave_1);
            // 
            // btnAgregarCategorias
            // 
            this.btnAgregarCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarCategorias.FlatAppearance.BorderSize = 0;
            this.btnAgregarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategorias.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCategorias.Location = new System.Drawing.Point(0, 120);
            this.btnAgregarCategorias.Name = "btnAgregarCategorias";
            this.btnAgregarCategorias.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAgregarCategorias.Size = new System.Drawing.Size(167, 30);
            this.btnAgregarCategorias.TabIndex = 7;
            this.btnAgregarCategorias.Text = "Agregar categoría";
            this.btnAgregarCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCategorias.UseVisualStyleBackColor = false;
            this.btnAgregarCategorias.Click += new System.EventHandler(this.btnVerCategorias_Click);
            this.btnAgregarCategorias.MouseEnter += new System.EventHandler(this.btnVerCategorias_MouseEnter);
            this.btnAgregarCategorias.MouseLeave += new System.EventHandler(this.btnVerCategorias_MouseLeave);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(0, 90);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAgregarCategoria.Size = new System.Drawing.Size(167, 30);
            this.btnAgregarCategoria.TabIndex = 6;
            this.btnAgregarCategoria.Text = "Ver ingresos";
            this.btnAgregarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.button1_Click);
            this.btnAgregarCategoria.MouseEnter += new System.EventHandler(this.btnAgregarCategoria_MouseEnter);
            this.btnAgregarCategoria.MouseLeave += new System.EventHandler(this.btnAgregarCategoria_MouseLeave);
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
            this.btnIngresoProductos.MouseEnter += new System.EventHandler(this.btnIngresoProductos_MouseEnter);
            this.btnIngresoProductos.MouseLeave += new System.EventHandler(this.btnIngresoProductos_MouseLeave);
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
            this.btnModificarMenu.Text = "Ver productos\r\n";
            this.btnModificarMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarMenu.UseVisualStyleBackColor = false;
            this.btnModificarMenu.Click += new System.EventHandler(this.btnModificarMenu_Click);
            this.btnModificarMenu.MouseEnter += new System.EventHandler(this.btnModificarMenu_MouseEnter);
            this.btnModificarMenu.MouseLeave += new System.EventHandler(this.btnModificarMenu_MouseLeave);
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
            this.btnAgregarPlato.MouseEnter += new System.EventHandler(this.btnAgregarPlato_MouseEnter);
            this.btnAgregarPlato.MouseLeave += new System.EventHandler(this.btnAgregarPlato_MouseLeave);
            // 
            // panelClientesSubmenu
            // 
            this.panelClientesSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelClientesSubmenu.Controls.Add(this.btnModificarCliente);
            this.panelClientesSubmenu.Controls.Add(this.btnAgregarCliente);
            this.panelClientesSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientesSubmenu.Location = new System.Drawing.Point(0, 135);
            this.panelClientesSubmenu.Name = "panelClientesSubmenu";
            this.panelClientesSubmenu.Size = new System.Drawing.Size(167, 60);
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
            this.btnModificarCliente.Text = "Ver clientes";
            this.btnModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            this.btnModificarCliente.MouseEnter += new System.EventHandler(this.btnModificarCliente_MouseEnter);
            this.btnModificarCliente.MouseLeave += new System.EventHandler(this.btnModificarCliente_MouseLeave);
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
            this.btnAgregarCliente.MouseEnter += new System.EventHandler(this.btnAgregarCliente_MouseEnter);
            this.btnAgregarCliente.MouseLeave += new System.EventHandler(this.btnAgregarCliente_MouseLeave);
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
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelChildForm.Controls.Add(this.label1S);
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
            // label1S
            // 
            this.label1S.AutoSize = true;
            this.label1S.BackColor = System.Drawing.Color.Black;
            this.label1S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1S.ForeColor = System.Drawing.Color.Yellow;
            this.label1S.Location = new System.Drawing.Point(372, 462);
            this.label1S.Name = "label1S";
            this.label1S.Size = new System.Drawing.Size(234, 20);
            this.label1S.TabIndex = 6;
            this.label1S.Text = "Sesión iniciada como Empleado";
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
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
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
            // btnVersion
            // 
            this.btnVersion.BackColor = System.Drawing.Color.Yellow;
            this.btnVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVersion.FlatAppearance.BorderSize = 0;
            this.btnVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVersion.ForeColor = System.Drawing.Color.Black;
            this.btnVersion.Image = global::kenjhi.Properties.Resources.version;
            this.btnVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVersion.Location = new System.Drawing.Point(0, 535);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.btnVersion.Size = new System.Drawing.Size(167, 38);
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
            this.btnCerrarSesion.Image = global::kenjhi.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 573);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(167, 38);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
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
            this.btnPedidos.Location = new System.Drawing.Point(0, 410);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(0, 0, 72, 0);
            this.btnPedidos.Size = new System.Drawing.Size(167, 35);
            this.btnPedidos.TabIndex = 5;
            this.btnPedidos.Text = "Ventas";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Yellow;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Image = global::kenjhi.Properties.Resources.proteina__1_;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 195);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(0, 0, 55, 0);
            this.btnMenu.Size = new System.Drawing.Size(167, 35);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Productos";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            this.btnClientes.Size = new System.Drawing.Size(167, 35);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // frmMenu_Empleados
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
            this.Name = "frmMenu_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suplementos Salto";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelPedidosSubmenu.ResumeLayout(false);
            this.panelMenuSubmenu.ResumeLayout(false);
            this.panelClientesSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button btnAgregarCategorias;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Label label1S;
        private System.Windows.Forms.Button btnVerCategorias;
        private System.Windows.Forms.Button btnDeudores;
    }
}