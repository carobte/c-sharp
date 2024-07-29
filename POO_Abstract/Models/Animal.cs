using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Abstract.Models
{
    public class Animal
    {
        // get y set, formas de acceder
        protected int Id { get; set; }
        protected string? Nombre { get; set; }
        protected string? Especie { get; set; }

        public Animal(int id, string nombre, string especie)
        {
            Id = id;
            Nombre = nombre;
            Especie = especie;
        }

        protected void Saludar() {
            Console.WriteLine($"Hola soy {Nombre}");
        }
    }


}