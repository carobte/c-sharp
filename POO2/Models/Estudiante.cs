using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO2.Models;
public class Estudiante
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public string Correo { get; set; }

    public Estudiante(int id, string nombre, string apellido, int edad, string correo)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Correo = correo;
    }

    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} {Apellido}");
    }
    public void Despedir()
    {
        Console.WriteLine($"Adiós, a todo el mundo");
    }
}
