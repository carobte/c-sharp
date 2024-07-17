using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO3.Models
{
    public class PersonalTecnico
    {
        private int Id {get;set;}
        public string? Nombre {get;set;}
        public string? Apellido {get;set;}
        public int TipoDocumento {get;set;}
        public DateOnly FechaNacimiento {get;set;}
        protected string? RH {get;set;}
        public string? TallaSuperior {get;set;}
        public string? TallaInferior {get;set;}
        public double TallaZapatos {get;set;}

        public void MostrarDatos()
        {
            Console.WriteLine("Jugador...");
        }

        public int CalcularEdad()
        {
            return 1;
        }
    }
}