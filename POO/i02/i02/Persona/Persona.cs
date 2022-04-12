using System;

namespace Entidades
{
    /*
     * 
     * Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

Deberá tener los atributos:

    nombre
    fechaDeNacimiento
    dni

Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:

    Setter y getter para cada uno de los atributos.
    CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
    Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
    EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.

    Instanciar 3 objetos de tipo Persona en el método Main.
    Mostrar quiénes son mayores de edad y quiénes no.
     * */
    public class Persona
    {
        private string nombrePersona;
        private string fechaNacimiento;
        private int dniPersona;

        public Persona(string nombre, int dni, string fecha)
        {
            this.nombrePersona = nombre;
            this.fechaNacimiento = fecha;
            this.dniPersona = dni;
        }
        /// <summary>
        /// Getters
        /// </summary>
        /// <returns></returns>

        public string GetNombre()
        {
            return this.nombrePersona;
        }
        public string GetFechaNacimineto()
        {
            return this.fechaNacimiento;
        }

        public int GetDni()
        {
            return this.dniPersona;
        }

        /// <summary>
        /// Setters
        /// </summary>
        /// <returns></returns>

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                this.nombrePersona = nombre;
            }
        }

        public void SetFecha(string fecha)
        {
            if (string.IsNullOrEmpty(fecha))
            {
                string[] fechaString = fecha.Split('/');
                DateTime f = new DateTime(int.Parse(fechaString[2]), int.Parse(fechaString[1]), int.Parse(fechaString[0]));
                this.fechaNacimiento = f.ToString("dd-MM-yy");
            }

        }

        public void SetDni(int dni)
        {
            if (dni > 20000000)
            {
                this.dniPersona = dni;
            }
        }

        private double CalcularEdad(string fecha)
        {
            string[] fechaString = fecha.Split('/');
            DateTime f = new DateTime(int.Parse(fechaString[2]), int.Parse(fechaString[1]), int.Parse(fechaString[0]));
            TimeSpan edad = DateTime.Today - f;
            double edadInt = Math.Floor(edad.Days / 365.255);
            return edadInt;
        }

        private string EsMayorDeEdad(double edad)
        {
            string verficador = string.Empty;
            if (edad >= 18)
            {
                verficador = "Es mayor de edad";
            }
            else
            {
                verficador = "Es menor de edad";
            }
            return verficador;
        }

        public string Mostrar()
        {
            return $"NOMBRE: {this.nombrePersona}, DNI:{this.dniPersona}, FECHA DE NACIMIENTO:{this.fechaNacimiento}, EDAD: {CalcularEdad(this.fechaNacimiento)}, {EsMayorDeEdad(CalcularEdad(this.fechaNacimiento))}";
        }


    }
}
