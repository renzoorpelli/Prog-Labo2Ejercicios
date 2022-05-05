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
namespace formEstacionamiento
{
    public partial class frmEstacionamiento : Form
    {
        Estacionamiento estacionamiento;
        public frmEstacionamiento()
        {
            InitializeComponent();
        }

        private void frmEstacionamiento_Load(object sender, EventArgs e)
        {
            this.cmbTipoVehiculo.DataSource = Enum.GetValues(typeof(Vehiculo.EVehiculo));
            this.cmbTipoMoto.DataSource = Enum.GetValues(typeof(Moto.ETipo));
            this.estacionamiento = Estacionamiento.GetEstacionamiento("ESTACIONAMIENTO 24HS",20);
            this.txtNombreEstacionamiento.Text = this.estacionamiento.Nombre;
        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Vehiculo.EVehiculo)this.cmbTipoVehiculo.SelectedItem == Vehiculo.EVehiculo.Automovil)
            {
                this.cmbTipoMoto.Visible = false;
                lblTipo.Text = "Marca:";
                this.txtMarca.Location = this.cmbTipoMoto.Location;
                this.txtMarca.Visible = true;
            }
            else
            {
                this.cmbTipoMoto.Visible = true;
                lblTipo.Text = "Tipo Moto:";
                this.txtMarca.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo;
            if ((Vehiculo.EVehiculo)this.cmbTipoVehiculo.SelectedItem == Vehiculo.EVehiculo.Automovil)
            {
                vehiculo = new Automovil(this.txtPatente.Text, DateTime.UtcNow.ToLocalTime(), this.txtMarca.Text);
            }
            else
            {
                vehiculo = new Moto(this.txtPatente.Text, DateTime.UtcNow.ToLocalTime(), (Moto.ETipo)this.cmbTipoMoto.SelectedItem);
            }
            if (this.estacionamiento + vehiculo)
            {
                this.listVehiculos.Items.Add(vehiculo);
                MessageBox.Show(vehiculo.ToString(), "Ingreso al Estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha podido ingresar vehiculo por falta de capacidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listVehiculos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.estacionamiento - (Vehiculo)this.listVehiculos.SelectedItem)
            {
                MessageBox.Show(this.estacionamiento.InformarSalida((Vehiculo)this.listVehiculos.SelectedItem), "Ingreso al Estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Information); this.listVehiculos.Items.Remove((Vehiculo)this.listVehiculos.SelectedItem);
            }
        }
    }
}
