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

var Coche = new Coche("Kia", "Picanto", 2024);
Console.WriteLine($"El primer coche es: {Coche.Año} {Coche.Marca} {Coche.Modelo}");

var Coche2 = new Coche("Toyota", "GrandHighlander", 2023);
Coche2.MostrarDetalles();
Coche2.ActualizarAño(2025);
Coche2.MostrarDetalles();







