using System;

namespace calcular
{
    public class numeroCentrico
    {
        public static int sumadorInferior;
        public static int sumadorSuperior;
        public static void esCentrico(int n)
        {
            for (int i = 1; i < n; i++)//recorro desde el 1 hasta el numero que ingresa el usuario
            {
                sumadorInferior = 0; // sumo los numeros inferiores
                for (int j = 0; j < i; j++)
                {
                    sumadorInferior += j;
                }
                sumadorSuperior = 0;// sumo los numeros superiores
                for (int k = i + 1; k < sumadorInferior; k++)
                {
                    if ((sumadorInferior == sumadorSuperior) || (sumadorSuperior > sumadorInferior))
                        break;

                    sumadorSuperior += k;
                }
            }

            if (sumadorInferior == sumadorSuperior)
            {
                Console.WriteLine($"EL nuumero {n} es centrico");
            }
        }

    }
}
