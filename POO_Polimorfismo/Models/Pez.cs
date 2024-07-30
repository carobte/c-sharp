using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Polimorfismo.Models;
public class Pez : Animal
{
    public override void Hablar()
    {
        base.Hablar(); // Llama al método de la clase base
        Console.WriteLine("El pez dice blub");
    }

    public override void Desplazarse()
    {
        base.Desplazarse();
        Console.WriteLine("El pez esta nadando");
    }
}