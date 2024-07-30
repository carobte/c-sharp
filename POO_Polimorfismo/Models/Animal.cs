using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Polimorfismo.Models;
public class Animal
{
    public Guid Id { get; set; }
    public string? Nombre { get; set; }
    public string? Genero { get; set; }
    public string? Especie { get; set; }
    public double PesoEnKG { get; set; }

    public Animal(string nombre, string genero, string especie, double pesoEnKG)
    {
        Id = new Guid();
        Nombre = nombre;
        Genero = genero;
        Especie = especie;
        PesoEnKG = pesoEnKG;
    }

    // El polimorfismo solo aplica para métodos, no para propiedades. 
    // Se usa la palabra reservada virtual, y en la clase heradada se usa la palabra reservada override
    public virtual void Hablar()
    {
        Console.WriteLine("El animal esta hablando");
    }

    public virtual void Desplazarse()
    {
        Console.WriteLine("El animal esta desplazandose");
    }
}