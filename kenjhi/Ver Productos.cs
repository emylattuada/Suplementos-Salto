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
    public partial class Ver_Productos : Form
    {
        public Ver_Productos()
        {

            InitializeComponent();
            txtBusquedaDGV.Text = "Ingresa un nombre para realizar la búsqueda";
            txtBusquedaDGV.ForeColor = System.Drawing.Color.DarkGray;
            dataGridProductos.RowTemplate.Height = 40;
            dataGridProductos.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);



            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"); ;
                conexion.Open();

                //string consulta = "SELECT ID_Cliente, Nombre, Telefono, Direccion, Email FROM Cliente";
                string consulta = "SELECT p.ID_Producto, p.Nombre, p.Precio, p.Cantidad, c.Nombre AS Categoria FROM producto p INNER JOIN categoria c ON p.ID_Categoria = c.ID_Categoria WHERE p.Visible = 1";


                MySqlCommand comandos = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandos);

                System.Data.DataTable tablaProductos = new System.Data.DataTable();
                adaptador.Fill(tablaProductos);

                dataGridProductos.DataSource = tablaProductos;

                // Configurar las columnas
                dataGridProductos.Columns["ID_Producto"].HeaderText = "ID";
                dataGridProductos.Columns["ID_Producto"].Visible = false;
                dataGridProductos.Columns["Nombre"].HeaderText = "Nombre";
                dataGridProductos.Columns["Cantidad"].HeaderText = "Cantidad";
                dataGridProductos.Columns["Categoria"].HeaderText = "Categoría";
                dataGridProductos.Columns["Precio"].HeaderText = "Precio";
                // Ajustar el ancho de las columnas
                dataGridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn column in dataGridProductos.Columns)
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


    }
}
