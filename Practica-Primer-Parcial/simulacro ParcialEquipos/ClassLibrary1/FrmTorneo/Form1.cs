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
namespace FrmTorneo
{
    public partial class Form1 : Form
    {
        Competencia competencia;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.competencia = new Competencia("Torneos el Foquito", 10);
            Equipo e1 = new EquipoFutbol("Independiente", true);
            Equipo e2 = new EquipoFutbol("Boca", true);
            Equipo e3 = new EquipoBasket("Spurs");
            Equipo e4 = new EquipoBasket("Chicago Bulls");
            Equipo e5 = new EquipoFutbol("Racing");
            this.competencia += e1;
            this.competencia += e1;//pruebo de agregar el mismo equipo
            this.competencia += e2;
            this.competencia += e3;
            this.competencia += e4;
            this.competencia += e5;
            this.cmbEquipo1.DataSource = this.competencia.Equipos;
            this.rchtDatosTorneo.Text += Competencia.MostrarTorneo(this.competencia);
        }

        private void cmbEquipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbEquipo2.DataSource = competencia.Equipos.FindAll(element => element != (Equipo)this.cmbEquipo1.SelectedItem);
        }

        private void btnDesafiar_Click(object sender, EventArgs e)
        {
            if (Equipo.JugarPartido((Equipo)this.cmbEquipo1.SelectedItem, (Equipo)cmbEquipo2.SelectedItem))
            {
                MessageBox.Show("Se Jugo el partido");
                this.dgvResultados.DataSource = null;
                this.dgvResultados.DataSource = this.competencia.Equipos;
            }
            else
            {
                MessageBox.Show("No se puede jugar el partido entre estos 2 equipos");
            }
        }
    }
}
