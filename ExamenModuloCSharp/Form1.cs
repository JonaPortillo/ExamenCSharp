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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ExamenModuloCSharp
{
    public partial class Form1 : Form
    {
        private Tienda tienda;
        private string prenda = "Camisa";
        private string calidad = "standar";
        private string cuello = "comun";
        private string manga = "larga";
        private string tipo = "comun";

        public Form1()
        {
            InitializeComponent();
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
            cbChupin.Enabled = rbPantalon.Checked;
            cbCuelloMao.Enabled = rbCamisa.Checked;
            cbMangaCorta.Enabled = rbCamisa.Checked;
            lblFormIncompleto.Visible = false;
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
                MessageBox.Show("(*) Campos obligatorios incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                groupDatosIniciales.Visible = false;
                Tienda tienda = TiendaController.CrearTienda(formNomTienda.Text, formDirTienda.Text);
                Vendedor vendedor = TiendaController.CrearVendedor(formNomVend.Text, formApeVend.Text, formCodVend.Text);

                tienda = TiendaController.AsignarVendedorATienda(vendedor, tienda);

                // Parte E, carga de stock de la tienda 

                TiendaController.CargaDeStock(ref tienda);

                lblNomTienda.Text = tienda.Nombre;
                lblDirTienda.Text = tienda.Direccion;
                lblNomApeVende.Text = (tienda.Vendedor.Nombre + " " + tienda.Vendedor.Apellido);
                lblCodVend.Text = tienda.Vendedor.CodigoVendedor;

                this.tienda = tienda;

                string[] carac = prenda == "Pantalon" ? new string[] { tipo } : new string[] { cuello, manga };
                lblStockDisponible.Text = TiendaController.ActualizarStockVista(tienda, prenda, calidad, carac).ToString();
            }
            
        }

        private void btnComenzar_Validated(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblCodVend_Click(object sender, EventArgs e)
        {

        }

        private void rbCamisa_CheckedChanged(object sender, EventArgs e)
        {
            //Visibilidad de los checkboxs de camisa
            cbCuelloMao.Enabled = rbCamisa.Checked;
            cbMangaCorta.Enabled = rbCamisa.Checked;

            this.prenda = "Camisa";
            string[] carac = new string[] { cuello, manga };
            lblStockDisponible.Text = TiendaController.ActualizarStockVista(tienda, prenda, calidad, carac).ToString();

        }

        private void rbPantalon_CheckedChanged(object sender, EventArgs e)
        {
            //Visibilidad de los checkboxs de pantalon
            cbChupin.Enabled = rbPantalon.Checked;
            this.prenda = "Pantalon";

            string[] carac = new string[] {tipo };
            lblStockDisponible.Text = TiendaController.ActualizarStockVista(tienda, prenda, calidad, carac).ToString();
        }

        private void btnCotizar_MouseEnter(object sender, EventArgs e)
        {
            if(tbCantidad.Text == "" || tbPrecioUni.Text == "")
            {
                tbCantidad.BackColor = Color.Red;
                tbPrecioUni.BackColor = Color.Red;
                lblFormIncompleto.Visible = true;
            }
            
        }

        private void btnCotizar_MouseLeave(object sender, EventArgs e)
        {
            tbCantidad.BackColor = Color.White;
            tbPrecioUni.BackColor = Color.White;
            lblFormIncompleto.Visible = false;
        }

        private void tbPrecioUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') == -1))
            {
                e.Handled = true;
            }
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            //lblStockDisponible.Text = this.tienda.Prendas[1].CantidadStock.ToString();
            label12.Text = this.prenda;
            label13.Text = this.calidad;
            label14.Text = this.cuello;
            label15.Text = this.manga;
            label16.Text = this.tipo;

            if (!(tbCantidad.Text == "" || tbPrecioUni.Text == ""))
            {
                int stock = Int32.Parse(lblStockDisponible.Text);
                int cant = Int32.Parse(tbCantidad.Text);
                double precio = double.Parse(tbPrecioUni.Text);

                if (stock >= cant)
                {
                    // Cotización
                    string[] carac = prenda == "Pantalon" ? new string[] { tipo } : new string[] { cuello, manga };
                    lblTotal.Text = TiendaController.Cotizar(ref tienda, prenda, calidad, carac, precio, cant).ToString();

                    // Actualizacion de la vista de stock
                    lblStockDisponible.Text = TiendaController.ActualizarStockVista(tienda, prenda, calidad, carac).ToString();

                    // Reset de los campos
                    tbCantidad.Text = "";
                    tbPrecioUni.Text = "";

                    //Actualizar historial cotizaciones
                    label24.Text = this.tienda.Cotizaciones.First().NumeroIdentificacion.ToString() ;
                    label25.Text = this.tienda.Cotizaciones.First().CodigoVendedor.ToString();
                    label26.Text = this.tienda.Cotizaciones.First().Prenda.GetType().Name;
                    label27.Text = this.tienda.Cotizaciones.First().CantidadUnidadesCotizadas.ToString();
                    if(this.tienda.Cotizaciones.First().Prenda.GetType().Name == "Camisa")
                    {
                        label26.Text = this.tienda.Cotizaciones.First().Prenda.GetType().Name.ToString() + ", cuello " + this.tienda.Cotizaciones.First().Prenda.Calidad.ToString(); ;
                    }
                    label28.Text = this.tienda.Cotizaciones.First().Prenda.Calidad.ToString();
                    label29.Text = this.tienda.Cotizaciones.First().Resultado.ToString();

                    label17.Text = tienda.Cotizaciones.Count().ToString();
                }
                else
                {
                    MessageBox.Show("No hay stock de esa prenda suficiente en esta tienda", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }

        }

        private void groupPrenda_Enter(object sender, EventArgs e)
        {

        }

        private void cbMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            this.manga = this.manga == "corta" ? "larga":"corta";

            string[] carac = new string[] { cuello, manga };
            lblStockDisponible.Text = TiendaController.ActualizarStockVista(tienda, prenda, calidad, carac).ToString();
        }

        private void cbCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            this.cuello = this.cuello == "comun" ? "mao" : "comun";
            string[] carac = new string[] { cuello, manga };
            lblStockDisponible.Text = TiendaController.ActualizarStockVista(tienda, prenda, calidad, carac).ToString();
        }

        private void cbChupin_CheckedChanged(object sender, EventArgs e)
        {
            this.tipo = this.tipo == "comun" ? "chupin" : "comun";
            string[] carac = new string[] { tipo };
            lblStockDisponible.Text = TiendaController.ActualizarStockVista(tienda, prenda, calidad, carac).ToString();
        }

        private void rbStandar_CheckedChanged(object sender, EventArgs e)
        {
            this.calidad = this.calidad == "standar" ? "premium" : "standar";
            string[] carac = prenda == "Pantalon" ? new string[] { tipo } : new string[] { cuello,manga };
            lblStockDisponible.Text = TiendaController.ActualizarStockVista(tienda, prenda, calidad, carac).ToString();

        }

        private void rbPremium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbPrecioUni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
