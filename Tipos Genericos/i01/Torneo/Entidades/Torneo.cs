using System;
using System.Collections.Generic;
using System.Text;
namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> listaEquiposGenerica;
        private string nombreTorneo;

        private Torneo()
        {
            this.listaEquiposGenerica = new List<T>();
        }

        public Torneo(string nombre):this()
        {
            this.nombreTorneo = nombre;
        }

        public string JugarPartido
        {
            get
            {
                Random r1 = new Random();
                Random r2 = new Random();
                int primerEquipoIndice = r1.Next(0, listaEquiposGenerica.Count);
                int segundoEquipoIndice = r2.Next(0, listaEquiposGenerica.Count);

                while (primerEquipoIndice == segundoEquipoIndice)
                {
                    segundoEquipoIndice = r2.Next(0, listaEquiposGenerica.Count);
                }
                return CalcularPartido(this.listaEquiposGenerica[primerEquipoIndice], this.listaEquiposGenerica[segundoEquipoIndice]); ;
            }
        }

        /// <summary>
        /// retorna true si el equipo ya se encuentra en la lista
        /// </summary>
        /// <param name="e"></param>
        /// <param name="torneo"></param>
        /// <returns></returns>
        public static bool operator ==(T e, Torneo<T> torneo)
        {
            foreach (T equipo in torneo.listaEquiposGenerica)
            {
                if (equipo.Equals(e))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(T e, Torneo<T> torneo)
        {
            return !(e == torneo);
        }

        public static T operator +(T e, Torneo<T> torneo)
        {
            if(e != torneo)
            {
                torneo.listaEquiposGenerica.Add(e);
            }
            return e;
        }

        public string MostrarTorneo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"TORNEO {this.nombreTorneo}");
            foreach (Equipo equipo in listaEquiposGenerica)
            {
                sb.AppendLine(equipo.Ficha());
            }

            return sb.ToString();
        }

        private string CalcularPartido<T>(T equipo1, T equipo2) where T : Equipo
        {
            StringBuilder sb = new StringBuilder();
            Random resultadoRandom = new Random();   
            Random resultadoRandom2 = new Random();
            sb.AppendLine($"[EQUIPO 1 :{equipo1.Nombre}][{resultadoRandom.Next(1, 10)}]  [EQUIPO 2:{equipo2.Nombre}][{resultadoRandom2.Next(1, 10)}]");
            return sb.ToString();   
        }




    }
}
