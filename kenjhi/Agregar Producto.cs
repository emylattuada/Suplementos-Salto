using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kenjhi
{
    public partial class Agregar_Producto : Form
    {

        
        private Timer timerCategoria2 = new Timer();
        private string categoriaSeleccionada = "";
        private MySqlConnection conexion;
        private string connectionString = "Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;";
        public Agregar_Producto()
        {
            InitializeComponent();
            string query = "SELECT ID_Categoria, Nombre FROM Categoria";
            CargarCategorias();
            timerCategoria2.Interval = 2000; // 2 segundos
            //timerCategoria2.Tick += TimerCategoria_Tick;
            timerCategoria2.Start();
            conexion = new MySqlConnection(connectionString);
            //CargarCategorias(); // Llamada al método para cargar las categorías en el ComboBox
            //txtPrecioProducto.Text = "$";
            //txtPrecioProducto.ForeColor = System.Drawing.Color.DarkGray;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                comboCategoriaProducto.Items.Clear();

                while (reader.Read())
                {
                    int categoriaID = reader.GetInt32(0);
                    string nombreCategoria = reader.GetString(1);
                    comboCategoriaProducto.Items.Add(new CategoriaItem(categoriaID, nombreCategoria));
                }

                reader.Close();
            }

        }

        //private void CargarCategorias()
        //{
        //    try
        //    {
        //        conexion.Open();

        //        string consulta = "SELECT Nombre FROM Categoria";
        //        MySqlCommand comando = new MySqlCommand(consulta, conexion);

        //        using (MySqlDataReader reader = comando.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                comboCategoriaProducto.Items.Add(reader["Nombre"].ToString());
        //            }
        //        }

        //        conexion.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), "Error al cargar las categorías", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkCrearCategoria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Agregar_Categoria formAgregarCategoria = new Agregar_Categoria();
            formAgregarCategoria.Show();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtNombreProducto.Text) ||
            //comboCategoriaProducto.SelectedItem == null ||
            //numericUpDownPrecio.Value <= 0 ||
            //numericUpDownCantidad.Value <= 0)
            //{
            //    labelActualizacionCate.Visible = false;
            //    lblAgregarProducto.Visible = true;
            //    System.Media.SystemSounds.Exclamation.Play();
            //    // Reproducir sonido de error si es necesario.
            //    return;
            //}

            //string nombreProducto = txtNombreProducto.Text;
            //int categoriaID = ((CategoriaItem)comboCategoriaProducto.SelectedItem).ID;
            //int precio = (int)numericUpDownPrecio.Value; // Convertir el decimal a int
            //int cantidad = (int)numericUpDownCantidad.Value;

            //if (CheckIfProductExists(nombreProducto))
            //{
            //    MessageBox.Show($"El producto '{nombreProducto}' ya existe. Por favor, elige un nombre diferente.",
            //                    "Producto Existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //// Insertar los datos en la base de datos
            //InsertProductIntoDatabase(nombreProducto, categoriaID, precio, cantidad);

            //MessageBox.Show("Producto agregado exitosamente.", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (string.IsNullOrEmpty(txtNombreProducto.Text) ||
            comboCategoriaProducto.SelectedItem == null ||
            numericUpDownPrecio.Value <= 0 ||
            numericUpDownCantidad.Value <= 0)
            {
                labelActualizacionCate.Visible = false;
                lblAgregarProducto.Visible = true;
                System.Media.SystemSounds.Exclamation.Play();
                // Reproducir sonido de error si es necesario.
                return;
            }

            string nombreProducto = txtNombreProducto.Text;
            string nombreCategoria = comboCategoriaProducto.SelectedItem.ToString();
            int precio = (int)numericUpDownPrecio.Value;
            int cantidad = (int)numericUpDownCantidad.Value;

            if (CheckIfProductExists(nombreProducto))
            {
                MessageBox.Show($"El producto '{nombreProducto}' ya existe. Por favor, elige un nombre diferente.",
                                "Producto Existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Obtener el ID de la categoría desde la base de datos (puede ser necesario modificar esto)
            int categoriaID = ObtenerCategoriaIDDesdeBaseDeDatos(nombreCategoria);

            // Insertar los datos en la base de datos
            InsertProductIntoDatabase(nombreProducto, categoriaID, precio, cantidad);

            MessageBox.Show("Producto agregado exitosamente.", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombreProducto.Clear();
            numericUpDownPrecio.Value = 0;
            numericUpDownCantidad.Value = 0;
        }
        private int ObtenerCategoriaIDDesdeBaseDeDatos(string nombreCategoria)
        {
            int categoriaID = -1; // Valor predeterminado en caso de que no se encuentre
            try
            {
                string query = "SELECT ID_Categoria FROM Categoria WHERE Nombre = @nombre";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", nombreCategoria);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        categoriaID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener el ID de la categoría", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return categoriaID;
        }


        private bool CheckIfProductExists(string productName)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Producto WHERE Nombre = @nombre";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", productName);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al verificar existencia del producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Manejo de error: devuelve falso si hay algún problema
            }
        }


        private void InsertProductIntoDatabase(string productName, int categoriaID, int precio, int cantidad)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Producto (Nombre, ID_Categoria, Precio, Cantidad) " +
                                         "VALUES (@nombre, @categoriaID, @precio, @cantidad)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@nombre", productName);
                    insertCommand.Parameters.AddWithValue("@categoriaID", categoriaID);
                    insertCommand.Parameters.AddWithValue("@precio", precio);
                    insertCommand.Parameters.AddWithValue("@cantidad", cantidad);

                    insertCommand.ExecuteNonQuery(); // Ejecuta la consulta de inserción
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al insertar el producto en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Puedes manejar el error aquí si es necesario
            }
        }


        private void linkProductoImagen_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void timerCategoria_Tick(object sender, EventArgs e)
        {
            //CargarCategorias();
            //if (!string.IsNullOrEmpty(categoriaSeleccionada))
            //{
            //    comboCategoriaProducto.SelectedItem = categoriaSeleccionada;
            //}
        }

        private void CargarCategorias()
        {
            try
            {
                if (comboCategoriaProducto.SelectedIndex != -1)
                {
                    categoriaSeleccionada = comboCategoriaProducto.SelectedItem.ToString();
                }

                comboCategoriaProducto.Items.Clear();
                

                // Carga las categorías desde la base de datos y agrega al ComboBox
                string connectionString = "Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;";
                string query = "SELECT Nombre FROM Categoria";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboCategoriaProducto.Items.Add(reader["Nombre"].ToString());
                        }
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar las categorías", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picActualizarCategoria_Click(object sender, EventArgs e)
        {
            lblAgregarProducto.Visible = false;
            labelActualizacionCate.Visible = true;
            System.Media.SystemSounds.Exclamation.Play();
            CargarCategorias();
            //comboCategoriaProducto.Items.Clear();

        }
    }
}
