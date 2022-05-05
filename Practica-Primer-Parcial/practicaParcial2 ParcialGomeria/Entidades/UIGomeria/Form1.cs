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
namespace UIGomeria
{
    public partial class FrmGomeria : Form
    {
        public Gomeria gomeria;
        public FrmGomeria()
        {
            InitializeComponent();
            gomeria = new Gomeria();
            //this.dataGridVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.gomeria = new Gomeria();
            Vehiculo ElRocomovil = new Auto("El Rocomóvil", 10, ETipoAuto.Coupe);
            Vehiculo ElEspantomovil = new Auto("El Espantomóvil", EMarcaRuedas.GoodYear.ToString(), 16, ETipoAuto.Sedan);
            Vehiculo Herbie = new Auto("Herbie", EMarcaRuedas.Brigedstone.ToString(), 26, ETipoAuto.Hatchback);
            Vehiculo ElTroncoswagen = new Camion("El Troncoswagen",EMarcaRuedas.Brigedstone.ToString(), true);
            Vehiculo SuperPerrari = new Camion("Súper Perrari",EMarcaRuedas.Pirelli.ToString(), 23, false);
            Vehiculo Mate = new Camion("Mate",EMarcaRuedas.GoodYear.ToString(), 30, true);
            this.gomeria += ElRocomovil;
            this.gomeria += ElEspantomovil;
            this.gomeria += Herbie;
            this.gomeria += ElTroncoswagen;
            this.gomeria += SuperPerrari;
            this.gomeria += Mate;
            //this.dataGridVehiculos.DataSource = null;
            this.dataGridVehiculos.DataSource = gomeria.ListaVehiculos;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehiculo v1 = (Vehiculo)dataGridVehiculos.CurrentRow.DataBoundItem;
            //this.richTextBox1.Text += gomeria.ToString();
            this.richTextBox1.Text = v1.ToString();
            //this.richTextBox1.Text += 
        }

        private void dataGridVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           //int indice = e.RowIndex;
            //;
        }
    }
}
