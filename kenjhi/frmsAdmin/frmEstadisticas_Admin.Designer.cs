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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label10 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductosMasVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(107, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Menú principal > Administrador > Estadísticas\r\n";
            this.label10.Click += new System.EventHandler(this.label10_Click);
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
            this.labelClientes.Location = new System.Drawing.Point(193, 127);
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
            this.labelProductos.Location = new System.Drawing.Point(432, 127);
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
            chartArea5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.Name = "ChartArea1";
            this.chartProductosMasVendidos.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            legend5.TitleSeparatorColor = System.Drawing.Color.Red;
            this.chartProductosMasVendidos.Legends.Add(legend5);
            this.chartProductosMasVendidos.Location = new System.Drawing.Point(12, 85);
            this.chartProductosMasVendidos.Name = "chartProductosMasVendidos";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartProductosMasVendidos.Series.Add(series5);
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
            // frmEstadisticas_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(673, 505);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureDetalles);
            this.Controls.Add(this.linkVerDetalles);
            this.Controls.Add(this.labelProductos);
            this.Controls.Add(this.pictureBoxProductos);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.pictureBoxClientes);
            this.Controls.Add(this.label10);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton btnVolver;
        private System.Windows.Forms.Label label10;
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
    }
}