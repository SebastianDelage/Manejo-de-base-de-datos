using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Security.Cryptography;

namespace ConexionBBDD
{
    public partial class Form1 : Form
    {
        private Conexion ConexionBBDD;

        public Form1()
        {
            InitializeComponent();
            ConexionBBDD = new Conexion();
        }

        public void Cargar_tabla()
        {
            ConexionBBDD.Abrir();
            string consulta = "select * from Clientes";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, ConexionBBDD.conectarbbdd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Cargar_tabla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtNombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtApellido.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtTelefono.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string consulta = "insert into clientes values('" + txtApellido.Text + "', '" + txtNombre.Text + "', '" + txtEmail.Text + "', '" + txtTelefono.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, ConexionBBDD.conectarbbdd);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registor Agregado");

            Cargar_tabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string consulta = "UPDATE clientes SET " +
                          "Apellido = '" + txtApellido.Text + "', " +
                          "Nombre = '" + txtNombre.Text + "', " +
                          "Email = '" + txtEmail.Text + "', " +
                          "Telefono = '" + txtTelefono.Text + "' " +
                          "WHERE idCliente = " + Convert.ToInt32(txtId.Text);
            SqlCommand comando = new SqlCommand(consulta, ConexionBBDD.conectarbbdd);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Actualizado");
            Cargar_tabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string consulta = "delete from Clientes where idCliente=" + Convert.ToInt32(txtId.Text);
            SqlCommand comando = new SqlCommand(consulta,ConexionBBDD.conectarbbdd);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            Cargar_tabla();
        }
    }
}
