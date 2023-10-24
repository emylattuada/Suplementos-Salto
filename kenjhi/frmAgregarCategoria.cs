using Microsoft.VisualBasic.Devices;
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
    public partial class frmAgregarCategoria : Form
    {

        private MySqlConnection conexion;
        private string connectionString = "Server=localhost; Database=suple; Uid=jhin; Pwd=jhin444_2023;";

        public frmAgregarCategoria()
        {
            InitializeComponent();
            conexion = new MySqlConnection(connectionString);

        }
        private int ClickX = 0, ClickY = 0;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        public void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string nombreCategoria = txtNombreCategoria.Text.Trim();
            string descripcionCategoria = txtDescripcionCategoria.Text;

            if (string.IsNullOrEmpty(nombreCategoria))
            {
                lblCate.Visible = true; // Mostrar el label de error
                System.Media.SystemSounds.Exclamation.Play(); // Reproducir el sonido de error
                return; // Salir del evento sin realizar la subida
            }

            if (CategoriaExiste(nombreCategoria))
            {
                MessageBox.Show("La categoría ya existe", "Categoría existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del evento sin realizar la subida
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
                LimpiarCampos();
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

        private void LimpiarCampos()
        {
            txtNombreCategoria.Clear();
            txtDescripcionCategoria.Clear();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                ClickX = e.X;
                ClickY = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X - ClickX);
                this.Top = this.Top + (e.Y - ClickY);
            }
        }
    }
}
