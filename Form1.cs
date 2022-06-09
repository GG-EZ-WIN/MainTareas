using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3
{
    public partial class Form1 : Form
    {
        List<Appoinment> Appoiments = new List<Appoinment>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SAppoinment();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }
        private void Empty()
        {
            txtNombre.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }


        public class Appoinment
        {
            public string ID { get; set; }
            public string Code { get; set; }
            public string NombreCliente { get; set; }
            public string NumeroCliente { get; set; }
            public string MailCliente { get; set; }
            public string Nacionalidad { get; set; }
            public string Edad { get; set; }
            public string Cedula { get; set; }
        }
        private void GAppoinment()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Appoiments;
            dataGridView1.Columns["ID"].HeaderText = "Cedula";
            dataGridView1.Columns["Code"].HeaderText = "Codigo";
            dataGridView1.Columns["NombreCliente"].HeaderText = "Cliente";
            dataGridView1.Columns["NumeroCliente"].HeaderText = "Telefono";
            dataGridView1.Columns["MailCliente"].HeaderText = "Correo";
            dataGridView1.Columns["Nacionalidad"].HeaderText = "Nacionalidad";
            dataGridView1.Columns["Edad"].HeaderText = "Edad";

        }


        private void SAppoinment()
        {
            var random = new Random();
            var appoinment = new Appoinment
            {
                ID = txtCedula.Text,
                Code = random.Next(1000000, 9999999).ToString(),
                NombreCliente = txtNombre.Text,
                NumeroCliente = txtTelefono.Text,
                MailCliente = txtCorreo.Text,
                Nacionalidad = txtNacionalidad.Text,
                Edad = txtEdad.Text,
                Cedula = txtCedula.Text,

            };

            Appoiments.Add(appoinment);

            GAppoinment();
            Empty();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
