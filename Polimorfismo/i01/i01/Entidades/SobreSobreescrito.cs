using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SobreSobreescrito: Sobrescrito
    {
        public SobreSobreescrito() : base()
        {
        }
        public override string MiPropiedad{ get => miAtributo; }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
