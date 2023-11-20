namespace kenjhi.frmsAdmin
{
    partial class frmVerCategorias_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerCategorias_Admin));
            this.label10 = new System.Windows.Forms.Label();
            this.txtBusquedaDGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridCategorias = new System.Windows.Forms.DataGridView();
            this.lblSinResultado4 = new System.Windows.Forms.Label();
            this.lblSinResultado3 = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new kenjhi.RJButton();
            this.btnModificar = new kenjhi.RJButton();
            this.btnVolver = new kenjhi.RJButton();
            this.btnCancelarModificacion = new kenjhi.RJButton();
            this.btnEliminarCategoria = new kenjhi.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(107, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Menú principal > Productos > Ver categorías\r\n";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtBusquedaDGV
            // 
            this.txtBusquedaDGV.BackColor = System.Drawing.Color.Black;
            this.txtBusquedaDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusquedaDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaDGV.ForeColor = System.Drawing.Color.White;
            this.txtBusquedaDGV.Location = new System.Drawing.Point(110, 56);
            this.txtBusquedaDGV.Multiline = true;
            this.txtBusquedaDGV.Name = "txtBusquedaDGV";
            this.txtBusquedaDGV.Size = new System.Drawing.Size(535, 20);
            this.txtBusquedaDGV.TabIndex = 75;
            this.txtBusquedaDGV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBusquedaDGV_MouseClick);
            this.txtBusquedaDGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusquedaDGV_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(107, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(110, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(535, 1);
            this.textBox1.TabIndex = 73;
            // 
            // dataGridCategorias
            // 
            this.dataGridCategorias.AllowUserToAddRows = false;
            this.dataGridCategorias.AllowUserToDeleteRows = false;
            this.dataGridCategorias.AllowUserToOrderColumns = true;
            this.dataGridCategorias.AllowUserToResizeColumns = false;
            this.dataGridCategorias.AllowUserToResizeRows = false;
            this.dataGridCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCategorias.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCategorias.ColumnHeadersHeight = 35;
            this.dataGridCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCategorias.EnableHeadersVisualStyles = false;
            this.dataGridCategorias.GridColor = System.Drawing.Color.Yellow;
            this.dataGridCategorias.Location = new System.Drawing.Point(110, 88);
            this.dataGridCategorias.Name = "dataGridCategorias";
            this.dataGridCategorias.ReadOnly = true;
            this.dataGridCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCategorias.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridCategorias.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCategorias.Size = new System.Drawing.Size(535, 405);
            this.dataGridCategorias.TabIndex = 76;
            this.dataGridCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCategorias_CellClick);
            this.dataGridCategorias.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridCategorias_CellValidating);
            this.dataGridCategorias.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCategorias_CellValueChanged);
            // 
            // lblSinResultado4
            // 
            this.lblSinResultado4.AutoSize = true;
            this.lblSinResultado4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinResultado4.ForeColor = System.Drawing.Color.White;
            this.lblSinResultado4.Location = new System.Drawing.Point(321, 268);
            this.lblSinResultado4.Name = "lblSinResultado4";
            this.lblSinResultado4.Size = new System.Drawing.Size(123, 16);
            this.lblSinResultado4.TabIndex = 78;
            this.lblSinResultado4.Text = "Intente nuevamente";
            this.lblSinResultado4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSinResultado4.Visible = false;
            // 
            // lblSinResultado3
            // 
            this.lblSinResultado3.AutoSize = true;
            this.lblSinResultado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinResultado3.ForeColor = System.Drawing.Color.White;
            this.lblSinResultado3.Location = new System.Drawing.Point(146, 243);
            this.lblSinResultado3.Name = "lblSinResultado3";
            this.lblSinResultado3.Size = new System.Drawing.Size(467, 25);
            this.lblSinResultado3.TabIndex = 77;
            this.lblSinResultado3.Text = "La categoría ingresada no pertenece al sistema";
            this.lblSinResultado3.Visible = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Yellow;
            this.btnGuardarCambios.BackgroundColor = System.Drawing.Color.Yellow;
            this.btnGuardarCambios.BorderColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambios.BorderRadius = 10;
            this.btnGuardarCambios.BorderSize = 0;
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarCambios.Location = new System.Drawing.Point(12, 105);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(72, 26);
            this.btnGuardarCambios.TabIndex = 81;
            this.btnGuardarCambios.Text = "Guardar";
            this.btnGuardarCambios.TextColor = System.Drawing.Color.Black;
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Visible = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Yellow;
            this.btnModificar.BackgroundColor = System.Drawing.Color.Yellow;
            this.btnModificar.BorderColor = System.Drawing.Color.Transparent;
            this.btnModificar.BorderRadius = 10;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(12, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(72, 26);
            this.btnModificar.TabIndex = 79;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.Black;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnVolver.TabIndex = 61;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextColor = System.Drawing.Color.Black;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCancelarModificacion
            // 
            this.btnCancelarModificacion.BackColor = System.Drawing.Color.Yellow;
            this.btnCancelarModificacion.BackgroundColor = System.Drawing.Color.Yellow;
            this.btnCancelarModificacion.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancelarModificacion.BorderRadius = 10;
            this.btnCancelarModificacion.BorderSize = 0;
            this.btnCancelarModificacion.FlatAppearance.BorderSize = 0;
            this.btnCancelarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarModificacion.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarModificacion.Location = new System.Drawing.Point(12, 41);
            this.btnCancelarModificacion.Name = "btnCancelarModificacion";
            this.btnCancelarModificacion.Size = new System.Drawing.Size(72, 26);
            this.btnCancelarModificacion.TabIndex = 80;
            this.btnCancelarModificacion.Text = "Cancelar";
            this.btnCancelarModificacion.TextColor = System.Drawing.Color.Black;
            this.btnCancelarModificacion.UseVisualStyleBackColor = false;
            this.btnCancelarModificacion.Visible = false;
            this.btnCancelarModificacion.Click += new System.EventHandler(this.btnCancelarModificacion_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.Yellow;
            this.btnEliminarCategoria.BackgroundColor = System.Drawing.Color.Yellow;
            this.btnEliminarCategoria.BorderColor = System.Drawing.Color.Transparent;
            this.btnEliminarCategoria.BorderRadius = 10;
            this.btnEliminarCategoria.BorderSize = 0;
            this.btnEliminarCategoria.FlatAppearance.BorderSize = 0;
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(12, 73);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(72, 26);
            this.btnEliminarCategoria.TabIndex = 82;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.TextColor = System.Drawing.Color.Black;
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Visible = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // frmVerCategorias_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(673, 505);
            this.Controls.Add(this.lblSinResultado4);
            this.Controls.Add(this.lblSinResultado3);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridCategorias);
            this.Controls.Add(this.txtBusquedaDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelarModificacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerCategorias_Admin";
            this.Text = "Suplementos Salto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton btnVolver;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBusquedaDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridCategorias;
        private System.Windows.Forms.Label lblSinResultado4;
        private System.Windows.Forms.Label lblSinResultado3;
        private RJButton btnModificar;
        private RJButton btnCancelarModificacion;
        private RJButton btnGuardarCambios;
        private RJButton btnEliminarCategoria;
    }
}