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
using IO;

namespace Fom
{
    public partial class Form1 : Form
    {
        private OpenFileDialog ofd;
        private SaveFileDialog svd;
        private string archivo;
        private PuntoJson<string> puntoJson;
        private PuntoXml<string> puntoXml;
        private PuntoTxt puntoTxt;    

        public Form1()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            svd = new SaveFileDialog();
            ofd.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";
            svd.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";
            puntoJson = new PuntoJson<string>();
             puntoXml = new PuntoXml<string>();
            puntoTxt = new PuntoTxt();
    }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                archivo = ofd.FileName;
                switch (Path.GetExtension(archivo).ToLower())
                {
                    case ".json":
                        richTextBox1.Text = this.puntoJson.Leer(archivo);
                        break;
                    case ".xml":
                        richTextBox1.Text = this.puntoXml.Leer(archivo);
                        break;
                    case ".txt":
                        richTextBox1.Text = this.puntoTxt.Leer(archivo);
                        break;
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.archivo))
            {
                this.GuardarComo();
            }
            else
            {
                this.Guardar();
            }

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
            this.GuardarComo();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = $"{richTextBox1.Text.Length} caracteres";
        }


        private string SeleccionarUbicacionGuardado()
        {
            if (svd.ShowDialog() == DialogResult.OK)
            {
                return svd.FileName;
            }

            return string.Empty;
        }

        private void GuardarComo()
        {
            archivo = SeleccionarUbicacionGuardado();

            try
            {
                switch (Path.GetExtension(archivo))
                {
                    case ".json":
                        puntoJson.GuardarComo(archivo, richTextBox1.Text);
                        break;
                    case ".xml":
                        puntoXml.GuardarComo(archivo, richTextBox1.Text);
                        break;
                    case ".txt":
                        puntoTxt.GuardarComo(archivo, richTextBox1.Text);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error desde guardarComo", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guardar()
        {
            try
            {
                switch (Path.GetExtension(archivo))
                {
                    case ".json":
                        puntoJson.Guardar(archivo, richTextBox1.Text);
                        break;
                    case ".xml":
                        puntoXml.Guardar(archivo, richTextBox1.Text);
                        break;
                    case ".txt":
                        puntoTxt.Guardar(archivo, richTextBox1.Text);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error desde guardar", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
