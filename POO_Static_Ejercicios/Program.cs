using POO_Static_Ejercicios.Models;

// Contador: 
Console.WriteLine("============================================");
Console.WriteLine($"Contador: {Contador.TotalContadores}");
Contador.Incrementar();
Console.WriteLine($"Contador ahora: {Contador.TotalContadores}");
Console.WriteLine("============================================");



// Convertidor

Console.WriteLine("============================================");
double celsius = 4.5;
double fahrenheit = Convertidor.CelsiusAFahrenheit(celsius);
Console.WriteLine($"{celsius} en grados Fahrenheit son: {fahrenheit}");
Console.WriteLine("============================================");



// Configuracion
Console.WriteLine("============================================");
Configuracion.CambiarModo();
Configuracion.CambiarModo();
Console.WriteLine("============================================");


// MatematicaUtil
Console.WriteLine("============================================");
double num1 = 4;
double num2 = 6.9;

var matematicaUtil = new MatematicaUtil();

var suma = matematicaUtil.Sumar(num1, num2);
Console.WriteLine($"La suma de {num1} y {num2} es {suma}");

var resta = matematicaUtil.Restar(num1, num2);
Console.WriteLine($"La resta de {num1} y {num2} es {resta}");

var multiplicacion = matematicaUtil.Multiplicar(num1, num2);
Console.WriteLine($"La multiplicacion de {num1} por {num2} es {multiplicacion}");

var division = matematicaUtil.Dividir(num1, num2);
Console.WriteLine($"La division de {num1} entre {num2} es {division}");
Console.WriteLine("============================================");


// CalculadoraAritmetica
Console.WriteLine("============================================");

// :F2 -> 2 cifras flotantes
var suma2 = CalculadoraAritmetica.Sumar(num1, num2);
Console.WriteLine($"La suma de {num1} y {num2} es {suma2:F2}");

var resta2 = CalculadoraAritmetica.Restar(num1, num2);
Console.WriteLine($"La resta de {num1} y {num2} es {resta2:F2}");

var multiplicacion2 = CalculadoraAritmetica.Multiplicar(num1, num2);
Console.WriteLine($"La multiplicacion de {num1} por {num2} es {multiplicacion2:F2}");

var division2 = CalculadoraAritmetica.Dividir(num1, num2);
Console.WriteLine($"La division de {num1} entre {num2} es {division2:F2}"); 
Console.WriteLine("============================================");

// AlmacenamientoMensajes
Console.WriteLine("============================================");
AlmacenamientoMensajes.MostrarMensajes();
