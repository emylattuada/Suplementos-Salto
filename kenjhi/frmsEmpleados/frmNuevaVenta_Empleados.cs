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
using MySqlX.XDevAPI;

namespace kenjhi
{
    public partial class frmNuevaVenta_Empleados : Form
    {
        Dictionary<int, int> preciosProductos = new Dictionary<int, int>();
        private ToolTip toolTipAyuda;



        public frmNuevaVenta_Empleados()
        {

            InitializeComponent();
            dataFechaVenta.MaxDate = DateTime.Today;



        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nueva_Venta_Load(object sender, EventArgs e)
        {
          
            toolTipAyuda = new ToolTip();


           
            using (MySqlConnection connection = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;"))
            {
                connection.Open();

                string consultaClientes = "SELECT ID_Cliente, Nombre, CI FROM cliente WHERE Visible = 1";

                MySqlCommand cmdClientes = new MySqlCommand(consultaClientes, connection);
                MySqlDataReader readerClientes = cmdClientes.ExecuteReader();

                while (readerClientes.Read())
                {
                    int idCliente = readerClientes.GetInt32("ID_Cliente");
                    string nombreCliente = readerClientes.IsDBNull(readerClientes.GetOrdinal("Nombre")) ? null : readerClientes.GetString("Nombre");
                    string ciCliente = readerClientes.IsDBNull(readerClientes.GetOrdinal("CI")) ? null : readerClientes.GetString("CI");

                    comboListaClientes.Items.Add(new Cliente(idCliente, nombreCliente, ciCliente));
                }
            }

            using (MySqlConnection connection = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;"))
            {
                connection.Open();

                string consultaProductos = "SELECT ID_Producto, Nombre, Precio FROM producto WHERE visible = 1";

                MySqlCommand cmdProductos = new MySqlCommand(consultaProductos, connection);
                MySqlDataReader readerProductos = cmdProductos.ExecuteReader();

                while (readerProductos.Read())
                {
                    int idProducto = readerProductos.GetInt32("ID_Producto");
                    int precio = readerProductos.GetInt32("Precio");
                    string nombreProducto = readerProductos.GetString("Nombre");

                    comboListaProductos.Items.Add(new Producto
                    {
                        ID = idProducto,
                        Nombre = nombreProducto
                    });

                    preciosProductos[idProducto] = precio;
                }

            }


            dataGridCarrito.Columns.Add("Producto", "Producto");

            dataGridCarrito.Columns.Add("Precio", "Precio");
            dataGridCarrito.Columns.Add("Cantidad", "Cantidad");
            dataGridCarrito.Columns.Add("Precio Total", "Precio Total");

            dataGridCarrito.Columns["Precio"].DefaultCellStyle.Format = "C";
            dataGridCarrito.Columns["Precio Total"].DefaultCellStyle.Format = "C";

            dataGridCarrito.Columns["Precio Total"].ReadOnly = true;
            dataGridCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;






        }

        private void comboListaClientes_Click(object sender, EventArgs e)
        {
           
        }

        private void comboListaProductos_Click(object sender, EventArgs e)
        {
           


        }

        private void radioCuotas_Click(object sender, EventArgs e)
        {
            
        }

        private void radioContado_Click(object sender, EventArgs e)
        {
           
        }

        private void numericCantidadVenta_ValueChanged(object sender, EventArgs e)
        {
            if (numericCantidadVenta.Value == 0)
            {
                MessageBox.Show("La cantidad mínima de venta es 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericCantidadVenta.Value = 1;
            }
        }

        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {


            if (comboListaProductos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, elija un producto.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto productoSeleccionado = (Producto)comboListaProductos.SelectedItem;
            int cantidadDeseada = (int)numericCantidadVenta.Value;

            if (cantidadDeseada == 0)
            {
                MessageBox.Show("La cantidad mínima de venta es 1.", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int stockDisponible = ObtenerStockDisponible(productoSeleccionado.ID);

            if (cantidadDeseada > stockDisponible)
            {
                MessageBox.Show($"No hay suficiente stock disponible para '{productoSeleccionado.Nombre}' (Stock actual: {stockDisponible}).", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ActualizarStockProducto(productoSeleccionado.ID, cantidadDeseada);

            decimal precioUnitario = preciosProductos[productoSeleccionado.ID];
            decimal precioTotal = precioUnitario * cantidadDeseada;

            dataGridCarrito.Rows.Add(new object[] { productoSeleccionado, precioUnitario, cantidadDeseada, precioTotal });
            comboListaProductos.SelectedIndex = -1;
            numericCantidadVenta.Value = 1;
            comboListaClientes.Enabled = false;
            txtLineaAmarilla.Visible = false;


            decimal precioTotalVenta = 0;
            foreach (DataGridViewRow fila in dataGridCarrito.Rows)
            {
                precioTotalVenta += Convert.ToDecimal(fila.Cells["Precio Total"].Value);
            }
            int precioTotalVentaLabel = CalcularPrecioTotalCarrito();

            lblTotalCobro.Text = "Total a cobrar \n " + precioTotalVenta.ToString() + " UYU";
        }

        private int ObtenerStockDisponible(int productoID)
        {
            using (MySqlConnection connection = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;"))
            {
                connection.Open();

                string consultaStockProducto = "SELECT Cantidad FROM producto WHERE ID_Producto = @idProducto";
                MySqlCommand cmdStockProducto = new MySqlCommand(consultaStockProducto, connection);
                cmdStockProducto.Parameters.AddWithValue("@idProducto", productoID);

                using (MySqlDataReader reader = cmdStockProducto.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32("Cantidad");
                    }
                }
            }

            return 0; 
        }

        private void ActualizarStockProducto(int productoID, int cantidadVendida)
        {
            using (MySqlConnection connection = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;"))
            {
                connection.Open();

                string actualizarStock = "UPDATE producto SET Cantidad = Cantidad - @cantidadVendida WHERE ID_Producto = @productoID";
                MySqlCommand cmdActualizarStock = new MySqlCommand(actualizarStock, connection);
                cmdActualizarStock.Parameters.AddWithValue("@cantidadVendida", cantidadVendida);
                cmdActualizarStock.Parameters.AddWithValue("@productoID", productoID);

                cmdActualizarStock.ExecuteNonQuery();
            }

        }



        private int CalcularPrecioTotalCarrito()
        {
            int precioTotal = 0;
            foreach (DataGridViewRow fila in dataGridCarrito.Rows)
            {
                precioTotal += Convert.ToInt32(fila.Cells["Precio Total"].Value);
            }
            return precioTotal;
        }

        private void btnBorrarFilaCarrito_Click(object sender, EventArgs e)
        {
            if (dataGridCarrito.SelectedRows.Count > 0)
            {
                dataGridCarrito.Rows.RemoveAt(dataGridCarrito.SelectedRows[0].Index);
                btnBorrarFilaCarrito.Visible = false;

                int precioTotalVenta = CalcularPrecioTotalCarrito();

                lblTotalCobro.Text = "Total a cobrar\n " + precioTotalVenta.ToString() + " UYU";
            }
        }

        private void radioContado_CheckedChanged(object sender, EventArgs e)
        {
            numericCuotasVenta.Enabled = false;
            numericCuotasVenta.Value = 0;
        }

        private void radioCuotas_CheckedChanged(object sender, EventArgs e)
        {
            numericCuotasVenta.Enabled = true;

        }



        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {


           

            using (MySqlConnection connection = new MySqlConnection("Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;"))
            {
                connection.Open();

                if (comboListaClientes.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, elija un cliente.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dataGridCarrito.Rows.Count == 0)
                {
                    MessageBox.Show("Agregue al menos un producto al carrito antes de realizar la venta.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!radioContado.Checked && !radioCuotas.Checked)
                {
                    MessageBox.Show("Por favor, seleccione un tipo de pago (Contado o Cuotas).", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dataFechaVenta.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Por favor, seleccione una fecha de venta.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idCliente = ((Cliente)comboListaClientes.SelectedItem).ID;

                string tipoPago = radioContado.Checked ? "Contado" : "Cuotas";
                int cuotas = radioContado.Checked ? 0 : (int)numericCuotasVenta.Value;

                decimal precioTotal = 0;
                foreach (DataGridViewRow fila in dataGridCarrito.Rows)
                {
                    precioTotal += Convert.ToDecimal(fila.Cells["Precio Total"].Value);
                }

                string insertarVenta = "INSERT INTO venta (ID_Cliente, Tipo, Fecha_Venta, Cuotas, Total, Saldo) " +
                                       "VALUES (@idCliente, @tipoPago, @fechaVenta, @cuotas, @precioTotal, @saldo)";

                MySqlCommand cmdVenta = new MySqlCommand(insertarVenta, connection);
                cmdVenta.Parameters.AddWithValue("@idCliente", idCliente);
                cmdVenta.Parameters.AddWithValue("@tipoPago", tipoPago);
                cmdVenta.Parameters.AddWithValue("@fechaVenta", dataFechaVenta.Value);
                cmdVenta.Parameters.AddWithValue("@cuotas", cuotas);
                cmdVenta.Parameters.AddWithValue("@precioTotal", precioTotal);
                cmdVenta.Parameters.AddWithValue("@saldo", tipoPago == "Contado" ? 0 : precioTotal);

                cmdVenta.ExecuteNonQuery();

                int idVenta = (int)cmdVenta.LastInsertedId;

                if (tipoPago == "Contado")
                {
                    string insertarPago = "INSERT INTO pagos (Fecha_Pagos, Monto, ID_Venta) " +
                                          "VALUES (@fechaPago, @monto, @idVenta)";

                    MySqlCommand cmdPago = new MySqlCommand(insertarPago, connection);
                    cmdPago.Parameters.AddWithValue("@fechaPago", dataFechaVenta.Value);
                    cmdPago.Parameters.AddWithValue("@monto", precioTotal);
                    cmdPago.Parameters.AddWithValue("@idVenta", idVenta);

                    cmdPago.ExecuteNonQuery();
                }

                foreach (DataGridViewRow fila in dataGridCarrito.Rows)
                {
                    int idProducto = ((Producto)fila.Cells["Producto"].Value).ID;
                    int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    decimal precioUnitario = Convert.ToDecimal(fila.Cells["Precio"].Value);

                    string insertarAsignado = "INSERT INTO asignado (ID_Producto, ID_Venta, Cantidad, P_U) " +
                                              "VALUES (@idProducto, @idVenta, @cantidad, @precioUnitario)";

                    MySqlCommand cmdAsignado = new MySqlCommand(insertarAsignado, connection);
                    cmdAsignado.Parameters.AddWithValue("@idProducto", idProducto);
                    cmdAsignado.Parameters.AddWithValue("@idVenta", idVenta);
                    cmdAsignado.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdAsignado.Parameters.AddWithValue("@precioUnitario", precioUnitario);

                    cmdAsignado.ExecuteNonQuery();
                }

                MessageBox.Show("Venta registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                comboListaClientes.Enabled = true;
                txtLineaAmarilla.Visible = true;
                lblTotalCobro.Text = "";

            }

        }

        private void LimpiarFormulario()
        {
            comboListaClientes.SelectedIndex = -1;
            comboListaProductos.SelectedIndex = -1;
            numericCantidadVenta.Value = 1;
            numericCuotasVenta.Value = 0;
            radioContado.Checked = false;
            radioCuotas.Checked = false;
            dataGridCarrito.Rows.Clear();
        }

        private void dataGridCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBorrarFilaCarrito.Visible = true;
        }

       


        private void picturePasosCliente_MouseEnter(object sender, EventArgs e)
        {
            toolTipAyuda.Show("Pasos para agregar un nuevo cliente", picturePasosCliente, 0, picturePasosCliente.Height);

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            toolTipAyuda.Hide(picPasosProducto);
        }

        private void picturePasosCliente_MouseLeave(object sender, EventArgs e)
        {
            toolTipAyuda.Hide(picturePasosCliente);

        }

        private void picturePasosCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pasos para agregar un nuevo cliente\n1) Ubicarse en 'Menú principal'\n2) Clic en el listado llamado 'Clientes'\n3) Dentro del listado, clic en 'Agregar cliente'\n4) Completar los datos del nuevo cliente");

        }

        private void picPasosProducto_MouseHover(object sender, EventArgs e)
        {

        }

        private void picPasosProducto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pasos para agregar un nuevo producto\n1) Ubicarse en 'Menú principal'\n2) Clic en el listado llamado 'Productos'\n3) Dentro del listado, clic en 'Agregar producto'\n4) Completar los datos del nuevo producto");

        }

        private void picPasosProducto_MouseEnter(object sender, EventArgs e)
        {
            toolTipAyuda.Show("Pasos para agregar un nuevo producto", picPasosProducto, 0, picPasosProducto.Height);

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
