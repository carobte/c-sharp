using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Abstract.Models
{
    public class Perro : Animal
    {
        public bool EsCriollo { get; set; }
        public Perro(int id, string nombre, string especie, bool esCriollo) : base(id, nombre, especie)
        {
            EsCriollo = esCriollo;
        }

        public override void Saludar()
        {
            Console.WriteLine($"Hola, soy {Nombre}");
        }

    }
}