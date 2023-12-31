﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kenjhi
{
    public partial class Ver_Productos : Form
    {
        public Ver_Productos()
        {

            InitializeComponent();
            dataGridProductos.CellEndEdit += dataGridProductos_CellEndEdit;

            txtBusquedaDGV.Text = "Ingresa un nombre de producto para realizar la búsqueda";
            txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
            dataGridProductos.RowTemplate.Height = 40;
            dataGridProductos.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);



            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                conexion.Open();

                string consulta = "SELECT p.ID_Producto, p.Precio, p.Cantidad, p.Nombre, c.ID_Categoria, IF(c.visible = 1, c.Nombre, 'Sin categoria') AS Categoria " +
                   "FROM producto p " +
                   "LEFT JOIN categoria c ON p.ID_Categoria = c.ID_Categoria " +
                   "WHERE p.visible = 1";


                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                DataTable tablaProductos = new DataTable();
                adaptador.Fill(tablaProductos);

                dataGridProductos.DataSource = tablaProductos;

                dataGridProductos.Columns["ID_Producto"].HeaderText = "ID";
                dataGridProductos.Columns["ID_Producto"].Visible = false;
                dataGridProductos.Columns["Precio"].HeaderText = "Precio (UYU)";
                dataGridProductos.Columns["Cantidad"].HeaderText = "Cantidad";
                dataGridProductos.Columns["Nombre"].HeaderText = "Nombre del Producto";
                dataGridProductos.Columns["Categoria"].HeaderText = "Categoría";
                dataGridProductos.Columns["ID_Categoria"].Visible = false;
                dataGridProductos.Columns["Cantidad"].ReadOnly = true;

                dataGridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridProductos.Columns["Categoria"].ReadOnly = true;

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
            if (dataGridProductos.ReadOnly = true)
            {
                dataGridProductos.ReadOnly = false;

            }
            dataGridProductos.Columns["Cantidad"].ReadOnly = true;
            dataGridProductos.Columns["Categoria"].ReadOnly = false;
            btnModificar.Visible = false;
            btnCancelarModificacion.Visible = true;
            
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
           

            try
            {
                using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                {
                    connection.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT ID_Producto, Nombre, Precio, Cantidad, ID_Categoria FROM producto", connection))
                    {
                        MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);

                        DataTable dataTable = (DataTable)dataGridProductos.DataSource;

                        foreach (DataRow row in dataTable.Rows)
                        {
                            if (row.RowState == DataRowState.Modified && dataTable.Columns.Contains("Categoria"))
                            {
                                string nuevaCategoria = row["Categoria"].ToString();

                                if (CategoriaExisteEnBD(nuevaCategoria))
                                {
                                    int idCategoria = ObtenerIdCategoria(nuevaCategoria);
                                    row["ID_Categoria"] = idCategoria;
                                }
                                else
                                {
                                    MessageBox.Show($"La categoría '{nuevaCategoria}' no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        adapter.Update(dataTable);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT ID_Categoria, Nombre FROM categoria", connection))
                    {
                        MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);

                    }

                    MessageBox.Show("Datos de productos actualizados.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardarCambios.Visible = false;
                    btnEliminarProducto.Visible = false;
                    btnCancelarModificacion.Visible = false;

                    if (txtBusquedaDGV.Text != "Ingresa un nombre de producto para realizar la búsqueda")
                    {
                        txtBusquedaDGV.Clear();
                        txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
                        txtBusquedaDGV.Text = "Ingresa un nombre de producto para realizar la búsqueda";

                    }


                    foreach (DataGridViewColumn column in dataGridProductos.Columns)
                    {
                        column.ReadOnly = true;
                    }

                    btnModificar.Visible = true;
                   
                    try
                    {
                        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                        conexion.Open();

                        string consulta = "SELECT p.ID_Producto, p.Precio, p.Cantidad, p.Nombre, c.ID_Categoria, IF(c.visible = 1, c.Nombre, 'Sin categoria') AS Categoria " +
                           "FROM producto p " +
                           "LEFT JOIN categoria c ON p.ID_Categoria = c.ID_Categoria " +
                           "WHERE p.visible = 1";

                        MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                        DataTable tablaProductos = new DataTable();
                        adaptador.Fill(tablaProductos);

                        dataGridProductos.DataSource = tablaProductos;

                        dataGridProductos.Columns["ID_Producto"].HeaderText = "ID";
                        dataGridProductos.Columns["ID_Producto"].Visible = false;
                        dataGridProductos.Columns["Precio"].HeaderText = "Precio (UYU)";
                        dataGridProductos.Columns["Cantidad"].HeaderText = "Cantidad";
                        dataGridProductos.Columns["Nombre"].HeaderText = "Nombre del Producto";
                        dataGridProductos.Columns["Categoria"].HeaderText = "Categoría";
                        dataGridProductos.Columns["ID_Categoria"].Visible = false;
                        dataGridProductos.Columns["Cantidad"].ReadOnly = true;

                        dataGridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        dataGridProductos.Columns["Categoria"].ReadOnly = true;

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
                MessageBox.Show("Error al guardar los cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private int ObtenerIdCategoria(string nombreCategoria)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                {
                    conexion.Open();
                    string consulta = "SELECT ID_Categoria FROM categoria WHERE Nombre = @nombreCategoria";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);
                        int idCategoria = Convert.ToInt32(cmd.ExecuteScalar());
                        return idCategoria;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el ID de la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; 
            }
        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {

            btnCancelarModificacion.Visible = false;
            btnGuardarCambios.Visible = false;
            btnModificar.Visible = true;
            dataGridProductos.ReadOnly = true;
            btnEliminarProducto.Visible = false;
        }

        private void dataGridProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
            
                if (dataGridProductos.IsCurrentCellDirty)
                {
                  
                    btnGuardarCambios.Visible = true;


                }
            }
        }

        private void txtBusquedaDGV_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBusquedaDGV.Text == "Ingresa un nombre de producto para realizar la búsqueda") { txtBusquedaDGV.Clear(); txtBusquedaDGV.ForeColor = System.Drawing.Color.White; }

        }

        private void dataGridProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEliminarProducto.Visible = true;
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridProductos.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dataGridProductos.SelectedRows[0].Cells["ID_Producto"].Value);

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                    {
                        conexion.Open();

                        string consultaActualizar = $"UPDATE producto SET visible=0 WHERE ID_Producto={idProducto}";
                        MySqlCommand comandoActualizar = new MySqlCommand(consultaActualizar, conexion);
                        comandoActualizar.ExecuteNonQuery();

                        conexion.Close();

                        dataGridProductos.SelectedRows[0].Visible = false;

                    }
                }
                catch /*(Exception ex)*/
                {
                    MessageBox.Show("Producto eliminado", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (txtBusquedaDGV.Text != "Ingresa un nombre de producto para realizar la búsqueda")
                    {
                        txtBusquedaDGV.Clear();
                        txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
                        txtBusquedaDGV.Text = "Ingresa un nombre de producto para realizar la búsqueda";

                    }
                    try
                    {
                        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                        conexion.Open();

                        string consulta = "SELECT p.ID_Producto, p.Precio, p.Cantidad, p.Nombre, c.ID_Categoria, IF(c.visible = 1, c.Nombre, 'Sin categoria') AS Categoria " +
                           "FROM producto p " +
                           "LEFT JOIN categoria c ON p.ID_Categoria = c.ID_Categoria " +
                           "WHERE p.visible = 1";

                        MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                        DataTable tablaProductos = new DataTable();
                        adaptador.Fill(tablaProductos);

                        dataGridProductos.DataSource = tablaProductos;

                        dataGridProductos.Columns["ID_Producto"].HeaderText = "ID";
                        dataGridProductos.Columns["ID_Producto"].Visible = false;
                        dataGridProductos.Columns["Precio"].HeaderText = "Precio (UYU)";
                        dataGridProductos.Columns["Cantidad"].HeaderText = "Cantidad";
                        dataGridProductos.Columns["Nombre"].HeaderText = "Nombre del Producto";
                        dataGridProductos.Columns["Categoria"].HeaderText = "Categoría";
                        dataGridProductos.Columns["ID_Categoria"].Visible = false;
                        dataGridProductos.Columns["Cantidad"].ReadOnly = true;

                        dataGridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        dataGridProductos.Columns["Categoria"].ReadOnly = true;

                        conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                btnEliminarProducto.Visible = false;
            }
        }

        private void dataGridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEliminarProducto.Visible = true;

        }

        private void dataGridProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBusquedaDGV_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                conexion.Open();

                string consulta = "SELECT p.ID_Producto, p.Precio, p.Cantidad, p.Nombre, c.ID_Categoria, IF(c.visible = 1, c.Nombre, 'Sin categoria') AS Categoria " +
                                  "FROM producto p " +
                                  "LEFT JOIN categoria c ON p.ID_Categoria = c.ID_Categoria " +
                                  "WHERE p.visible = 1";

                if (txtBusquedaDGV.Text.Length > 0)
                {
                    consulta += " AND p.Nombre LIKE @textoBusqueda";
                }

                MySqlCommand comandos = new MySqlCommand(consulta, conexion);

                if (txtBusquedaDGV.Text.Length > 0)
                {
                    comandos.Parameters.AddWithValue("@textoBusqueda", "%" + txtBusquedaDGV.Text + "%");
                }

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                DataTable tablaProductos = new DataTable();
                adaptador.Fill(tablaProductos);

                dataGridProductos.DataSource = tablaProductos;

                dataGridProductos.Columns["ID_Producto"].HeaderText = "ID";
                dataGridProductos.Columns["ID_Producto"].Visible = false;
                dataGridProductos.Columns["Precio"].HeaderText = "Precio (UYU)";
                dataGridProductos.Columns["Cantidad"].HeaderText = "Cantidad";
                dataGridProductos.Columns["Nombre"].HeaderText = "Nombre del Producto";
                dataGridProductos.Columns["Categoria"].HeaderText = "Categoría";

                dataGridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridProductos.Columns["Categoria"].ReadOnly = true;
                dataGridProductos.Columns["Cantidad"].ReadOnly = true;

                lblSinResultado.Visible = (tablaProductos.Rows.Count == 0);
                lblSinResultado2.Visible = (tablaProductos.Rows.Count == 0);

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void dataGridProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridProductos.Columns[e.ColumnIndex].Name == "Cantidad" && e.Value != null)
            {
                int cantidad = Convert.ToInt32(e.Value);

                if (cantidad < 10)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
            }
        }

        private void dataGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminarProducto.Visible = true;

        }

        private void dataGridProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


            
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string nombreColumna = dataGridProductos.Columns[e.ColumnIndex].Name;

                if (nombreColumna == "Categoria")
                {
                    string nuevaCategoria = dataGridProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    if (nuevaCategoria != "Sin categoria" && !CategoriaExisteEnBD(nuevaCategoria))
                    {
                        MessageBox.Show($"La categoría '{nuevaCategoria}' no existe en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        dataGridProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = ObtenerValorOriginal(e.RowIndex, e.ColumnIndex);

                        dataGridProductos.EndEdit(); 
                    }
                    else
                    {
                        btnGuardarCambios.Visible = true;
                    }
                }
            }



        }

        private object ObtenerValorOriginal(int rowIndex, int columnIndex)
        {
            return (dataGridProductos.Rows[rowIndex].DataBoundItem as DataRowView)?.Row[columnIndex, DataRowVersion.Original];
        }
        private bool CategoriaExisteEnBD(string nuevaCategoria)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                {
                    conexion.Open();
                    string consulta = "SELECT COUNT(*) FROM categoria WHERE Nombre = @nuevaCategoria AND visible=1";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nuevaCategoria", nuevaCategoria);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar la existencia de la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridProductos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dataGridProductos.Columns["Precio"].Index)
            {
                string nuevoValorPrecio = e.FormattedValue.ToString();

                if (!EsNumero(nuevoValorPrecio) || Convert.ToInt32(nuevoValorPrecio) <= 0)
                {
                    MessageBox.Show("El precio debe ser un valor entero mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }

            if (e.ColumnIndex == dataGridProductos.Columns["Nombre"].Index)
            {
                string nuevoValorNombre = e.FormattedValue.ToString();

                if (nuevoValorNombre.Length > 45)
                {
                    MessageBox.Show("El nombre del producto contiene demasiados caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }

        }

        private bool EsNumero(string cadena)
        {
            int resultado;
            return int.TryParse(cadena, out resultado);
        }

       


    }


}
