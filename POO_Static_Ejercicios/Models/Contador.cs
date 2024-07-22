using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Static_Ejercicios.Models
{
    public static class Contador
    {
        public static int TotalContadores {get;set;}

        public static void Incrementar(){
            TotalContadores += 1;
        }
    }
}