using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Polimorfismo.Models;
public class Gato : Animal
{
    public double TamañoBigotes { get; set; }
    public bool Orejas { get; set; }

    //Esta es la estructura para llamar el constructor de la clase padre a la clase hija
    public Gato(string nombre, string genero, string especie, double pesoEnKG, double tamañoBigotes, bool orejas): base(nombre, genero, especie, pesoEnKG)
    {
        TamañoBigotes = tamañoBigotes;
        Orejas = orejas;
    }

    public override void Hablar()
    {
        base.Hablar(); // Llama al método de la clase base
        Console.WriteLine("El gato dice meow!");
    }

    public override void Desplazarse()
    {
        base.Desplazarse();
        Console.WriteLine("El gato se desplaza saltando");
    }

    public void Presentar()
    {
        Console.WriteLine($"Hola a todos, soy un gato y mi nombre es {Nombre}");
    }
}