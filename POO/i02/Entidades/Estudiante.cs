using System;
using System.Text;
namespace Entidades
{
    public class Estudiante
    {
        private string nombre;
        private string apellido;
        private int numeroLegajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private float notaPromedio;
        private static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string nombre, string apellido, int numeroLegajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.numeroLegajo = numeroLegajo;
        }



        public int GetNotaPrimerParcial()
        {
            return this.notaPrimerParcial;
        }

        public void SetNotaPrimerParcial(int primerNota)
        {
            if (primerNota > 0 && primerNota <= 10)
            {
                this.notaPrimerParcial = primerNota;

            }
        }

        public int SetNotaSegundoParcial()
        {
            return this.notaSegundoParcial;
        }

        public void SetNotaSegundoParcial(int segundaNota)
        {
            if (segundaNota > 0 && segundaNota <= 10)
            {
                this.notaSegundoParcial = segundaNota;

            }
        }

        public float CalcularPromedio (int notaPrimerParcial, int notaSegundoParcial)
        {
            float calcularPromedio = (float)(notaPrimerParcial + notaSegundoParcial) / 2.0f;
            this.notaPromedio = calcularPromedio;

            return calcularPromedio;
        }

        public float  CalcularNotaFinal(int notaPrimerParcial, int notaSegundoParcial)
        {
            float notaFinalCalcular;
            if (notaPrimerParcial >= 4 && notaSegundoParcial >=4)
            {
                notaFinalCalcular = random.Next(6, 10);
            }
            else
            {
                notaFinalCalcular = -1;
            }


            return notaFinalCalcular;
        }

        public string mostrarEstudiante()
        {
            StringBuilder informacionEstudiante = new StringBuilder();
            float notaPromedio;
            float notaFinal;
            string texto;

            notaPromedio = CalcularPromedio(this.notaPrimerParcial, this.notaSegundoParcial);
            notaFinal = CalcularNotaFinal(this.notaPrimerParcial, this.notaSegundoParcial);


            informacionEstudiante.Append($"Alumno {this.nombre} {this.apellido}, con numero de legajo {this.numeroLegajo} \n");
            informacionEstudiante.AppendLine($"Nota primer parcial {this.notaPrimerParcial}, Nota segundo parcial {this.notaSegundoParcial} y su promedio es de {notaPromedio}\n");
            if (notaFinal == -1)
            {
                informacionEstudiante.AppendLine($"Su nota final es: Desaprobado");
            }
            else 
            {
                informacionEstudiante.AppendLine($"Su nota final es: {notaFinal}");
            }
   
            texto = informacionEstudiante.ToString();

            return texto;
        }



    }
}
