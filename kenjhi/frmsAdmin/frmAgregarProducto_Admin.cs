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

        private string categoriaSeleccionada = "";
        private MySqlConnection conexion;
        private string connectionString = "Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;";

        public Agregar_Producto()
        {
            InitializeComponent();

            string query = "SELECT ID_Categoria, Nombre FROM Categoria WHERE visible=1";
            CargarCategorias();
           
            conexion = new MySqlConnection(connectionString);
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


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkCrearCategoria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAgregarCategoria formAgregarCategoria = new frmAgregarCategoria();
            formAgregarCategoria.Show();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtNombreProducto.Text) ||
            comboCategoriaProducto.SelectedItem == null ||
            numericUpDownPrecio.Value <= 0 ||
            numericUpDownCantidad.Value <= 0)
            {
                labelActualizacionCate.Visible = false;
                lblAgregarProducto.Visible = true;
                System.Media.SystemSounds.Exclamation.Play();
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

            int categoriaID = ObtenerCategoriaIDDesdeBaseDeDatos(nombreCategoria);

            InsertProductIntoDatabase(nombreProducto, categoriaID, precio, cantidad);

            MessageBox.Show("Producto agregado exitosamente.", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombreProducto.Clear();
            numericUpDownPrecio.Value = 0;
            numericUpDownCantidad.Value = 0;
            comboCategoriaProducto.Items.Clear();
            lblAgregarProducto.Visible = false;
            labelActualizacionCate.Visible = false;
            CargarCategorias();
        }
        private int ObtenerCategoriaIDDesdeBaseDeDatos(string nombreCategoria)
        {
            int categoriaID = -1; 
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
                return false; 
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

                    insertCommand.ExecuteNonQuery(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al insertar el producto en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                string connectionString = "Server=localhost; Database=suple; Uid=suple_admin; Pwd=supleadmin2023!_saltocentro;";
                string query = "SELECT Nombre FROM Categoria WHERE visible = 1";

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

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
