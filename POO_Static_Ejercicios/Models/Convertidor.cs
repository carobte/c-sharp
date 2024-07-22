using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Static_Ejercicios.Models
{
    public static class Convertidor
    {
        public static double CelsiusAFahrenheit(double Celsius)
        {
            double fahrenheit = (Celsius * 9 / 5) + 32;
            return fahrenheit;
        }
    }
}