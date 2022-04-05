using System;
using System.Text;

namespace Entidades
{
    public class Mascota
    {
        private string nombre;
        private string especie;
        private string fechaNacimiento;
        private string[] historialVacunacion = new string [6];
        
        public Mascota(string nombre, string especie, string  fechaNacimiento)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.fechaNacimiento = fechaNacimiento;
            for (int i = 0; i < historialVacunacion.Length; i++)
            {
                this.historialVacunacion[i] = "";
            }
        }

        public string GetNombreMascota()
        {
            return nombre;
        }

        public void SetNombreMascota(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                this.nombre = nombre;
            }
        }

        public string GetFechaNacimientoMascota()
        {
            return fechaNacimiento;
        }

        public void SetFechaNacimientoMascota(string fecha)
        {
            if (string.IsNullOrEmpty(especie))
            {
                this.fechaNacimiento = especie;
            }
        }

        public string GetEspecieMascota()
        {
            return especie;
        }

        public void SetEspecieMascota(string especie)
        {
            if (string.IsNullOrEmpty(especie))
            {
                this.especie = especie;
            }
        }


        public string GetVacunaMascota()
        {
            return historialVacunacion[1];
        }

        public bool SetVacunaMascota(string vacuna)
        {
            this.historialVacunacion[1] = vacuna;
            return true;
        }


        public string MostrarMascota(Mascota m)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"ESPECIE: {m.especie}, NOMBRE: {m.nombre}, FECHA DE NACIMIENTO: {m.fechaNacimiento}, VACUNA: ");
            for (int i = 0; i < m.historialVacunacion.Length; i++)
            {
                sb.Append($"{historialVacunacion[i]}");
            }
            return sb.ToString();
        }
    }
}
