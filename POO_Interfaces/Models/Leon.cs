using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.Models
{
    public class Leon : Animal // Solo puede heredarse de una clase específica
    {
        public bool Melena { get; set; }


        public Leon(string nombre, double pesoKG, bool melena) : base(nombre, pesoKG)
        {
            Melena = melena;
        }

        public override void Respirar() // método abstract de Animal. Sí o sí debe usarse.

        {
            Console.WriteLine($"{Nombre} respira lentamente");
        }

    }

}