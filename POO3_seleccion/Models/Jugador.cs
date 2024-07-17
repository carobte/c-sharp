using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO3.Models
{
    public class Jugador : PersonalTecnico
    {
        public string? Posicion {get;set;}
        public byte Estatura {get;set;}
        public double Peso {get;set;}
        public string? ClubActual {get;set;}
        public string? PieHabil {get;set;}

        public Jugador(string posicion, byte estatura, double peso, string clubActual, string pieHabil)
        {
            this.Posicion = posicion;
            this.Estatura = estatura;
            this.Peso = peso;
            this.ClubActual = clubActual;
            this.PieHabil = pieHabil;
        }

        public double CalcularIMC(){
            return this.Peso / Math.Pow(this.Estatura, 2);
        }
    }
}