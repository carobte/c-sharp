using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Abstract.Models
{
    public class Coder: Persona
    {
        public string Clan {get;set;}

        public Coder(string nombre, string apellido, string clan) : base (nombre, apellido)
        {
            Clan = clan;
        }

        public override void Saludar(){
            Console.WriteLine($"Hola {Nombre} {Apellido}, perteneces al clan: {Clan}. Tu ID es: {ObtenerID()}");
        }
    }
}