using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Static_Ejercicios.Models
{
    public class Configuracion
    {
        public static bool ModoOscuro { get; set; }


        public Configuracion()
        {
            ModoOscuro = false;
        }

        public static void CambiarModo()
        {
            if (ModoOscuro)
            {
                ModoOscuro = false;
            }
            else
            {
                ModoOscuro = true;
            }

            Console.WriteLine($"Modo Oscuro: {ModoOscuro}");
        }
    }
}