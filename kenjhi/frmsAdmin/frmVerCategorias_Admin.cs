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
    public partial class frmVerCategorias_Admin : Form
    {
        public frmVerCategorias_Admin()
        {
            InitializeComponent();
            txtBusquedaDGV.Text = "Ingresa un nombre para realizar la búsqueda";
            txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
            dataGridCategorias.RowTemplate.Height = 40;
            dataGridCategorias.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10); 

            CargarDatosCate();

        }

        private void CargarDatosCate()
        {

            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
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
                using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
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
                    using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                    {
                        conexion.Open();

                        string actualizarCategoria = $"UPDATE categoria SET visible = 0 WHERE ID_Categoria = {idCategoria}";
                        MySqlCommand comandoActualizarCategoria = new MySqlCommand(actualizarCategoria, conexion);
                        comandoActualizarCategoria.ExecuteNonQuery();

                        MessageBox.Show("Categoría eliminada.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBusquedaDGV.Clear();
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
    }
}
