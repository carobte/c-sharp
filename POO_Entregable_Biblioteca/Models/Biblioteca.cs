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

        public void MostrarLibros(List<Libro> ListaLibros)
        {
            foreach (var libro in ListaLibros)
            {
                libro.MostrarDetalles();
            }
        }

        public static Libro PedirInfoLibro()
        {
            Console.WriteLine("Escribe el nombre del libro que deseas agregar");
            string? titulo = Console.ReadLine();

            Console.WriteLine($"Escribe el nombre del autor de {titulo}");
            string? autor = Console.ReadLine();

            Console.WriteLine($"Escribe el género de {titulo}");
            string? genero = Console.ReadLine();

            Console.WriteLine($"Escribe el precio de {titulo}");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Escribe el año de publicación de {titulo}");
            int añoPublicacion = Convert.ToInt32(Console.ReadLine());

            var nuevoLibro = new Libro(autor, genero, precio, añoPublicacion, titulo);
            return nuevoLibro;
        }

        public void AgregarLibro()
        {
            var nuevoLibro = PedirInfoLibro();
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
        public void BuscarPorGenero()
        {
            Console.Write("Ingresa el genero a buscar: ");
            string? generoBuscar = Console.ReadLine().ToLower();

            var librosEncontrados = Libros.FindAll(libro => libro.Genero.Contains(generoBuscar));

            if (librosEncontrados.Count == 0)
            {
                Console.WriteLine($"No se encontraron libros del genero {generoBuscar} en el momento");
            }
            else
            {
                Console.WriteLine($"Libros del genero {generoBuscar}:");
                MostrarLibros(librosEncontrados);
            }
        }

        public void BuscarPorAutor()
        {
            Console.Write("Ingresa el autor a buscar: ");
            string? autorBuscar = Console.ReadLine().ToLower();

            var librosEncontrados = Libros.FindAll(libro => libro.Autor.Contains(autorBuscar));

            if (librosEncontrados.Count == 0)
            {
                Console.WriteLine($"No se encontraron libros del autor {autorBuscar} en el momento");
            }
            else
            {
                Console.WriteLine($"Libros del autor {autorBuscar}:");
                MostrarLibros(librosEncontrados);
            }
        }

        public void BuscarPorAños()
                {
                    Console.Write("Ingresa el primer año del rango: ");
                    int añoMenor = Convert.ToInt32( Console.ReadLine());

                    Console.Write("Ingresa el último año del rango: ");
                    int añoMayor = Convert.ToInt32( Console.ReadLine());

                    var librosEncontrados = Libros.FindAll(libro => libro.AñoPublicacion < añoMayor && libro.AñoPublicacion > añoMenor );

                    if (librosEncontrados.Count == 0)
                    {
                        Console.WriteLine($"No se encontraron libros publicados en ese rango de años {añoMenor} - {añoMayor} en el momento");
                    }
                    else
                    {
                        Console.WriteLine($"Libros en ese rango de años {añoMenor} - {añoMayor}:");
                        MostrarLibros(librosEncontrados);
                    }
                } 

        public void OrdenarPorAño()
        {
            Console.WriteLine($"Libros ordenados por su año de publicación: ");
            var listaOrdenada = Libros.OrderBy(libro => libro.AñoPublicacion).ToList();
            MostrarLibros(listaOrdenada);
        }
    }

}