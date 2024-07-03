// Ejercicios.

// Escribe un programa que imprima “¡Hola, mundo!" en la consola.

Console.WriteLine("Hola mundo!");

// Declara un int y un string, asignarles valores e imprímelos.

int age = 26;
string newClan = "Berners Lee";

Console.WriteLine($"Tengo {age} años, y estoy en el clan {newClan}");

// Convierte un string a mayúsculas y a minúsculas.

Console.WriteLine(newClan.ToUpper());
Console.WriteLine(newClan.ToLower());

// Declara dos int, realizar suma, resta, multiplicación y división, y muestra los resultados.

int num1 = 5;
int num2 = 10;

int suma = num1 + num2;
int resta = num1 - num2;
int multiplicacion = num1 * num2;
float division = (float) num1/num2; // numeros float-> double o float. (float)-> tipo de dato a otro tipo de datos

Console.WriteLine($"La suma es: {suma}");
Console.WriteLine($"La resta es: {resta}");
Console.WriteLine($"La multiplicación es: {multiplicacion}");
Console.WriteLine($"La división es: {division}");

// Declara dos int, realiza comparaciones de igualdad, desigualdad, mayor que y menor que, y muestra los resultados.

bool igual = num1 == num2; 
Console.WriteLine($"El {num1} es igual que el {num2}?: {igual}");

bool desigual = num1 != num2; 
Console.WriteLine($"El {num1} es desigual que el {num2}?: {desigual}");

bool mayor = num1 > num2; 
Console.WriteLine($"El {num1} es mayor que el {num2}?: {mayor}");

bool menor = num1 > num2; 
Console.WriteLine($"El {num1} es menor que el {num2}?: {menor}");

// Busca una palabra específica en un string y reemplazarla por otra.

string palabra = "Hello";

Console.WriteLine(palabra.Replace("Hello", "Hola Mundo"));

// Pide al usuario su nombre y edad, luego imprime un mensaje con esta información.

Console.WriteLine("Escribe tu nombre");
string nombre = Console.ReadLine();

Console.WriteLine("Escribe tu edad");
int edad = int.Parse(Console.ReadLine()); // Castear el string en tipo int

Console.WriteLine(@$"El nombre del usuario es {nombre}, 
tiene {edad} años");

// Declara un int y escribe un programa que indique si es mayor, menor o igual a 10.

int num3 = 10;

if(num3 == 10)
{
    Console.WriteLine($"El {num3} es igual a 10");
}
else if (num3 > 10)
{
    Console.WriteLine($"El {num3} es mayor que 10");
} else
{ 
    Console.WriteLine($"El {num3} es menor que 10");
}

// Declara dos variables double, realiza suma, resta, multiplicación y división, y muestra los resultados.

double num4 = 5.76;
double num5 = 10.11;

double suma2 = num4 + num5;
double resta2 = num4 - num5;
double multiplicacion2 = num4 * num5;
double division2 = num4/num5; // numeros float-> double o float. (float)-> tipo de dato a otro tipo de datos

Console.WriteLine($"La suma es: {suma2}");
Console.WriteLine($"La resta es: {resta2}");
Console.WriteLine($"La multiplicación es: {multiplicacion2}");
Console.WriteLine($"La división es: {division2}");

// Declarar dos variables string, concatenarlas y mostrar el resultado.

string var1 = "hola";
string var2 = "mundo!";

Console.WriteLine($"{var1} {var2}");

// Declara una variable int, conviértela a double y muestra ambos valores.

int num6  = 10;
float num7 = (float)num6;

Console.WriteLine($"{num6} en int, {num7} en double");

// Escribe un programa que pida al usuario un número y muestre si es positivo, negativo o cero.
// Usa un bucle for para imprimir los números del 1 al 10.
// Elimina los espacios en blanco al inicio y al final de un string, y formatea el string para que
// empiece con mayúscula y el resto en minúsculas.
// Escribe un programa que pida al usuario un número y muestre su tabla de multiplicar del 1 al 10.
// Concatena dos strings y muestra la longitud de cada uno.
// Extrae una subcadena de un string y muestra la subcadena y su longitud.


