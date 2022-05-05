using System;
using System.Text;
using System.Collections.Generic;
namespace Entidades
{
    public enum EHabilidades { Volar, SuperFuerza, Resistencia, Rayos, Energia, InteligenciaSuperior, Sigilo, Astucia}
    public enum EEquipamiento { Armadura, Escudo, Martillo, Arco, Transformacion, ArtesMarciales}
    public abstract class Personaje
    {
        private List<EHabilidades> listaHabilidades;
        protected string nombre;

        // constructores
        private Personaje()
        {
            this.listaHabilidades = new List<EHabilidades>();   
        }

        public Personaje(string nombre, List<EHabilidades> habilidades)
        {
            this.nombre = nombre;
            if(habilidades is not null)
            {
                this.listaHabilidades = habilidades;

            }
        }

        //propiedades
        private string ListaHabilidades
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (EHabilidades item in listaHabilidades)
                {
                    sb.AppendLine(item.ToString());
                }
                return sb.ToString();
            }
        }
        protected virtual string Nombre { get { return this.nombre; } }

        // sobrecarga

        public static bool operator ==(List<Personaje> listaPersonaje, Personaje p)
        {
            if(listaPersonaje is not null)
            {
                foreach (Personaje personaje in listaPersonaje)
                {
                    if(personaje.nombre == p.nombre && personaje.GetType() == p.GetType())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(List<Personaje> listaPersonaje, Personaje p)
        {
            return !(listaPersonaje == p);
        }

        public static List<Personaje> operator +(List<Personaje> listaPersonaje, Personaje p)
        {
            if(listaPersonaje != p)
            {
                listaPersonaje.Add(p);
            }
            return listaPersonaje;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {this.Nombre}");
            sb.AppendLine($"HABILIDADES:");
            foreach (EHabilidades item in listaHabilidades)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
