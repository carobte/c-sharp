using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Ejercicios.Models
{
    public class Empleado
    {
        public string? Nombre {get;set;}
        public string? Puesto {get;set;}
        public double Salario {get;set;}

        public Empleado(string nombre, string puesto, double salario)
        {
            this.Nombre = nombre.ToLower();
            this.Puesto = puesto;
            this.Salario = salario;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"El empleado se llama: {this.Nombre}, el puesto es {this.Puesto}, y su salario: {this.Salario:C} COP");
        }
    }
}