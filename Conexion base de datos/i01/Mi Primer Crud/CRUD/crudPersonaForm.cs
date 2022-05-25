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

namespace CRUD
{
    public partial class crudPersonaForm : Form
    {
        public crudPersonaForm()
        {
            InitializeComponent();
            //this.listaPersona = PersonaDAO.LeerDatos();
        }

        private void ActualizarLista()
        {
            this.lstPersonas.DataSource = null;
            this.lstPersonas.DataSource = PersonaDAO.LeerDatos();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            this.ActualizarLista();
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Persona persona = (Persona)lstPersonas.SelectedItem;
            if(persona is not null)
            {
                this.txtNombre.Text = persona.Nombre;
                this.txtApellido.Text = persona.Apellido;

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona persona = (Persona)lstPersonas.SelectedItem;
            persona.Nombre = this.txtNombre.Text;
            persona.Apellido= this.txtApellido.Text;
            PersonaDAO.Modificar(persona.Id, persona);
            this.ActualizarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona persona = (Persona)lstPersonas.SelectedItem;
            PersonaDAO.Borrar(persona.Id);
            this.ActualizarLista();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(this.txtNombre.Text, this.txtApellido.Text);
            PersonaDAO.Guardar(persona);
            this.ActualizarLista();
        }
    }
}
