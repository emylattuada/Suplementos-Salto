namespace kenjhi.frmsAdmin
{
    partial class frmRecuperarDatos_Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarDatos_Admin));
            this.label10 = new System.Windows.Forms.Label();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.btnVolver = new kenjhi.RJButton();
            this.lblDatos = new System.Windows.Forms.Label();
            this.dataGridRecuperarDatos = new System.Windows.Forms.DataGridView();
            this.pictureBoxClientes = new System.Windows.Forms.PictureBox();
            this.pictureBoxCategorias = new System.Windows.Forms.PictureBox();
            this.pictureBoxProductos = new System.Windows.Forms.PictureBox();
            this.labelClientes = new System.Windows.Forms.Label();
            this.labelProductos = new System.Windows.Forms.Label();
            this.labelCategorias = new System.Windows.Forms.Label();
            this.pictureBoxEmpleados = new System.Windows.Forms.PictureBox();
            this.labelEmpleados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecuperarDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(107, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 26);
            this.label10.TabIndex = 68;
            this.label10.Text = "Menú principal > Administrador > Recuperar Datos\r\n\r\n";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // labelPrincipal
            // 
            this.labelPrincipal.AutoSize = true;
            this.labelPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelPrincipal.Location = new System.Drawing.Point(114, 11);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.labelPrincipal.Size = new System.Drawing.Size(468, 61);
            this.labelPrincipal.TabIndex = 70;
            this.labelPrincipal.Text = "Selecciona el tipo de dato a recuperar";
            this.labelPrincipal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextColor = System.Drawing.Color.Black;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDatos.Location = new System.Drawing.Point(117, 94);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(0, 16);
            this.lblDatos.TabIndex = 76;
            // 
            // dataGridRecuperarDatos
            // 
            this.dataGridRecuperarDatos.AllowUserToAddRows = false;
            this.dataGridRecuperarDatos.AllowUserToDeleteRows = false;
            this.dataGridRecuperarDatos.AllowUserToOrderColumns = true;
            this.dataGridRecuperarDatos.AllowUserToResizeColumns = false;
            this.dataGridRecuperarDatos.AllowUserToResizeRows = false;
            this.dataGridRecuperarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRecuperarDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridRecuperarDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridRecuperarDatos.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridRecuperarDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridRecuperarDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridRecuperarDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRecuperarDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRecuperarDatos.ColumnHeadersHeight = 35;
            this.dataGridRecuperarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRecuperarDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridRecuperarDatos.EnableHeadersVisualStyles = false;
            this.dataGridRecuperarDatos.GridColor = System.Drawing.Color.Yellow;
            this.dataGridRecuperarDatos.Location = new System.Drawing.Point(120, 130);
            this.dataGridRecuperarDatos.Name = "dataGridRecuperarDatos";
            this.dataGridRecuperarDatos.ReadOnly = true;
            this.dataGridRecuperarDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRecuperarDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridRecuperarDatos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridRecuperarDatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridRecuperarDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRecuperarDatos.Size = new System.Drawing.Size(450, 363);
            this.dataGridRecuperarDatos.TabIndex = 78;
            this.dataGridRecuperarDatos.Visible = false;
            // 
            // pictureBoxClientes
            // 
            this.pictureBoxClientes.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClientes.Image")));
            this.pictureBoxClientes.Location = new System.Drawing.Point(120, 139);
            this.pictureBoxClientes.Name = "pictureBoxClientes";
            this.pictureBoxClientes.Size = new System.Drawing.Size(130, 137);
            this.pictureBoxClientes.TabIndex = 79;
            this.pictureBoxClientes.TabStop = false;
            this.pictureBoxClientes.Click += new System.EventHandler(this.pictureBoxClientes_Click);
            // 
            // pictureBoxCategorias
            // 
            this.pictureBoxCategorias.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCategorias.Image")));
            this.pictureBoxCategorias.Location = new System.Drawing.Point(440, 139);
            this.pictureBoxCategorias.Name = "pictureBoxCategorias";
            this.pictureBoxCategorias.Size = new System.Drawing.Size(130, 137);
            this.pictureBoxCategorias.TabIndex = 80;
            this.pictureBoxCategorias.TabStop = false;
            // 
            // pictureBoxProductos
            // 
            this.pictureBoxProductos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProductos.Image")));
            this.pictureBoxProductos.Location = new System.Drawing.Point(278, 139);
            this.pictureBoxProductos.Name = "pictureBoxProductos";
            this.pictureBoxProductos.Size = new System.Drawing.Size(130, 137);
            this.pictureBoxProductos.TabIndex = 81;
            this.pictureBoxProductos.TabStop = false;
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClientes.Location = new System.Drawing.Point(149, 110);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(77, 24);
            this.labelClientes.TabIndex = 82;
            this.labelClientes.Text = "Clientes";
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProductos.Location = new System.Drawing.Point(298, 110);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(95, 24);
            this.labelProductos.TabIndex = 83;
            this.labelProductos.Text = "Productos";
            // 
            // labelCategorias
            // 
            this.labelCategorias.AutoSize = true;
            this.labelCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCategorias.Location = new System.Drawing.Point(459, 110);
            this.labelCategorias.Name = "labelCategorias";
            this.labelCategorias.Size = new System.Drawing.Size(99, 24);
            this.labelCategorias.TabIndex = 84;
            this.labelCategorias.Text = "Categorías";
            // 
            // pictureBoxEmpleados
            // 
            this.pictureBoxEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEmpleados.Image")));
            this.pictureBoxEmpleados.Location = new System.Drawing.Point(278, 322);
            this.pictureBoxEmpleados.Name = "pictureBoxEmpleados";
            this.pictureBoxEmpleados.Size = new System.Drawing.Size(130, 137);
            this.pictureBoxEmpleados.TabIndex = 85;
            this.pictureBoxEmpleados.TabStop = false;
            // 
            // labelEmpleados
            // 
            this.labelEmpleados.AutoSize = true;
            this.labelEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmpleados.Location = new System.Drawing.Point(291, 295);
            this.labelEmpleados.Name = "labelEmpleados";
            this.labelEmpleados.Size = new System.Drawing.Size(106, 24);
            this.labelEmpleados.TabIndex = 86;
            this.labelEmpleados.Text = "Empleados";
            // 
            // frmRecuperarDatos_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(673, 505);
            this.Controls.Add(this.labelEmpleados);
            this.Controls.Add(this.pictureBoxEmpleados);
            this.Controls.Add(this.labelCategorias);
            this.Controls.Add(this.labelProductos);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.pictureBoxProductos);
            this.Controls.Add(this.pictureBoxCategorias);
            this.Controls.Add(this.pictureBoxClientes);
            this.Controls.Add(this.dataGridRecuperarDatos);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.labelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecuperarDatos_Admin";
            this.Text = "Suplementos Salto";
            this.Load += new System.EventHandler(this.frmRecuperarDatos_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecuperarDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton btnVolver;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.DataGridView dataGridRecuperarDatos;
        private System.Windows.Forms.PictureBox pictureBoxClientes;
        private System.Windows.Forms.PictureBox pictureBoxCategorias;
        private System.Windows.Forms.PictureBox pictureBoxProductos;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.Label labelCategorias;
        private System.Windows.Forms.PictureBox pictureBoxEmpleados;
        private System.Windows.Forms.Label labelEmpleados;
    }
}