using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Ejercicios.Models
{
    public class Estudiante
    {
        public string? Nombre { get; set; }
        public string? Grado { get; set; }
        public int Edad { get; set; }

        public Estudiante(string nombre, string grado, int edad)
        {
            this.Nombre = nombre.ToLower();
            this.Grado = grado;
            this.Edad = edad;
        }

        public void GetEdad()
        {
            Console.WriteLine($"La edad del estudiante es: {this.Edad}");
        }

        public void SetEdad(int edad)
        {
            this.Edad = edad;
            Console.WriteLine($"La edad del estudiante se actualizo, ahora es: {this.Edad}");
        }


    }

}