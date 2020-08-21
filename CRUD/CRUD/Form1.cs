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
    public partial class Form1 : Form
    {
        NpgsqlConnection conexion = new NpgsqlConnection("Server= localhost; User Id= postgres; Password= 1234; Database= Transacciones");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logearse(textBox1.Text, textBox2.Text);
        }
        public void Logearse(string user, string pass)
        {
            if (user == "1234" && pass == "1234")
            {
                Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }
    }
}
