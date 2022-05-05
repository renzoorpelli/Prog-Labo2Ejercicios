using System;

namespace Entidades
{
    public abstract class Equipo
    {
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosJugados;
        protected int partidosGanados;
        protected int partidosPerdidos;
        protected int puntuacion;

        protected Equipo(string nombre)
        {
            this.nombre = nombre;
        }

        //defino como abstracto
        public abstract int GetDificultad();
        

        //propiedades
        public string Nombre { get { return this.nombre; } }
        public string Tipo { get { return this.GetType().Name; } }

        public int PE {  
            get { 
                return this.partidosEmpatados;  
                }
            set
            {
                this.partidosEmpatados = value;
            }
        
        }
        public int PG {  
            get { 
                return this.partidosGanados;  
                }
            set
            {
                this.partidosGanados = value;
            }
        
        }
        public int PJ {  
            get { 
                return this.partidosJugados;  
                }
            set
            {
                this.partidosJugados = value;
            }
        
        }
        public int PP {  
            get { 
                return this.partidosPerdidos;  
                }
            set
            {
                this.partidosPerdidos = value;
            }
        
        }
        public int Puntuacion {  
            get { 
                return this.puntuacion;  
                }
            set
            {
                this.puntuacion = value;
            }
        
        }

        public override bool Equals(object obj)
        {
            Equipo equipo = obj as Equipo;
            return equipo is not null && this.Tipo == equipo.Tipo;
            //return  obj is not null && this.getType() == obj.GetType()
        }

        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            return equipoA.nombre == equipoB.nombre && equipoA.Tipo == equipoB.Tipo;
        }
        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoB == equipoA);
        }

        public static bool JugarPartido (Equipo equipoA, Equipo equipoB)
        {
            
            if (equipoA.Equals(equipoB))
            {
                equipoA.partidosJugados++;
                equipoB.partidosJugados++;
                if (equipoA.GetDificultad() > equipoB.GetDificultad())
                {
                    equipoA.Puntuacion += 3;
                    equipoA.partidosGanados++;
                    equipoB.partidosPerdidos++;



                }
                else if (equipoA.GetDificultad() < equipoB.GetDificultad())
                {
                    equipoB.Puntuacion += 3;
                    equipoB.partidosGanados++;
                    equipoA.partidosPerdidos++;
                }
                else
                {
                    equipoB.Puntuacion += 1;
                    equipoA.Puntuacion += 1;
                }
                return true;
            }
            return false;
        }

        protected virtual string MostrarDatos()
        {
            return $"{this.nombre}";
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }


    }
}
