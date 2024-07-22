using POO_Static.Models;

Console.Clear();

// Uso de propiedades y métodos 
var ejemplo1 = new Ejemplo();
Console.WriteLine($"Nombre: {ejemplo1.Nombre}");
Console.WriteLine($"Apellido: {ejemplo1.Apellido}");
ejemplo1.Saludar();

// Uso de propiedades y métodos Static 
EjemploStatic.Nombre = "Caro2";
EjemploStatic.Apellido = "Bte2";
EjemploStatic.Saludar();
 
// La clase static automáticamente todas sus propiedades y métodos, tiene que ser static
// Normalmente se usa clase static para configuración

// Uso de clase hibrida

EjemploHibrido.MostrarHeader();
var nuevoUsuario = new EjemploHibrido(1, "Caro3", "Bte", 157);
Console.WriteLine(EjemploHibrido.FechaActual);
nuevoUsuario.MostrarInfo();
EjemploHibrido.MostrarFooter();
