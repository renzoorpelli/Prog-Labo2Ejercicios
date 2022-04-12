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
    public partial class FormSaludar : Form
    {
        
        public FormSaludar()
        {
            InitializeComponent();
        }


        public FormSaludar(string titulo, string mensaje) :this()
        {
            this.lblSaludo.Text = mensaje;
            this.lblTitulo.Text = titulo;

        }
    }
}
