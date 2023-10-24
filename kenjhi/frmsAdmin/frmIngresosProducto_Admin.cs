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

namespace kenjhi
{
    public partial class frmIngresosProducto_Admin : Form
    {
        public frmIngresosProducto_Admin()
        {
            InitializeComponent();
            string connectionString = "Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;";
            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            //{
            //    connection.Open();
            //    string query = "SELECT Nombre FROM producto";

            //    using (MySqlCommand cmd = new MySqlCommand(query, connection))
            //    {
            //        using (MySqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            // Limpia los elementos existentes en el ComboBox
            //            comboListaProductos.Items.Clear();

            //            // Agrega los nombres de productos al ComboBox
            //            while (reader.Read())
            //            {
            //                string nombreProducto = reader["Nombre"].ToString();
            //                comboListaProductos.Items.Add(nombreProducto);
            //            }
            //        }
            //    }
            //}
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //consulta y sacamos el id del producto
                string query = "SELECT ID_Producto, Nombre FROM producto WHERE visible=1";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Limpia los elementos existentes en el ComboBox
                        comboListaProductos.Items.Clear();

                        // Agrega los nombres de productos al ComboBox junto con sus IDs
                        while (reader.Read())
                        {
                            int idProducto = Convert.ToInt32(reader["ID_Producto"]);
                            string nombreProducto = reader["Nombre"].ToString();
                            comboListaProductos.Items.Add(new ComboboxItem(nombreProducto, idProducto));
                        }
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkCrearProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Pasos para agregar un nuevo producto\n1) Ubicarse en 'Menú principal'\n2) Clic en el listado llamado 'Productos'\n3) Dentro del listado, clic en 'Agregar producto'\n4) Completar los datos del nuevo producto");
        }

        private void btnCrearIngreso_Click(object sender, EventArgs e)
        {
            if (comboListaProductos.SelectedItem != null)
            {
                ComboboxItem selectedItem = (ComboboxItem)comboListaProductos.SelectedItem; // Obtener el producto seleccionado y su ID
                int idProducto = selectedItem.Value;
                string nombreProducto = selectedItem.Text;

                int cantidadIngreso = (int)numericCantidadIngreso.Value; // Obtener la cantidad del Numeric y la fecha del DateTime

                DateTime fechaIngreso = dataAgregarIngreso.Value;

               //subida
                string connectionString = "Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertIngresoQuery = "INSERT INTO ingresos (ID_Producto, Cantidad, Fecha_Ingreso) VALUES (@ID_Producto, @Cantidad, @Fecha_Ingreso)";
                    using (MySqlCommand cmd = new MySqlCommand(insertIngresoQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID_Producto", idProducto);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidadIngreso);
                        cmd.Parameters.AddWithValue("@Fecha_Ingreso", fechaIngreso);
                        cmd.ExecuteNonQuery();
                    }

                    // Actualizar la cantidad en la tabla de producto
                    string updateProductoQuery = "UPDATE producto SET Cantidad = Cantidad + @Cantidad WHERE ID_Producto = @ID_Producto";
                    using (MySqlCommand cmd = new MySqlCommand(updateProductoQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID_Producto", idProducto);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidadIngreso);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Se ingresaron {cantidadIngreso} unidades de {nombreProducto}.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto de la lista.");
            }
        }
    }
}
//funciono, no toquen nada porque se rompe todo, no tocar la clase comboboxitem