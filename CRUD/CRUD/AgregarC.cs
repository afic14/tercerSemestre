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
    public partial class AgregarC : Form
    {
        public AgregarC()
        {
            InitializeComponent();
        }
        NpgsqlConnection conexion = new NpgsqlConnection("Server= localhost; User Id= postgres; Password= 1234; Database= Transacciones");
        private void AgregarC_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

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
            Agregar(textBox1.Text, textBox2.Text, textBox3.Text);
        }
        public void Agregar(string numero, string saldo, string id)
        {
            conexion.Open();
            DateTime fecha = DateTime.Today;
            var saldos = Convert.ToDouble(saldo);
            string agregar = $"call p_agregar_cuenta('{numero}',{saldos},'{fecha}',{id})";
            NpgsqlCommand ejecutar = new NpgsqlCommand(agregar, conexion);
            ejecutar.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Usuario agregado exitosamente");
        }
    }
}
