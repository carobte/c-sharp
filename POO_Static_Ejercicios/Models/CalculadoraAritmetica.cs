using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Static_Ejercicios.Models
{
    public class CalculadoraAritmetica
    {
        public static double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Dividir(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}