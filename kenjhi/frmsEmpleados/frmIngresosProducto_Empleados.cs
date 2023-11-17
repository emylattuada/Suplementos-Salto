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
    public partial class frmIngresosProducto_Empleados : Form
    {


        public frmIngresosProducto_Empleados()
        {
            InitializeComponent();
            dataAgregarIngreso.Format = DateTimePickerFormat.Custom;
            dataAgregarIngreso.CustomFormat = "dd/MM/yyyy";
            dataAgregarIngreso.MaxDate = DateTime.Today;


            string connectionString = "Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;";
           
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ID_Producto, Nombre FROM producto WHERE visible=1";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        comboListaProductos.Items.Clear();

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
                ComboboxItem selectedItem = (ComboboxItem)comboListaProductos.SelectedItem; 
                int idProducto = selectedItem.Value;
                string nombreProducto = selectedItem.Text;

                int cantidadIngreso = (int)numericCantidadIngreso.Value; 

                DateTime fechaIngreso = dataAgregarIngreso.Value;

               
                string connectionString = "Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;";

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

                    string updateProductoQuery = "UPDATE producto SET Cantidad = Cantidad + @Cantidad WHERE ID_Producto = @ID_Producto";
                    using (MySqlCommand cmd = new MySqlCommand(updateProductoQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID_Producto", idProducto);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidadIngreso);
                        cmd.ExecuteNonQuery();
                    }


                    MessageBox.Show($"Se ingresaron {cantidadIngreso} unidades de {nombreProducto}. ", "Nuevo ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboListaProductos.Items.Clear();
                    cargarcombobox();
                    numericCantidadIngreso.Value = 0;






                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto de la lista.");
            }
        }

        private void picturePasos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pasos para agregar un nuevo producto\n1) Ubicarse en 'Menú principal'\n2) Clic en el listado llamado 'Productos'\n3) Dentro del listado, clic en 'Agregar producto'\n4) Completar los datos del nuevo producto");

        }

        private void cargarcombobox()
        {
            string connectionString = "Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ID_Producto, Nombre FROM producto WHERE visible=1";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        comboListaProductos.Items.Clear();

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

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
