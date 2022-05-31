﻿using System;
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
    public partial class Form1 : Form
    {
        private FrmMostrar frmMostrar;
        private FormTestDelegado frmTestDelegado;
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.frmMostrar = new FrmMostrar();
            this.frmTestDelegado = new FormTestDelegado(frmMostrar.ActualizarNombre);
            frmMostrar.MdiParent = this;
            frmTestDelegado.MdiParent = this;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmTestDelegado.Show();
            mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar.Show();
        }
    }
}
