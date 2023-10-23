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
    public partial class frmNuevaVenta_Admin : Form
    {
        Dictionary<int, int> preciosProductos = new Dictionary<int, int>();


        public frmNuevaVenta_Admin()
        {

            InitializeComponent();

            //Dictionary<int, int> preciosProductos = new Dictionary<int, int>();

            //numericCantidadVenta.Value = 1;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nueva_Venta_Load(object sender, EventArgs e)
        {
            //comboListaTipoPago.Items.Add("Contado");
            //comboListaTipoPago.Items.Add("Cuotas");
            // Conexión a la base de datos


            using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
            {
                connection.Open();

                string consultaClientes = "SELECT ID_Cliente, Nombre, Telefono FROM cliente WHERE Visible = 1";

                MySqlCommand cmdClientes = new MySqlCommand(consultaClientes, connection);
                MySqlDataReader readerClientes = cmdClientes.ExecuteReader();

                while (readerClientes.Read())
                {
                    int idCliente = readerClientes.GetInt32("ID_Cliente");
                    string nombreCliente = readerClientes.GetString("Nombre");
                    string telefonoCliente = readerClientes.GetString("Telefono");

                    comboListaClientes.Items.Add(new Cliente(idCliente, nombreCliente, telefonoCliente));
                }
            }

            using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
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

                    // Agrega el precio del producto al diccionario
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


            numericDescuentoVenta.ValueChanged += new EventHandler(numericDescuentoVenta_ValueChanged);



        }

        private void comboListaClientes_Click(object sender, EventArgs e)
        {
           
        }

        private void comboListaProductos_Click(object sender, EventArgs e)
        {
            //using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
            //{
            //    connection.Open();
            //    string query = "SELECT Nombre FROM producto WHERE Visible = 1 AND Cantidad > 0";
            //    MySqlCommand cmd = new MySqlCommand(query, connection);

            //    using (MySqlDataReader reader = cmd.ExecuteReader())
            //    {
            //        comboListaProductos.Items.Clear();
            //        while (reader.Read())
            //        {
            //            comboListaProductos.Items.Add(reader["Nombre"].ToString());
            //        }
            //    }
            //}


        }

        private void radioCuotas_Click(object sender, EventArgs e)
        {
            //numericCuotasVenta.Enabled = true;
            
        }

        private void radioContado_Click(object sender, EventArgs e)
        {
            //numericCuotasVenta.Value = 0;
            //numericCuotasVenta.Enabled = false;
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


            //// Verificar si se ha seleccionado un producto
            //if (comboListaProductos.SelectedItem == null)
            //{
            //    MessageBox.Show("Por favor, elija un producto.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Obtener el producto seleccionado
            //Producto productoSeleccionado = (Producto)comboListaProductos.SelectedItem;

            //// Obtener la cantidad del producto del NumericUpDown
            //int cantidad = (int)numericCantidadVenta.Value;

            //if (cantidad == 0)
            //{
            //    MessageBox.Show("La cantidad mínima de venta es 1.", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Realizar una consulta para obtener el precio del producto desde la base de datos
            //decimal precioUnitario = 0;

            //using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
            //{
            //    connection.Open();

            //    string consultaPrecioProducto = "SELECT Precio FROM producto WHERE ID_Producto = @idProducto";
            //    MySqlCommand cmdPrecioProducto = new MySqlCommand(consultaPrecioProducto, connection);
            //    cmdPrecioProducto.Parameters.AddWithValue("@idProducto", productoSeleccionado.ID);

            //    using (MySqlDataReader reader = cmdPrecioProducto.ExecuteReader())
            //    {
            //        if (reader.Read())
            //        {
            //            precioUnitario = reader.GetDecimal("Precio");
            //        }
            //        else
            //        {
            //            MessageBox.Show("El producto seleccionado no tiene un precio válido en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //    }
            //}

            //// Calcular el precio total para esta fila
            //decimal precioTotal = precioUnitario * cantidad;

            //// Agregar el producto al carrito en el DataGridView
            //dataGridCarrito.Rows.Add(new object[] { productoSeleccionado, precioUnitario, cantidad, precioTotal });

            //// Limpiar el ComboBox de productos y reiniciar la cantidad
            //comboListaProductos.SelectedIndex = -1;
            //numericCantidadVenta.Value = 1;

            //// Calcular el precio total de la venta
            //decimal precioTotalVenta = 0;
            //foreach (DataGridViewRow fila in dataGridCarrito.Rows)
            //{
            //    precioTotalVenta += Convert.ToDecimal(fila.Cells["Precio Total"].Value);
            //} //comentado para probar otro


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
            //lo represente aca como stock pero en la bd es cantidad, no se confundan
            int stockDisponible = ObtenerStockDisponible(productoSeleccionado.ID);

            if (cantidadDeseada > stockDisponible)
            {
                MessageBox.Show($"No hay suficiente stock disponible para '{productoSeleccionado.Nombre}' (Stock actual: {stockDisponible}).", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar el stock en la base de datos
            ActualizarStockProducto(productoSeleccionado.ID, cantidadDeseada);

            decimal precioUnitario = preciosProductos[productoSeleccionado.ID];
            decimal precioTotal = precioUnitario * cantidadDeseada;

            dataGridCarrito.Rows.Add(new object[] { productoSeleccionado, precioUnitario, cantidadDeseada, precioTotal });
            comboListaProductos.SelectedIndex = -1;
            numericCantidadVenta.Value = 1;

            // Calcular el precio total de la venta
            decimal precioTotalVenta = 0;
            foreach (DataGridViewRow fila in dataGridCarrito.Rows)
            {
                precioTotalVenta += Convert.ToDecimal(fila.Cells["Precio Total"].Value);
            }
        }

        private int ObtenerStockDisponible(int productoID)
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
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

            return 0; // Valor predeterminado si no se encuentra el stock
        }

        private void ActualizarStockProducto(int productoID, int cantidadVendida)
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
            {
                connection.Open();

                string actualizarStock = "UPDATE producto SET Cantidad = Cantidad - @cantidadVendida WHERE ID_Producto = @productoID";
                MySqlCommand cmdActualizarStock = new MySqlCommand(actualizarStock, connection);
                cmdActualizarStock.Parameters.AddWithValue("@cantidadVendida", cantidadVendida);
                cmdActualizarStock.Parameters.AddWithValue("@productoID", productoID);

                cmdActualizarStock.ExecuteNonQuery();
            }

        }

        // Método para calcular el precio total del carrito
        private double CalcularPrecioTotalCarrito()
        {
            double precioTotal = 0;
            foreach (DataGridViewRow row in dataGridCarrito.Rows)
            {
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                double precioUnitario = Convert.ToDouble(row.Cells["Precio"].Value);
                precioTotal += cantidad * precioUnitario;
            }
            return precioTotal;
        }

        private void btnBorrarFilaCarrito_Click(object sender, EventArgs e)
        {
            if (dataGridCarrito.SelectedRows.Count > 0)
            {
                dataGridCarrito.Rows.RemoveAt(dataGridCarrito.SelectedRows[0].Index);
                btnBorrarFilaCarrito.Visible = false;
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
            using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
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

                //calcula el precio total de la venta
                decimal precioTotal = 0;
                foreach (DataGridViewRow fila in dataGridCarrito.Rows)
                {
                    precioTotal += Convert.ToDecimal(fila.Cells["Precio Total"].Value);
                }

                //insertar la venta en la tabla de ventas
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

              
                MessageBox.Show("Venta registrada con éxito.");
                LimpiarFormulario();
                labelPrecioTotal.Text = "Total a cobrar: ";
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
            numericDescuentoVenta.Value = 0;
            dataGridCarrito.Rows.Clear();
            dataFechaVenta.Value = DateTime.Now;
            //este metodo deberiamos ponerlo en una clase a parte para poder hacer clear sin escribir todo el codigo
        }

        private void dataGridCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBorrarFilaCarrito.Visible = true;
        }

        private void numericDescuentoVenta_ValueChanged(object sender, EventArgs e)
        {
            AplicarDescuento((decimal)numericDescuentoVenta.Value);

        }

        private void AplicarDescuento(decimal descuentoPorcentaje)
        {
            decimal precioTotal = CalcularPrecioTotalCarrito2(); // Calcular el precio total de los productos en el carrito
            decimal descuento = (precioTotal * descuentoPorcentaje) / 100;
            decimal precioConDescuento = precioTotal - descuento;

            // Actualizar el campo de texto que muestra el precio total
            labelPrecioTotal.Text = "Total a cobrar: " + precioConDescuento.ToString("C");

            // Actualizar el saldo en la tabla de ventas
            if (dataGridCarrito.Rows.Count > 0)
            {
                // El descuento se aplica al saldo si hay productos en el carrito
                using (MySqlConnection connection = new MySqlConnection("Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;"))
                {
                    connection.Open();

                    // Obtener el ID de la última venta insertada
                    string obtenerIdVenta = "SELECT MAX(ID_Venta) FROM venta";
                    MySqlCommand cmdIdVenta = new MySqlCommand(obtenerIdVenta, connection);
                    int idVenta = Convert.ToInt32(cmdIdVenta.ExecuteScalar());

                    // Actualizar el saldo en la tabla de ventas
                    string actualizarSaldo = "UPDATE venta SET Saldo = @saldo WHERE ID_Venta = @idVenta";
                    MySqlCommand cmdActualizarSaldo = new MySqlCommand(actualizarSaldo, connection);
                    cmdActualizarSaldo.Parameters.AddWithValue("@saldo", precioConDescuento);
                    cmdActualizarSaldo.Parameters.AddWithValue("@idVenta", idVenta);
                    cmdActualizarSaldo.ExecuteNonQuery();
                }
            }
            labelPrecioTotal.Text ="Total a cobrar: " +precioConDescuento.ToString("C");
        }
        private decimal CalcularPrecioTotalCarrito2()
        {
            decimal precioTotal = 0;

            foreach (DataGridViewRow fila in dataGridCarrito.Rows)
            {
                decimal precioTotalFila = Convert.ToDecimal(fila.Cells["Precio Total"].Value);
                precioTotal += precioTotalFila;
            }

            return precioTotal;
        }

        private void numericDescuentoVenta_Validating(object sender, CancelEventArgs e)
        {
            if (numericDescuentoVenta.Value > 100)
            {
                MessageBox.Show("El descuento no puede ser mayor que 100.", "Descuento Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericDescuentoVenta.Value = 100; 
            }
        }
    }
}
