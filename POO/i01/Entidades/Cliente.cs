using System;

/*
 * Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

Deberá tener los atributos:

    titular que contendrá la razón social del titular de la cuenta.
    cantidad que será un número decimal que representa al monto actual de dinero en la cuenta. 

Construir los siguientes métodos para la clase:

    Un constructor que permita inicializar todos los atributos.
    Un método getter para cada atributo.
    mostrar retornará una cadena de texto con todos los datos de la cuenta.
    ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
    retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo. 

En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.*/
namespace Entidades
{
    public class Cliente
    {
        private string razonSocial;
        public float montoCuenta;

        public Cliente(string razonSocial, float numeroCuenta)
        {
            this.razonSocial = razonSocial;
            this.montoCuenta = numeroCuenta;
        }

        public string GetRazonSocial()
        {
            return this.razonSocial;
        }

        public void SetRazonSocial(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                this.razonSocial = value;
            }
        }

        public float GetMontoCuenta()
        {
            return this.montoCuenta;
        }

        public void SetMontoCuenta(float value)
        {
            if (value > 0)
            {
                this.montoCuenta = value;
            }
        }


        public void IngresarDinero(float monto)
        {

            if(monto > 0 || float.IsNaN(monto))
            {
                this.montoCuenta += monto;
            }
        }

        public void RetirarDinero(float monto)
        {
            if (monto > 0 || float.IsNaN(monto) || this.montoCuenta < monto)
            {
                this.montoCuenta -= monto;
            }

        }

        public string MostrarEstadoCuenta(Cliente cliente)
        {
            return $"Bienvenido {cliente.razonSocial} Usted posee ${cliente.montoCuenta} disponibles a la fecha";
        }

    }
}
