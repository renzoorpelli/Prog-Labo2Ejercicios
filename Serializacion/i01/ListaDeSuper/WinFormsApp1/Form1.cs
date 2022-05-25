using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<string> listaSupermercado;
        private static string rutaArchivoCompleta;

        static Form1()
        {
            string rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            const string nombreArchivo = "listaSupermercado.xml";
            rutaArchivoCompleta = $"{rutaBase}{nombreArchivo}";
        }
        public Form1()
        {
            InitializeComponent();
            listaSupermercado = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Deserializar_XmlTextReader();
            RefrescarLista();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btnMas, "Agregar Objeto");
            FrmAltaModificacion frm = new FrmAltaModificacion("Agregar objeto", " ", "Agregar");
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                listaSupermercado.Add(frm.TxtObjetoContenido);
                RefrescarLista();
                Serializar2_conXmlWritter();
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            ToolTip toolTip2 = new ToolTip();
            toolTip2.SetToolTip(btnMas, "Eliminar Objeto");
            string selectedItem = lstObjetos.SelectedItem as string;
            if(selectedItem is not null)
            {
                listaSupermercado.Remove(selectedItem);
                RefrescarLista();
                Serializar2_conXmlWritter();
            }
            else
            {
                MessageBox.Show("No selecciono ningun elemento");
            }
            
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            ToolTip toolTip3 = new ToolTip();
            toolTip3.SetToolTip(btnMas, "Modificar Objeto");
            string selectedItem = lstObjetos.SelectedItem as string;
            FrmAltaModificacion frm = new FrmAltaModificacion("Modificar objeto", selectedItem, "Modificar");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int index = listaSupermercado.IndexOf(selectedItem);
                listaSupermercado[index] =  frm.TxtObjetoContenido;
                RefrescarLista();
                Serializar2_conXmlWritter();
            }
            else
            {
                MessageBox.Show("No selecciono ningun elemento");
            }
        }

        private void RefrescarLista()
        {
            lstObjetos.DataSource = null;
            lstObjetos.DataSource = listaSupermercado;
        }

        public  void Serializar2_conXmlWritter()
        {
            using (XmlTextWriter xmlText = new XmlTextWriter(rutaArchivoCompleta, Encoding.UTF8))
            {
                try
                {
                    XmlSerializer xml = new XmlSerializer(listaSupermercado.GetType());
                    xmlText.Formatting = Formatting.Indented;
                    xml.Serialize(xmlText, listaSupermercado);
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);    
                }
               
            }
        }

        public  void Deserializar_XmlTextReader()
        {
            using (XmlTextReader xmlReader = new XmlTextReader(rutaArchivoCompleta))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(listaSupermercado.GetType());
                    listaSupermercado = serializer.Deserialize(xmlReader) as List<string>;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
