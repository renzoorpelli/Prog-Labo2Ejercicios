using System;
using System.Text;

namespace Entidades
{
    public class Conductor
    {
        private string nombre;
        public int[] kilometrosSemana = new int[7];// una dia de la semana tiene franco


        public Conductor()
        {
            this.nombre = String.Empty;
            for (int i = 0; i < kilometrosSemana.Length; i++)
            {
                this.kilometrosSemana[i] = 0;
            }

        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public int GetKilometros()
        {
            int acumulador = 0;

            for (int i = 0; i < this.kilometrosSemana.Length; i++)
            {
                acumulador += this.kilometrosSemana[i];
            }
            return acumulador;
        }

        public bool SetKilometros(int numeroKilometros, int dia)
        {
            bool todoOk = false;
            if (dia >= 0 && dia <= 7)
            {
                switch (dia)
                {
                    case 1:
                        this.kilometrosSemana[0] += numeroKilometros;
                        break;
                    case 2:
                        this.kilometrosSemana[1] += numeroKilometros;
                        break;
                    case 3:
                        this.kilometrosSemana[2] += numeroKilometros;
                        break;
                    case 4:
                        this.kilometrosSemana[3] += numeroKilometros;
                        break;
                    case 5:
                        this.kilometrosSemana[4] += numeroKilometros;
                        break;
                    case 6:
                        this.kilometrosSemana[5] += numeroKilometros;
                        break;
                    case 7:
                        this.kilometrosSemana[6] += numeroKilometros;
                        break;
                    default:
                        Console.Write("error");
                        break;
                }
                todoOk = true;

            }
            return todoOk;
        }

        public void SetNombreConductor(string nombreConductor)
        {    
           this.nombre = nombreConductor;
        }

        public static string MostrarConductor(Conductor c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE CONDUCTOR: {c.nombre} \n");
            for (int i = 1; i < c.kilometrosSemana.Length; i++)
            {
                sb.AppendLine($"DIA {i} KILOMETROS RECORRIDOS: {c.kilometrosSemana[i]}"); //falta agregar los kilometros por dia
            }

            return sb.ToString();
        }


    }
}
