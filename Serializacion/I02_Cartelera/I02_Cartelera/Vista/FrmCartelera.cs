using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCartelera : Form
    {
        private static string rutaConfiguracion;
        private static string filename = "configuracion.json";
        private static string finalPath;

        static FrmCartelera()
        {
            FrmCartelera.rutaConfiguracion = $"{Environment.SpecialFolder.ApplicationData}";
            FrmCartelera.finalPath = $"{rutaConfiguracion}\\{filename}";

        }
        public FrmCartelera()
        {
            InitializeComponent();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = txtTitulo.Text;
        }

        private void rtxtMensaje_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = rtxtMensaje.Text;
        }

        private void btnColorPanel_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                pnlCartel.BackColor = colorDialog.Color;

            }
        }

        private void btnColorTitulo_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblTitulo.ForeColor = colorDialog.Color;
            }
        }

        private void btnColorMensaje_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblMensaje.ForeColor = colorDialog.Color;
            }
        }

        private void FrmCartelera_Load(object sender, EventArgs e)
        {
            ImportarConfiguracion(FrmCartelera.finalPath);
        }

        private void ImportarConfiguracion(string finalPath)
        {
            try
            {
                if(File.Exists(finalPath))
                {
                    string archivoAJson = File.ReadAllText(finalPath);
                    Cartel cartel = JsonSerializer.Deserialize<Cartel>(archivoAJson);
                    pnlCartel.BackColor = Color.FromArgb(cartel.ColorARGB);

                    txtTitulo.Text = cartel.Titulo.Contenido;
                    lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                    rtxtMensaje.Text = cartel.Mensaje.Contenido;
                    lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);

                }
            }
            catch (JsonException)
            {
                MessageBox.Show("El archivo de configuracion no se encuentra en el formato correcot", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportarConfiguracion_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Json files(.json)|.json";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                ImportarConfiguracion(ofd.FileName);

            }
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            GuardarConfiguracion();
        }

        private void GuardarConfiguracion()
        {
            try
            {
                Texto titulo = new Texto(lblTitulo.Text, lblTitulo.ForeColor.ToArgb());
                Texto mensaje = new Texto(lblMensaje.Text, lblMensaje.ForeColor.ToArgb());
                Cartel cartel = new Cartel(pnlCartel.BackColor.ToArgb(), titulo, mensaje);
                string archivoAJson = JsonSerializer.Serialize(cartel);
                File.WriteAllText(FrmCartelera.finalPath, archivoAJson);
            }
            catch (JsonException)
            {
                MessageBox.Show("El archivo de configuracion no se encuentra en el formato correcot", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarConfiguracion_Click(object sender, EventArgs e)
        {
            EliminarConfiguracion(FrmCartelera.finalPath);
        }

        private void EliminarConfiguracion(string path)
        {
            try
            {
                if(File.Exists(path))
                {
                    File.Delete(path);
                }
                txtTitulo.Text = "Título";
                lblTitulo.ForeColor = Control.DefaultForeColor;

                rtxtMensaje.Text = "Mensaje";
                lblMensaje.ForeColor = Control.DefaultForeColor;

                pnlCartel.BackColor = Control.DefaultBackColor;
            }
            catch (JsonException)
            {
                MessageBox.Show("El archivo de configuracion no se encuentra en el formato correcot", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
