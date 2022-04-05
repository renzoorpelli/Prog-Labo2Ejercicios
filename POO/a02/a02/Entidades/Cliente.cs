using System;

namespace Entidades
{
    public class Cliente
    {
        private string nombreCompleto;
        public string domicilio;
        public double telefono;
        private Mascota[] mascota = new Mascota[3];


        public Cliente (string nombre, string domicilio, double telefono)
        {
            this.nombreCompleto = nombre;
            this.domicilio = domicilio;
            this.telefono = telefono;
            for (int i = 0; i < mascota.Length; i++)
            {
                mascota[i] = null;
            }
    }

        public string GetNombreCliente()
        {
            return nombreCompleto;
        }

        public void SetNombreCliente(string nombre)
        {
            if(string.IsNullOrEmpty(nombre))
            {
                this.nombreCompleto = nombre;
            }
        }

        public string GetDomicilioCliente()
        {
            return domicilio;
        }

        public void SetDomicilioCliente(string domicilio)
        {
            if (string.IsNullOrEmpty(domicilio))
            {
                this.domicilio = domicilio;
            }
        }


        public double GetTelefonoCliente()
        {
            return telefono;
        }

        public void SetDomicilioCliente(double telefono)
        {
           this.telefono = telefono;
        }

        public Mascota generarMascota(string nombre, string especie, string fechaNacimiento, string[] vacunas)
        {
            Mascota m;


        }


        public string MostrarCliente()
        {
            return $"NOMBRE: {nombreCompleto}, DOMICILIO: {domicilio}, TELEFONO: {telefono}";
        }



    }
}
