using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Ejercicios.Models
{
    public class Rectangulo
    {
        public int Ancho { get; set; }
        public int Alto { get; set; }

        public Rectangulo(int ancho, int alto)
        {
            this.Ancho = ancho; 
            this.Alto = alto;
        }

        public int CalcularArea(){
            return this.Ancho * this.Alto;
        }
    }
}