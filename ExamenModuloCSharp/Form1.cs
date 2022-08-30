using ExamenModuloCSharp.controller;
using ExamenModuloCSharp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenModuloCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblNomTienda_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if(formApeVend.Text == "" ||
                formNomVend.Text == "" ||
                formCodVend.Text == "" ||
                formNomTienda.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                groupDatosIniciales.Visible = false;
                Tienda tienda = TiendaController.CrearTienda(formNomTienda.Text, formDirTienda.Text);
                Vendedor vendedor = TiendaController.CrearVendedor(formNomVend.Text, formApeVend.Text, formCodVend.Text);

                TiendaController.AsignarVendedorATienda(vendedor, tienda);


            }
            
        }

        private void btnComenzar_Validated(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
