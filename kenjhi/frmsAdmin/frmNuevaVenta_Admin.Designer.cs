namespace kenjhi
{
    partial class frmNuevaVenta_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaVenta_Admin));
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboListaProductos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboListaClientes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericCantidadVenta = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericCuotasVenta = new System.Windows.Forms.NumericUpDown();
            this.dataGridCarrito = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.radioContado = new System.Windows.Forms.RadioButton();
            this.radioCuotas = new System.Windows.Forms.RadioButton();
            this.dataFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.picturePasosCliente = new System.Windows.Forms.PictureBox();
            this.picPasosProducto = new System.Windows.Forms.PictureBox();
            this.btnAgregarAlCarrito = new kenjhi.RJButton();
            this.btnBorrarFilaCarrito = new kenjhi.RJButton();
            this.btnNuevaVenta = new kenjhi.RJButton();
            this.btnVolver = new kenjhi.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCuotasVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasosProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(107, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Menú principal > Ventas > Nueva venta";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(107, 11);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.label1.Size = new System.Drawing.Size(470, 62);
            this.label1.TabIndex = 66;
            this.label1.Text = "Completa los datos de la nueva venta\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboListaProductos
            // 
            this.comboListaProductos.BackColor = System.Drawing.Color.Black;
            this.comboListaProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboListaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboListaProductos.ForeColor = System.Drawing.Color.White;
            this.comboListaProductos.FormattingEnabled = true;
            this.comboListaProductos.Location = new System.Drawing.Point(119, 166);
            this.comboListaProductos.Name = "comboListaProductos";
            this.comboListaProductos.Size = new System.Drawing.Size(346, 24);
            this.comboListaProductos.TabIndex = 70;
            this.comboListaProductos.Click += new System.EventHandler(this.comboListaProductos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(397, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "Obligatorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(116, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "Selecciona el producto";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(119, 194);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 1);
            this.textBox1.TabIndex = 67;
            // 
            // comboListaClientes
            // 
            this.comboListaClientes.BackColor = System.Drawing.Color.Black;
            this.comboListaClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboListaClientes.ForeColor = System.Drawing.Color.White;
            this.comboListaClientes.FormattingEnabled = true;
            this.comboListaClientes.Location = new System.Drawing.Point(119, 109);
            this.comboListaClientes.Name = "comboListaClientes";
            this.comboListaClientes.Size = new System.Drawing.Size(450, 24);
            this.comboListaClientes.TabIndex = 74;
            this.comboListaClientes.Click += new System.EventHandler(this.comboListaClientes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(496, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "Obligatorio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(116, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "Selecciona el cliente";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Yellow;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(119, 137);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(450, 1);
            this.textBox2.TabIndex = 71;
            // 
            // numericCantidadVenta
            // 
            this.numericCantidadVenta.BackColor = System.Drawing.Color.Black;
            this.numericCantidadVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericCantidadVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCantidadVenta.ForeColor = System.Drawing.Color.White;
            this.numericCantidadVenta.Location = new System.Drawing.Point(479, 166);
            this.numericCantidadVenta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericCantidadVenta.Name = "numericCantidadVenta";
            this.numericCantidadVenta.Size = new System.Drawing.Size(90, 22);
            this.numericCantidadVenta.TabIndex = 87;
            this.numericCantidadVenta.ValueChanged += new System.EventHandler(this.numericCantidadVenta_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(476, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 88;
            this.label6.Text = "Cantidad";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Yellow;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(479, 194);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 1);
            this.textBox3.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(116, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 97;
            this.label8.Text = "Tipo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(229, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 99;
            this.label9.Text = "Obligatorio";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Yellow;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(119, 290);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(178, 1);
            this.textBox5.TabIndex = 98;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Yellow;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(483, 293);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(90, 1);
            this.textBox6.TabIndex = 103;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(480, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 102;
            this.label11.Text = "Cuotas";
            // 
            // numericCuotasVenta
            // 
            this.numericCuotasVenta.BackColor = System.Drawing.Color.Black;
            this.numericCuotasVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericCuotasVenta.Enabled = false;
            this.numericCuotasVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCuotasVenta.ForeColor = System.Drawing.Color.White;
            this.numericCuotasVenta.Location = new System.Drawing.Point(483, 265);
            this.numericCuotasVenta.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericCuotasVenta.Name = "numericCuotasVenta";
            this.numericCuotasVenta.ReadOnly = true;
            this.numericCuotasVenta.Size = new System.Drawing.Size(90, 22);
            this.numericCuotasVenta.TabIndex = 101;
            // 
            // dataGridCarrito
            // 
            this.dataGridCarrito.AllowUserToAddRows = false;
            this.dataGridCarrito.AllowUserToDeleteRows = false;
            this.dataGridCarrito.AllowUserToOrderColumns = true;
            this.dataGridCarrito.AllowUserToResizeColumns = false;
            this.dataGridCarrito.AllowUserToResizeRows = false;
            this.dataGridCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridCarrito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCarrito.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCarrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCarrito.ColumnHeadersHeight = 35;
            this.dataGridCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCarrito.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCarrito.EnableHeadersVisualStyles = false;
            this.dataGridCarrito.GridColor = System.Drawing.Color.Yellow;
            this.dataGridCarrito.Location = new System.Drawing.Point(119, 334);
            this.dataGridCarrito.Name = "dataGridCarrito";
            this.dataGridCarrito.ReadOnly = true;
            this.dataGridCarrito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCarrito.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCarrito.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridCarrito.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCarrito.Size = new System.Drawing.Size(454, 78);
            this.dataGridCarrito.TabIndex = 104;
            this.dataGridCarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCarrito_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(38, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 105;
            this.label12.Text = "Carrito";
            // 
            // radioContado
            // 
            this.radioContado.AutoSize = true;
            this.radioContado.ForeColor = System.Drawing.Color.White;
            this.radioContado.Location = new System.Drawing.Point(119, 267);
            this.radioContado.Name = "radioContado";
            this.radioContado.Size = new System.Drawing.Size(65, 17);
            this.radioContado.TabIndex = 111;
            this.radioContado.TabStop = true;
            this.radioContado.Text = "Contado";
            this.radioContado.UseVisualStyleBackColor = true;
            this.radioContado.CheckedChanged += new System.EventHandler(this.radioContado_CheckedChanged);
            this.radioContado.Click += new System.EventHandler(this.radioContado_Click);
            // 
            // radioCuotas
            // 
            this.radioCuotas.AutoSize = true;
            this.radioCuotas.ForeColor = System.Drawing.Color.White;
            this.radioCuotas.Location = new System.Drawing.Point(244, 267);
            this.radioCuotas.Name = "radioCuotas";
            this.radioCuotas.Size = new System.Drawing.Size(58, 17);
            this.radioCuotas.TabIndex = 112;
            this.radioCuotas.TabStop = true;
            this.radioCuotas.Text = "Cuotas";
            this.radioCuotas.UseVisualStyleBackColor = true;
            this.radioCuotas.CheckedChanged += new System.EventHandler(this.radioCuotas_CheckedChanged);
            this.radioCuotas.Click += new System.EventHandler(this.radioCuotas_Click);
            // 
            // dataFechaVenta
            // 
            this.dataFechaVenta.CalendarForeColor = System.Drawing.Color.White;
            this.dataFechaVenta.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dataFechaVenta.Location = new System.Drawing.Point(167, 304);
            this.dataFechaVenta.Name = "dataFechaVenta";
            this.dataFechaVenta.Size = new System.Drawing.Size(406, 20);
            this.dataFechaVenta.TabIndex = 113;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label15.Location = new System.Drawing.Point(116, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 16);
            this.label15.TabIndex = 114;
            this.label15.Text = "Fecha";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Yellow;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(119, 418);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(454, 1);
            this.textBox4.TabIndex = 116;
            // 
            // picturePasosCliente
            // 
            this.picturePasosCliente.Image = ((System.Drawing.Image)(resources.GetObject("picturePasosCliente.Image")));
            this.picturePasosCliente.Location = new System.Drawing.Point(244, 91);
            this.picturePasosCliente.Name = "picturePasosCliente";
            this.picturePasosCliente.Size = new System.Drawing.Size(19, 15);
            this.picturePasosCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePasosCliente.TabIndex = 119;
            this.picturePasosCliente.TabStop = false;
            this.picturePasosCliente.Click += new System.EventHandler(this.picturePasosCliente_Click);
            this.picturePasosCliente.MouseEnter += new System.EventHandler(this.picturePasosCliente_MouseEnter);
            this.picturePasosCliente.MouseLeave += new System.EventHandler(this.picturePasosCliente_MouseLeave);
            // 
            // picPasosProducto
            // 
            this.picPasosProducto.Image = ((System.Drawing.Image)(resources.GetObject("picPasosProducto.Image")));
            this.picPasosProducto.Location = new System.Drawing.Point(257, 148);
            this.picPasosProducto.Name = "picPasosProducto";
            this.picPasosProducto.Size = new System.Drawing.Size(19, 15);
            this.picPasosProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPasosProducto.TabIndex = 120;
            this.picPasosProducto.TabStop = false;
            this.picPasosProducto.Click += new System.EventHandler(this.picPasosProducto_Click);
            this.picPasosProducto.MouseEnter += new System.EventHandler(this.picPasosProducto_MouseEnter);
            this.picPasosProducto.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.picPasosProducto.MouseHover += new System.EventHandler(this.picPasosProducto_MouseHover);
            // 
            // btnAgregarAlCarrito
            // 
            this.btnAgregarAlCarrito.BackColor = System.Drawing.Color.Yellow;
            this.btnAgregarAlCarrito.BackgroundColor = System.Drawing.Color.Yellow;
            this.btnAgregarAlCarrito.BorderColor = System.Drawing.Color.Transparent;
            this.btnAgregarAlCarrito.BorderRadius = 10;
            this.btnAgregarAlCarrito.BorderSize = 0;
            this.btnAgregarAlCarrito.FlatAppearance.BorderSize = 0;
            this.btnAgregarAlCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlCarrito.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarAlCarrito.Location = new System.Drawing.Point(119, 205);
            this.btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            this.btnAgregarAlCarrito.Size = new System.Drawing.Size(450, 26);
            this.btnAgregarAlCarrito.TabIndex = 118;
            this.btnAgregarAlCarrito.Text = "Agregar al carrito";
            this.btnAgregarAlCarrito.TextColor = System.Drawing.Color.Black;
            this.btnAgregarAlCarrito.UseVisualStyleBackColor = false;
            this.btnAgregarAlCarrito.Click += new System.EventHandler(this.btnAgregarAlCarrito_Click);
            // 
            // btnBorrarFilaCarrito
            // 
            this.btnBorrarFilaCarrito.BackColor = System.Drawing.Color.Yellow;
            this.btnBorrarFilaCarrito.BackgroundColor = System.Drawing.Color.Yellow;
            this.btnBorrarFilaCarrito.BorderColor = System.Drawing.Color.Transparent;
            this.btnBorrarFilaCarrito.BorderRadius = 10;
            this.btnBorrarFilaCarrito.BorderSize = 0;
            this.btnBorrarFilaCarrito.FlatAppearance.BorderSize = 0;
            this.btnBorrarFilaCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarFilaCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarFilaCarrito.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarFilaCarrito.Location = new System.Drawing.Point(579, 334);
            this.btnBorrarFilaCarrito.Name = "btnBorrarFilaCarrito";
            this.btnBorrarFilaCarrito.Size = new System.Drawing.Size(90, 23);
            this.btnBorrarFilaCarrito.TabIndex = 117;
            this.btnBorrarFilaCarrito.Text = "Borrar";
            this.btnBorrarFilaCarrito.TextColor = System.Drawing.Color.Black;
            this.btnBorrarFilaCarrito.UseVisualStyleBackColor = false;
            this.btnBorrarFilaCarrito.Visible = false;
            this.btnBorrarFilaCarrito.Click += new System.EventHandler(this.btnBorrarFilaCarrito_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.BackColor = System.Drawing.Color.Yellow;
            this.btnNuevaVenta.BackgroundColor = System.Drawing.Color.Yellow;
            this.btnNuevaVenta.BorderColor = System.Drawing.Color.Transparent;
            this.btnNuevaVenta.BorderRadius = 10;
            this.btnNuevaVenta.BorderSize = 0;
            this.btnNuevaVenta.FlatAppearance.BorderSize = 0;
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.Black;
            this.btnNuevaVenta.Location = new System.Drawing.Point(119, 436);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(450, 44);
            this.btnNuevaVenta.TabIndex = 106;
            this.btnNuevaVenta.Text = "Guardar";
            this.btnNuevaVenta.TextColor = System.Drawing.Color.Black;
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
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
            // frmNuevaVenta_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(673, 505);
            this.Controls.Add(this.picPasosProducto);
            this.Controls.Add(this.picturePasosCliente);
            this.Controls.Add(this.radioCuotas);
            this.Controls.Add(this.radioContado);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericCuotasVenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAgregarAlCarrito);
            this.Controls.Add(this.btnBorrarFilaCarrito);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataFechaVenta);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridCarrito);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericCantidadVenta);
            this.Controls.Add(this.comboListaClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboListaProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevaVenta_Admin";
            this.Text = "Suplementos Salto";
            this.Load += new System.EventHandler(this.Nueva_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCuotasVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePasosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasosProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton btnVolver;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboListaProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboListaClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericCantidadVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericCuotasVenta;
        private System.Windows.Forms.DataGridView dataGridCarrito;
        private System.Windows.Forms.Label label12;
        private RJButton btnNuevaVenta;
        private System.Windows.Forms.RadioButton radioContado;
        private System.Windows.Forms.RadioButton radioCuotas;
        private System.Windows.Forms.DateTimePicker dataFechaVenta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox4;
        private RJButton btnBorrarFilaCarrito;
        private RJButton btnAgregarAlCarrito;
        private System.Windows.Forms.PictureBox picturePasosCliente;
        private System.Windows.Forms.PictureBox picPasosProducto;
    }
}