using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class EditarU : Form
    {
        public EditarU()
        {
            InitializeComponent();
        }
        NpgsqlConnection conexion = new NpgsqlConnection("Server= localhost; User Id= postgres; Password= 1234; Database= Transacciones");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modificar(textBox1.Text, textBox2.Text, textBox3.Text);
        }
        public void Modificar(string nombre, string clave, string cedula)
        {
            conexion.Open();
            string modificar = $"call p_editar_usuario('{clave}','{nombre}','{cedula}')";
            NpgsqlCommand ejecutar = new NpgsqlCommand(modificar, conexion);
            ejecutar.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Usuario agregado exitosamente");
        }
    }
}
