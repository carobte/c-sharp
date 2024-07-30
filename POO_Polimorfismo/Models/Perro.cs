using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Polimorfismo.Models;
public class Perro : Animal
{
    public override void Hablar()
    {
        base.Hablar(); // Llama al método de la clase base
        Console.WriteLine("El perro dice wauff!");
    }
    public override void Desplazarse()
    {
        base.Desplazarse(); // Llama al método de la clase base
        Console.WriteLine("El perro se desplaza corriendo");
    }
}