using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.Models
{
    public abstract class Animal 
    // al tener un método abstract, la clase tiene que ser abstract
    {
        public string? Nombre { get; set; }
        public double PesoKG { get; set; }
        public Animal(string nombre, double pesoKG)
        {
            Nombre = nombre;
            PesoKG = pesoKG;
        }

        public void Comer()
        {
            Console.WriteLine($"{Nombre} está comiendo");
        }

        public void Dormir()
        {
            Console.WriteLine($"{Nombre} está duermiendo");
        }

        public void Caminar()
        {
            Console.WriteLine($"{Nombre} está caminando");
        }

        public abstract void Respirar(); // abstract no lleva cuerpo.
    }
}