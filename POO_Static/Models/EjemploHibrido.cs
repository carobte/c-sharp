using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Static.Models;

public class EjemploHibrido
{
    public int Id { get; set; }
    public static string? Nombre { get; set; }
    public static string? Apellido { get; set; }
    public byte AlturaCM { get; set; }

    public EjemploHibrido(int id, string nombre, string apellido, byte alturaCM)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        AlturaCM = alturaCM;
    }

    public void MostrarInfo()
    {
        Console.WriteLine(@$"
        Id: {Id},
        Nombre: {Nombre}, 
        Apellido: {Apellido}, 
        Altura: {AlturaCM} cm");
    }

    public static void MostrarHeader()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("             Detalles             ");
        Console.WriteLine("==================================");

    }

        public static void MostrarFooter()
    {
        Console.WriteLine("_________________________________");
    }

}
