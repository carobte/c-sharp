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
            this.Id = Guid.NewGuid();
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
            return (DateTime.Now.Year - FechaContratacion.Year) * 12 + (DateTime.Now.Month - FechaContratacion.Month);
        }

        public void ObtenerSalario()
        {
            Console.WriteLine($"Salario: {this.Salario:C} COP");
        }

        public void MostrarCursos()
        {
            foreach (var curso in Cursos)
            {
                Console.WriteLine($"{curso},");
            }
        }

        public void AgregarCursos(string curso)
        {
            Cursos.Add(curso);
        }

        public override void MostrarDetalles() //override -> sobreescritura del método
        {
            Console.WriteLine($"Rol: Profesor");
            base.MostrarDetalles();
            Console.WriteLine($"Asignatura: {Asignatura}");
            ObtenerSalario();
            Console.WriteLine($"Antiguedad: {CalcularAntiguedad()} meses");
            Console.WriteLine($"Cursos: ");
            MostrarCursos();
        }

        public static void EditarProfesor(List<Profesor> lista, Profesor profesor)
        {
            if (profesor != null)
            {
                Console.WriteLine("Nuevo Email: ");
                profesor.Email = Console.ReadLine();
            }
        }

    }
}