using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_Interfaces.Interfaces;

namespace POO_Interfaces.Models
{
    public class Leon2: Animal, IAnimal // se puede heredar una clase (solo una) e implementar interfaz (una o varias)
    {
        public bool Melena {get;set;}

        // Constructor porque heredamos de una clase
        public Leon2(string nombre, double pesoKG, bool melena) : base(nombre, pesoKG)
        {
            Melena = melena;
        }

        // Métodos de la clase
        public void Comer() 
        {
            base.Comer(); // para heredar el método comer de la clase
            Console.WriteLine("ejemplo");
        }

        public void Dormir()
        {
            Console.WriteLine($"");
        }

        // Viene del método abstract en la clase
        public override void Respirar() 
        {
            Console.WriteLine($""); // solo imprime lo nuevo, lo que se sobreescribe aquí
        }

        public void Desplazar()
        {
            Console.WriteLine($"");
        }

        // Primero se implementan los métodos de la interface 
        // Y luego los propios de la clase. 
        // Ya pueden tener encapsulamiento normal
        public void Cazar(){
            Console.WriteLine();
        }
    }
}