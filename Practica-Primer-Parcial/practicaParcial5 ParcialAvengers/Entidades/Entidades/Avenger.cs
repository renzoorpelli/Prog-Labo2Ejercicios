using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avenger : Personaje
    {
        private EEquipamiento equipamiento;

        public Avenger(string nombre, List<EHabilidades> habilidades, EEquipamiento equipo):base(nombre, habilidades)
        {
            this.equipamiento = equipo;
        }
        // propiedad
        protected override string Nombre
        {
            get
            {
                return $"Mi nombre es {base.Nombre} y si no puedo y si no puedo proteger la tierra, la vengaré";
            }
           
        }
        //sobrecarga
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("EQUIPAMENTO: ");
            sb.AppendLine(equipamiento.ToString());
            return sb.ToString();
        }


    }
}
