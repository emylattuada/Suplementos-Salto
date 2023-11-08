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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticas_Admin));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnVolver = new kenjhi.RJButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBoxClientes = new System.Windows.Forms.PictureBox();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.labelClientes = new System.Windows.Forms.Label();
            this.labelProductos = new System.Windows.Forms.Label();
            this.pictureBoxProductos = new System.Windows.Forms.PictureBox();
            this.lblMasVendido7Dias = new System.Windows.Forms.Label();
            this.chartProductosMasVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductosMasVendidos)).BeginInit();
            this.SuspendLayout();
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
            // lblMasVendido7Dias
            // 
            this.lblMasVendido7Dias.AutoSize = true;
            this.lblMasVendido7Dias.ForeColor = System.Drawing.Color.White;
            this.lblMasVendido7Dias.Location = new System.Drawing.Point(37, 112);
            this.lblMasVendido7Dias.Name = "lblMasVendido7Dias";
            this.lblMasVendido7Dias.Size = new System.Drawing.Size(35, 13);
            this.lblMasVendido7Dias.TabIndex = 86;
            this.lblMasVendido7Dias.Text = "label1";
            this.lblMasVendido7Dias.Visible = false;
            // 
            // chartProductosMasVendidos
            // 
            this.chartProductosMasVendidos.BorderlineColor = System.Drawing.Color.Yellow;
            this.chartProductosMasVendidos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartProductosMasVendidos.BorderlineWidth = 8;
            chartArea4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.chartProductosMasVendidos.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            legend4.TitleSeparatorColor = System.Drawing.Color.Red;
            this.chartProductosMasVendidos.Legends.Add(legend4);
            this.chartProductosMasVendidos.Location = new System.Drawing.Point(12, 85);
            this.chartProductosMasVendidos.Name = "chartProductosMasVendidos";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartProductosMasVendidos.Series.Add(series4);
            this.chartProductosMasVendidos.Size = new System.Drawing.Size(649, 408);
            this.chartProductosMasVendidos.TabIndex = 87;
            this.chartProductosMasVendidos.Text = "chart1";
            this.chartProductosMasVendidos.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmEstadisticas_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(673, 505);
            this.Controls.Add(this.lblMasVendido7Dias);
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
        private System.Windows.Forms.Label lblMasVendido7Dias;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductosMasVendidos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}