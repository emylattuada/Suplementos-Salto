﻿namespace kenjhi
{
    partial class Ingresos_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresos_Producto));
            this.btnVolver = new kenjhi.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboListaProductos = new System.Windows.Forms.ComboBox();
            this.linkCrearProducto = new System.Windows.Forms.LinkLabel();
            this.numericCantidadIngreso = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dataAgregarIngreso = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCrearIngreso = new kenjhi.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadIngreso)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(107, -8);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.label1.Size = new System.Drawing.Size(466, 123);
            this.label1.TabIndex = 43;
            this.label1.Text = "Completa los datos del nuevo ingreso\r\n\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(497, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "Obligatorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(117, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Selecciona el producto";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(120, 143);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 1);
            this.textBox1.TabIndex = 61;
            // 
            // comboListaProductos
            // 
            this.comboListaProductos.BackColor = System.Drawing.Color.Black;
            this.comboListaProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboListaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboListaProductos.ForeColor = System.Drawing.Color.White;
            this.comboListaProductos.FormattingEnabled = true;
            this.comboListaProductos.Location = new System.Drawing.Point(120, 115);
            this.comboListaProductos.Name = "comboListaProductos";
            this.comboListaProductos.Size = new System.Drawing.Size(450, 24);
            this.comboListaProductos.TabIndex = 64;
            // 
            // linkCrearProducto
            // 
            this.linkCrearProducto.ActiveLinkColor = System.Drawing.Color.White;
            this.linkCrearProducto.AutoSize = true;
            this.linkCrearProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCrearProducto.ForeColor = System.Drawing.Color.DimGray;
            this.linkCrearProducto.LinkColor = System.Drawing.Color.DimGray;
            this.linkCrearProducto.Location = new System.Drawing.Point(329, 147);
            this.linkCrearProducto.Name = "linkCrearProducto";
            this.linkCrearProducto.Size = new System.Drawing.Size(241, 16);
            this.linkCrearProducto.TabIndex = 83;
            this.linkCrearProducto.TabStop = true;
            this.linkCrearProducto.Text = "Pasos para agregar un nuevo producto";
            this.linkCrearProducto.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.linkCrearProducto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCrearProducto_LinkClicked);
            // 
            // numericCantidadIngreso
            // 
            this.numericCantidadIngreso.BackColor = System.Drawing.Color.Black;
            this.numericCantidadIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericCantidadIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCantidadIngreso.ForeColor = System.Drawing.Color.White;
            this.numericCantidadIngreso.Location = new System.Drawing.Point(120, 220);
            this.numericCantidadIngreso.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericCantidadIngreso.Name = "numericCantidadIngreso";
            this.numericCantidadIngreso.Size = new System.Drawing.Size(450, 22);
            this.numericCantidadIngreso.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(114, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 85;
            this.label11.Text = "Cantidad";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Yellow;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(120, 245);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(450, 1);
            this.textBox7.TabIndex = 84;
            // 
            // dataAgregarIngreso
            // 
            this.dataAgregarIngreso.Location = new System.Drawing.Point(120, 315);
            this.dataAgregarIngreso.Name = "dataAgregarIngreso";
            this.dataAgregarIngreso.Size = new System.Drawing.Size(450, 20);
            this.dataAgregarIngreso.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(117, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 88;
            this.label3.Text = "Fecha";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Yellow;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(120, 338);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(450, 1);
            this.textBox2.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(497, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 90;
            this.label4.Text = "Obligatorio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(500, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 91;
            this.label6.Text = "Obligatorio";
            // 
            // btnCrearIngreso
            // 
            this.btnCrearIngreso.BackColor = System.Drawing.Color.Yellow;
            this.btnCrearIngreso.BackgroundColor = System.Drawing.Color.Yellow;
            this.btnCrearIngreso.BorderColor = System.Drawing.Color.Transparent;
            this.btnCrearIngreso.BorderRadius = 10;
            this.btnCrearIngreso.BorderSize = 0;
            this.btnCrearIngreso.FlatAppearance.BorderSize = 0;
            this.btnCrearIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearIngreso.ForeColor = System.Drawing.Color.Black;
            this.btnCrearIngreso.Location = new System.Drawing.Point(113, 388);
            this.btnCrearIngreso.Name = "btnCrearIngreso";
            this.btnCrearIngreso.Size = new System.Drawing.Size(450, 44);
            this.btnCrearIngreso.TabIndex = 92;
            this.btnCrearIngreso.Text = "Agregar";
            this.btnCrearIngreso.TextColor = System.Drawing.Color.Black;
            this.btnCrearIngreso.UseVisualStyleBackColor = false;
            this.btnCrearIngreso.Click += new System.EventHandler(this.btnCrearIngreso_Click);
            // 
            // Ingresos_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(673, 505);
            this.Controls.Add(this.btnCrearIngreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataAgregarIngreso);
            this.Controls.Add(this.numericCantidadIngreso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.linkCrearProducto);
            this.Controls.Add(this.comboListaProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ingresos_Producto";
            this.Text = "Suplementos Salto";
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadIngreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboListaProductos;
        private System.Windows.Forms.LinkLabel linkCrearProducto;
        private System.Windows.Forms.NumericUpDown numericCantidadIngreso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker dataAgregarIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private RJButton btnCrearIngreso;
    }
}