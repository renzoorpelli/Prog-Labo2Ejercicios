using System;

namespace Entidades
{
    public abstract class  Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            miAtributo = "Probar abstractos";
        }
        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
    

        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }


        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
