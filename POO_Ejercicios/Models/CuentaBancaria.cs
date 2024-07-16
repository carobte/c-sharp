using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Ejercicios.Models
{
    public class CuentaBancaria
    {
        public string? Titular { get; set; }
        public double Saldo { get; set; }

        public CuentaBancaria(string titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public void Depositar(double cantidad)
        {
            this.Saldo += cantidad;
            Console.WriteLine($"Depositaste {cantidad:C} COP, tu saldo actual es:{this.Saldo:C} COP");
        }

        public void Retirar(double cantidad)
        {
            if (this.Saldo >= cantidad)
            {
                this.Saldo -= cantidad;
                Console.WriteLine($"Retiraste {cantidad:C} COP, tu saldo actual es: {this.Saldo:C} COP");
            }
            else
            {
                Console.WriteLine("No tienes fondos suficientes para el retiro");
            }
        }
    }
}