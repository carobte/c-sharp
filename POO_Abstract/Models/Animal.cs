using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Abstract.Models
{
    public class Animal
    {
        // get y set, formas de acceder
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Especie {get;set;}
/*         {
            get { return Especie; }
            set { Especie = value.Trim().ToLower(); }
        } */

    public Animal(int id, string nombre, string especie)
    {
        Id = id;
        Nombre = nombre;
        Especie = especie;
    }
    }


}