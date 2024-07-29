using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Abstract.Models
{
    public static class Calculadora
    {
        
        public static double Sumar( double num, double num2)
        {
            return num + num2;
        }

        public static double Restar(double num, double num2){
            return num - num2;
        }

        public static double Multiplicar(double num, double num2){
            return num * num2;
        }
        
        public static double Dividir(double num, double num2){
            return num / num2;
        }
    }

}