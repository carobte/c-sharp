using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_POO.Models
{
    public class Profesor : Persona
    {
        public string Asignatura { get; set; }
        private double Salario { get; set; }
        public DateTime FechaContratacion { get; set; }
        public List<string> Cursos { get; set; }

        public Profesor(
            string nombre,
            string apellido,
            string tipoDocumento,
            string numeroDocumento,
            string email,
            string telefono,
            string asignatura,
            double salario,
            DateTime fechaContratacion)
        {
            this.Id = Guid.NewGuid(); // generar Id
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.TipoDocumento = tipoDocumento;
            this.NumeroDocumento = numeroDocumento;
            this.Email = email;
            this.Telefono = telefono;
            this.Asignatura = asignatura;
            this.Salario = salario;
            this.FechaContratacion = fechaContratacion;
            this.Cursos = new List<string>();
        }

        public int CalcularAntiguedad()
        {
            // Años * 12 para volverlo meses, + meses actuales en caso de que no haya cumplido el año
            return (DateTime.Now.Year - FechaContratacion.Year) * 12 + (DateTime.Now.Month - FechaContratacion.Month);
        }

        public double ObtenerSalario() // Imprime el salario actual del profesor
        {
            return this.Salario;
        }

        public void MostrarCursos() // Imprime los cursos que tiene asignados el profesor
        {
            foreach (var curso in Cursos)
            {
                Console.WriteLine($"{curso},");
            }
        }

        public void AgregarCursos(string curso) // Agrega cursos al profesor
        {
            Cursos.Add(curso);
        }

        public override void MostrarDetalles() //override -> sobreescritura del método
        {
            Console.WriteLine($"Rol: Profesor");
            base.MostrarDetalles();
            Console.WriteLine($"Asignatura: {Asignatura}");
            Console.WriteLine($"Salario: {this.Salario:C} COP");
            Console.WriteLine($"Antiguedad: {CalcularAntiguedad()} meses");
            Console.WriteLine($"Cursos: ");
            MostrarCursos();
        }

        public static void EditarProfesor(Profesor profesor) // Método para editar el profesor 
        {
            if (profesor != null)
            {
                Console.WriteLine("Nuevo Email: ");
                profesor.Email = Console.ReadLine();

                Console.WriteLine("Nuevo Teléfono: ");
                profesor.Telefono = Console.ReadLine();

                Console.WriteLine("Nueva Asignatura: ");
                profesor.Asignatura = Console.ReadLine();

                Console.WriteLine($"El profesor {profesor.ObtenerNombre()} fue editado");
            }
        }

    }
}