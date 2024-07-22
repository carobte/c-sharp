using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Static.Models;

    public class Ejemplo
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Ejemplo()
        {
            Nombre = "Caro";
            Apellido = "Bte";
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola! Soy {Nombre} {Apellido}");
        }
    }
