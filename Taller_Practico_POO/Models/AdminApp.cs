using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_POO.Models
{
    public class AdminApp
    {
        public List<Estudiante> Estudiantes {get;set;}
        public List<Profesor> Profesores {get;set;}

        public AdminApp()
        {
            this.Estudiantes = new List<Estudiante>();
            this.Profesores = new List<Profesor>();
        }
    }
}