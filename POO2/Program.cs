using POO2.Models;

// Instanciando una clase
var estudianteNuevo = new Estudiante(1,"lucas","martinez",32,"lucas.martinez@gmail");

// estudianteNuevo.Id = 1;
// estudianteNuevo.Nombre = "lucas";
// estudianteNuevo.Apellido = "martinez";
// estudianteNuevo.Edad = 32;
// estudianteNuevo.Correo= "lucas.martinez@gmail.com";

Console.WriteLine(estudianteNuevo.Correo);
estudianteNuevo.Saludar();
estudianteNuevo.Despedir();

// -- Empleado

var empleado = new Empleado("Caro","Bte","caro@example.com", 3500000, 10);
var sueldo = empleado.CalcularSueldoEmpleado();
Console.WriteLine(sueldo);

empleado.MostrarEmpleado();