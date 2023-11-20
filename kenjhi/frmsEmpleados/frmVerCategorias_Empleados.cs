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


namespace kenjhi.frmsAdmin
{
    public partial class frmVerCategorias_Empleados : Form
    {
        public frmVerCategorias_Empleados()
        {
            InitializeComponent();

            txtBusquedaDGV.Text = "Ingresa un nombre de categoría para realizar la búsqueda";
            txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
            dataGridCategorias.RowTemplate.Height = 40;
            dataGridCategorias.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
           
            CargarDatosCate();

        }

        private void CargarDatosCate()
        {

            try
            {
                MySqlConnection conexion = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;");
                conexion.Open();

                string consulta = "SELECT ID_Categoria, Nombre, Descripcion FROM categoria WHERE visible=1";

                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                DataTable tablaCategorias = new DataTable();
                adaptador.Fill(tablaCategorias);

                dataGridCategorias.DataSource = tablaCategorias;

                dataGridCategorias.Columns["ID_Categoria"].Visible = false;
                dataGridCategorias.Columns["Nombre"].HeaderText = "Nombre";
                dataGridCategorias.Columns["Descripcion"].HeaderText = "Descripción";

                dataGridCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                foreach (DataGridViewColumn column in dataGridCategorias.Columns)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dataGridCategorias.ReadOnly = false;
            btnModificar.Visible = false;
            btnCancelarModificacion.Visible = true;
        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            dataGridCategorias.ReadOnly = true;
            btnCancelarModificacion.Visible = false;
            btnModificar.Visible = true;
        }

        private void dataGridCategorias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                if (dataGridCategorias.IsCurrentCellDirty)
                {

                    btnGuardarCambios.Visible = true;


                }
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {


            try
            {
                using (MySqlConnection connection = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;"))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT ID_Categoria, Nombre, Descripcion FROM Categoria", connection))
                    {
                        MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                        adapter.Update((DataTable)dataGridCategorias.DataSource);
                    }

                    MessageBox.Show("Datos de categorías actualizados.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardarCambios.Visible = false;
                    btnCancelarModificacion.Visible = false;
                    btnModificar.Visible = true;
                    CargarDatosCate();
                    if (txtBusquedaDGV.Text != "Ingresa un nombre de categoría para realizar la búsqueda")
                    {
                        txtBusquedaDGV.Clear();
                        txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
                        txtBusquedaDGV.Text = "Ingresa un nombre de categoría para realizar la búsqueda";

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dataGridCategorias.SelectedRows.Count > 0)
            {
                int idCategoria = Convert.ToInt32(dataGridCategorias.SelectedRows[0].Cells["ID_Categoria"].Value);

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;"))
                    {
                        conexion.Open();

                        string actualizarCategoria = $"UPDATE categoria SET visible = 0 WHERE ID_Categoria = {idCategoria}";
                        MySqlCommand comandoActualizarCategoria = new MySqlCommand(actualizarCategoria, conexion);
                        comandoActualizarCategoria.ExecuteNonQuery();

                        MessageBox.Show("Categoría eliminada.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (txtBusquedaDGV.Text != "Ingresa un nombre de categoría para realizar la búsqueda")
                        {
                            txtBusquedaDGV.Clear();
                            txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
                            txtBusquedaDGV.Text = "Ingresa un nombre de categoría para realizar la búsqueda";

                        }
                        CargarDatosCate();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al ocultar la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminarCategoria.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtBusquedaDGV_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBusquedaDGV.Text == "Ingresa un nombre de categoría para realizar la búsqueda") { txtBusquedaDGV.Clear(); txtBusquedaDGV.ForeColor = System.Drawing.Color.White; }

        }

        private void txtBusquedaDGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBusquedaDGV.Text.Length == 0)
            {
                try
                {
                    MySqlConnection conexion = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;");
                    conexion.Open();

                    string consulta = "SELECT ID_Categoria, Nombre, Descripcion FROM categoria WHERE visible=1";

                    MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                    DataTable tablaCategorias = new DataTable();
                    adaptador.Fill(tablaCategorias);

                    dataGridCategorias.DataSource = tablaCategorias;

                    dataGridCategorias.Columns["ID_Categoria"].Visible = false;
                    dataGridCategorias.Columns["Nombre"].HeaderText = "Nombre";
                    dataGridCategorias.Columns["Descripcion"].HeaderText = "Descripción";

                    dataGridCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    foreach (DataGridViewColumn column in dataGridCategorias.Columns)
                    {
                        column.ReadOnly = true;
                    }

                    if (lblSinResultado3.Visible)
                    {
                        lblSinResultado3.Visible = false;
                        lblSinResultado4.Visible = false;
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
                    string consulta = "SELECT ID_Categoria, Nombre, Descripcion FROM categoria WHERE visible=1 AND Nombre LIKE @textoBusqueda OR Descripcion LIKE @textoBusqueda";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridCategorias.DataSource = dataTable;
                        dataGridCategorias.Columns["ID_Categoria"].Visible = false;
                        if (dataTable.Rows.Count == 0)
                        {
                            lblSinResultado3.Visible = true;
                            lblSinResultado4.Visible = true;
                        }
                        else
                        {
                            lblSinResultado3.Visible = false;
                            lblSinResultado4.Visible = false;
                        }
                    }
                }
            }
        }

        private void dataGridCategorias_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridCategorias.Columns["Nombre"].Index)
            {
                string nuevoValorNombre = e.FormattedValue.ToString();

                if (nuevoValorNombre.Length > 25)
                {
                    MessageBox.Show("El nombre de categoría contiene demasiados caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridCategorias.Columns["Descripcion"].Index)
            {
                string nuevoValorNombre = e.FormattedValue.ToString();

                if (nuevoValorNombre.Length > 25)
                {
                    MessageBox.Show("La descripción contiene demasiados caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
    }
}
