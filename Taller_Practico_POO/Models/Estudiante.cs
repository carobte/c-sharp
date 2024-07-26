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
            this.Id = Guid.NewGuid();
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.TipoDocumento = tipoDocumento;
            this.NumeroDocumento = numeroDocumento;
            this.Email = email;
            this.Telefono = telefono;
            this.NombreAcudiente = nombreAcudiente;
            this.CursoActual = cursoActual;
            this.FechaNacimiento = fechaNacimiento;
            this.Calificaciones = new List<double>();
        }

        public void AgregarCalificaciones(double calificacion)
        {
            Calificaciones.Add(calificacion);
        }

        private void CalcularPromedio()
        {
            Console.WriteLine($"Promedio: {Calificaciones.Average():F2}");
        }

        public int CalcularEdad()
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }

        public void MostrarCalificaciones()
        {
            foreach (var calificacion in Calificaciones)
            {
                Console.WriteLine($"{calificacion},");
            }
        }

        public override void MostrarDetalles() //override -> sobreescritura del método
        {
            base.MostrarDetalles();
            Console.WriteLine($"Nombre Acudiente: {NombreAcudiente}");
            Console.WriteLine($"Curso Actual: {CursoActual}");
            Console.WriteLine($"Edad: {CalcularEdad()} años");
            Console.WriteLine("Calificaciones: ");
            MostrarCalificaciones();
            CalcularPromedio();
        }

        public static void EditarEstudiante(List<Estudiante> lista, Estudiante estudiante)
        {
            if (estudiante != null)
            {
                Console.WriteLine("Nuevo Email: ");
                estudiante.Email = Console.ReadLine();
            }
        }
    }
}