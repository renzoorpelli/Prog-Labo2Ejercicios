using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public interface IArchivo <T>
    {

        void Guardar(string ruta, T contenido);

        void GuardarComo(string ruta, T contenido);

        T Leer(string ruta);
    }
}
