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

namespace frmPrincipal
{
    public partial class Form1 : Form
    {
        private Vendedor vendedor;
        public Form1()
        {
            InitializeComponent();
            vendedor = new Vendedor("Libros Minguito");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            lstStock.Items.Add(p1);
            lstStock.Items.Add(p2);
            lstStock.Items.Add(p3);
            lstStock.Items.Add(p4);
            lstStock.Items.Add(p5);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Publicacion publicacion = lstStock.SelectedItem as Publicacion;

            if (publicacion is not null)
            {
                if (vendedor + publicacion)
                {
                    MessageBox.Show("Venta realizada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La venta no pudo realizarse por falta de stock.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            rtbInforme.Text = Vendedor.ObtenerInformacionDeVentas(vendedor);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
