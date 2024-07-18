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

        public void AgregarLibro(Libro nuevolibro)
        {
            Libros.Add(nuevolibro);
            Console.WriteLine($"El libro {nuevolibro.Titulo} fue agregado satisfactoriamente");
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