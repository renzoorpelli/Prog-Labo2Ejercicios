using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace frmIngresante
{
    public partial class Form1 : Form
    {
        public string genero = string.Empty;
        public string[] curso = new string[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxPaises.Items.Add("Argentina");
            listBoxPaises.Items.Add("Chile");
            listBoxPaises.Items.Add("Paraguay");
        }

        private void radioMasculino_CheckedChanged(object sender, EventArgs e)
        {
            this.genero = "Masculino";
        }

        private void radioFemenino_CheckedChanged(object sender, EventArgs e)
        {
            this.genero = "Femenino";
        }

        private void radioNoBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.genero = "No binario";
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtDireccion.Text) && !string.IsNullOrEmpty(this.genero) && !string.IsNullOrEmpty(this.listBoxPaises.SelectedItem.ToString()))
            {
                Ingresante i = new Ingresante(this.txtNombre.Text, this.txtDireccion.Text, this.genero, this.listBoxPaises.SelectedItem.ToString(), this.curso, this.numericEdad.Value);
                MessageBox.Show(i.Mostar());
            }
            else
            {
                MessageBox.Show("Error revisa que los campos esten completos");
            }
        }

        private void chkCSharp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCSharp.Checked)
            {
                curso[0] = "C#";
            }
            else
            {
                curso[0] = "";
            }
        }

        private void chkCPlus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPlus.Checked)
            {
                curso[1] = "C++";
            }
            else
            {
                curso[1] = "";
            }
        }

        private void chkJS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJS.Checked)
            {
                curso[2] = "JavaScript";
            }
            else
            {
                curso[2] = "";
            }
        }
    }
}
