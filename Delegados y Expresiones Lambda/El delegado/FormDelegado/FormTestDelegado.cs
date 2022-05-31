using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDelegado
{
   
    public partial class FormTestDelegado : Form
    {
        public delegate void actualizarNombreDelegate(string texto);
        protected actualizarNombreDelegate actualizarNombreDelDelegado;

        public FormTestDelegado(actualizarNombreDelegate actualizarNombreDelDelegado)
        {
            InitializeComponent();
            this.actualizarNombreDelDelegado = actualizarNombreDelDelegado;
        }
        private void bntActualizar_Click(object sender, EventArgs e)
        {
            actualizarNombreDelDelegado.Invoke(txtNombre.Text);
        }
    }
}
