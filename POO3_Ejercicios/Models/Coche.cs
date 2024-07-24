using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Ejercicios.Models
{
    public class Coche
    {
        public string? Marca {get; set; } 
        public string? Modelo {get; set; }
        public int Año {get; set; }

        public Coche(string marca, string modelo, int año)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Año = año;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"El nuevo coche es: {Marca} {Modelo} del año {Año}");
        }

        public void ActualizarAño(int año)
        {
            this.Año = año;
        }

    }
}