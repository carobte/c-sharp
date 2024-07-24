using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Ejercicios.Models
{
    public class Circulo
    {
        public double Radio {get; set;}

        public Circulo(double radio)
        {
            this.Radio = radio;
        }

        public double CalcularCircunferencia()
        {
            return Math.Round(Math.PI * this.Radio, 2);
        }

    }
}