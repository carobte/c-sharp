using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Ejercicios.Models

{
    public class Persona
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }


    public Persona(string nombre, int edad)
    {
        this.Nombre = nombre.ToLower(); // validación de datos, se guardan en minusculas
        this.Edad = edad;
    }
        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre}");
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Hola, Persona: {Nombre}, Edad: {Edad} años");           
        }
    }

}