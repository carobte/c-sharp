using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO2.Models;
public class Estudiante
{
    // Estas son las propiedades o atributos (del estudiante)
    // Abstacción: Tener solo lo necesario de propiedades (Evitar datos innecesarios)
    // Encapsulamiento: Ocultar los detalles de implementación (Evitar acceso directo a los datos) Public, Internal, Protected(solo sirve en esta clase o el alguna de las herencias), Private (solo sirve entre la clase)
    // Herencia: Heredar propiedades y métodos de una clase padre (Evitar repetir código)
    // Polimorfismo: Usar objetos de diferentes clases con el mismo nombre y comportamiento (Evitar casts)
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