using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Ejercicios.Models
{
    public class Libro
    {
        public string? Titulo {get;set;}
        public string? Autor {get;set;}
    

    public Libro(string titulo, string autor)
    {
        this.Titulo = titulo.ToUpper();
        this.Autor = autor;
    }


    public int ContarPalabras(string text){
        return text.Length;
    }


    }
}