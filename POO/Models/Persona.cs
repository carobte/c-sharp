// using es similar al import de JS
// Aunque estén desactivadas, no se recomienda borrarlas por el editor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models; // espacio de trabajo, forma de encapsular
// Se puede encapsular lo de abajo, o dejarlo así y funcionará igual

public class Persona

{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    // public DateOnly FechaNacimiento { get; set; }
    public string? Genero { get; set; }
    public string? Nacionalidad { get; set; }
    public string? Telefono { get; set; }
    public string? Correo { get; set; }

    // Método constructor, snippet -> ctor 
    public Persona(int id, string nombre, string genero, string nacionalidad, string telefono, string correo)
    {
        // this es por convención o ayuda visual para el desarrollador
        this.Id = id;
        this.Nombre = nombre;
        // this.FechaNacimiento = fechaNacimiento;
        this.Genero = genero;
        this.Nacionalidad = nacionalidad;
        this.Telefono = telefono;
        this.Correo = correo;
    }

    // encapsulamiento (ej: public), modificador (ej: static) (opcional), retorno (tipo), nombre método (mayus)
    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre}");
    }
}

// Diagrama de clases con UML -> Lenguaje Unificado de Modelado

// Propiedades (atributos) vs variables -> Propiedades mayusculas, variables minuscula