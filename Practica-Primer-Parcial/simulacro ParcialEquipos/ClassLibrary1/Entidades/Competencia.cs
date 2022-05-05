using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private int cantidadCompetidores;
        private List<Equipo> equipos;
        private string nombre;


        public Competencia(string nombre)
        {
            this.nombre = nombre;
            this.equipos = new List<Equipo>();
            this.cantidadCompetidores = 0;
        }
        public Competencia(string nombre, int cantidadCompetidores = 5) : this(nombre)
        {
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public int CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public List<Equipo> Equipos { get { return equipos; } }

        public static implicit operator Competencia(string nombre)
        {
            return new Competencia(nombre);
        }

        //sobrecarga de operadores
        public static bool operator ==(Competencia torneo, Equipo equipo)
        {
            foreach (Equipo equipo1 in torneo.Equipos)
            {
                if (equipo1 == equipo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static Competencia operator +(Competencia torneo, Equipo equipo)
        {
            if (torneo != equipo && torneo.CantidadCompetidores > torneo.equipos.Count)
            {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }

        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sbMensaje = new StringBuilder();
            if (torneo is not null)
            {
                sbMensaje.AppendLine($"Nombre de campeonato: {torneo.nombre}");
                sbMensaje.AppendLine($"Cantidad de competidores : {torneo.cantidadCompetidores}");
                foreach (Equipo equipo in torneo.equipos)
                {
                    sbMensaje.AppendLine($"Nombre de equipo: {equipo.Nombre}");
                }
                return sbMensaje.ToString();
            }
            return "Error";

        }

    }
}
