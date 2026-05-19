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

namespace ProductosYStock
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form1 frmPrincipal = new Form1();
            this.Dispose();
            frmPrincipal.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string conn = "server=localhost;port=3306;user=root;database=negocio;";
            MySqlConnection connection = new MySqlConnection(conn);

            connection.Open();

            string consulta = "SELECT * FROM productos";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connection);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvProductos.DataSource = tabla;

            connection.Close();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProductos.SelectedCells[0].Value.ToString();
            txtNombre.Text = dgvProductos.SelectedCells[1].Value.ToString();
            txtDescripcion.Text = dgvProductos.SelectedCells[2].Value.ToString();
            txtPrecio.Text = dgvProductos.SelectedCells[3].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string conn = "server=localhost;port=3306;user=root;database=negocio;";
            
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                string agregar = "INSERT INTO productos (id_producto,nombre,descripcion,precio) VALUES (@id_producto,@nombre,@descripcion,@precio)";

                using(MySqlCommand comando = new MySqlCommand(agregar, connection))
                {
                    Decimal precio = Decimal.Parse(txtPrecio.Text);
                    comando.Parameters.AddWithValue("@id_producto", txtId.Text);
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    comando.Parameters.AddWithValue("@precio", precio);

                    comando.ExecuteNonQuery();

                }

                MessageBox.Show("Producto agregado");

                string consulta = "SELECT * FROM productos";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connection);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvProductos.DataSource = tabla;

                connection.Close();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string conn = "server=localhost;port=3306;user=root;database=negocio;";
            
            using(MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                string eliminar = "DELETE FROM productos WHERE id_producto= @id";

                using(MySqlCommand comand = new MySqlCommand(eliminar, connection))
                {
                    comand.Parameters.AddWithValue("@id",txtId.Text);

                    comand.ExecuteNonQuery();
                }

                MessageBox.Show("Producto eliminado");

                string consulta = "SELECT * FROM productos";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connection);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvProductos.DataSource = tabla;

                connection.Close();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string conn = "server=localhost;port=3306;user=root;database=negocio;";
            
            using(MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                string editar = "UPDATE productos SET nombre = @nombre,descripcion = @descripcion,precio = @precio WHERE id_producto = @id_producto";

                using (MySqlCommand cmd = new MySqlCommand(editar, connection))
                {
                    Decimal precio = Decimal.Parse(txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@id_producto", txtId.Text);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@precio", precio);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Producto modificado");

                string consulta = "SELECT * FROM productos";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connection);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvProductos.DataSource = tabla;

                connection.Close();
            }
        }
    }
}
