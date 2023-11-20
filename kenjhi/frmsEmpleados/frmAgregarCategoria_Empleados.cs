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


namespace kenjhi.frmsAdmin
{
    public partial class frmAgregarCategoria_Empleados : Form

    {
        private MySqlConnection conexion;
        private string connectionString = "Server = localhost; Database=suple; Uid=suple_empleado; Pwd=supleempleado2023!;";
        public frmAgregarCategoria_Empleados()

        {

            InitializeComponent();
            conexion = new MySqlConnection(connectionString);


        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string nombreCategoria = txtNombreCategoria.Text.Trim();
            string descripcionCategoria = txtDescripcionCategoria.Text;

            if (txtNombreCategoria.Text.Length > 25)
            {
                MessageBox.Show("El nombre de categoría contiene demasiados caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtDescripcionCategoria.Text.Length > 25)
            {

                MessageBox.Show("La descripción contiene demasiados caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(nombreCategoria))
            {
                lblCate.Visible = true; 
                System.Media.SystemSounds.Exclamation.Play(); 
                return; 
            }

            if (CategoriaExiste(nombreCategoria))
            {
                MessageBox.Show("La categoría ya existe", "Categoría existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            try
            {
                conexion.Open();

                string consulta = "INSERT INTO Categoria (Nombre, Descripcion) VALUES (@nombre, @descripcion)";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@nombre", nombreCategoria);
                comando.Parameters.AddWithValue("@descripcion", descripcionCategoria);

                comando.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Categoría agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreCategoria.Clear();
                txtDescripcionCategoria.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al agregar la categoría", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private bool CategoriaExiste(string nombreCategoria)
        {
            try
            {
                conexion.Open();

                string consulta = "SELECT COUNT(*) FROM Categoria WHERE Nombre = @nombre";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombre", nombreCategoria);

                int cantidad = Convert.ToInt32(comando.ExecuteScalar());

                conexion.Close();

                return cantidad > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al verificar la existencia de la categoría", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
