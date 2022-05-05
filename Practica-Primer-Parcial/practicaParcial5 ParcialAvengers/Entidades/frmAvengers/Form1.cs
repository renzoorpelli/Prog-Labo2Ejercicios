using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace frmAvengers
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //AVENGERS
            Marvel.Personaje = new Avenger("Anthony Stark", new List<EHabilidades>() {EHabilidades.InteligenciaSuperior }, EEquipamiento.Armadura);
            Marvel.Personaje = new Avenger("Anthony Stark", new List<EHabilidades>() {EHabilidades.InteligenciaSuperior }, EEquipamiento.Armadura);
            Marvel.Personaje = new Avenger("Dr Banner", new List<EHabilidades>() {EHabilidades.InteligenciaSuperior }, EEquipamiento.Transformacion);
            Marvel.Personaje = new Avenger("Dr Banner", new List<EHabilidades>() {EHabilidades.InteligenciaSuperior }, EEquipamiento.Transformacion);
            Marvel.Personaje = new Avenger("Natasha Romanoff ", new List<EHabilidades>() {EHabilidades.Sigilo, EHabilidades.Astucia }, EEquipamiento.ArtesMarciales);
            Marvel.Personaje = new Avenger("Thor", new List<EHabilidades>() { EHabilidades.Rayos,EHabilidades.Volar }, EEquipamiento.Martillo);
            Marvel.Personaje = new Avenger("Thor", new List<EHabilidades>() { EHabilidades.Rayos,EHabilidades.Volar }, EEquipamiento.Martillo);
            //VILLANOS
            Marvel.Personaje = new Enemigo("Thanos", new List<EHabilidades>() {EHabilidades.SuperFuerza, EHabilidades.Astucia, EHabilidades.Resistencia }, "Obtener las infinitystones y un te de vainilla");
            Marvel.Personaje = new Enemigo("Ultron", new List<EHabilidades>() {EHabilidades.SuperFuerza, EHabilidades.Astucia, EHabilidades.Volar }, "Exterminar a los humanos");
            Marvel.Personaje = new Enemigo("Loki", new List<EHabilidades>() { EHabilidades.Astucia },
            "Dominar los 9 reinos");


        }

        private void button1_Click(object sender, EventArgs e)
        {
           richTextBox1.Text += Marvel.MostrarInformacion();
        }
    }
}
