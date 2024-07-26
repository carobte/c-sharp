using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_POO.Models
{
    public class Estudiante : Persona
    {
        public string NombreAcudiente { get; set; }
        public string CursoActual { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public List<double> Calificaciones { get; set; }

        public Estudiante(string nombre, string apellido, string tipoDocumento, string numeroDocumento, string email, string telefono, string nombreAcudiente, string cursoActual, DateOnly fechaNacimiento)
        {
            this.Id = Guid.NewGuid(); // se genera un id para cada estudiante
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.TipoDocumento = tipoDocumento;
            this.NumeroDocumento = numeroDocumento;
            this.Email = email;
            this.Telefono = telefono;
            this.NombreAcudiente = nombreAcudiente;
            this.CursoActual = cursoActual;
            this.FechaNacimiento = fechaNacimiento;
            this.Calificaciones = new List<double>(); // se genera una lista de calificaciones para cada estudiante
        }

        public void AgregarCalificaciones(double calificacion) // agregamos la calificacion a la lista
        {
            Calificaciones.Add(calificacion);
        }

        private void CalcularPromedio() // se calcula el promedio de las calificaciones del estudiante
        {
            Console.WriteLine($"Promedio: {Calificaciones.Average():F2}");
        }

        public int CalcularEdad() // calculamos la edad
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }

        public void MostrarCalificaciones() // mostramos cada nota
        {
            foreach (var calificacion in Calificaciones)
            {
                Console.WriteLine($"{calificacion},");
            }
        }

        public override void MostrarDetalles() //override -> sobreescritura del método
        {
            Console.WriteLine("__________________________________________________________");
            base.MostrarDetalles();
            Console.WriteLine($"Nombre Acudiente: {NombreAcudiente}");
            Console.WriteLine($"Curso Actual: {CursoActual}");
            Console.WriteLine($"Edad: {CalcularEdad()} años");
            Console.WriteLine("Calificaciones: ");
            MostrarCalificaciones();
            CalcularPromedio();
            Console.WriteLine("__________________________________________________________");
        }

        public static void EditarEstudiante(Estudiante estudiante) 
        // al tener atributos protected, generamos un método para permitir su edición
        {
            if (estudiante != null)
            {
                Console.WriteLine("Nuevo Email: ");
                estudiante.Email = Console.ReadLine();

                Console.WriteLine("Nuevo Teléfono: ");
                estudiante.Telefono = Console.ReadLine();

                Console.WriteLine("Nuevo acudiente: ");
                estudiante.NombreAcudiente = Console.ReadLine();

                Console.WriteLine("Nuevo curso: ");
                estudiante.CursoActual = Console.ReadLine();

                Console.WriteLine($"El estudiante {estudiante.ObtenerNombre()} fue editado");
            }
        }
    }
}