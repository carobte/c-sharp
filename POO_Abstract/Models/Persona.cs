using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Abstract.Models
{
    public abstract class Persona
    {
        protected Guid Id {get;set;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}


        public Persona(string nombre, string apellido)
        {
            Id = Guid.NewGuid(); 
            Nombre = nombre;
            Apellido = apellido;
        }

        public abstract void Saludar();
        public Guid ObtenerID(){
            return Id;
        }
    }
}