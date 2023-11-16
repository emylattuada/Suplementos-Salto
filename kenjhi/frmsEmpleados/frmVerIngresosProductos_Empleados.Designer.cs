namespace kenjhi
{
    partial class frmVerIngresosProductos_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerIngresosProductos_Empleados));
            this.btnVolver = new kenjhi.RJButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBusquedaDGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridIngresosProd = new System.Windows.Forms.DataGridView();
            this.lblSinResultado2 = new System.Windows.Forms.Label();
            this.lblSinResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIngresosProd)).BeginInit();
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
            this.btnVolver.TabIndex = 61;
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
            this.label10.Size = new System.Drawing.Size(206, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Menú principal > Productos > Ver ingresos";
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
            this.txtBusquedaDGV.TabIndex = 68;
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
            this.label1.TabIndex = 67;
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
            this.textBox1.TabIndex = 66;
            // 
            // dataGridIngresosProd
            // 
            this.dataGridIngresosProd.AllowUserToAddRows = false;
            this.dataGridIngresosProd.AllowUserToDeleteRows = false;
            this.dataGridIngresosProd.AllowUserToOrderColumns = true;
            this.dataGridIngresosProd.AllowUserToResizeColumns = false;
            this.dataGridIngresosProd.AllowUserToResizeRows = false;
            this.dataGridIngresosProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridIngresosProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridIngresosProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridIngresosProd.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridIngresosProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridIngresosProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridIngresosProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridIngresosProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridIngresosProd.ColumnHeadersHeight = 35;
            this.dataGridIngresosProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridIngresosProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridIngresosProd.EnableHeadersVisualStyles = false;
            this.dataGridIngresosProd.GridColor = System.Drawing.Color.Yellow;
            this.dataGridIngresosProd.Location = new System.Drawing.Point(110, 88);
            this.dataGridIngresosProd.Name = "dataGridIngresosProd";
            this.dataGridIngresosProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridIngresosProd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridIngresosProd.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridIngresosProd.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridIngresosProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridIngresosProd.Size = new System.Drawing.Size(535, 405);
            this.dataGridIngresosProd.TabIndex = 69;
            // 
            // lblSinResultado2
            // 
            this.lblSinResultado2.AutoSize = true;
            this.lblSinResultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinResultado2.ForeColor = System.Drawing.Color.White;
            this.lblSinResultado2.Location = new System.Drawing.Point(321, 268);
            this.lblSinResultado2.Name = "lblSinResultado2";
            this.lblSinResultado2.Size = new System.Drawing.Size(123, 16);
            this.lblSinResultado2.TabIndex = 71;
            this.lblSinResultado2.Text = "Intente nuevamente";
            this.lblSinResultado2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSinResultado2.Visible = false;
            // 
            // lblSinResultado
            // 
            this.lblSinResultado.AutoSize = true;
            this.lblSinResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinResultado.ForeColor = System.Drawing.Color.White;
            this.lblSinResultado.Location = new System.Drawing.Point(117, 243);
            this.lblSinResultado.Name = "lblSinResultado";
            this.lblSinResultado.Size = new System.Drawing.Size(528, 25);
            this.lblSinResultado.TabIndex = 70;
            this.lblSinResultado.Text = "El producto ingresado no ha recibido nuevos ingresos";
            this.lblSinResultado.Visible = false;
            // 
            // frmVerIngresosProductos_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(673, 505);
            this.Controls.Add(this.lblSinResultado2);
            this.Controls.Add(this.lblSinResultado);
            this.Controls.Add(this.dataGridIngresosProd);
            this.Controls.Add(this.txtBusquedaDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnVolver);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerIngresosProductos_Empleados";
            this.Text = "Suplementos Salto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIngresosProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton btnVolver;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBusquedaDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridIngresosProd;
        private System.Windows.Forms.Label lblSinResultado2;
        private System.Windows.Forms.Label lblSinResultado;
    }
}