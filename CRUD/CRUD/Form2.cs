using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        NpgsqlConnection conexion = new NpgsqlConnection("Server= localhost; User Id= postgres; Password= 1234; Database= Transacciones");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("select * from v_consultar_usuario", conexion);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            data.Fill(dt);
            grilla.DataSource = dt;
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            EliminarU eliminarU = new EliminarU();
            eliminarU.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            AgregarU agregar = new AgregarU();
            agregar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            EditarU editar = new EditarU();
            editar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            AgregarC agregar = new AgregarC();
            agregar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            EditarC editar = new EditarC();
            editar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            EliminarC eliminar = new EliminarC();
            eliminar.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("select * from v_consultar_usuario", conexion);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            data.Fill(dt);
            grilla.DataSource = dt;
            //grilla.DataBindings();
            conexion.Close();
        }
    }
}
