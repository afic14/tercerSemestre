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
    public partial class EliminarC : Form
    {
        public EliminarC()
        {
            InitializeComponent();
        }
        NpgsqlConnection conexion = new NpgsqlConnection("Server= localhost; User Id= postgres; Password= 1234; Database= Transacciones");

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eliminar(textBox1.Text);
        }
        public void Eliminar(string numero)
        {
            conexion.Open();
            string eliminar = $"call p_eliminar_cuenta('{numero}')";
            NpgsqlCommand ejecutar = new NpgsqlCommand(eliminar, conexion);
            ejecutar.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Cuenta eliminada exitosamente");
        }
    }
}
