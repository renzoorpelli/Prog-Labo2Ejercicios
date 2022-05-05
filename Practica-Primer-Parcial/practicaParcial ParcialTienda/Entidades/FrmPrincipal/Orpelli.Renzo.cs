using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace FrmPrincipal
{
    public partial class Form1 : Form
    {
        int cantidadProductos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = Tienda.NombreTienda;
            if (Tienda.AgregarProducto(new Televisor("42mlp", 40000, EMarca.LG, true)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Televisor("57rpk", 50000, EMarca.LG, true)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Televisor("43sam_lat", 43000, EMarca.Samsung, true)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Televisor("42mlp", 40000, EMarca.LG, true)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Televisor("40ujkp", 35000, EMarca.LG, false)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Televisor("32ujkp", 30000, EMarca.Noblex, false)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Televisor("32ujkp", 30000, EMarca.Noblex, false)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Celular("S21", 100000, EMarca.Samsung, 20)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Celular("MotoE", 38000, EMarca.Samsung, 8)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Celular("S21", 100000, EMarca.Samsung, 12)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Celular("K42", 25000, EMarca.LG, 12)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Celular("A02", 33000, EMarca.Samsung, 16)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Celular("A02", 33000, EMarca.Samsung, 16)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Celular("N405", 9999, EMarca.Noblex, 2)))
                cantidadProductos++;
            this.rtb_catalogo.Text += string.Concat("Cantidad de productos en el catalogo: ", cantidadProductos);
            this.rtb_catalogo.Text += "\n" + Tienda.InfoTienda();
        }

        private void btnNuevaOFerta_Click(object sender, EventArgs e)
        {
            richTextBoxOfertas.Text = Tienda.Oferta;
        }
    }
}
