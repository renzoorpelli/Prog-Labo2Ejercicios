using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmAltaModificacion : Form
    {
        public FrmAltaModificacion(string titulo, string contenidoTextBox, string textBotonConfirmar)
        {
            InitializeComponent();
            Text = titulo;
            txtObjeto.Text = contenidoTextBox;
            btnConfirmar.Text = textBotonConfirmar;
            
        }

        public string TxtObjetoContenido { get => this.txtObjeto.Text;}

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtObjeto.Text))
            {
                MessageBox.Show("el texto esta vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            Close();
        }

        private void FrmAltaModificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 13 es el código ASCII que representa a ENTER.
            {
                btnConfirmar_Click(sender, e);
            }
            else if (e.KeyChar == (char)27)// el escape en codigo ascii
            {
                // ...
                btnCancelar_Click(sender, e);
            }
        }
    }
}
