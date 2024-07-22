using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Static_Ejercicios.Models
{
    public class AlmacenamientoMensajes
    {
        public static List<string>? Mensajes { get; set; }

        public AlmacenamientoMensajes(){
            Mensajes = new List<string>();
        }

        public static void AgregarMensajes(string msg)
        {
            Mensajes.Add(msg);
        }

        public static void MostrarMensajes()
        {
            if (Mensajes != null) 
            {
                foreach (var msg in Mensajes)
                {
                    Console.WriteLine($"Mensaje: {msg}");
                }
            } else {
                Console.WriteLine($"Mensajes está vacío");
            }
        }
    }
}