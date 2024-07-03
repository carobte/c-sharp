// Ejercicios
// 1. Escribe un programa que pida al usuario un número y muestre si es par o impar usando una condición if.

Console.WriteLine("Escribe un número (par o impar): ");

int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine($"El número {numero} es par");
}
else
{
    Console.WriteLine($"El número {numero} es impar");
}

// 2. Escribe un programa que pida al usuario que ingrese su nombre. Luego, verifica si el nombre ingresado no es nulo ni está vacío. Si el nombre es válido, muestra un mensaje de bienvenida; de lo contrario, muestra un mensaje de error.

Console.WriteLine("Escribe tu nombre: ");
string nombre = Console.ReadLine();

if (string.IsNullOrWhiteSpace(nombre)) // Nulo o string vacío, Nulo o string con espacio en blanco
{
    Console.WriteLine("Error, ingresa un nombre válido");
}
else
{
    Console.WriteLine($"Bienvenido {nombre}");
}

// 3. Escribe un programa que pida al usuario su edad y muestre si es mayor o menor de edad usando if-else.

Console.WriteLine("Escribe tu edad: ");
int edad = int.Parse(Console.ReadLine());

string mensaje = (edad >= 18) ? "Eres mayor de edad" : "Eres menor de edad";
Console.WriteLine(mensaje);

// 4. Escribe un programa que pida al usuario un día de la semana (como número del 1 al 7) y muestre el nombre del día correspondiente usando switch.

Console.WriteLine("Ingresa tu numero del 1 al 7 (día de la semana): ");

byte dia = Convert.ToByte(Console.ReadLine());

switch (dia)
{
    case 1:
        Console.WriteLine("Elegiste el dia Lunes");
        break;
    case 2:
        Console.WriteLine("Elegiste el dia Martes");
        break;
    case 3:
        Console.WriteLine("Elegiste el dia Miercoles");
        break;
    case 4:
        Console.WriteLine("Elegiste el dia Jueves");
        break;
    case 5:
        Console.WriteLine("Elegiste el dia Viernes");
        break;
    case 6:
        Console.WriteLine("Elegiste el dia Sabado");
        break;
    case 7:
        Console.WriteLine("Elegiste el dia Domingo");
        break;
    default:
        Console.WriteLine("El numero ingresado no corresponde a un dia de la semana");
        break;
}

// 5. Escribe un programa que pida al usuario su equipo de nacionalidad, si es colombiana debe decirle que es nativo el país y si no lo es debe decir que es extranjeto (hacer ejercicio con operador ternario)

Console.WriteLine("Escriba su nacionalidad");
string nacionalidad = Console.ReadLine();

string nativo = (nacionalidad == "colombiano" || nacionalidad == "colombiana") ? "Eres nativo" : "Eres extranjero";
Console.WriteLine(nativo);

// 6. Escribe un programa que pida al usuario tres números y muestre cuál es el mayor usando if-else.

Console.WriteLine("Escribe un número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escribe un segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Escribe un tercer número: ");
int numero3 = int.Parse(Console.ReadLine());


if (numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine($"{numero1} es mayor que los demás: {numero2}, {numero3}");
}
else if (numero2 > numero3 && numero2 > numero1)
{
    Console.WriteLine($"{numero2} es mayor que los demás: {numero1}, {numero3}");
}
else
{
    Console.WriteLine($"{numero3} es mayor que los demás: {numero1}, {numero2}");
}

// 7. Escribe un programa que pida al usuario que ingrese una contraseña. Verifica si la contraseña no es nula ni está vacía. Si la contraseña es válida, muestra un mensaje indicando que la contraseña es aceptada; de lo contrario, muestra un mensaje indicando que la contraseña no puede estar en blanco.

Console.WriteLine("Escribe una contraseña: ");
string contrasena = Console.ReadLine();

if (string.IsNullOrWhiteSpace(contrasena))
{
    Console.WriteLine("Debes ingresar una contraseña valida");
}
else
{
    Console.WriteLine("Contraseña aceptada");
}

// 8. Escribe un programa que pida al usuario un número del 1 al 12 y muestre el nombre del mes correspondiente usando switch.
Console.WriteLine("Ingresa un numero del 1 al 12 (mes)");
int mes = int.Parse(Console.ReadLine());
switch (mes)
{
    case 1:
        Console.WriteLine("Elegiste enero");
        break;
    case 2:
        Console.WriteLine("Elegiste febrero");
        break;
    case 3:
        Console.WriteLine("Elegiste marzo");
        break;
    case 4:
        Console.WriteLine("Elegiste abril");
        break;
    case 5:
        Console.WriteLine("Elegiste mayo");
        break;
    case 6:
        Console.WriteLine("Elegiste junio");
        break;
    case 7:
        Console.WriteLine("Elegiste julio");
        break;
    case 8:
        Console.WriteLine("Elegiste agosto");
        break;
    case 9:
        Console.WriteLine("Elegiste septiembre");
        break;
    case 10:
        Console.WriteLine("Elegiste octubre");
        break;
    case 11:
        Console.WriteLine("Elegiste noviembre");
        break;
    case 12:
        Console.WriteLine("Elegiste diciembre");
        break;
    default:
        Console.WriteLine("El numero ingresado no corresponde a un mes del año");
        break;
}

// 9. Escribe un programa que pida al usuario una calificación numérica y muestre la letra correspondiente (A, B, C, D, F) usando if-else.

Console.WriteLine("Escribe una calificación del 0 al 100: ");
int calificacion = int.Parse(Console.ReadLine());
if (0 < calificacion && calificacion < 20)
{
    Console.WriteLine("Sacaste F");
}
else if (21 < calificacion && calificacion < 40)
{
    Console.WriteLine("Sacaste una D");
}
else if (41 < calificacion && calificacion < 60)
{
    Console.WriteLine("Sacaste una C");
}
else if (61 < calificacion && calificacion < 80)
{
    Console.WriteLine("Sacaste una B");
}
else if (81 < calificacion && calificacion < 100)
{
    Console.WriteLine("Sacaste una A");
}
else
{
    Console.WriteLine("La calificación debe estar entre 0 y 100");
}

// 10. Escribe un programa que pida al usuario un carácter y determine si es una vocal o una consonante usando switch.

Console.WriteLine("Escribe una letra (vocal o consonante): ");
char letra = Convert.ToChar(Console.ReadLine());

switch (char.ToLower(letra))
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("El carácter es una vocal.");
        break;
    default:
        if (char.IsLetter(letra))
        {
            Console.WriteLine("El carácter es una consonante.");
        }
        else
        {
            Console.WriteLine("El carácter no es una letra.");
        }
        break;
}

// 11. Escribe un programa que pida al usuario dos números y muestre si son iguales o diferentes usando if-else.

Console.WriteLine("Escribe un número: ");
int comparacion1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escribe un segundo número: ");
int comparacion2 = int.Parse(Console.ReadLine());

if (comparacion1 == comparacion2)
{
    Console.WriteLine("Los numeros son iguales");
}
else if (comparacion1 != comparacion2)
{
    Console.WriteLine("Los numeros son diferentes");
}
else
{
    Console.WriteLine("No se ha ingresado ningún número");
}

// 12. Escribe un programa que solicite al usuario que ingrese su dirección. Verifica si la dirección no es nula, no está vacía y no consiste sólo en espacios en blanco. Si la dirección es válida, muestra un mensaje de confirmación; de lo contrario, muestra un mensaje de error.

Console.WriteLine("Escribe tu dirección: ");
string direccion = Console.ReadLine();

if (string.IsNullOrWhiteSpace(direccion))
{
    Console.WriteLine("Error: Debes escribir una dirección válida");
}
else
{
    Console.WriteLine("La dirección ha sido guardada");
}

// 13. Escribe un programa que pida al usuario un número y determine si es positivo, negativo o cero usando if-else.
Console.WriteLine("Escribe un nùmero por favor (+, - o 0): ");

int numero4 = int.Parse(Console.ReadLine());

if (numero4 > 0)
{
    Console.WriteLine("El número es positivo");
}
else if (numero4 < 0)
{
    Console.WriteLine("El número es negativo");
}
else
{
    Console.WriteLine("El número es cero");
}

// 14. Escribe un programa que pida al usuario una letra y determine si es una vocal usando if-else.

Console.WriteLine("Escribe una letra (vocal o no): ");
char letra2 = Convert.ToChar(Console.ReadLine());

if (letra2 == 'a' || letra2 == 'e' || letra2 == 'i' || letra2 == 'o' || letra2 == 'u')
{
    Console.WriteLine($"{letra2} es vocal");
}
else
{
    Console.WriteLine($"{letra2} no es vocal");
}

// 15. Escribe un programa que pida al usuario una temperatura en grados Celsius y determine si es caliente (mayor a 30), templada (entre 10 y 30) o fría (menor a 10) usando if-else.

Console.WriteLine("Escribe una temperatura por favor: ");

int temperatura = int.Parse(Console.ReadLine());

if (temperatura > 30)
{
    Console.WriteLine("La temperatura es caliente");
}
else if (temperatura < 10)
{
    Console.WriteLine("La temperatura es fria");
}
else
{
    Console.WriteLine("La temperatura es templada");
}

// 16. Escribe un programa que pida al usuario un año y determine si es un año bisiesto usando if-else.
Console.Write("Ingresa un año por favor: ");

byte bisiesto = Convert.ToByte(Console.ReadLine());

if (bisiesto % 4 == 0)
{
    Console.WriteLine("El año es bisiesto");
}
else
{
    Console.WriteLine("El año no es bisiesto");
}

// 17. Escribe un programa que pida al usuario que ingrese un valor. Verifica si el valor ingresado no es nulo, no está vacío y no contiene solo espacios en blanco. Si la entrada es válida, muestra el valor; de lo contrario, pide al usuario que ingrese un valor válido.

Console.WriteLine("Ingresa un valor: ");
string valor = Console.ReadLine();

if (string.IsNullOrWhiteSpace(valor))
{
    Console.WriteLine("Error: Por favor ingresa un valor válido");
}
else
{
    Console.WriteLine($"Valor: {valor}");
}

// 18. Escribe un programa que pida al usuario un número del 1 al 7 y determine si es un día laborable o de fin de semana usando switch.

Console.Write("Ingresa tu numero del 1 al 7 (dia laborable) por favor ");
byte diaLaboral = Convert.ToByte(Console.ReadLine());
switch (diaLaboral)
{
    case 1:
        Console.Write("Elegiste un dia laborable");
        break;
    case 2:
        Console.Write("Elegiste un dia laborable");
        break;
    case 3:
        Console.Write("Elegiste un dia laborable");
        break;
    case 4:
        Console.Write("Elegiste un dia laborable");
        break;
    case 5:
        Console.Write("Elegiste un dia laborable");
        break;
    case 6:
        Console.Write("Es fin de semana");
        break;
    case 7:
        Console.Write("Es fin de semana");
        break;
    default:
        Console.Write("El numero ingresado no corresponde a un dia de la semana");
        break;
}
