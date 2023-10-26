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
            dataGridCategorias.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10); // Ajusta el espacio vertical entre las celdas de cada fila

            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;");
                conexion.Open();

                string consulta = "SELECT ID_Categoria, Nombre, Descripcion FROM categoria";

                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                DataTable tablaCategorias = new DataTable();
                adaptador.Fill(tablaCategorias);

                dataGridCategorias.DataSource = tablaCategorias;

                dataGridCategorias.Columns["ID_Categoria"].Visible = false; // Oculta la columna ID
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
                using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
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
                    try
                    {
                        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;");
                        conexion.Open();

                        string consulta = "SELECT ID_Categoria, Nombre, Descripcion FROM categoria";

                        MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                        DataTable tablaCategorias = new DataTable();
                        adaptador.Fill(tablaCategorias);

                        dataGridCategorias.DataSource = tablaCategorias;

                        dataGridCategorias.Columns["ID_Categoria"].Visible = false; // Oculta la columna ID
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
