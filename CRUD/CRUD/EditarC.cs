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
    public partial class EditarC : Form
    {
        public EditarC()
        {
            InitializeComponent();
        }

        NpgsqlConnection conexion = new NpgsqlConnection("Server= localhost; User Id= postgres; Password= 1234; Database= Transacciones");

        private void label2_Click(object sender, EventArgs e)
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
            Editar(textBox1.Text, textBox2.Text);
        }
        public void Editar(string numero, string saldo)
        {
            conexion.Open();
            var saldos = Convert.ToDouble(saldo);
            string agregar = $"call p_editar_cuenta('{numero}',{saldos})";
            NpgsqlCommand ejecutar = new NpgsqlCommand(agregar, conexion);
            ejecutar.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Usuario modificado exitosamente");
        }
    }
}
