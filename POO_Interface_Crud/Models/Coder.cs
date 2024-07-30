using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_Interface_Crud.Interfaces;

namespace POO_Interface_Crud.Models
{
    // Otra manera de hacer el constructor:
    public class Coder(string nombre, string apellido, string email, string telefono) : ICRUD
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Nombre { get; set; } = nombre;
        public string? Apellido { get; set; } = apellido;
        public string? Email { get; set; } = email;
        public string? Telefono { get; set; } = telefono;

        public void Create(List<Coder> coders, Coder coder)
        {
            coders.Add(coder);
            Console.WriteLine($"El coder {coder.Nombre} fue agregado satisfactoriamente");
        }

        public void Update(List<Coder> coders, Guid id, Coder newInfo)
        {
            var coderUpdate = coders.Find(coder => coder.Id == id);
            coderUpdate = newInfo;
            Console.WriteLine($"El coder{coderUpdate} fue actualizado satisfactoriamente");
        }

        public void Read(List<Coder> coders)
        {
            foreach (var coder in coders)
            {
                Console.WriteLine($@"
                ID: {coder.Id} 
                Nombre: {coder.Nombre} {coder.Apellido} 
                Email: {coder.Email} 
                Telefono: {coder.Telefono}
                ");

            }
        }
        public void Delete(List<Coder> coders, Guid id)
        {

        }

        /*         public Coder Find(string nombre, List<Coder> coders)
                {
                    return coders.Find(coder => coder.Nombre == nombre);
                } */

        public static Coder GetData()
        {
            Console.WriteLine("Escribe el nombre del coder");
            string? nombre = Console.ReadLine();

            Console.WriteLine("Escribe el apellido del coder");
            string? apellido = Console.ReadLine();

            Console.WriteLine("Escribe el email del coder");
            string? email = Console.ReadLine();

            Console.WriteLine("Escribe el télefono del coder");
            string? telefono = Console.ReadLine();

            return new Coder(nombre, apellido, email, telefono);
        }
    }
}