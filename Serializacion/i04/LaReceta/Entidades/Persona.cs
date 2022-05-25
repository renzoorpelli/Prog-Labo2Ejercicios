using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre { get => this.nombre; set => nombre = value; }
        public string Apellido { get => this.apellido; set => apellido = value; }

        
        public override string ToString()
        {
            return $"Nombre: {this.Nombre}\nApellido: {this.Apellido}";
        }
    }
}
