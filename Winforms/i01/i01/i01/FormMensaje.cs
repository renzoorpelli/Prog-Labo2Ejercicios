using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace i01
{
    public partial class FormMensaje : Form
    {
        public FormMensaje()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.textBoxApellido.Text) && !string.IsNullOrEmpty(this.textBoxApellido.Text))
            {
                FormSaludar frmSaludar = new FormSaludar("Hola windows forms", $"Soy {this.textBoxNombre.Text}, {this.textBoxApellido.Text} y mi materia favorita es {this.cmbMateriaFavorita.SelectedItem}");
                frmSaludar.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Se debe completar los siguientes campos\n{this.textBoxNombre.Name}\n{this.textBoxApellido.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void FormMensaje_Load(object sender, EventArgs e)
        {
            this.cmbMateriaFavorita.Items.Add("PROGRAMACION 2");
            this.cmbMateriaFavorita.Items.Add("LABORATORIO 2");
            this.cmbMateriaFavorita.Items.Add("INGLES 2");
            this.cmbMateriaFavorita.Items.Add("SISTEMAS");
            this.cmbMateriaFavorita.Items.Add("METODOLOGIA");
            this.cmbMateriaFavorita.Items.Add("ESTADISTICA");
            this.cmbMateriaFavorita.SelectedIndex = 0;// le precargo la opcion 0 como default

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
