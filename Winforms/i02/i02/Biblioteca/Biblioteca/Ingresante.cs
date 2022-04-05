using System;
using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {
        public string[] cursos = new string [3];
        private string direccion;
        private decimal edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, decimal edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }
        public Ingresante () 
        {

        }

        public string Mostar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine($"Pais: {this.pais}");
            sb.AppendLine($"Curso/s:");
            for (int i = 0; i < this.cursos.Length; i++)
            {
                sb.AppendLine($"{this.cursos[i]}");
            }
            return sb.ToString();
        }
    }
}
