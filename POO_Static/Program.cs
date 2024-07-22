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