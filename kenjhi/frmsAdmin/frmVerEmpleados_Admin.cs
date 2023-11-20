using System;
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


namespace kenjhi
{
    public partial class frmVerEmpleados_Admin : Form
    {
      

        public frmVerEmpleados_Admin()
        {
            InitializeComponent();
            txtBusquedaDGV.Text = "Ingresa un nombre de usuario para realizar la búsqueda";
            txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
            dataGridEmpleados.RowTemplate.Height = 40;
            dataGridEmpleados.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10); 
            dataGridEmpleados.ReadOnly=true;




            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                conexion.Open();

                string consulta = "SELECT ID_Usuario, NombreUsuario, Rol, email FROM usuarios WHERE Visible = 1 AND Rol = 'Empleado'";

                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                DataTable tablaUsuarios = new DataTable();
                adaptador.Fill(tablaUsuarios);

                dataGridEmpleados.DataSource = tablaUsuarios;

                dataGridEmpleados.Columns["ID_Usuario"].Visible = false;
                dataGridEmpleados.Columns["NombreUsuario"].HeaderText = "Nombre de Usuario";
                dataGridEmpleados.Columns["Rol"].HeaderText = "Rol";
                dataGridEmpleados.Columns["Rol"].ReadOnly = true;

                dataGridEmpleados.Columns["email"].HeaderText = "Correo electrónico";

                dataGridEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
                using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                {
                    connection.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT ID_Usuario, NombreUsuario, Rol, email FROM usuarios", connection))
                    {
                        MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                        adapter.Update((DataTable)dataGridEmpleados.DataSource);
                    }

                    MessageBox.Show("Datos de usuarios actualizados.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBusquedaDGV.ForeColor = Color.White;

                    try
                    {
                        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                        conexion.Open();

                        string consulta = "SELECT ID_Usuario, NombreUsuario, Rol, email FROM usuarios WHERE Visible = 1 AND Rol = 'Empleado'";

                        MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                        DataTable tablaUsuarios = new DataTable();
                        adaptador.Fill(tablaUsuarios);

                        dataGridEmpleados.DataSource = tablaUsuarios;

                        dataGridEmpleados.Columns["ID_Usuario"].Visible = false;
                        dataGridEmpleados.Columns["NombreUsuario"].HeaderText = "Nombre de Usuario";
                        dataGridEmpleados.Columns["Rol"].HeaderText = "Rol";
                        dataGridEmpleados.Columns["email"].HeaderText = "Correo electrónico";

                        dataGridEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    btnGuardarCambios.Visible = false;
                    btnEliminarEmpleado.Visible = false;
                    dataGridEmpleados.ReadOnly = true;
                    btnCancelarModificacion.Visible = false;
                    btnModificar.Visible = true;
                    txtBusquedaDGV.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridEmpleados.ReadOnly = true)
            {
                dataGridEmpleados.ReadOnly = false;
            }
            dataGridEmpleados.Columns["Rol"].ReadOnly = true;

            
            btnModificar.Visible = false;
            btnCancelarModificacion.Visible = true;
          
        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            btnEliminarEmpleado.Visible = false;
            btnGuardarCambios.Visible = false;
            btnCancelarModificacion.Visible = false;
            btnModificar.Visible = false;
            foreach (DataGridViewColumn column in dataGridEmpleados.Columns)
            {
                column.ReadOnly = true;
            }
            btnModificar.Visible = true;

        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dataGridEmpleados.SelectedRows.Count > 0)
            {
                int idEmpleado = Convert.ToInt32(dataGridEmpleados.SelectedRows[0].Cells["ID_Usuario"].Value);

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                    {
                        conexion.Open();

                        string consultaActualizar = $"UPDATE usuarios SET visible=0 WHERE ID_Usuario={idEmpleado}";
                        MySqlCommand comandoActualizar = new MySqlCommand(consultaActualizar, conexion);
                        comandoActualizar.ExecuteNonQuery();

                        conexion.Close();

                        dataGridEmpleados.SelectedRows[0].Visible = false;

                        txtBusquedaDGV.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Empleado eliminado", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBusquedaDGV.Clear();
                    txtBusquedaDGV.ForeColor = Color.White;

                }
                try
                {
                    MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                    conexion.Open();

                    string consulta = "SELECT ID_Usuario, NombreUsuario, Rol, email FROM usuarios WHERE Visible = 1 AND Rol = 'Empleado'";

                    MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                    DataTable tablaUsuarios = new DataTable();
                    adaptador.Fill(tablaUsuarios);

                    dataGridEmpleados.DataSource = tablaUsuarios;

                    dataGridEmpleados.Columns["ID_Usuario"].Visible = false;
                    dataGridEmpleados.Columns["NombreUsuario"].HeaderText = "Nombre de Usuario";
                    dataGridEmpleados.Columns["Rol"].HeaderText = "Rol";
                    dataGridEmpleados.Columns["Rol"].ReadOnly = true;

                    dataGridEmpleados.Columns["email"].HeaderText = "Correo electrónico";

                    dataGridEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dataGridEmpleados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEliminarEmpleado.Visible = true;

        }

        private void dataGridEmpleados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridEmpleados.IsCurrentCellDirty)
                {
                    btnGuardarCambios.Visible = true;


                }
            }

        }

        private void txtBusquedaDGV_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBusquedaDGV.Text == "Ingresa un nombre de usuario para realizar la búsqueda") { txtBusquedaDGV.Clear(); txtBusquedaDGV.ForeColor = System.Drawing.Color.White; }

        }

        private void txtBusquedaDGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBusquedaDGV.Text.Length == 0)
            {
                try
                {
                    MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                    conexion.Open();

                    string consulta = "SELECT ID_Usuario, NombreUsuario, Rol, email FROM usuarios WHERE Visible = 1 AND Rol = 'Empleado'";

                    MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                    DataTable tablaUsuarios = new DataTable();
                    adaptador.Fill(tablaUsuarios);

                    dataGridEmpleados.DataSource = tablaUsuarios;

                    dataGridEmpleados.Columns["ID_Usuario"].HeaderText = "ID";
                    dataGridEmpleados.Columns["ID_Usuario"].Visible = false;
                    dataGridEmpleados.Columns["NombreUsuario"].HeaderText = "Nombre de Usuario";
                    dataGridEmpleados.Columns["Email"].HeaderText = "Correo Electrónico";
                    dataGridEmpleados.Columns["Rol"].HeaderText = "Rol";

                    dataGridEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    foreach (DataGridViewColumn column in dataGridEmpleados.Columns)
                    {
                        column.ReadOnly = true;
                    }

                    if (lblSinResultado.Visible)
                    {
                        lblSinResultado.Visible = false;
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
                using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                {
                    conexion.Open();
                    string consulta = "SELECT ID_Usuario, NombreUsuario, Email, Rol FROM usuarios WHERE Rol = 'Empleado' AND Visible = 1 AND NombreUsuario LIKE @textoBusqueda";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridEmpleados.DataSource = dataTable;
                        dataGridEmpleados.Columns["ID_Usuario"].Visible = false;
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

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridEmpleados_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridEmpleados.Columns["NombreUsuario"].Index)
                {
                    string nuevoValorNombreUsuario = e.FormattedValue.ToString();

                    if (nuevoValorNombreUsuario.Length > 45)
                    {
                        MessageBox.Show("El nombre de usuario ingresado contiene demasiados caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
                else if (e.ColumnIndex == dataGridEmpleados.Columns["email"].Index)
                {
                    string nuevoValorEmail = e.FormattedValue.ToString();

                    if (nuevoValorEmail.Length > 35)
                    {
                        MessageBox.Show("El correo eléctronico ingresado contiene demasiados caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    else if (!string.IsNullOrEmpty(nuevoValorEmail) && !EsCorreoElectronicoValido(nuevoValorEmail))
                    {
                        MessageBox.Show("El correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
            }
        }
        private bool EsCorreoElectronicoValido(string correo)
        {
            return Regex.IsMatch(correo, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$");
        }
    }
}
