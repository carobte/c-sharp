using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO3.Models
{
    public class Entrenador : PersonalTecnico
    {
        public byte AñosExp {get;set;}
        public byte CantidadTitulos {get;set;}
        private double Salario {get;set;}
        public string? Nacionalidad {get;set;}

        public Entrenador(byte añosExp, byte cantidadTitulos, double salario, string nacionalidad)
        {
            this.AñosExp = añosExp;
            this.CantidadTitulos = cantidadTitulos;
            this.Salario = salario;
            this.Nacionalidad = nacionalidad;
        }
    }
}