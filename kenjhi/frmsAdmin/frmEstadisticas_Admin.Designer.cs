namespace kenjhi.frmsAdmin
{
    partial class frmEstadisticas_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticas_Admin));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelRuta = new System.Windows.Forms.Label();
            this.pictureBoxClientes = new System.Windows.Forms.PictureBox();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.labelClientes = new System.Windows.Forms.Label();
            this.labelProductos = new System.Windows.Forms.Label();
            this.pictureBoxProductos = new System.Windows.Forms.PictureBox();
            this.chartProductosMasVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.linkVerDetalles = new System.Windows.Forms.LinkLabel();
            this.pictureDetalles = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnVolver = new kenjhi.RJButton();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.pictureImprimir = new System.Windows.Forms.PictureBox();
            this.linkImprimir = new System.Windows.Forms.LinkLabel();
            this.dgvver = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvverclientes = new System.Windows.Forms.DataGridView();
            this.nomcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductosMasVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvverclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRuta
            // 
            this.labelRuta.AutoSize = true;
            this.labelRuta.BackColor = System.Drawing.Color.Black;
            this.labelRuta.ForeColor = System.Drawing.Color.DimGray;
            this.labelRuta.Location = new System.Drawing.Point(107, 16);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(221, 13);
            this.labelRuta.TabIndex = 69;
            this.labelRuta.Text = "Menú principal > Administrador > Estadísticas\r\n";
            this.labelRuta.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBoxClientes
            // 
            this.pictureBoxClientes.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClientes.Image")));
            this.pictureBoxClientes.Location = new System.Drawing.Point(160, 154);
            this.pictureBoxClientes.Name = "pictureBoxClientes";
            this.pictureBoxClientes.Size = new System.Drawing.Size(130, 137);
            this.pictureBoxClientes.TabIndex = 80;
            this.pictureBoxClientes.TabStop = false;
            this.pictureBoxClientes.Click += new System.EventHandler(this.pictureBoxClientes_Click);
            // 
            // labelPrincipal
            // 
            this.labelPrincipal.AutoSize = true;
            this.labelPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelPrincipal.Location = new System.Drawing.Point(136, 9);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.labelPrincipal.Size = new System.Drawing.Size(443, 61);
            this.labelPrincipal.TabIndex = 82;
            this.labelPrincipal.Text = "Selecciona el tipo de dato a graficar";
            this.labelPrincipal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClientes.Location = new System.Drawing.Point(189, 127);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(77, 24);
            this.labelClientes.TabIndex = 83;
            this.labelClientes.Text = "Clientes";
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProductos.Location = new System.Drawing.Point(434, 127);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(95, 24);
            this.labelProductos.TabIndex = 85;
            this.labelProductos.Text = "Productos";
            // 
            // pictureBoxProductos
            // 
            this.pictureBoxProductos.Image = global::kenjhi.Properties.Resources.productos;
            this.pictureBoxProductos.Location = new System.Drawing.Point(414, 154);
            this.pictureBoxProductos.Name = "pictureBoxProductos";
            this.pictureBoxProductos.Size = new System.Drawing.Size(130, 137);
            this.pictureBoxProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProductos.TabIndex = 84;
            this.pictureBoxProductos.TabStop = false;
            this.pictureBoxProductos.Click += new System.EventHandler(this.pictureBoxProductos_Click);
            // 
            // chartProductosMasVendidos
            // 
            this.chartProductosMasVendidos.BorderlineColor = System.Drawing.Color.Yellow;
            this.chartProductosMasVendidos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartProductosMasVendidos.BorderlineWidth = 8;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartProductosMasVendidos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.TitleSeparatorColor = System.Drawing.Color.Red;
            this.chartProductosMasVendidos.Legends.Add(legend1);
            this.chartProductosMasVendidos.Location = new System.Drawing.Point(12, 85);
            this.chartProductosMasVendidos.Name = "chartProductosMasVendidos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProductosMasVendidos.Series.Add(series1);
            this.chartProductosMasVendidos.Size = new System.Drawing.Size(649, 408);
            this.chartProductosMasVendidos.TabIndex = 87;
            this.chartProductosMasVendidos.Text = "chart1";
            this.chartProductosMasVendidos.Visible = false;
            // 
            // linkVerDetalles
            // 
            this.linkVerDetalles.ActiveLinkColor = System.Drawing.Color.White;
            this.linkVerDetalles.AutoSize = true;
            this.linkVerDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkVerDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkVerDetalles.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkVerDetalles.Location = new System.Drawing.Point(582, 54);
            this.linkVerDetalles.Name = "linkVerDetalles";
            this.linkVerDetalles.Size = new System.Drawing.Size(79, 16);
            this.linkVerDetalles.TabIndex = 88;
            this.linkVerDetalles.TabStop = true;
            this.linkVerDetalles.Text = "Ver detalles";
            this.linkVerDetalles.Visible = false;
            this.linkVerDetalles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVerDetalles_LinkClicked);
            // 
            // pictureDetalles
            // 
            this.pictureDetalles.Image = ((System.Drawing.Image)(resources.GetObject("pictureDetalles.Image")));
            this.pictureDetalles.Location = new System.Drawing.Point(563, 55);
            this.pictureDetalles.Name = "pictureDetalles";
            this.pictureDetalles.Size = new System.Drawing.Size(19, 15);
            this.pictureDetalles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDetalles.TabIndex = 94;
            this.pictureDetalles.TabStop = false;
            this.pictureDetalles.Visible = false;
            this.pictureDetalles.Click += new System.EventHandler(this.pictureDetalles_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(446, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 95;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Yellow;
            this.btnVolver.BackgroundColor = System.Drawing.Color.Yellow;
            this.btnVolver.BorderColor = System.Drawing.Color.Transparent;
            this.btnVolver.BorderRadius = 10;
            this.btnVolver.BorderSize = 0;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(12, 9);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(72, 26);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextColor = System.Drawing.Color.Black;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Black;
            this.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblFiltro.Location = new System.Drawing.Point(405, 57);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 96;
            this.lblFiltro.Text = "Filtro";
            this.lblFiltro.Visible = false;
            // 
            // pictureImprimir
            // 
            this.pictureImprimir.Image = global::kenjhi.Properties.Resources.imprimir;
            this.pictureImprimir.Location = new System.Drawing.Point(563, 34);
            this.pictureImprimir.Name = "pictureImprimir";
            this.pictureImprimir.Size = new System.Drawing.Size(19, 15);
            this.pictureImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureImprimir.TabIndex = 97;
            this.pictureImprimir.TabStop = false;
            this.pictureImprimir.Visible = false;
            this.pictureImprimir.Click += new System.EventHandler(this.pictureImprimir_Click);
            // 
            // linkImprimir
            // 
            this.linkImprimir.ActiveLinkColor = System.Drawing.Color.White;
            this.linkImprimir.AutoSize = true;
            this.linkImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkImprimir.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkImprimir.Location = new System.Drawing.Point(582, 33);
            this.linkImprimir.Name = "linkImprimir";
            this.linkImprimir.Size = new System.Drawing.Size(54, 16);
            this.linkImprimir.TabIndex = 98;
            this.linkImprimir.TabStop = true;
            this.linkImprimir.Text = "Imprimir";
            this.linkImprimir.Visible = false;
            this.linkImprimir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkImprimir_LinkClicked);
            // 
            // dgvver
            // 
            this.dgvver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.cantidad});
            this.dgvver.Location = new System.Drawing.Point(421, 343);
            this.dgvver.Name = "dgvver";
            this.dgvver.Size = new System.Drawing.Size(240, 150);
            this.dgvver.TabIndex = 99;
            this.dgvver.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // dgvverclientes
            // 
            this.dgvverclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvverclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomcliente,
            this.compras});
            this.dgvverclientes.Location = new System.Drawing.Point(12, 343);
            this.dgvverclientes.Name = "dgvverclientes";
            this.dgvverclientes.Size = new System.Drawing.Size(240, 150);
            this.dgvverclientes.TabIndex = 100;
            this.dgvverclientes.Visible = false;
            // 
            // nomcliente
            // 
            this.nomcliente.HeaderText = "Nombre";
            this.nomcliente.Name = "nomcliente";
            // 
            // compras
            // 
            this.compras.HeaderText = "Compras";
            this.compras.Name = "compras";
            // 
            // frmEstadisticas_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(673, 505);
            this.Controls.Add(this.dgvverclientes);
            this.Controls.Add(this.dgvver);
            this.Controls.Add(this.linkImprimir);
            this.Controls.Add(this.pictureImprimir);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureDetalles);
            this.Controls.Add(this.linkVerDetalles);
            this.Controls.Add(this.labelProductos);
            this.Controls.Add(this.pictureBoxProductos);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.pictureBoxClientes);
            this.Controls.Add(this.labelRuta);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.labelPrincipal);
            this.Controls.Add(this.chartProductosMasVendidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstadisticas_Admin";
            this.Text = "Suplementos Salto";
            this.Load += new System.EventHandler(this.frmEstadisticas_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductosMasVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvverclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton btnVolver;
        private System.Windows.Forms.Label labelRuta;
        private System.Windows.Forms.PictureBox pictureBoxClientes;
        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.PictureBox pictureBoxProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductosMasVendidos;
        private System.Windows.Forms.LinkLabel linkVerDetalles;
        private System.Windows.Forms.PictureBox pictureDetalles;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.PictureBox pictureImprimir;
        private System.Windows.Forms.LinkLabel linkImprimir;
        private System.Windows.Forms.DataGridView dgvver;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridView dgvverclientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn compras;
    }
}