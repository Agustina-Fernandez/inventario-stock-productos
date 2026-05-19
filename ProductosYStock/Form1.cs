namespace ProductosYStock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form2 frmProductos = new Form2();
            this.Hide();
            frmProductos.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Form3 frmStock = new Form3();
            this.Hide();
            frmStock.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adios!!");
            Application.Exit();
        }
    }
}
