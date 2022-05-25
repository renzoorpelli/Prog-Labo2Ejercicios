using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using i03;
namespace Fom
{
    public partial class Form1 : Form
    {
        private OpenFileDialog ofd;
        private SaveFileDialog svd;
        private string archivo;

        public Form1()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            svd = new SaveFileDialog();
            svd.Filter = "Archivo de texto|*.txt";
           
        }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.archivo = ofd.FileName;
                    using StreamReader streamReader = new StreamReader(this.archivo);
                    richTextBox1.Text = streamReader.ReadToEnd();
                }
                catch (Exception ex)
                {
                    throw new ArchivoException("Excepcion controlada desde abrir", ex);
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.archivo))
            {
                this.archivo = svd.FileName;
            }
            Escribir(this.archivo);

        }

        private void toolStripStatusLabel1_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        private void Escribir(string ruta)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(ruta))
                {
                    using StreamWriter streamWriter = new StreamWriter(archivo);
                    streamWriter.Write(richTextBox1.Text);
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Excepcion controlada desde Escribir", ex);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "0 caracteres";
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (svd.ShowDialog() == DialogResult.OK)
            {
                archivo = svd.FileName;
                Escribir(archivo);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = $"{richTextBox1.Text.Length} caracteres";
        }
    }
}
