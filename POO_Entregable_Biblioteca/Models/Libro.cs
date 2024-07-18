using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Entregable_Biblioteca.Models
{
    public class Libro : Publicacion
    {
        private Guid Id { get; set; }
        public string? Autor { get; set; }
        public string? ISBN { get; set; }
        public string? Genero { get; set; }
        public double Precio { get; set; }


        public Libro(string autor, string isbn, string genero, double precio, int añoPublicacion, string titulo)
        {
            this.Id = Guid.NewGuid();
            this.Autor = autor;
            this.ISBN = isbn;
            this.Genero = genero;
            this.Precio = precio;
            this.AñoPublicacion = añoPublicacion;
            this.Titulo = titulo;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine(@$"
            ----------------------------------------------------------------------------------
            Libro: {this.Titulo}
            Autor: {this.Autor},
            ISBN: {this.ISBN},
            Año de publicación: {this.AñoPublicacion},
            Genero: {this.Genero},
            Precio: {this.Precio}
            ----------------------------------------------------------------------------------
            ");
        }

        public void AplicarDescuento(int descuento)
        {
            var precioFinal = this.Precio - this.Precio * descuento / 100;
            Console.WriteLine($"El libro {this.Titulo} vale {this.Precio:C} COP, con un descuento del {descuento}% quedaría en {precioFinal:C} COP");
        }

    }
}