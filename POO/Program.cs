using POO.Models; // Usamos el namespace para poder utilizar la clase Persona

Console.Clear();

var Coder = new Persona(1, "Caro Bte", "Femenino", "Colombiano", "3123456789", "caro@example.com"); // Instanciamos la clase -> creamos plantilla vacía

/* Podemos llenar los datos así si la clase no tiene constructor:

Coder.Id = 1; 
Coder.Nombre = "Caro Bte"; 
Coder.Genero = "Femenino";
Coder.Nacionalidad = "Colombiano";
Coder.Telefono = "3123456789";
Coder.Correo = "caro@example.com";

Sin embargo, es mejor utilizar el método constructor de la clase */

Coder.Saludar();