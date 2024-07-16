using POO_Ejercicios.Models;

// -------------------- Ejercicios Persona --------------------

/* // Sin constructor: 

var nuevaPersona = new Persona();
nuevaPersona.Nombre = "Caro";
nuevaPersona.Edad = 26;

Console.WriteLine($"Persona: {nuevaPersona.Nombre}, Edad: {nuevaPersona.Edad}");
nuevaPersona.Saludar(); */

// Con constructor: 

var otraPersona = new Persona("Caro", 26);
otraPersona.MostrarDetalles(); 

// -------------------- Ejercicios Coche --------------------

var coche = new Coche("Kia", "Picanto", 2024);
Console.WriteLine($"El primer coche es: {coche.Año} {coche.Marca} {coche.Modelo}");

var coche2 = new Coche("Toyota", "GrandHighlander", 2023);
coche2.MostrarDetalles();
coche2.ActualizarAño(2025);
coche2.MostrarDetalles();

// -------------------- Ejercicios Libro --------------------

var libro = new Libro("Harry Potter", "J.K Rowling");
Console.WriteLine($"El libro {libro.Titulo}, autor: {libro.Autor}");

var numPalabras = libro.ContarPalabras("Harry Potter y la Piedra filosofal");
Console.WriteLine($"Número de palabras: {numPalabras}");

// -------------------- Ejercicios Calculadora --------------------

var calculadora = new Calculadora();

Console.WriteLine("Escribe un número: ");
var num1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Escribe otro número: ");
var num2 = Convert.ToInt32(Console.ReadLine()); 

var suma = calculadora.Sumar(num1, num2);
Console.WriteLine($"El resultado de tu suma es: {suma}");

var resta = calculadora.Restar(num1, num2);
Console.WriteLine($"El resultado de tu suma es: {resta}");

// -------------------- Ejercicios Producto --------------------

var producto = new Producto("papa", 5.400);
Console.WriteLine($"El producto es {producto.Nombre}, vale {producto.Precio:C} COP");
producto.GetNombre();
producto.SetNombre("yuca");

// -------------------- Ejercicios CuentaBancaria --------------------

var cuentaBancaria = new CuentaBancaria("Caro", 3000);
cuentaBancaria.Depositar(500);
cuentaBancaria.Retirar(100000);

// -------------------- Ejercicios Estudiantes --------------------

var estudiante = new Estudiante("Caro", "Universitario", 26);
Console.WriteLine($"Nombre de estudiante: {estudiante.Nombre}, grado: {estudiante.Grado}, edad: {estudiante.Edad} años");
estudiante.GetEdad();
estudiante.SetEdad(27);
