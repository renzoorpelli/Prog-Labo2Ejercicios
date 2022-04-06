using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Dictionary<string, int> agenda = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabras = richPlabras.Text;
            string[] palabrasSeparadas = palabras.Split(',');

            foreach(string palabra in palabrasSeparadas)
            {
                if(!agenda.ContainsKey(palabra) && palabra is not "")
                {
                    agenda.Add(palabra, 1);
                }
                else
                {
                    agenda[palabra] += 1; 
                }

            }

            MessageBox.Show($"PALABRAS TOP\n{Mostrar()}");

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            string eliminar = string.Empty;//inicializo contenedor de palabra a eliminar

            while (i < 3)
            {
                foreach (KeyValuePair<string, int> elemento in agenda)
                {
                    if (agenda.Values.Max() == elemento.Value && i < 3)
                    {
                        eliminar = elemento.Key;
                        sb.AppendLine($"{elemento.Key}   {elemento.Value}");
                        break;
                    }
                }

                if (agenda.Remove(eliminar))
                {
                    i++;
                }
            }

            return sb.ToString();
        }

    }

}
/*
 * piso,piso,piso,piso,piso,piso,piso,piso,piso,pato,pato,pato,pato,plata,plata,plata,pecho*/