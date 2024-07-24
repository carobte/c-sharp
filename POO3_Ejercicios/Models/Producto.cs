using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Ejercicios.Models
{
    public class Producto
    {
        public string? Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, double precio)
        {
            this.Nombre = nombre.ToLower();
            this.Precio = precio;
        }

        public string GetNombre()
        {
            Console.WriteLine($"El producto es: {this.Nombre}");
            return this.Nombre;
        }

        public void SetNombre(string nombre)
        {
            this.Nombre = nombre;
            Console.WriteLine($"El producto se actualizo, ahora es: {this.Nombre}");
        }

    }
}