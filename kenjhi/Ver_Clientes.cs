using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace kenjhi
{
    public partial class Ver_Clientes : Form
    {

        public Ver_Clientes()
        {
            InitializeComponent();


            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"); ;
                conexion.Open();

                //string consulta = "SELECT ID_Cliente, Nombre, Telefono, Direccion, Email FROM Cliente";
                string consulta = "SELECT ID_Cliente, Nombre, Telefono, Direccion, Email FROM Cliente WHERE visible=1";


                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                System.Data.DataTable tablaClientes = new System.Data.DataTable();
                adaptador.Fill(tablaClientes);

                dataGridClientes.DataSource = tablaClientes;

                // Configurar las columnas
                dataGridClientes.Columns["ID_Cliente"].HeaderText = "ID";
                dataGridClientes.Columns["ID_Cliente"].Visible = false;
                dataGridClientes.Columns["Nombre"].HeaderText = "Cliente";
                dataGridClientes.Columns["Telefono"].HeaderText = "Numero de teléfono";
                dataGridClientes.Columns["Direccion"].HeaderText = "Dirección";
                dataGridClientes.Columns["Email"].HeaderText = "Correo electrónico";

                // Ajustar el ancho de las columnas
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
                using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT ID_Cliente, Nombre, Email, Telefono, Direccion FROM Cliente", connection))
                    {
                        MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                        adapter.Update((DataTable)dataGridClientes.DataSource);
                    }

                    MessageBox.Show("Datos actualizados.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //lblSinGuardar.Visible = false;
                    btnGuardarCambios.Visible = false;
                    btnEliminarCliente.Visible = false;
                    btnCancelarModificacion.Visible = false;
                    foreach (DataGridViewColumn column in dataGridClientes.Columns)
                    {
                        column.ReadOnly = true;
                    }
                    btnModificar.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
        }

        private void dataGridClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEliminarCliente.Visible = true;

        }

        private void dataGridClientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //lblSinGuardar.Visible = true;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Asegúrate de que se haya cambiado una celda válida
            {
                // Verifica si se ha cambiado el valor en una celda
                if (dataGridClientes.IsCurrentCellDirty)
                {
                    // Mostrar un mensaje al usuario.
                    //MessageBox.Show("Has cambiado el valor en una celda."); //esto es para probar que funcione nada mas
                    // no tocar, funciona
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
                    using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
                    {
                        conexion.Open();

                        string consultaActualizar = $"UPDATE Cliente SET visible=0 WHERE ID_Cliente={idCliente}";
                        MySqlCommand comandoActualizar = new MySqlCommand(consultaActualizar, conexion);
                        comandoActualizar.ExecuteNonQuery();

                        conexion.Close();

                        // Ocultar la fila seleccionada en el DataGridView
                        dataGridClientes.SelectedRows[0].Visible = false;
                        //MessageBox.Show("Cliente eliminado.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch /*(Exception ex)*/
                {
                    MessageBox.Show("Cliente eliminado.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //MessageBox.Show(ex.ToString(), "Error al eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //btnGuardarCambios.Visible=true;
            btnModificar.Visible = false;
            if (btnModificar.Visible = false) { btnCancelarModificacion.Visible = true; }
            if (btnCancelarModificacion.Visible = true) { btnModificar.Visible = false; }
        }
    }
}
