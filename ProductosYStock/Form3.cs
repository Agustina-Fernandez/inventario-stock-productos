using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosYStock
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 frmInicio = new Form1();
            this.Dispose();
            frmInicio.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string conn = "server=localhost;port=3306;user=root;database=negocio;";
            MySqlConnection connect = new MySqlConnection(conn);

            connect.Open();

            string consulta = "SELECT * FROM stock";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connect);
            DataTable tb = new DataTable();
            adaptador.Fill(tb);
            dgvStock.DataSource = tb;

            connect.Close();
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStock.Text = dgvStock.SelectedCells[0].Value.ToString();
            txtProducto.Text = dgvStock.SelectedCells[1].Value.ToString();
            txtCantidad.Text = dgvStock.SelectedCells[2].Value.ToString();
            txtFecha.Text = dgvStock.SelectedCells[3].Value.ToString();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string conn = "server=localhost;port=3306;user=root;database=negocio;";
            using (MySqlConnection connect = new MySqlConnection(conn))
            {
                connect.Open();

                string agregar = "INSERT INTO stock (id_stock,id_producto,cantidad,fecha_actualizacion) VALUES (@id_stock,@id_producto,@cantidad,@fecha_actualizacion)";

                using (MySqlCommand comando = new MySqlCommand(agregar, connect))
                {
                    DateTime fecha = DateTime.Parse(txtFecha.Text);
                    comando.Parameters.AddWithValue("@id_stock", txtStock.Text);
                    comando.Parameters.AddWithValue("@id_producto", txtProducto.Text);
                    comando.Parameters.AddWithValue("@cantidad", txtCantidad.Text);
                    comando.Parameters.AddWithValue("@fecha_actualizacion", fecha);

                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Informacion agregada");

                string consulta = "SELECT * FROM stock";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connect);
                DataTable tb = new DataTable();
                adaptador.Fill(tb);
                dgvStock.DataSource = tb;

                connect.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string conn = "server=localhost;port=3306;user=root;database=negocio;";

            using (MySqlConnection connect = new MySqlConnection(conn))
            {
                connect.Open();

                string actualizar = "UPDATE stock SET id_producto = @id_producto,cantidad = @cantidad,fecha_actualizacion = @fecha_actualizacion WHERE id_stock = @id_stock";

                using (MySqlCommand comand = new MySqlCommand(actualizar, connect))
                {
                    DateTime fecha = DateTime.Parse(txtFecha.Text);
                    comand.Parameters.AddWithValue("@id_stock", txtStock.Text);
                    comand.Parameters.AddWithValue("@id_producto", txtProducto.Text);
                    comand.Parameters.AddWithValue("@cantidad", txtCantidad.Text);
                    comand.Parameters.AddWithValue("@fecha_actualizacion", fecha);

                    comand.ExecuteNonQuery();
                }

                MessageBox.Show("Informacion actualizada");

                string consulta = "SELECT * FROM stock";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connect);
                DataTable tb = new DataTable();
                adaptador.Fill(tb);
                dgvStock.DataSource = tb;

                connect.Close();
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            string conn = "server=localhost;port=3306;user=root;database=negocio;";

            using (MySqlConnection connect = new MySqlConnection(conn))
            {
                connect.Open();

                string quitar = "DELETE FROM stock WHERE id_stock = @id_stock";

                using (MySqlCommand cmd = new MySqlCommand(quitar, connect))
                {
                    cmd.Parameters.AddWithValue("@id_stock",txtStock.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Stock eliminado");

                string consulta = "SELECT * FROM stock";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connect);
                DataTable tb = new DataTable();
                adaptador.Fill(tb);
                dgvStock.DataSource = tb;

                connect.Close();
            }
        }
    }
}
