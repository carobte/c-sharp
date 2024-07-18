using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Entregable_Biblioteca.Models
{
    public class Biblioteca
    {
        private Guid Id { get; set; }
        public List<Libro> Libros { get; set; }

        public Biblioteca()
        {
            this.Id = Guid.NewGuid();
            this.Libros = new List<Libro>();
        }

        public void MostrarLibros()
        {
            foreach (var libro in Libros)
            {
                libro.MostrarDetalles();
            }
        }

        public void AgregarLibro()
        {

            // Libro que ingresará el usuario:
            Console.WriteLine("Escribe el nombre del libro que deseas agregar");
            string? titulo = Console.ReadLine();

            Console.WriteLine($"Escribe el nombre del autor de {titulo}");
            string? autor = Console.ReadLine();

            Console.WriteLine($"Escribe el ISBN de {titulo}");
            string? isbn = Console.ReadLine();

            Console.WriteLine($"Escribe el género de {titulo}");
            string? genero = Console.ReadLine();

            Console.WriteLine($"Escribe el precio de {titulo}");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Escribe el año de publicación de {titulo}");
            int añoPublicacion = Convert.ToInt32(Console.ReadLine());

            var nuevoLibro = new Libro(autor, isbn, genero,precio, añoPublicacion, titulo);

            Libros.Add(nuevoLibro);
            Console.WriteLine($"El libro {nuevoLibro.Titulo} fue agregado satisfactoriamente");
        }

        public void EliminarLibro()
        {
            Console.WriteLine("Escribe el nombre del libro que deseas eliminar");
            string nombre = Console.ReadLine().ToLower();
            var libroEncontrado = Libros.Find(libro => libro.Titulo.ToLower() == nombre);

            if (libroEncontrado == null)
            {
                Console.WriteLine("El libro que ingresaste no se encuentra en la lista de libros");
            }
            else
            {
                Console.WriteLine($"¿Está seguro que desea eliminar {libroEncontrado.Titulo} de la lista (si - no)?");
                string? confirmacion = Console.ReadLine();
                if (confirmacion.Equals("si", StringComparison.CurrentCultureIgnoreCase))
                {
                    Libros.Remove(libroEncontrado);
                    Console.WriteLine($"{libroEncontrado.Titulo} fue eliminado satisfactoriamente");
                }
            }
        }
    }
}