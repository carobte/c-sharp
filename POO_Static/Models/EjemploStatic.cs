using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Static.Models
{
public static class EjemploStatic
 // static es cualidad de POO que permite acceder a propiedades y métodos de manera directa, sin instanciar la clase
    {
        public static string? Nombre { get; set; }
        public static string? Apellido { get; set; }

        static EjemploStatic()
        {
            Nombre = "Caro";
            Apellido = "Bte";
        }

        public static void Saludar()
        {
            Console.WriteLine($"Hola! Soy {Nombre} {Apellido}");
        }
    }
}