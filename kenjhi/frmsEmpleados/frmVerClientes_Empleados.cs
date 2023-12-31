﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace kenjhi
{
    public partial class frmVerClientes_Empleados : Form
    {

        public frmVerClientes_Empleados()
        {
            InitializeComponent();
            txtBusquedaDGV.Text = "Ingresa un nombre de cliente para realizar la búsqueda";
            txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
            dataGridClientes.RowTemplate.Height = 40;
            dataGridClientes.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);



            try
            {
                MySqlConnection conexion = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;"); ;
                conexion.Open();

                string consulta = "SELECT ID_Cliente, Nombre, Telefono, Direccion, Email, CI FROM Cliente WHERE visible=1";


                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                System.Data.DataTable tablaClientes = new System.Data.DataTable();
                adaptador.Fill(tablaClientes);

                dataGridClientes.DataSource = tablaClientes;

                dataGridClientes.Columns["ID_Cliente"].HeaderText = "ID";
                dataGridClientes.Columns["ID_Cliente"].Visible = false;
                dataGridClientes.Columns["Nombre"].HeaderText = "Cliente";
                dataGridClientes.Columns["Telefono"].HeaderText = "Numero de teléfono";
                dataGridClientes.Columns["Direccion"].HeaderText = "Dirección";
                dataGridClientes.Columns["Email"].HeaderText = "Correo electrónico";
                dataGridClientes.Columns["CI"].HeaderText = "CI";


                dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn column in dataGridClientes.Columns)
                {
                    column.ReadOnly = true;
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (MySqlConnection connection = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;"))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT ID_Cliente, Nombre, Email, Telefono, Direccion, CI FROM Cliente", connection))
                    {
                        MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                        adapter.Update((DataTable)dataGridClientes.DataSource);
                    }

                    MessageBox.Show("Datos actualizados.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (txtBusquedaDGV.Text != "Ingresa un nombre de cliente para realizar la búsqueda")
                    {
                        txtBusquedaDGV.Clear();
                        txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
                        txtBusquedaDGV.Text = "Ingresa un nombre de cliente para realizar la búsqueda";

                    }

                    btnGuardarCambios.Visible = false;
                    btnEliminarCliente.Visible = false;
                    btnCancelarModificacion.Visible = false;
                    foreach (DataGridViewColumn column in dataGridClientes.Columns)
                    {
                        column.ReadOnly = true;
                    }
                    btnModificar.Visible = true;
                    try
                    {
                        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;"); ;
                        conexion.Open();

                        string consulta = "SELECT ID_Cliente, Nombre, Telefono, Direccion, Email, CI FROM Cliente WHERE visible=1";


                        MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                        System.Data.DataTable tablaClientes = new System.Data.DataTable();
                        adaptador.Fill(tablaClientes);

                        dataGridClientes.DataSource = tablaClientes;

                        dataGridClientes.Columns["ID_Cliente"].HeaderText = "ID";
                        dataGridClientes.Columns["ID_Cliente"].Visible = false;
                        dataGridClientes.Columns["Nombre"].HeaderText = "Cliente";
                        dataGridClientes.Columns["Telefono"].HeaderText = "Numero de teléfono";
                        dataGridClientes.Columns["Direccion"].HeaderText = "Dirección";
                        dataGridClientes.Columns["Email"].HeaderText = "Correo electrónico";
                        dataGridClientes.Columns["CI"].HeaderText = "CI";


                        dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        foreach (DataGridViewColumn column in dataGridClientes.Columns)
                        {
                            column.ReadOnly = true;
                        }
                        conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
        }

        private void dataGridClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridClientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
                if (dataGridClientes.IsCurrentCellDirty)
                {
                    btnGuardarCambios.Visible = true;
                     
                }
            }

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dataGridClientes.SelectedRows[0].Cells["ID_Cliente"].Value);

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;"))
                    {
                        conexion.Open();

                        string consultaActualizar = $"UPDATE Cliente SET visible=0 WHERE ID_Cliente={idCliente}";
                        MySqlCommand comandoActualizar = new MySqlCommand(consultaActualizar, conexion);
                        comandoActualizar.ExecuteNonQuery();

                        conexion.Close();

                        dataGridClientes.SelectedRows[0].Visible = false;

                        
                    }
                }
                catch 
                {
                    MessageBox.Show("Cliente eliminado.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (txtBusquedaDGV.Text != "Ingresa un nombre de cliente para realizar la búsqueda")
                    {
                        txtBusquedaDGV.Clear();
                        txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
                        txtBusquedaDGV.Text = "Ingresa un nombre de cliente para realizar la búsqueda";

                    }
                    try
                    {
                        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;"); ;
                        conexion.Open();

                        string consulta = "SELECT ID_Cliente, Nombre, Telefono, Direccion, Email, CI FROM Cliente WHERE visible=1";


                        MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                        System.Data.DataTable tablaClientes = new System.Data.DataTable();
                        adaptador.Fill(tablaClientes);

                        dataGridClientes.DataSource = tablaClientes;

                        dataGridClientes.Columns["ID_Cliente"].HeaderText = "ID";
                        dataGridClientes.Columns["ID_Cliente"].Visible = false;
                        dataGridClientes.Columns["Nombre"].HeaderText = "Cliente";
                        dataGridClientes.Columns["Telefono"].HeaderText = "Numero de teléfono";
                        dataGridClientes.Columns["Direccion"].HeaderText = "Dirección";
                        dataGridClientes.Columns["Email"].HeaderText = "Correo electrónico";
                        dataGridClientes.Columns["CI"].HeaderText = "CI";


                        dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        foreach (DataGridViewColumn column in dataGridClientes.Columns)
                        {
                            column.ReadOnly = true;
                        }
                        conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            btnEliminarCliente.Visible = false;
            btnGuardarCambios.Visible = false;
            btnCancelarModificacion.Visible = false;
            btnModificar.Visible = false;
            foreach (DataGridViewColumn column in dataGridClientes.Columns)
            {
                column.ReadOnly = true;
            }
            btnModificar.Visible = true;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridClientes.Columns)
            {
                column.ReadOnly = false;
            }
            btnModificar.Visible = false;
            if (btnModificar.Visible == false) { btnCancelarModificacion.Visible = true; }
            if (btnCancelarModificacion.Visible == true) { btnModificar.Visible = false; }
        }

       

        private void txtBusquedaDGV_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (txtBusquedaDGV.Text.Length == 0)
            {
                try
                {
                    MySqlConnection conexion = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;"); ;
                    conexion.Open();

                    string consulta = "SELECT ID_Cliente, Nombre, Telefono, Direccion, Email, CI FROM Cliente WHERE visible=1";


                    MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                    System.Data.DataTable tablaClientes = new System.Data.DataTable();
                    adaptador.Fill(tablaClientes);

                    dataGridClientes.DataSource = tablaClientes;

                    dataGridClientes.Columns["ID_Cliente"].HeaderText = "ID";
                    dataGridClientes.Columns["ID_Cliente"].Visible = false;
                    dataGridClientes.Columns["Nombre"].HeaderText = "Cliente";
                    dataGridClientes.Columns["Telefono"].HeaderText = "Numero de teléfono";
                    dataGridClientes.Columns["Direccion"].HeaderText = "Dirección";
                    dataGridClientes.Columns["Email"].HeaderText = "Correo electrónico";
                    dataGridClientes.Columns["CI"].HeaderText = "CI";


                    dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    foreach (DataGridViewColumn column in dataGridClientes.Columns)
                    {
                        column.ReadOnly = true;
                    }
                    if (lblSinResultado.Visible == true)
                    {
                        lblSinResultado.Visible = false;
                    }
                    if (lblSinResultado2.Visible == true)
                    {
                        lblSinResultado2.Visible = false;
                    }


                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            if (txtBusquedaDGV.Text.Length > 0)
            {
                string textoBusqueda = txtBusquedaDGV.Text;
                using (MySqlConnection conexion = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;"))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM cliente WHERE Visible = 1 AND Nombre LIKE @textoBusqueda";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridClientes.DataSource = dataTable;
                        dataGridClientes.Columns["Visible"].Visible = false;
                        if (dataTable.Rows.Count == 0)
                        {
                            lblSinResultado.Visible = true;
                            lblSinResultado2.Visible = true;

                        }
                        else
                        {
                            lblSinResultado.Visible = false;
                            lblSinResultado2.Visible = false;
                        }
                    }
                }

            }
        }

        private void txtBusquedaDGV_MouseClick(object sender, MouseEventArgs e)
        {   

            if (txtBusquedaDGV.Text == "Ingresa un nombre de cliente para realizar la búsqueda") { txtBusquedaDGV.Clear(); txtBusquedaDGV.ForeColor = System.Drawing.Color.White; }
        }

        private void dataGridClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEliminarCliente.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridClientes_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dataGridClientes.Columns["CI"].Index)
            {
                string nuevoValorCI = e.FormattedValue.ToString();

                if (!EsNumero(nuevoValorCI))
                {
                    MessageBox.Show("El campo CI solo debe contener dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }

                if (string.IsNullOrEmpty(nuevoValorCI))
                {
                    MessageBox.Show("No se puede dejar vacío el campo CI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
                else if (nuevoValorCI.Length > 8)
                {
                    MessageBox.Show("La CI no puede tener más de 8 dígitos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }

            if (e.ColumnIndex == dataGridClientes.Columns["Telefono"].Index)
            {
                string nuevoValor = e.FormattedValue.ToString();


                if (!EsNumero(nuevoValor))
                {

                    MessageBox.Show("El número de teléfono debe contener solo dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }


                if (nuevoValor.Length > 9)
                {

                    MessageBox.Show("El número de teléfono no puede tener más de 9 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }

            if (e.ColumnIndex == dataGridClientes.Columns["Nombre"].Index)
            {
                string nuevoValorNombre = e.FormattedValue.ToString();

                if (nuevoValorNombre.Length > 25)
                {
                    MessageBox.Show("El nombre de cliente contiene demasiados caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }

            if (e.ColumnIndex == dataGridClientes.Columns["Direccion"].Index)
            {
                string nuevoValorDireccion = e.FormattedValue.ToString();

                if (nuevoValorDireccion.Length > 50)
                {
                    MessageBox.Show("La dirección del cliente no puede tener más de 50 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }

            if (e.ColumnIndex == dataGridClientes.Columns["Email"].Index)
            {
                string nuevoValorEmail = e.FormattedValue.ToString();

                if (!string.IsNullOrEmpty(nuevoValorEmail) && !EsCorreoElectronicoValido(nuevoValorEmail))
                {
                    MessageBox.Show("El correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }

                if (nuevoValorEmail.Length > 50)
                {
                    MessageBox.Show("El correo electrónico ingresado contiene demasiados caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private bool EsNumero(string cadena)
        {
            return cadena.All(char.IsDigit);
        }

        private bool EsCorreoElectronicoValido(string correo)
        {
            return Regex.IsMatch(correo, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$");
        }
    }
}
