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


namespace kenjhi.frmsAdmin
{
    public partial class frmRecuperarDatos_Admin : Form
    {
        int pos = 0;
        public frmRecuperarDatos_Admin()
        {

            InitializeComponent();
            dataGridRecuperarDatos.RowTemplate.Height = 40;
            dataGridRecuperarDatos.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            txtBusquedaDGV.Text = "";
            txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;



        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRecuperarDatos_Admin_Load(object sender, EventArgs e)
        {


        }


        private void CargarDatosClientes()
        {


            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"); ;
                conexion.Open();

                string consulta = "SELECT ID_Cliente, Nombre, Telefono, Direccion, Email, CI FROM Cliente WHERE visible=0";


                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                System.Data.DataTable tablaClientes = new System.Data.DataTable();
                adaptador.Fill(tablaClientes);

                dataGridRecuperarDatos.DataSource = tablaClientes;

                dataGridRecuperarDatos.Columns["ID_Cliente"].HeaderText = "ID";
                dataGridRecuperarDatos.Columns["ID_Cliente"].Visible = false;
                dataGridRecuperarDatos.Columns["Nombre"].HeaderText = "Cliente";
                dataGridRecuperarDatos.Columns["Telefono"].HeaderText = "Numero de teléfono";
                dataGridRecuperarDatos.Columns["Direccion"].HeaderText = "Dirección";
                dataGridRecuperarDatos.Columns["Email"].HeaderText = "Correo electrónico";
                dataGridRecuperarDatos.Columns["CI"].HeaderText = "CI";


                dataGridRecuperarDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn column in dataGridRecuperarDatos.Columns)
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

        private void pictureBoxClientes_Click(object sender, EventArgs e)
        {
            pictureBoxProductos.Visible = false;
            labelProductos.Visible = false;
            pictureBoxClientes.Visible = false;
            labelClientes.Visible = false;
            pictureBoxCategorias.Visible = false;
            labelCategorias.Visible = false;
            pictureBoxEmpleados.Visible = false;
            labelEmpleados.Visible = false;
            labelRuta.Text = "Menú principal > Administrador > Recuperar datos > Clientes";
            txtBusquedaDGV.Text = "Ingresa un nombre de cliente para realizar la búsqueda";



            dataGridRecuperarDatos.Visible = true;
            CargarDatosClientes();
            labelPrincipal.Text = "Visualizando Clientes eliminados";
            labelBuscar.Visible = true;
            txtLinea.Visible = true;
            txtBusquedaDGV.Visible = true;

            pos = 1;

        }

        private void BusquedaClientes()
        {
            if (txtBusquedaDGV.Text.Length == 0)
            {
                try
                {
                    MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"); ;
                    conexion.Open();

                    string consulta = "SELECT ID_Cliente, Nombre, Telefono, Direccion, Email, CI FROM Cliente WHERE visible=0";


                    MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                    System.Data.DataTable tablaClientes = new System.Data.DataTable();
                    adaptador.Fill(tablaClientes);

                    dataGridRecuperarDatos.DataSource = tablaClientes;

                    dataGridRecuperarDatos.Columns["ID_Cliente"].HeaderText = "ID";
                    dataGridRecuperarDatos.Columns["ID_Cliente"].Visible = false;
                    dataGridRecuperarDatos.Columns["Nombre"].HeaderText = "Cliente";
                    dataGridRecuperarDatos.Columns["Telefono"].HeaderText = "Numero de teléfono";
                    dataGridRecuperarDatos.Columns["Direccion"].HeaderText = "Dirección";
                    dataGridRecuperarDatos.Columns["Email"].HeaderText = "Correo electrónico";
                    dataGridRecuperarDatos.Columns["CI"].HeaderText = "CI";


                    dataGridRecuperarDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
                using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM cliente WHERE Visible = 0 AND Nombre LIKE @textoBusqueda";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridRecuperarDatos.DataSource = dataTable;
                        dataGridRecuperarDatos.Columns["Visible"].Visible = false;
                        if (dataTable.Rows.Count == 0)
                        {
                            dataGridRecuperarDatos.Visible = true;
                            dataGridRecuperarDatos.Visible = true;
                            lblSinResultado.Text = "El cliente ingresado no pertenece al sistema";
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

        private void BusquedaProducto()
        {
            if (txtBusquedaDGV.Text.Length == 0)
            {
                try
                {
                    MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                    conexion.Open();

                    string consulta = "SELECT p.ID_Producto, p.Precio, p.Cantidad, p.Nombre, c.Nombre AS Categoria " +
                                      "FROM producto p " +
                                      "INNER JOIN categoria c ON p.ID_Categoria = c.ID_Categoria " +
                                      "WHERE p.visible = 0";

                    MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                    DataTable tablaProductos = new DataTable();
                    adaptador.Fill(tablaProductos);

                    dataGridRecuperarDatos.DataSource = tablaProductos;

                    dataGridRecuperarDatos.Columns["ID_Producto"].HeaderText = "ID";
                    dataGridRecuperarDatos.Columns["ID_Producto"].Visible = false;
                    dataGridRecuperarDatos.Columns["Precio"].HeaderText = "Precio (UYU)";
                    dataGridRecuperarDatos.Columns["Cantidad"].HeaderText = "Cantidad";
                    dataGridRecuperarDatos.Columns["Nombre"].HeaderText = "Nombre del Producto";
                    dataGridRecuperarDatos.Columns["Categoria"].HeaderText = "Categoría";

                    dataGridRecuperarDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridRecuperarDatos.Columns["Categoria"].ReadOnly = true;
                    dataGridRecuperarDatos.Columns["Cantidad"].ReadOnly = true;

                    lblSinResultado.Visible = false;
                    lblSinResultado2.Visible = false;

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
                    string consulta = "SELECT p.ID_Producto, p.Nombre, p.Precio, p.Cantidad, c.Nombre AS Categoria FROM producto p " +
                                      "INNER JOIN categoria c ON p.ID_Categoria = c.ID_Categoria " +
                                      "WHERE p.visible = 0 AND p.Nombre LIKE @textoBusqueda";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridRecuperarDatos.DataSource = dataTable;
                        dataGridRecuperarDatos.Columns["ID_Producto"].Visible = false;
                        if (dataTable.Rows.Count == 0)
                        {
                            lblSinResultado.Text = "El producto ingresado no pertenece al sistema";
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
            if (txtBusquedaDGV.Text== "Ingresa un nombre de cliente para realizar la búsqueda" && pos == 1) { txtBusquedaDGV.Clear(); txtBusquedaDGV.ForeColor = System.Drawing.Color.White; }
            if (txtBusquedaDGV.Text == "Ingresa un nombre de producto para realizar la búsqueda" && pos == 2) { txtBusquedaDGV.Clear(); txtBusquedaDGV.ForeColor = System.Drawing.Color.White; }
            if (txtBusquedaDGV.Text == "Ingresa un nombre de categoría para realizar la búsqueda" && pos == 5) { txtBusquedaDGV.Clear(); txtBusquedaDGV.ForeColor = System.Drawing.Color.White; }
            if (txtBusquedaDGV.Text == "Ingresa un nombre de empleado para realizar la búsqueda" && pos == 4) { txtBusquedaDGV.Clear(); txtBusquedaDGV.ForeColor = System.Drawing.Color.White; }

            txtBusquedaDGV.ForeColor = System.Drawing.Color.White;
        }

        private void txtBusquedaDGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (pos == 1)
            {
                BusquedaClientes();
            }
            if (pos == 2)
            {
                BusquedaProducto();
            }
            if (pos == 4)
            {
                BusquedaEmpleado();
            }
            if (pos == 5)
            {
                BusquedaCategoria();
            }
        }

        private void dataGridRecuperarDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRecuperarDatos.Visible = true;
        }

        private void RecuperarCliente()
        {

            if (dataGridRecuperarDatos.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dataGridRecuperarDatos.SelectedRows[0].Cells["ID_Cliente"].Value);

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                    {
                        conexion.Open();

                        string consultaActualizar = $"UPDATE Cliente SET visible=1 WHERE ID_Cliente={idCliente}";
                        MySqlCommand comandoActualizar = new MySqlCommand(consultaActualizar, conexion);
                        comandoActualizar.ExecuteNonQuery();

                        conexion.Close();

                        dataGridRecuperarDatos.SelectedRows[0].Visible = false;


                    }
                }
                catch 
                {
                    MessageBox.Show("Cliente recuperado.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                CargarDatosClientes();
            }
        }

     

        private void CargarDatosProductos()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                conexion.Open();

                string consulta = "SELECT p.ID_Producto, p.Precio, p.Cantidad, p.Nombre, c.Nombre AS Categoria " +
                                  "FROM producto p " +
                                  "INNER JOIN categoria c ON p.ID_Categoria = c.ID_Categoria " +
                                  "WHERE p.visible = 0";

                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                DataTable tablaProductos = new DataTable();
                adaptador.Fill(tablaProductos);

                dataGridRecuperarDatos.DataSource = tablaProductos;

                dataGridRecuperarDatos.Columns["ID_Producto"].HeaderText = "ID";
                dataGridRecuperarDatos.Columns["ID_Producto"].Visible = false;
                dataGridRecuperarDatos.Columns["Precio"].HeaderText = "Precio (UYU)";
                dataGridRecuperarDatos.Columns["Cantidad"].HeaderText = "Cantidad";
                dataGridRecuperarDatos.Columns["Nombre"].HeaderText = "Nombre del Producto";
                dataGridRecuperarDatos.Columns["Categoria"].HeaderText = "Categoría";
                dataGridRecuperarDatos.Columns["Cantidad"].ReadOnly = true;


                dataGridRecuperarDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridRecuperarDatos.Columns["Categoria"].ReadOnly = true;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBoxProductos_Click(object sender, EventArgs e)
        {
            pictureBoxClientes.Visible = false;
            labelClientes.Visible = false;
            pictureBoxCategorias.Visible = false;
            labelCategorias.Visible = false;
            pictureBoxEmpleados.Visible = false;
            labelEmpleados.Visible = false;
            pictureBoxProductos.Visible = false;
            labelProductos.Visible = false;
            labelRuta.Text = "Menú principal > Administrador > Recuperar datos > Productos";
            txtBusquedaDGV.Text = "Ingresa un nombre de producto para realizar la búsqueda";



            dataGridRecuperarDatos.Visible = true;
            CargarDatosProductos();
            labelPrincipal.Text = "Visualizando Productos eliminados";
            labelBuscar.Visible = true;
            txtLinea.Visible = true;
            txtBusquedaDGV.Visible = true;

            pos = 2;

        }

        private void RecuperarProducto()
        {

            if (dataGridRecuperarDatos.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dataGridRecuperarDatos.SelectedRows[0].Cells["ID_Producto"].Value);

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                    {
                        conexion.Open();

                        string consultaActualizar = $"UPDATE producto SET visible=1 WHERE ID_Producto={idProducto}";
                        MySqlCommand comandoActualizar = new MySqlCommand(consultaActualizar, conexion);
                        comandoActualizar.ExecuteNonQuery();

                        conexion.Close();

                        dataGridRecuperarDatos.SelectedRows[0].Visible = false;

                        txtBusquedaDGV.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Producto recuperado", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBusquedaDGV.Clear();
                }
                CargarDatosProductos();
            }
        }

       

        private void btnRecuperarDato_Click(object sender, EventArgs e)
        {
            if (pos == 1)
            {
                RecuperarCliente();
                txtBusquedaDGV.Clear();
                txtBusquedaDGV.Text = "Ingresa un nombre de cliente para realizar la búsqueda";
                txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
            }
            if (pos == 2)
            {
                RecuperarProducto();
                txtBusquedaDGV.Clear();
                txtBusquedaDGV.Text = "Ingresa un nombre de producto para realizar la búsqueda";
                txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
            }
            if (pos == 4)
            {
                RecuperarEmpleado();
                txtBusquedaDGV.Clear();
                txtBusquedaDGV.Text = "Ingresa un nombre de empleado para realizar la búsqueda";
                txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
            }

            if (pos == 5)
            {
                RecuperarCategoria();
                txtBusquedaDGV.Clear();
                txtBusquedaDGV.Text = "Ingresa un nombre de categoría para realizar la búsqueda";
                txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;

            }
        }

        private void CargarDatosEmpleado()
        {

            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                conexion.Open();

                string consulta = "SELECT ID_Usuario, NombreUsuario, Rol, email FROM usuarios WHERE Visible = 0";

                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                DataTable tablaUsuarios = new DataTable();
                adaptador.Fill(tablaUsuarios);

                dataGridRecuperarDatos.DataSource = tablaUsuarios;

                dataGridRecuperarDatos.Columns["ID_Usuario"].Visible = false;
                dataGridRecuperarDatos.Columns["NombreUsuario"].HeaderText = "Nombre de Usuario";
                dataGridRecuperarDatos.Columns["Rol"].HeaderText = "Rol";
                dataGridRecuperarDatos.Columns["Rol"].ReadOnly = true;

                dataGridRecuperarDatos.Columns["email"].HeaderText = "Correo Electrónico";

                dataGridRecuperarDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BusquedaEmpleado()
        {

            if (txtBusquedaDGV.Text.Length == 0)
            {
                try
                {
                    MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                    conexion.Open();

                    string consulta = "SELECT ID_Usuario, NombreUsuario, Email, Rol FROM usuarios WHERE Visible = 0";

                    MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                    DataTable tablaUsuarios = new DataTable();
                    adaptador.Fill(tablaUsuarios);

                    dataGridRecuperarDatos.DataSource = tablaUsuarios;

                    dataGridRecuperarDatos.Columns["ID_Usuario"].HeaderText = "ID";
                    dataGridRecuperarDatos.Columns["ID_Usuario"].Visible = false;
                    dataGridRecuperarDatos.Columns["NombreUsuario"].HeaderText = "Nombre de Usuario";
                    dataGridRecuperarDatos.Columns["Email"].HeaderText = "Correo Electrónico";
                    dataGridRecuperarDatos.Columns["Rol"].HeaderText = "Rol";

                    dataGridRecuperarDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    foreach (DataGridViewColumn column in dataGridRecuperarDatos.Columns)
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
                    string consulta = "SELECT ID_Usuario, NombreUsuario, Email, Rol FROM usuarios WHERE Visible = 0 AND NombreUsuario LIKE @textoBusqueda";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridRecuperarDatos.DataSource = dataTable;
                        dataGridRecuperarDatos.Columns["ID_Usuario"].Visible = false;
                        if (dataTable.Rows.Count == 0)
                        {
                            lblSinResultado.Text = "El empleado ingresado no pertenece al sistema";
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

        private void RecuperarEmpleado()
        {


            if (dataGridRecuperarDatos.SelectedRows.Count > 0)
            {
                int idEmpleado = Convert.ToInt32(dataGridRecuperarDatos.SelectedRows[0].Cells["ID_Usuario"].Value);

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                    {
                        conexion.Open();

                        string consultaActualizar = $"UPDATE usuarios SET visible=1 WHERE ID_Usuario={idEmpleado}";
                        MySqlCommand comandoActualizar = new MySqlCommand(consultaActualizar, conexion);
                        comandoActualizar.ExecuteNonQuery();

                        conexion.Close();

                        dataGridRecuperarDatos.SelectedRows[0].Visible = false;

                        txtBusquedaDGV.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Empleado recuperado", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBusquedaDGV.Clear();
                }
                CargarDatosEmpleado();
            }
        }

        private void pictureBoxEmpleados_Click(object sender, EventArgs e)
        {
            pictureBoxEmpleados.Visible = false;
            labelEmpleados.Visible = false;
            pictureBoxClientes.Visible = false;
            labelClientes.Visible = false;
            pictureBoxProductos.Visible = false;
            labelProductos.Visible =false;
            pictureBoxCategorias.Visible = false;
            labelCategorias.Visible = false;
            labelRuta.Text = "Menú principal > Administrador > Recuperar datos > Empleados";
            txtBusquedaDGV.Text = "Ingresa un nombre de empleado para realizar la búsqueda";



            dataGridRecuperarDatos.Visible = true;
            CargarDatosEmpleado();

            labelPrincipal.Text = "Visualizando Empleados eliminados";
            labelBuscar.Visible = true;
            txtLinea.Visible = true;
            txtBusquedaDGV.Visible = true;

            pos = 4;

        }

        private void pictureBoxCategorias_Click(object sender, EventArgs e)
        {
            pictureBoxClientes.Visible = false;
            labelClientes.Visible = false;
            labelEmpleados.Visible = false;
            pictureBoxProductos.Visible=false;
            labelProductos.Visible = false;
            pictureBoxCategorias.Visible=false;
            labelCategorias.Visible = false;
            pictureBoxEmpleados.Visible = false;
            labelEmpleados.Visible = false;
            labelRuta.Text = "Menú principal > Administrador > Recuperar datos > Categorías";
            txtBusquedaDGV.Text = "Ingresa un nombre de categoría para realizar la búsqueda";



            dataGridRecuperarDatos.Visible = true;
            CargarDatosCategorias();

            labelPrincipal.Text = "Visualizando Categorias eliminadas";
            labelBuscar.Visible = true;
            txtLinea.Visible = true;
            txtBusquedaDGV.Visible = true;

            pos = 5;

        }

        private void CargarDatosCategorias()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                conexion.Open();

                string consulta = "SELECT ID_Categoria, Nombre, descripcion FROM categoria WHERE visible=0";

                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                DataTable tablaCategorias = new DataTable();
                adaptador.Fill(tablaCategorias);

                dataGridRecuperarDatos.DataSource = tablaCategorias;

                dataGridRecuperarDatos.Columns["ID_Categoria"].Visible = false;
                dataGridRecuperarDatos.Columns["Nombre"].HeaderText = "Nombre";
                dataGridRecuperarDatos.Columns["Descripcion"].HeaderText = "Descripción";

                dataGridRecuperarDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void RecuperarCategoria()
        {
            if (dataGridRecuperarDatos.SelectedRows.Count > 0)
            {
                int idCategoria = Convert.ToInt32(dataGridRecuperarDatos.SelectedRows[0].Cells["ID_Categoria"].Value);

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;"))
                    {
                        conexion.Open();

                        string consultaActualizar = $"UPDATE categoria SET visible=1 WHERE ID_Categoria={idCategoria}";
                        MySqlCommand comandoActualizar = new MySqlCommand(consultaActualizar, conexion);
                        comandoActualizar.ExecuteNonQuery();

                        conexion.Close();

                        dataGridRecuperarDatos.SelectedRows[0].Visible = false;

                        txtBusquedaDGV.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Categoría recuperada", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBusquedaDGV.Clear();
                }
                CargarDatosCategorias();
            }


        }


        private void BusquedaCategoria()
        {

            if (txtBusquedaDGV.Text.Length == 0)
            {
                try
                {
                    MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;");
                    conexion.Open();

                    string consulta = "SELECT ID_Categoria, Nombre, Descripcion FROM categoria WHERE visible=0";

                    MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                    DataTable tablaCategorias = new DataTable();
                    adaptador.Fill(tablaCategorias);

                    dataGridRecuperarDatos.DataSource = tablaCategorias;

                    dataGridRecuperarDatos.Columns["ID_Categoria"].Visible = false;
                    dataGridRecuperarDatos.Columns["Nombre"].HeaderText = "Nombre";
                    dataGridRecuperarDatos.Columns["Descripcion"].HeaderText = "Descripción";

                    dataGridRecuperarDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    foreach (DataGridViewColumn column in dataGridRecuperarDatos.Columns)
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
                    string consulta = "SELECT ID_Categoria, Nombre, Descripcion FROM categoria WHERE visible=0 AND Nombre LIKE @textoBusqueda OR Descripcion LIKE @textoBusqueda";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridRecuperarDatos.DataSource = dataTable;
                        dataGridRecuperarDatos.Columns["ID_Categoria"].Visible = false;
                        if (dataTable.Rows.Count == 0)
                        {
                            lblSinResultado.Text = "La categoría ingresada no existe en el sistema";
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
    }
}
